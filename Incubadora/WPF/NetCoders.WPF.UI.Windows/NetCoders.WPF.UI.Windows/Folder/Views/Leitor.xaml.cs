using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Speech.Synthesis;

namespace NetCoders.WPF.UI.Windows.Folder.Views
{
    /// <summary>
    /// Interaction logic for Leitor.xaml
    /// </summary>
    public partial class Leitor : Window
    {
        public Leitor()
        {
            InitializeComponent();
        }

        public void Falar(String texto_, Int32 velocidade_, Int32 volume_)
        {
            var voz = new SpeechSynthesizer();

            PromptBuilder builder = new PromptBuilder();

            builder.StartVoice("ScanSoft Raquel_Full_22Hz");

            builder.AppendText(texto_);

            builder.EndVoice();

            voz.SetOutputToDefaultAudioDevice();

            voz.Rate = velocidade_;

            voz.Volume = volume_;

            voz.Speak(builder);
        }

        private void BtnFala_Click(object sender, RoutedEventArgs e)
        {
            Falar(TxtFala.Text, -10, 100);
        }

        private void TxtFala_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var textoFala = TxtFala.SelectedText;

            Falar(textoFala, -4, 100);
        }
    }
}
