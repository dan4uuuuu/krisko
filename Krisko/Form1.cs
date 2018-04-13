using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisko
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speechSynthesizerObj;
        public Form1()
        {
            InitializeComponent();
            speechSynthesizerObj = new SpeechSynthesizer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете текст!");
            }
            else
            {
                speechSynthesizerObj.Dispose();
                speechSynthesizerObj = new SpeechSynthesizer();
                var voices = speechSynthesizerObj;

                speechSynthesizerObj.SelectVoice("Microsoft Zira Desktop");

                speechSynthesizerObj.SpeakAsync(textBox1.Text);
            }
            
        }
    }
}
