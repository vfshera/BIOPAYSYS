using SecuGen.FDxSDKPro.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricPayroll.HELPERS
{
    class FingerprintScanner
    {

        private SGFingerPrintManager m_FPM;
         
        public void scanIt(Guna.UI.WinForms.GunaLabel stateLabel)
        {
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU03;
            m_FPM = new SGFingerPrintManager();

            Int32 image_width = 260;
            Int32 image_height = 300;
            Int32 image_dpi = 500; 

           int err =  m_FPM.InitEx(image_width, image_height, image_dpi);

            Int32 port_addr = (int)SGFPMPortAddr.USB_AUTO_DETECT;

            int dErr = m_FPM.Init(device_name);
         
            int iError = m_FPM.OpenDevice(port_addr);



            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                
                stateLabel.Text = "Initialization Success";
            }
            else {
                stateLabel.Text = "OpenDevice() Error : " + iError;
                
            }
        }


    }
}
