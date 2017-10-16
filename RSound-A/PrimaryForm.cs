using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using Encryption;

namespace RSound_A
{


    public partial class PrimaryForm : Form
    {
        private List<float> HauteurCryptees = new List<float>();
        private String SoundPath = String.Empty;
        private byte Multiplier = Convert.ToByte(12);
        private int Hauteur;
        private int Channel;
        public PrimaryForm() {
            InitializeComponent();
        }     
 
        private void CreateHauteurListAndCrypt(String path) {

            ChangeStatus("Crypting your sound ...", FlatUI.FlatAlertBox._Kind.Info);

            AudioFileReader ReadedSound = new AudioFileReader(path);
            int SoundSize = Convert.ToInt32(ReadedSound.Length);
            byte[]  HauteurArray= new byte[SoundSize];

            ReadedSound.Read(HauteurArray, 0, SoundSize);
            Hauteur = ReadedSound.WaveFormat.SampleRate;
            Channel = ReadedSound.WaveFormat.Channels;

            RSA PreparedRSA = new RSA();
            PreparedRSA.GenerateKey();

            for(int a = 0; a < HauteurArray.Length; ++a)
            {
                HauteurArray[a] *= Multiplier;
            }
            for (int i = 0; i < HauteurArray.Length; i++) {

                HauteurCryptees.Add(PreparedRSA.Crypt(HauteurArray[i]));
 
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
                ChangeStatus("Sound opened with success!", FlatUI.FlatAlertBox._Kind.Success);
              
            }

        }

        private void ChangeStatus(string Message, FlatUI.FlatAlertBox._Kind kind) {
            statusLbl.Text = Message;
            statusLbl.kind = kind;
        }

        public static byte[] GetSamplesWaveData(List<float> samples) {
            var pcm = new byte[samples.Count * 2];
            int sampleIndex = 0, pcmIndex = 0;

            while (sampleIndex < samples.Count)
            {
                var outsample = (short)(samples[sampleIndex] * short.MaxValue);
                pcm[pcmIndex] = (byte)(outsample & 0xff);
                pcm[pcmIndex + 1] = (byte)((outsample >> 8) & 0xff);

                sampleIndex++;
                pcmIndex += 2;
            }

            return pcm;
        }

        private void ExportSound(String path, List<float> myFrequencies, int channel, int Hauteur)
        {
            //Frequence d'analyse : 44,100 Hz et channel : 1
            /* Où Wave désigne le format .wav */

            MemoryStream convertedStream = new MemoryStream(GetSamplesWaveData(myFrequencies));
            IWaveProvider provider = new RawSourceWaveStream(convertedStream, new WaveFormat(Hauteur, channel));
            WaveFileWriter.CreateWaveFile(path, provider);
                 
        }

   
        private void btnCrypt_click(object sender, EventArgs e) {
            try {
                CreateHauteurListAndCrypt(SoundPath);

            }

            catch (Exception error) {
                MessageBox.Show(error.Data + "\n" + error.Message + "\n" + error.Source, null , MessageBoxButtons.OK , MessageBoxIcon.Error);
                ChangeStatus("An error happened !", FlatUI.FlatAlertBox._Kind.Error);
                Application.Exit();
            }
            ChangeStatus("Done with success!", FlatUI.FlatAlertBox._Kind.Success);

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
                    ExportSound(path, HauteurCryptees, Channel, Hauteur);
                    ChangeStatus("Sound exported with success!", FlatUI.FlatAlertBox._Kind.Success);

                }
                catch (Exception error) {
                    MessageBox.Show(error.Data + "\n" + error.Message + "\n" + error.Source, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnCrypt_Click_1(object sender, EventArgs e)
        {

        }
    }
}
