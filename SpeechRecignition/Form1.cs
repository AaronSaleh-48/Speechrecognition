using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace PlayDespacito
{
    public partial class frmMain : Form
    {
        //Variablendeklaration
        SpeechRecognitionEngine speechRec = new SpeechRecognitionEngine();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            try
            {
                Choices sList = new Choices();
                sList.Add(new string[] { "c#", "hello", "how", "are", "you"});
                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(sList);
                Grammar gr = new Grammar(gBuilder);

                speechRec.RequestRecognizerUpdate();
                speechRec.LoadGrammar(gr);
                speechRec.SpeechRecognized += new EventHandler <SpeechRecognizedEventArgs>(SpeechRec_SpeechRecognized);
                speechRec.SetInputToDefaultAudioDevice();
                speechRec.RecognizeAsync(RecognizeMode.Multiple);
                speechRec.Recognize();
            }
            catch
            {
                return;
            }
        }

        private void SpeechRec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            rtxSpeech.Text += (" " + e.Result.Text.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxSpeech.Clear();
        }
    }
}
