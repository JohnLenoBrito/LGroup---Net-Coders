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
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace NetCoders.WPF.UI.Windows.Folder.Views
{
    /// <summary>
    /// Interaction logic for Robo.xaml
    /// </summary>
    public partial class Robo : Window
    {
        public Robo()
        {
            InitializeComponent();
        }

        public void Escrever(String texto_)
        {
            SendKeys.SendWait(texto_);
        }

        public void Abrir(String programa_, Int32 vezes_)
        {
            for (int i = 0; i < vezes_; i++)
            {
                Process.Start(programa_);
            }
        }

        private void BtnChrome_Click(object sender, RoutedEventArgs e)
        {
            Abrir("chrome.exe", 1);
            Thread.Sleep(5000);
            Escrever("www.fb.com");
            //Thread.Sleep(2000);
            //Escrever("Escrito por um Robô (LGroup - .Net Coders)");
            Escrever("{ENTER}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{TAB}");
            Escrever("{ENTER}");
        }

        private void BtnNotepad_Click(object sender, RoutedEventArgs e)
        {
            Abrir("notepad.exe", 1);
            Thread.Sleep(2000);
            Escrever("Malandroviks");
        }
    }
}
