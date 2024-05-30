using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraWattanaEasy {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            resizeAuto = new ResizeAuto(this);
        }

        #region =========================================== Input ===========================================
        private ResizeAuto resizeAuto;
        private VideoCapture capture;
        private readonly VideoCapture.API[] captureApis = { VideoCapture.API.DShow };
        private readonly Image<Bgr, byte> defaultImage = new Image<Bgr, byte>(640, 480);
        private readonly Timer timer = new Timer();
        private FileInput fileInput = new FileInput();
        private FileOutput fileOutput = new FileOutput();
        private FileTxt fileTxt = new FileTxt();

        private int rotate = 0;
        private const string fileConfig = "CameraEasyConfig.txt";
        private const string headRotate = "Rotate";
        private Dictionary<string, List<string>> topics = new Dictionary<string, List<string>>();
        #endregion

        #region =========================================== Display ===========================================

        #endregion

        #region =========================================== Cal ===========================================

        #endregion

        #region =========================================== Main ===========================================
        private void FormMain_Load(object sender, EventArgs e) {
            resizeAuto.Initial();

            // Use the first capture API that works
            foreach (var api in captureApis)
            {
                capture = new VideoCapture(0, api);
                if (capture.IsOpened)
                {
                    break;
                }
            }

            if (!capture.IsOpened)
            {
                MessageBox.Show("Failed to open camera 1.");
                Application.Exit();
            }

            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 640);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 480);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, 15);
            capture.Stop();

            timer.Interval = 33; // Update at about 30 fps
            timer.Tick += Timer_Tick;
            //timer.Enabled = true;

            if (!File.Exists(fileConfig))
            {
                // Create the file with some topics and details
                topics[headRotate] = new List<string>() { rotate.ToString() };
                fileTxt.WriteTopicsToFile(fileConfig, topics);
            }
            else
            {
                // Read the file and display its contents again
                Dictionary<string, List<string>> topics = fileTxt.ReadTopicsFromFile(fileConfig);
                if (topics.ContainsKey(headRotate))
                {
                    if (int.TryParse(topics[headRotate][0], out int rotateValue))
                    {
                        rotate = rotateValue;
                    }
                    else
                    {
                        // Edit one of the details in the file
                        fileTxt.EditDetailInFile(fileConfig, headRotate, rotate.ToString());
                    }
                }
            }

            this.WindowState = FormWindowState.Minimized;
        }
        private void FormMain_Resize(object sender, EventArgs e) {
            resizeAuto.Resize();
        }
        private void Timer_Tick(object sender, EventArgs e) {
            Mat frame = new Mat();
            try
            {
                //capture.Read(frame);
                capture.Grab();
                capture.Retrieve(frame);
                if (!frame.IsEmpty)
                {
                    var imgage = frame.ToImage<Bgr, byte>();
                    Bgr sup = new Bgr();
                    imgage = imgage.Rotate(rotate, sup);
                    ptb_camera.BackgroundImage = imgage.Bitmap;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void tm_readFile_Tick(object sender, EventArgs e) {
            tm_readFile.Enabled = false;
            if (fileInput.ReadFile())
            {
                if (File.Exists(fileInput.pathImage))
                {
                    using (Image image = Image.FromFile(fileInput.pathImage))
                    {
                        ptb_image.BackgroundImage = new Bitmap(image);
                    }
                }
                else
                {
                    //MessageBox.Show("Image file not found.");
                    _ = Task.Run(() => MessageBox.Show("Image file not found."));
                }

                tb_message.Text = fileInput.message;

                if (fileInput.type.ToUpper() == "YESNO")
                {
                    bt_no.Visible = true;
                    bt_ok.Visible = false;
                    bt_yes.Visible = true;
                }
                else
                {
                    bt_no.Visible = false;
                    bt_ok.Visible = true;
                    bt_yes.Visible = false;
                }

                timer.Enabled = true;
                this.WindowState = FormWindowState.Normal;
            }
            tm_readFile.Enabled = true;
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show("Do you want to close the program?", "Close Program", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void bt_yes_Click(object sender, EventArgs e) {
            if (!fileInput.flagRead)
            {
                return;
            }
            fileOutput.Write("Yes");
            this.WindowState = FormWindowState.Minimized;
            timer.Enabled = false;
        }
        private void bt_ok_Click(object sender, EventArgs e) {
            if (!fileInput.flagRead)
            {
                return;
            }
            fileOutput.Write("OK");
            this.WindowState = FormWindowState.Minimized;
            timer.Enabled = false;
        }
        private void bt_no_Click(object sender, EventArgs e) {
            if (!fileInput.flagRead)
            {
                return;
            }
            fileOutput.Write("No");
            this.WindowState = FormWindowState.Minimized;
            timer.Enabled = false;
        }
        private void pn_adjust_Click(object sender, EventArgs e) {
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Settings, 0);
        }
        private void pn_degree_Click(object sender, EventArgs e) {
            rotate += 90;
            if (rotate >= 360)
            {
                rotate = 0;
            }
            fileTxt.EditDetailInFile(fileConfig, headRotate, rotate.ToString());
        }
        #endregion


    }
}
