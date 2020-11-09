using SecuGen.FDxSDKPro.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BiometricPayroll.HELPERS
{
    class FingerprintScanner
    {



        private SGFingerPrintManager m_FPM;


 
        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private string deviceDPI;

        private string DevicID;
        private bool isLedOn = false;

        public FingerprintScanner()
        {
            m_FPM = new SGFingerPrintManager();
        }
        public void startScanner(Guna.UI.WinForms.GunaLabel stateLabel, Guna.UI.WinForms.GunaLabel lblDeviceInfo)
        {
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU03;

/*
            Int32 image_width = 260;
            Int32 image_height = 300;
            Int32 image_dpi = 500;

            m_ImageHeight = image_height;
            m_ImageWidth = image_width;

            int err = m_FPM.InitEx(image_width, image_height, image_dpi);*/

            Int32 port_addr = (int)SGFPMPortAddr.USB_AUTO_DETECT;

            int dErr = m_FPM.Init(device_name);

            int iError = m_FPM.OpenDevice(port_addr);



            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                isLedOn = true;
                stateLabel.Text = " Initialization Success";
                scanerInfo();
                m_FPM.SetLedOn(true);

                lblDeviceInfo.Text = "Device W : " + m_ImageWidth +", H : "+ m_ImageHeight+", DPI :"+deviceDPI;
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

        public void capture(Guna.UI2.WinForms.Guna2PictureBox fPrintView)
        {
            Cursor.Current = Cursors.WaitCursor;
            Int32 iError;
            Int32 timeout = 10000;
            Int32 quality = 60;
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            Int32 elap_time;

            elap_time = Environment.TickCount;


            iError = m_FPM.GetImageEx(fp_image, timeout, fPrintView.Handle.ToInt32(), quality);

                if (iError == 0)
                {
                    MessageBox.Show("FP Captured!");
                elap_time = Environment.TickCount - elap_time;
            }
                else
                {
                    MessageBox.Show("GetLiveImageEx() " + iError);
                }

            Cursor.Current = Cursors.Default;

        }
    

        public void scanerInfo()
        {
            SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
            Int32 iError = m_FPM.GetDeviceInfo(pInfo);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {    // This should be done GetDeviceInfo(); 
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






    }

}
