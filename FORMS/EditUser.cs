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
    public partial class EditUser : Form
    {
        private SGFingerPrintManager m_FPM;

        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private string deviceDPI;
        private Byte[] m_RegMin1;
        private Byte[] fetchedFP;

        private bool captured = false;
        public EditUser()
        {
            InitializeComponent();
            m_FPM = new SGFingerPrintManager();
        }

        public string[] userData = new string[4];
        public string userID;
        private bool emailOk = false;
        private void EditUser_Load(object sender, EventArgs e)
        {
            m_RegMin1 = new Byte[400];
            fetchedFP = new Byte[400];

            startScanner();

            string sql = $"SELECT id AS ID,name AS NAME,email AS EMAIL, type AS TYPE FROM users WHERE id='{userID}'";
            Database db = new Database();
            userData = db.singleRow(sql);



            if (userData?.Length == null)
            {

                Alert.Popup("Select A Field First!", Alert.AlertType.warning);
            }
            else
            {
                InitFormData();

            }

        }


        private void InitFormData()
        {
            txtEmail.Text = userData[2];
            txtName.Text = userData[1];
           
            roleDropDown.SelectedIndex = int.Parse(userData[3]);
        }


        private bool ValidateForm()
        {
            bool valid = false;

            if (
                txtName.Text.Length > 2 && tbxPass.Text.Length > 8 && emailOk  &&  roleDropDown.SelectedItem != null
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

        private void btnEmpDetailCancel_Click(object sender, EventArgs e)
        {
            closeBtn.PerformClick();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Database userdb = new Database();
                Utilities passUtil = new Utilities();

                bool update = userdb.UpdateUser(userID,txtName.Text.ToUpper(),passUtil.HashPassword(tbxPass.Text), roleDropDown.SelectedIndex.ToString(), txtEmail.Text);

                if (update)
                {
                    Alert.Popup("User Updated!", Alert.AlertType.success);
                    Users.userFM.loadUsers();
                    this.Close();
                    
                }
                else
                {
                    Alert.Popup("Unable To Update!", Alert.AlertType.error);
                 
                }
            }
            else
            {
                Alert.Popup("Check The Form!", Alert.AlertType.warning);
            }
        }

        //email validation
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            emailOk = false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Utilities myUtil = new Utilities();

            if (txtEmail.Text.Length > 3 && myUtil.ValidateEmail(txtEmail.Text.ToLower()))
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


        private void btnCapturePrint_Click(object sender, EventArgs e)
        {
            getImgQuality();

        }



        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (captured)
            {
                updateFP();
            }
            else
            {
                Alert.Popup("Take Fingerprint First!", Alert.AlertType.warning);
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
                deviceState.ForeColor = Color.Green;
                deviceState.Text = "Initialization Success";
                scanerInfo();


                lblDeviceInfo.Text = "Device W : " + m_ImageWidth + " , H : " + m_ImageHeight + " , DPI :" + deviceDPI;
            }
            else
            {
                DisplayError(iError);
                deviceState.Text = "Failed To Initialize FP";
                deviceState.ForeColor = Color.Red; 
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
                DrawImage(fp_image);

                iError = m_FPM.CreateTemplate(fp_image, m_RegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    captured = true;
                    Alert.Popup("Image Captured", Alert.AlertType.success);
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

        private void fetchFP() {

            Database dbfp = new Database();
            fetchedFP = dbfp.GetFP(int.Parse(userID), 0);

            if(fetchedFP == null)
            {
                //Alert.Popup("No FP", Alert.AlertType.success);
            }
            else
            {
                //Alert.Popup("FP Fetched", Alert.AlertType.success);
            }
        }


        public void updateFP()
        {
            Database db = new Database();

            if(fetchedFP == null)
                {
                    if (db.RegFP(userID, "0", m_RegMin1))
                    {
                 
                        Alert.Popup("FP Registered", Alert.AlertType.success);
                    }
                    else
                    {
                        Alert.Popup("Registration Failed", Alert.AlertType.error);
                    }
            }

            else
            {
                
                if (db.updateFP(userID, "0", m_RegMin1))
                {

                    Alert.Popup("FP Updated", Alert.AlertType.success);
                }
                else
                {
                    Alert.Popup("Failed To Update FP", Alert.AlertType.error);
                }
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
                deviceDPI = Convert.ToString(pInfo.ImageDPI);
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

