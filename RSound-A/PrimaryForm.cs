﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
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
                statusLbl.ForeColor = Color.Green;
                statusLbl.Text = "Sound opened with success!";
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show(SoundPath);
            AudioFileReader ReadedSound = new AudioFileReader(@SoundPath);
            int soundSize = Convert.ToInt32(ReadedSound.Length);
            var frequencyArray = new float[soundSize];
            ReadedSound.Read(frequencyArray, 0, soundSize);

            for (int i = 0; i < frequencyArray.Length; i++)
            {

                FrequencyList.Add(frequencyArray[i]);
                MessageBox.Show(frequencyArray[i].ToString());
            }
        }
    }
}