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
using System.IO;

namespace S7_300_MockingServer_UI
{
    public partial class MaxwellForm : Form
    {

        private IWavePlayer waveOutDevice;
        private Stream mediaStream;

        public MaxwellForm()
        {

            InitializeComponent();
        }

        private void MaxwellForm_Load(object sender, EventArgs e)
        {
            PlayAudioFromResources();
        }

        private void PlayAudioFromResources()
        {
            waveOutDevice = new WaveOutEvent();

            // Retrieve the audio stream from resources
            mediaStream = new MemoryStream(Properties.Resources.maxwell_the_cat_theme); // Assuming this is the correct resource name
            var mp3Reader = new Mp3FileReader(mediaStream);

            waveOutDevice.Init(mp3Reader);
            waveOutDevice.Play();

            this.FormClosing += (s, args) =>
            {
                waveOutDevice?.Stop();
                waveOutDevice?.Dispose();
                mp3Reader?.Dispose();
                mediaStream?.Dispose();
            };
        }
    }
}
