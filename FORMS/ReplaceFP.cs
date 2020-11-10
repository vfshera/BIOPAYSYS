using BiometricPayroll.HELPERS;
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
    public partial class ReplaceFP : Form
    {
        public static ReplaceFP repFP;
        private SGFingerPrintManager m_FPM;

        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private Byte[] m_RegMin1;
        private Byte[] m_RegMin2;
        private Byte[] m_DbFP;

        private bool captured = false;

        public string empID;

        public ReplaceFP()
        {
            InitializeComponent();
            m_FPM = new SGFingerPrintManager();
            repFP = this;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

        }

        private void btnCapturePrint_Click(object sender, EventArgs e)
        {
            if (captured)
            {
                getImgQuality();

            }
            else
            {
                captured = false;
                Alert.Popup("Enter FP First", Alert.AlertType.error);

            }
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
                
                deviceState.Text = " Initialization Success";
                scanerInfo();

 }
            else
            {
                deviceState.Text = "OpenDevice() Error : " + iError;

            }
        }

        public void getImgQuality()
        {

            Int32 iError;
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            Int32 img_qlty = 0;



            iError = m_FPM.GetImage(fp_image);

            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            printQualityProgress.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                if (img_qlty > 50)
                {
                    DrawImage(fp_image);

                    iError = m_FPM.CreateTemplate(fp_image, m_RegMin1);

                    if (iError == (Int32)SGFPMError.ERROR_NONE)
                    {
                        captured = true;
                        Alert.Popup("FP Image Captured", Alert.AlertType.success);
                    }
                    else

                    {
                        captured = false;
                        Alert.Popup("CreateTemplate() " + iError, Alert.AlertType.error);
                    }
                }
                else
                {
                    Alert.Popup("Below Required Quality", Alert.AlertType.error);
                }
            }
            else
            {
                DisplayError(iError);
            }
        }

       
        public void RegisterFP()
        {
            int iError;
            Int32 match_score = 0;
            bool matched = false;
            SGFPMSecurityLevel secu_level = SGFPMSecurityLevel.ABOVE_NORMAL;

            iError = m_FPM.MatchTemplate(m_RegMin1, m_RegMin2, secu_level, ref matched);
            iError = m_FPM.GetMatchingScore(m_RegMin1, m_RegMin2, ref match_score);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                if (matched)
                {
                    txtFingerprintStatus.ForeColor = Color.Green;
                    txtFingerprintStatus.Text = "Matching Score: " + match_score;

                    Database db = new Database();

                    if (db.RegFP(empID.ToString(), "1", m_RegMin1))
                    {
                        captured = false;
                        this.Close();
                        Alert.Popup("Registration Success", Alert.AlertType.success);
                    }
                    else
                    {
                        Alert.Popup("Registration Failed", Alert.AlertType.error);
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

        public void MatchFP()
        {
            int iError;
            Int32 match_score = 0;
            bool matched = false;
            SGFPMSecurityLevel secu_level = SGFPMSecurityLevel.ABOVE_NORMAL;

            Database db = new Database();

            m_DbFP = db.GetFP(11);

            iError = m_FPM.MatchTemplate(m_RegMin1, m_DbFP, secu_level, ref matched);
            iError = m_FPM.GetMatchingScore(m_RegMin1, m_DbFP, ref match_score);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                if (matched)
                {

                    Alert.Popup("Matching " + match_score, Alert.AlertType.success);

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


        private void DrawImage(Byte[] imgData)
        {
            int colorval;
            Bitmap bmp = new Bitmap(m_ImageWidth, m_ImageHeight);
            this.fingerPrintBox.Image = (Image)bmp;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorval = (int)imgData[(j * m_ImageWidth) + i];
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                }
            }
            this.fingerPrintBox.Refresh();
        }

        public void scanerInfo()
        {
            SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
            Int32 iError = m_FPM.GetDeviceInfo(pInfo);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                m_ImageWidth = pInfo.ImageWidth;
                m_ImageHeight = pInfo.ImageHeight;

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

     
    }

    /*BIOMETRIC*/
}

