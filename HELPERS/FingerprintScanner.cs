using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecuGen.SecuBSPPro.Windows;
using SecuGen.FDxSDKPro.Windows;
using System.Windows.Forms;

namespace BiometricPayroll.HELPERS
{
    class FingerprintScanner
    {

        private SGFingerPrintManager m_FPM;

     public void scanIt()
        {
            try
            {

                SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU05;

                Int32 image_width = 300;
                Int32 image_height = 400;
                Int32 image_dpi = 500;
                String pathToLicense = "license.dat";

                m_FPM = new SGFingerPrintManager();
                int err = m_FPM.InitEx2(image_width, image_height, image_dpi, pathToLicense);

                Int32 port_addr;
                port_addr = (int)SGFPMPortAddr.USB_AUTO_DETECT;

                int iError = m_FPM.OpenDevice(port_addr);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    MessageBox.Show("Initialization Success");

                }
                else
                {
                    MessageBox.Show("OpenDevice() Error : " + iError.ToString());
                }

                SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
                pInfo = new SGFPMDeviceInfoParam();
                iError = m_FPM.GetDeviceInfo(pInfo);
                int m_ImageWidth, m_ImageHeight;

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {    // This should be done GetDeviceInfo();  
                    m_ImageWidth = pInfo.ImageWidth;
                    m_ImageHeight = pInfo.ImageHeight;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
         }


    }
}
