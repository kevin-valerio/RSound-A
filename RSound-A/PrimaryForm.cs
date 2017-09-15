using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio;
using System.IO;

namespace RSound_A
{
    
    public partial class PrimaryForm : Form
    {
        private List<float> FrequencyList = new List<float>();
        private String SoundPath = String.Empty;
 
        public PrimaryForm() {
            InitializeComponent();
        }     

        private void CreateFrequencyList() {

            AudioFileReader ReadedSound = new AudioFileReader(SoundPath);
            int soundSize = Convert.ToInt32(ReadedSound.Length);
            var  frequencyArray = new float[soundSize];
            ReadedSound.Read(frequencyArray, 0, soundSize);

            for (int i = 0; i < frequencyArray.Length; i++) { 
                FrequencyList.Add(frequencyArray[i]);
            }

        }
 
        private void importBtn_click(object sender, EventArgs e)
        {
            OpenFileDialog openSound = new OpenFileDialog() {
                Filter = "WAV Files|*.wav",
                Title = "Please, select a .wav file"
            };

            if (openSound.ShowDialog() == DialogResult.OK) {
                SoundPath = openSound.FileName;
                txtBoxSoundPath.Text = SoundPath;
                ChangeStatus("Sound opened with success!", Color.Green);
              
            }

        }

        private void ChangeStatus(string Message, Color fontColor) {
            statusLbl.Text = Message;
            statusLbl.ForeColor = fontColor;
        }

        private void ExportSound(String path, List<float> myFrequencies)
        {
            //Prend chaque List<float>:float de myFrequencies et exporte le fichier à String:path
            string tempFile = Path.Combine(path);
            WaveFormat waveFormat = new WaveFormat(8000, 8, 2);
            WaveStream sourceStream = new NullWaveStream(waveFormat, 10000);
            WaveFileWriter.CreateWaveFile(tempFile, sourceStream);
        }


        private void btnCrypt_click(object sender, EventArgs e) {

            AudioFileReader ReadedSound = new AudioFileReader(@SoundPath);
            int soundSize = Convert.ToInt32(ReadedSound.Length);
            var frequencyArray = new float[soundSize];
            ReadedSound.Read(frequencyArray, 0, soundSize);
            ChangeStatus("Crypting your sound ...", Color.Black);
            try {
                for (int i = 0; i < frequencyArray.Length; i++) {
                    FrequencyList.Add(frequencyArray[i]);

                }
            }
            catch (Exception error) {
                MessageBox.Show(error.Message, null , MessageBoxButtons.OK , MessageBoxIcon.Error);
                ChangeStatus("An error happened !", Color.Red);

            }
            ChangeStatus("Done !", Color.Green);

            if(checkExportSound.Checked == true) {
                String path = String.Empty;
                SaveFileDialog exportSoundDialog = new SaveFileDialog()
                {
                    Filter = "WAV Files|*.wav",
                    Title = "Save the sound"
                };

                if (exportSoundDialog.ShowDialog() == DialogResult.OK) {
                    path = exportSoundDialog.FileName;
                }
                try {
                    ExportSound(path, FrequencyList);
                    ChangeStatus("Sound exported with success!", Color.Green);

                }
                catch (Exception error) {
                    MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
