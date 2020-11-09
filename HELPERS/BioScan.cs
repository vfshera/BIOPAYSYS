﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.HELPERS
{
    class BioScan
    {

      
        private void GetImageBtn_Click(object sender, System.EventArgs e)
        {
            Int32 iError;
            Int32 elap_time;
            Byte[] fp_image;


            elap_time = Environment.TickCount;
            fp_image = new Byte[m_ImageWidth * m_ImageHeight];

            iError = m_FPM.GetImage(fp_image);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                elap_time = Environment.TickCount - elap_time;
                DrawImage(fp_image, pictureBox1);
                StatusBar.Text = "Capture Time : " + elap_time + " ms";
            }
            else
                DisplayError("GetImage()", iError);

            Cursor.Current = Cursors.Default;
        }


        ///////////////////////
        /// GetImageEx()
        private void GetLiveImageBtn_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Int32 iError;
            Int32 timeout;
            Int32 quality;
            Byte[] fp_image;
            Int32 elap_time;

            timeout = Convert.ToInt32(textTimeout.Text);
            quality = Convert.ToInt32(textImgQuality.Text);
            fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            elap_time = Environment.TickCount;
            *//*  MessageBox.Show("" + fp_image);*//**//*
            iError = m_FPM.GetImageEx(fp_image, timeout, this.pictureBox1.Handle.ToInt32(), quality);

            if (iError == 0)
            {
                elap_time = Environment.TickCount - elap_time;
                StatusBar.Text = "Capture Time : " + elap_time + "millisec";
            }
            else
                DisplayError("GetLiveImageEx()", iError);

            Cursor.Current = Cursors.Default;
        }


        ///////////////////////
        /// GetImage(), GetImageQuality(), CreateTemplate
        private void BtnCapture1_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Int32 iError;
            Byte[] fp_image;
            Int32 img_qlty;

            fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            img_qlty = 0;

            iError = m_FPM.GetImage(fp_image);

            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar_R1.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBoxR1);
                iError = m_FPM.CreateTemplate(fp_image, m_RegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                    StatusBar.Text = "First image is captured";
                else
                    DisplayError("CreateTemplate()", iError);
            }
            else
                DisplayError("GetImage()", iError);

            Cursor.Current = Cursors.Default;
        }

        ///////////////////////
        /// GetImage(), GetImageQuality(), CreateTemplate
        private void BtnCapture2_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Int32 iError;
            Byte[] fp_image;
            Int32 img_qlty;

            fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            img_qlty = 0;

            iError = m_FPM.GetImage(fp_image);
            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar_R2.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBoxR2);
                iError = m_FPM.CreateTemplate(fp_image, m_RegMin2);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                    StatusBar.Text = "Second image is captured";
                else
                    DisplayError("CreateTemplate()", iError);
            }
            else
                DisplayError("GetImage()", iError);

            Cursor.Current = Cursors.Default;
        }

        ///////////////////////
        /// GetImage(), GetImageQuality(), CreateTemplate
        private void BtnCapture3_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Int32 iError;
            Byte[] fp_image;
            Int32 img_qlty;

            fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            img_qlty = 0;

            iError = m_FPM.GetImage(fp_image);

            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar_V1.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBoxV1);
                iError = m_FPM.CreateTemplate(null, fp_image, m_VrfMin);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                    StatusBar.Text = "Image for verification is captured";
                else
                    DisplayError("CreateTemplate()", iError);
            }
            else
                DisplayError("GetImage()", iError);

            Cursor.Current = Cursors.Default;
        }



        ///////////////////////
        void DisplayError(string funcName, int iError)
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

            text = funcName + " Error # " + iError + " :" + text;
            StatusBar.Text = text;
        }
    }

}
*/