using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using CSCore.CoreAudioAPI;

namespace Pablo_C_Sharp
{
    public partial class MainForm : Form
    {

        private string soundLocation = "sounds/";
        private string imagesLocation = "images/";
        private Boolean imageFormCreated = false;
        private ImageForm imageForm;

        public MainForm()
        {
            InitializeComponent();
            this.patientLetterCombo.SelectedIndex = 0;
            this.patientNumberCombo.SelectedIndex = 0;
            this.roomCombo.SelectedIndex = 0;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string pletter = this.patientLetterCombo.Text;
            string pnumber = this.patientNumberCombo.Text;
            string rnumber = this.roomCombo.Text;
            this.lastPatientLabel.Text = "Pacjent: " + pletter + pnumber + "        Gabinet: " + rnumber;
            string imagePath = imagesLocation + pletter + "_" + pnumber + ".png";
            string soundPath = soundLocation + pletter + "_" + pnumber + "_" + rnumber + ".mp3";


            // Screen handling
            Screen currentScreen = Screen.FromControl(this);
            Screen destinationScreen = currentScreen;

            Screen[] screens = Screen.AllScreens;
            if(screens.Length > 1)
            {
                foreach (var scr in screens)
                {
                    if (currentScreen != scr)
                    {
                        destinationScreen = scr;
                    }
                }
            }
            Rectangle destRect = destinationScreen.Bounds;


            // Image managing
            if (!imageFormCreated)
            {
                imageForm = ImageForm.getInstance(imagePath, destRect);
                imageFormCreated = true;
                imageForm.Show();
            }
            else
            {
                imageForm.updateImage(imagePath);
            }


            // Sound managing
            Task.Run(() => LowerSpotifyVolume());
            Task.Run(() => PlayRecording(soundPath));
        }

        //=============================================================
        //=============================================================
        //=============================================================

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }

        private static void LowerSpotifyVolume()
        {
            var processes = Process.GetProcessesByName("spotify");

            if (processes.Length != 0)
            {
                using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
                {
                    using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                    {
                        foreach (var session in sessionEnumerator)
                        {
                            using (var simpleVolume = session.QueryInterface<SimpleAudioVolume>())
                            using (var sessionControl = session.QueryInterface<AudioSessionControl2>())
                            {
                                foreach (var proc in processes)
                                {
                                    if (sessionControl.ProcessID == proc.Id)
                                    {
                                        simpleVolume.MasterVolume = 0.05f;
                                        System.Threading.Thread.Sleep(13000);
                                        simpleVolume.MasterVolume = 1.0f;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void PlayRecording(string filePath)
        {
            MusicPlayer player = new MusicPlayer(filePath);
            System.Threading.Thread.Sleep(1000);
            player.Play();
        }
    }
}
