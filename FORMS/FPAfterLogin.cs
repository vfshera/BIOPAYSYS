﻿using BiometricPayroll.HELPERS;
using SecuGen.FDxSDKPro.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricPayroll.FORMS
{
    public partial class FPAfterLogin : Form
    {
       

        private SGFingerPrintManager m_FPM;

        public string displayName;
        public string myID;
        public string myEmail;
        public string role;

        int timeout = 10000;

        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
       

        private Byte[] m_RegMin1;
        private Byte[] fetchedFP;

        private bool captured = false;

        public FPAfterLogin()
        {
            InitializeComponent();

            m_FPM = new SGFingerPrintManager();
        }


        private void next()
        {
            if (role == "1")
            {
                Dashboard dash = new Dashboard();
                dash.displayName = displayName;
                dash.myEmail = myEmail;
                dash.myID = myID;
                this.Hide();
                dash.Show();

            }
            else if (role == "0")
            {
                AdminDash adm = new AdminDash();
                adm.displayName = displayName;
                adm.myEmail = myEmail;
                adm.myID = myID;
                adm.role = role;
                this.Hide();
                adm.Show();
            }

            m_FPM.EnableAutoOnEvent(false,0);
            CloseDevice();
        }

        private void FPAfterLogin_Load(object sender, EventArgs e)
        {
            m_RegMin1 = new Byte[400];
            fetchedFP = new Byte[400];

            startScanner();
        }

















        /* B I O M E T R I C S     */

        public void startScanner()
        {
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU03;


            Int32 port_addr = (int)SGFPMPortAddr.USB_AUTO_DETECT;

            int dErr = m_FPM.Init(device_name);

            int iError = m_FPM.OpenDevice(port_addr);



            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                appStatelbl.ForeColor = Color.Green;
                appStatelbl.Text = "Waiting For Your Fingerprint...";
                scanerInfo();

 }
            else
            {
                DisplayError(iError);
                appStatelbl.Text = "Failed To Initialize FP";
                appStatelbl.ForeColor = Color.Red;
            }
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            timeout = 10000;
            getImgQuality();
        }

        public void getImgQuality()
        {

            Int32 iError;
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            Int32 img_qlty = 0;

            
            int quality = 60;

            iError = m_FPM.GetImageEx(fp_image,timeout,this.pbxVerfy.Handle.ToInt32(),quality);

           

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
               
                iError = m_FPM.CreateTemplate(fp_image, m_RegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    captured = true;
                    MatchFP();
                }
                else

                {
                    captured = false;
                    Alert.Popup("CreateTemplate() " + iError, Alert.AlertType.error);
                }
            }
            else
            {
                DisplayError(iError);
            }
        }


        public void MatchFP()
        {
            int iError;
            Int32 match_score = 0;
            bool matched = false;
            SGFPMSecurityLevel secu_level = SGFPMSecurityLevel.ABOVE_NORMAL;

            Database db = new Database();

           

            iError = m_FPM.MatchTemplate(m_RegMin1, fetchedFP, secu_level, ref matched);
            iError = m_FPM.GetMatchingScore(m_RegMin1, fetchedFP, ref match_score);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                if (matched)
                {

                    if(match_score > 120)
                    {
                        next();
                    }
                    else
                    {
                        Alert.Popup("Retry", Alert.AlertType.error);
                        m_FPM.EnableAutoOnEvent(false, 0);
                        m_FPM.EnableAutoOnEvent(true, (int)this.Handle);
                    }

                }
                else
                {
                    Alert.Popup("Fingerprints Not Matching", Alert.AlertType.error);
                }
            }
            else
            {
                DisplayError(iError);
            }
        }

        private void fetchFP()
        {

            Database dbfp = new Database();

            fetchedFP = dbfp.GetFP(int.Parse(myID), int.Parse(role));

            if (fetchedFP == null)
            {
                appStatelbl.Text = "You Haven't Enrolled FP";
                appStatelbl.ForeColor = Color.Red;
                Alert.Popup("You Haven't Enrolled!", Alert.AlertType.error);
                retryBtn.Enabled = false;

                autoLogoutTimer.Enabled = true;
            }
            else
            {

                retryBtn.Enabled = true;
                m_FPM.EnableAutoOnEvent(true, (int)this.Handle);
            }
        }


       
        public void scanerInfo()
        {
            SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
            Int32 iError = m_FPM.GetDeviceInfo(pInfo);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                m_ImageWidth = pInfo.ImageWidth;
                m_ImageHeight = pInfo.ImageHeight;
                fetchFP();
                
            }
            else
            {
                MessageBox.Show("Can't Get Device H & W");
            }
        }

        private void CloseDevice()
        {
            m_FPM.CloseDevice();
        }


        protected override void WndProc(ref Message message)
        {
            if (message.Msg == (int)SGFPMMessages.DEV_AUTOONEVENT)
            {
                if (message.WParam.ToInt32() == (Int32)SGFPMAutoOnEvent.FINGER_ON)
                {
                    appStatelbl.ForeColor = Color.Green;
                    appStatelbl.Text = "Reading Fingerprint...";
                    getImgQuality();
                }
                else if (message.WParam.ToInt32() == (Int32)SGFPMAutoOnEvent.FINGER_OFF)
                {
                    appStatelbl.ForeColor = Color.Green;
                    appStatelbl.Text = "Waiting For Your Fingerprint...";
                }
                    
            }
            base.WndProc(ref message);
        }


        private void DisplayError(int iError)
        {
            string text = "";

            switch (iError)
            {
                case 0:                             //SGFDX_ERROR_NONE				= 0,
                    text = "Error none";
                    break;

                case 1:                             //SGFDX_ERROR_CREATION_FAILED	= 1,
                    text = "Can not create object";
                    break;

                case 2:                             //   SGFDX_ERROR_FUNCTION_FAILED	= 2,
                    text = "Function Failed";
                    break;

                case 3:                             //   SGFDX_ERROR_INVALID_PARAM	= 3,
                    text = "Invalid Parameter";
                    break;

                case 4:                          //   SGFDX_ERROR_NOT_USED			= 4,
                    text = "Not used function";
                    break;

                case 5:                                //SGFDX_ERROR_DLLLOAD_FAILED	= 5,
                    text = "Can not create object";
                    break;

                case 6:                                //SGFDX_ERROR_DLLLOAD_FAILED_DRV	= 6,
                    text = "Can not load device driver";
                    break;
                case 7:                                //SGFDX_ERROR_DLLLOAD_FAILED_ALGO = 7,
                    text = "Can not load sgfpamx.dll";
                    break;

                case 51:                //SGFDX_ERROR_SYSLOAD_FAILED	   = 51,	// system file load fail
                    text = "Can not load driver kernel file";
                    break;

                case 52:                //SGFDX_ERROR_INITIALIZE_FAILED  = 52,   // chip initialize fail
                    text = "Failed to initialize the device";
                    break;

                case 53:                //SGFDX_ERROR_LINE_DROPPED		   = 53,   // image data drop
                    text = "Data transmission is not good";
                    break;

                case 54:                //SGFDX_ERROR_TIME_OUT			   = 54,   // getliveimage timeout error
                    text = "Time out";
                    break;

                case 55:                //SGFDX_ERROR_DEVICE_NOT_FOUND	= 55,   // device not found
                    text = "Device not found";
                    break;

                case 56:                //SGFDX_ERROR_DRVLOAD_FAILED	   = 56,   // dll file load fail
                    text = "Can not load driver file";
                    break;

                case 57:                //SGFDX_ERROR_WRONG_IMAGE		   = 57,   // wrong image
                    text = "Wrong Image";
                    break;

                case 58:                //SGFDX_ERROR_LACK_OF_BANDWIDTH  = 58,   // USB Bandwith Lack Error
                    text = "Lack of USB Bandwith";
                    break;

                case 59:                //SGFDX_ERROR_DEV_ALREADY_OPEN	= 59,   // Device Exclusive access Error
                    text = "Device is already opened";
                    break;

                case 60:                //SGFDX_ERROR_GETSN_FAILED		   = 60,   // Fail to get Device Serial Number
                    text = "Device serial number error";
                    break;

                case 61:                //SGFDX_ERROR_UNSUPPORTED_DEV		   = 61,   // Unsupported device
                    text = "Unsupported device";
                    break;

                // Extract & Verification error
                case 101:                //SGFDX_ERROR_FEAT_NUMBER		= 101, // utoo small number of minutiae
                    text = "The number of minutiae is too small";
                    break;

                case 102:                //SGFDX_ERROR_INVALID_TEMPLATE_TYPE		= 102, // wrong template type
                    text = "Template is invalid";
                    break;

                case 103:                //SGFDX_ERROR_INVALID_TEMPLATE1		= 103, // wrong template type
                    text = "1st template is invalid";
                    break;

                case 104:                //SGFDX_ERROR_INVALID_TEMPLATE2		= 104, // vwrong template type
                    text = "2nd template is invalid";
                    break;

                case 105:                //SGFDX_ERROR_EXTRACT_FAIL		= 105, // extraction fail
                    text = "Minutiae extraction failed";
                    break;

                case 106:                //SGFDX_ERROR_MATCH_FAIL		= 106, // matching  fail
                    text = "Matching failed";
                    break;

            }

            Alert.Popup(text, Alert.AlertType.error);

        }

        private void autoLogoutTimer_Tick(object sender, EventArgs e)
        {
            autoLogoutTimer.Stop();
            this.Hide();

            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
