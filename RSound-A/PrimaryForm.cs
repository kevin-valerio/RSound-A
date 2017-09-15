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
using NAudio.Wave.Compression;

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

        public static byte[] GetSamplesWaveData(List<float> samples, int samplesCount) {
            var pcm = new byte[samplesCount * 2];
            int sampleIndex = 0,
                pcmIndex = 0;

            while (sampleIndex < samplesCount)
            {
                var outsample = (short)(samples[sampleIndex] * short.MaxValue);
                pcm[pcmIndex] = (byte)(outsample & 0xff);
                pcm[pcmIndex + 1] = (byte)((outsample >> 8) & 0xff);

                sampleIndex++;
                pcmIndex += 2;
            }

            return pcm;
        }

        private void ExportSound(String path, List<float> myFrequencies)
        {
            //Prend chaque List<float>:float de myFrequencies et exporte le fichier à String:path

            MemoryStream convertedStream = new MemoryStream(GetSamplesWaveData(myFrequencies, myFrequencies.Count));
            IWaveProvider provider = new RawSourceWaveStream(  convertedStream, new WaveFormat());
            WaveFileWriter.CreateWaveFile(path, provider);
                 
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

                ExportSound(path, FrequencyList);
                ChangeStatus("Sound exported with success!", Color.Green);

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
