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
    public partial class AddEmployee : Form
    {
        private SGFingerPrintManager m_FPM;



        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private string deviceDPI;
        private Byte[] m_RegMin1;
        private Byte[] m_RegMin2;
        private Byte[] m_VrfMin;
        private int delayFp = 10;

        private bool pastFirst = false;

        private string DevicID;
        private bool isLedOn = false;
        public AddEmployee()
        {
            InitializeComponent();
            m_FPM = new SGFingerPrintManager();
        }

        private bool emailOk = false;
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            m_RegMin1 = new Byte[400];
            m_RegMin2 = new Byte[400];
            m_VrfMin = new Byte[400];

            startScanner(deviceState, lblDeviceInfo);
        }


        private void ClearFields()
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtEmmergencyNo.Text = "";
            txtFirstName.Text = "";
            txtJobPosition.Text = "";
            txtNationalID.Text = "";
            txtPhoneNumber.Text = "";
            txtSecondName.Text = "";
            txtSurname.Text = "";
            txtWorkID.Text = "";
            genderDropDown.StartIndex = -1;
            maritalStatusDropDown.StartIndex = -1;
            workStatusDropDown.StartIndex = -1;
        }
        private void btnEmpDetailCancel_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private bool ValidateForm()
        {
            bool valid = false;
            if (
                txtAddress.Text.Length > 4 && emailOk && txtEmmergencyNo.Text.Length > 9 &&
                txtFirstName.Text != "" && txtJobPosition.Text != "" && txtNationalID.Text.Length > 6 &&
                txtPhoneNumber.Text.Length >= 2 && txtSecondName.Text.Length >= 2 && txtSurname.Text.Length >= 2 &&
                txtWorkID.Text.Length > 3 && genderDropDown.SelectedItem != null &&
                maritalStatusDropDown.SelectedItem != null && workStatusDropDown.SelectedItem != null
                )
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                Database emp = new Database();
                bool added = emp.AddEmployee(
                             txtWorkID.Text.ToUpper(),
                             txtFirstName.Text.ToUpper(),
                             txtSecondName.Text.ToUpper(),
                             txtSurname.Text.ToUpper(),
                             txtJobPosition.Text.ToUpper(),
                             txtAddress.Text.ToUpper(),
                             txtEmail.Text.ToUpper(),
                             txtPhoneNumber.Text.ToUpper(),
                             txtNationalID.Text.ToUpper(),
                             maritalStatusDropDown.SelectedItem.ToString().ToUpper(),
                             genderDropDown.SelectedItem.ToString().ToUpper(),
                             pickerDOB.Value.ToString("yyyy'-'MM'-'dd"),
                             txtEmmergencyNo.Text.ToUpper(),
                             pickerDateHired.Value.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"),
                             workStatusDropDown.SelectedItem.ToString().ToUpper()
                        );


                if (added)
                {
                    Alert.Popup("Employee Added!", Alert.AlertType.success);
                    this.ClearFields();
                }
                else
                {
                    Alert.Popup("Unable To Add Employee!", Alert.AlertType.error);
                }
            }
            else
            {
                Alert.Popup("Check The Form!", Alert.AlertType.warning);
            }


        }


        //VALIDATING NUMBERS
        private void ValidateNumberOnKeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities util = new Utilities();
            util.NumbersOnly(e);
        }

        //VALIDATING TEXT
        private void ValidateTextOnKeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities util = new Utilities();
            util.TextOnly(e);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Utilities myUtil = new Utilities();

            if (myUtil.ValidateEmail(txtEmail.Text.ToLower()))
            {
                txtEmail.BorderThickness = 1;
                txtEmail.BorderColor = SystemColors.Control;
                emailOk = true;
            }
            else
            {
                txtEmail.BorderThickness = 2;
                txtEmail.BorderColor = Color.Red;
                emailOk = false;
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            RegisterFP();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            if (pastFirst)
            {
                getImgQualityTwo();
                
            }
            else
            {
                getImgQuality();
                
            }

            
        }

        public void setFPState(bool state)
        {
            pastFirst = state;
            enteredFPrint.Text = (pastFirst) ? "Second FingerPrint" : "First FingerPrint";
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            setFPState(false);
        }














        /* B I O M E T R I C S     */

        public void startScanner(Guna.UI.WinForms.GunaLabel stateLabel, Guna.UI.WinForms.GunaLabel lblDeviceInfo)
        {
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU03;

          
            Int32 port_addr = (int)SGFPMPortAddr.USB_AUTO_DETECT;

            int dErr = m_FPM.Init(device_name);

            int iError = m_FPM.OpenDevice(port_addr);



            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                isLedOn = true;
                stateLabel.Text = " Initialization Success";
                scanerInfo();
                m_FPM.SetLedOn(true);

                lblDeviceInfo.Text = "Device W : " + m_ImageWidth + ", H : " + m_ImageHeight + ", DPI :" + deviceDPI;
            }
            else
            {
                stateLabel.Text = "OpenDevice() Error : " + iError;

            }
        }

        public void toggleScannerLed(bool isChecked)
        {

            isLedOn = isChecked;
            m_FPM.SetLedOn(isLedOn);
        }

        public void capture()
        {
          
            Int32 iError;
            Int32 timeout = 10000;
            Int32 quality = 60;
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight];
         

            iError = m_FPM.GetImageEx(fp_image, timeout, this.fingerPrintBox.Handle.ToInt32(), quality);

            if (iError == 0)
            {
                Alert.Popup("FingerPrint Captured", Alert.AlertType.success);
               
            }
            else
            {
                MessageBox.Show("GetLiveImageEx() " + iError);
            }

           

        }


        public void getImgQuality()
        {

            Int32 iError;
            Byte[] fp_image = new Byte[m_ImageWidth*m_ImageHeight];
            Int32 img_qlty = 0;

                     

            iError = m_FPM.GetImage(fp_image);

            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            printQualityProgress.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image);

                iError = m_FPM.CreateTemplate(fp_image, m_RegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    setFPState(true);
                    Alert.Popup("First Image Captured", Alert.AlertType.success);
                }
                else

                {
                    setFPState(false);
                    Alert.Popup("CreateTemplate() " + iError, Alert.AlertType.error);
                }
            }
            else
            {
                DisplayError(iError);
            }
        }

        public void getImgQualityTwo()
        {

            Int32 iError;
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            Int32 img_qlty = 0;



            iError = m_FPM.GetImage(fp_image);

            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            printQualityProgress.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image);

                iError = m_FPM.CreateTemplate(fp_image, m_RegMin2);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    Alert.Popup("Second Image Captured", Alert.AlertType.success);
                }
                else

                {
                    Alert.Popup("CreateTemplate() " + iError, Alert.AlertType.error);
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
            SGFPMSecurityLevel secu_level = SGFPMSecurityLevel.NORMAL;

            iError = m_FPM.MatchTemplate(m_RegMin1, m_RegMin2, secu_level, ref matched);
            iError = m_FPM.GetMatchingScore(m_RegMin1, m_RegMin2, ref match_score);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                if (matched)
                {
                    Alert.Popup("Registration Success, Matching Score: " + match_score, Alert.AlertType.error);
                }
                else
                {
                    Alert.Popup("Registration Failed", Alert.AlertType.error);
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
                DevicID = Convert.ToString(pInfo.DeviceID);
                deviceDPI = Convert.ToString(pInfo.ImageDPI);

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
