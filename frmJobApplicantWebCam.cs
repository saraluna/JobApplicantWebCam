using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

// Reference path for the following assemblies --> C:\Program Files\Microsoft Expression\Encoder 4\SDK\
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;
using System.Resources;

namespace EE4Test
{
    public partial class frmJobApplicantWebCam : Form
    {
        /// <summary>
        /// Creates job for capture of live source
        /// </summary>
        private LiveJob _job;
        private CultureInfo culture;
        /// <summary>
        /// Device for live source
        /// </summary>
        private LiveDeviceSource _deviceSource;

        private bool _bStartedRecording = false;
        private string _urlSender = "";
        private int _applicantId = 0;
        private bool _englishLanguage = true;
        public frmJobApplicantWebCam()
        {
            InitializeComponent();
        }
        public frmJobApplicantWebCam(string[] args)
        {
            InitializeComponent();
            _applicantId = int.Parse(args[0].Replace("-a:",""));
            _urlSender = args[1].Replace("-p:","");
            if (args.Length > 2)
            {
                _englishLanguage = args[2].TrimEnd().EndsWith("en");
            }
            if (_englishLanguage)
            {
                culture = CultureInfo.CreateSpecificCulture("");
                rbEnglish.Checked = true;
            }
            else
            {
                culture = CultureInfo.CreateSpecificCulture("es-MX");
                rbSpanish.Checked = true;
            }
        }
        private void AdjustCulture()
        {
            ResourceManager rm = new ResourceManager("JobApplicantWebCam.webCamRes", typeof(frmJobApplicantWebCam).Assembly);
            btnClose.Text = rm.GetString("btnClose", culture);
            btnGrabImage.Text = rm.GetString("btnGrabImage", culture);
            btnPreview.Text = rm.GetString("btnPreview", culture);
            this.Text = rm.GetString("ActiveForm", culture);
            lblLanguage.Text = rm.GetString("lblLanguage", culture);
            //lblMessage.Text = rm.GetString("lblMessage", culture);
        }
        private void frmJobApplicantWebCam_Load(object sender, EventArgs e)
        {
            //this.Text += " - ver. " + Application.ProductVersion;

            lstVideoDevices.ClearSelected();
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                lstVideoDevices.Items.Add(edv.Name);
            }
            lblVideoDeviceSelectedForPreview.Text = "";

            
            if (System.Configuration.ConfigurationSettings.AppSettings["DefaultCamera"]!=null &&
                (System.Configuration.ConfigurationSettings.AppSettings["DefaultCamera"].ToString() !="") &&
                HasDefaultCamera(System.Configuration.ConfigurationSettings.AppSettings["DefaultCamera"].ToString()))
            {
            }
            else if (lstVideoDevices.Items.Count > 0)
            {
                lstVideoDevices.SelectedIndex = 0;
                Preview();
            }
            if (lstVideoDevices.Items.Count == 0)
            {
                MessageBox.Show("Plese install a video device and run this program again.");
                this.Close();
            }
            if (System.Configuration.ConfigurationSettings.AppSettings["IsLocalWebService"] != null &&
                            System.Configuration.ConfigurationSettings.AppSettings["IsLocalWebService"].ToString() == "true")
            {
                //checkBoxShowConfigDialog.Visible = true;
            }

            if(lstVideoDevices.Items.Count>1 || 
                (System.Configuration.ConfigurationSettings.AppSettings["IsLocalWebService"] != null &&
                System.Configuration.ConfigurationSettings.AppSettings["IsLocalWebService"].ToString() == "true"))
                btnPreview.Visible = true;
            else
                btnPreview.Visible = false;
            
        }
        private bool HasDefaultCamera(string searchString)
        {
            for (int i = 0; i < lstVideoDevices.Items.Count; i++)
            {
                if (lstVideoDevices.Items[i].ToString() == searchString)
                {
                    lstVideoDevices.SelectedIndex=i;
                    return true;
                }
            }
            return false;
        }
        private void Preview()
        {
            ResourceManager rm = new ResourceManager("JobApplicantWebCam.webCamRes", typeof(frmJobApplicantWebCam).Assembly);
                       
            EncoderDevice video = null;
            EncoderDevice audio = null;

            GetSelectedVideoAndAudioDevices(out video, out audio);
            StopJob();

            if (video == null)
            {
                return;
            }

            // Starts new job for preview window
            _job = new LiveJob();

            // Checks for a/v devices
            if (video != null)
            {
                try
                {
                    // Create a new device source. We use the first audio and video devices on the system
                    _deviceSource = _job.AddDeviceSource(video, audio);

                    // Is it required to show the configuration dialogs ?
                    if (checkBoxShowConfigDialog.Checked)
                    {
                        // Yes
                        // VFW video device ?
                        if (lstVideoDevices.SelectedItem.ToString().EndsWith("(VFW)", StringComparison.OrdinalIgnoreCase))
                        {
                            // Yes
                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VfwFormatDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VfwFormatDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VfwSourceDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VfwSourceDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VfwDisplayDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VfwDisplayDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                        }
                        else
                        {
                            // No
                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoCapturePinDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoCapturePinDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoCaptureDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoCaptureDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoCrossbarDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoCrossbarDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoPreviewPinDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoPreviewPinDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }

                            if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoSecondCrossbarDialog))
                            {
                                _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoSecondCrossbarDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                            }
                        }
                    }
                    else
                    {
                        // No
                        // Setup the video resolution and frame rate of the video device
                        // NOTE: Of course, the resolution and frame rate you specify must be supported by the device!
                        // NOTE2: May be not all video devices support this call, and so it just doesn't work, as if you don't call it (no error is raised)
                        // NOTE3: As a workaround, if the .PickBestVideoFormat method doesn't work, you could force the resolution in the 
                        //        following instructions (called few lines belows): 'panelVideoPreview.Size=' and '_job.OutputFormat.VideoProfile.Size=' 
                        //        to be the one you choosed (640, 480).
                        _deviceSource.PickBestVideoFormat(new Size(640, 480), 15);
                    }

                    // Get the properties of the device video
                    SourceProperties sp = _deviceSource.SourcePropertiesSnapshot();

                    // Resize the preview panel to match the video device resolution set
                    panelVideoPreview.Size = new Size(sp.Size.Width, sp.Size.Height);
                    //
                    this.Width = panelVideoPreview.Width + panel1.Width+20;
                    if (panelVideoPreview.Height > panel1.Height)
                        this.Height = panelVideoPreview.Height + 63;
                    else
                        this.Height = panel1.Height + 63;
                    //
                    // Setup the output video resolution file as the preview
                    _job.OutputFormat.VideoProfile.Size = new Size(sp.Size.Width, sp.Size.Height);

                    // Display the video device properties set
                    toolStripStatusLabel1.Text = sp.Size.Width.ToString() + "x" + sp.Size.Height.ToString() + "  " + sp.FrameRate.ToString() + " fps";

                    // Sets preview window to winform panel hosted by xaml window
                    _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(panelVideoPreview, panelVideoPreview.Handle));

                    // Make this source the active one
                    _job.ActivateSource(_deviceSource);

                    btnGrabImage.Enabled = true;

                    toolStripStatusLabel1.Text = "Preview activated";
                }
                catch (Exception ex){
                    MessageBox.Show("The camera appears to be in use.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Gives error message as no audio and/or video devices found
                MessageBox.Show("No Video capture devices have been found.", "Warning");
                toolStripStatusLabel1.Text = "No Video capture devices have been found.";
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            Preview();
        }

        private void cmdGrabImage_Click(object sender, EventArgs e)        
        {
            ResourceManager rm = new ResourceManager("JobApplicantWebCam.webCamRes", typeof(frmJobApplicantWebCam).Assembly);
            btnPreview.Enabled = false;
                btnGrabImage.Enabled = false;
                btnClose.Enabled = false;
                lblMessage.Text = rm.GetString("lblUploading", culture);//"Uploading picture, please wait.";

                try
                {
                    // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
                    using (Bitmap bitmap = new Bitmap(panelVideoPreview.Width, panelVideoPreview.Height))
                    {
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            // Get the paramters to call g.CopyFromScreen and get the image
                            Rectangle rectanglePanelVideoPreview = panelVideoPreview.Bounds;
                            Point sourcePoints = panelVideoPreview.PointToScreen(new Point(panelVideoPreview.ClientRectangle.X, panelVideoPreview.ClientRectangle.Y));
                            g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size);
                        }

                        byte[] b = ImageToByte((Image)bitmap);
                        string urlReturn = "error";
                        //
                        if (System.Configuration.ConfigurationSettings.AppSettings["IsLocalWebService"]!=null &&
                            System.Configuration.ConfigurationSettings.AppSettings["IsLocalWebService"].ToString() == "true")
                        {
                            JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoapClient s = new JobApplicantWebCam.JobRecruitmentService.JobRecruitmentWebServiceSoapClient();
                            urlReturn = s.SaveApplicantPicture(b,
                                _applicantId.ToString(),
                                _urlSender);
                        }
                        else
                        {
                            JobApplicantWebCam.JobRecruitmentServiceServer.JobRecruitmentWebServiceSoapClient sr = new JobApplicantWebCam.JobRecruitmentServiceServer.JobRecruitmentWebServiceSoapClient();
                            urlReturn = sr.SaveApplicantPicture(b,
                                _applicantId.ToString(),
                                _urlSender);
                        }
                        if (!urlReturn.StartsWith("error"))
                        {
                            webBrowser1.Visible = true;
                            webBrowser1.Navigate(urlReturn);

                            lblMessage.Text = rm.GetString("lblImageSaved", culture);//= "Your Image has been saved!";
                            MessageBox.Show( rm.GetString("msgSaved", culture));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(rm.GetString("msgUnable", culture));
                            lblMessage.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(rm.GetString("msgUnable", culture));
                    lblMessage.Text = "";
                }
                finally
                {
                    btnPreview.Enabled = true;
                    btnGrabImage.Enabled = true;
                    btnClose.Enabled = true;
                }
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void GetSelectedVideoAndAudioDevices(out EncoderDevice video, out EncoderDevice audio)
        {
            video = null;
            audio = null;

            lblVideoDeviceSelectedForPreview.Text = "";
           
            if (lstVideoDevices.SelectedIndex < 0 )
            {
                MessageBox.Show("No Video capture devices have been selected.\nSelect a video device from the listboxes and try again.", "Warning");
                return;
            }

            // Get the selected video device            
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(edv.Name, lstVideoDevices.SelectedItem.ToString()) == 0)
                {
                    video = edv;
                    lblVideoDeviceSelectedForPreview.Text = edv.Name;
                    break;
                }
            }
        }

        void StopJob()
        {
            // Has the Job already been created ?
            if (_job != null)
            {
                // Yes
                // Is it capturing ?
                //if (_job.IsCapturing)
                if (_bStartedRecording)
                {
                    // Yes
                    // Stop Capturing
                    }

                _job.StopEncoding();
                if (_deviceSource != null)
                {
                    // Remove the Device Source and destroy the job
                    _job.RemoveDeviceSource(_deviceSource);

                    // Destroy the device source
                    _deviceSource.PreviewWindow = null;
                    _deviceSource = null;
                }
                else
                {
                    MessageBox.Show("The camera appears to be in use.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frmJobApplicantWebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopJob();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            _englishLanguage = rbEnglish.Checked;
            if (_englishLanguage)
            {
                culture = CultureInfo.CreateSpecificCulture("");
            }
            else
            {
                culture = CultureInfo.CreateSpecificCulture("es-MX");
            }
            AdjustCulture();
        }
    }
}
