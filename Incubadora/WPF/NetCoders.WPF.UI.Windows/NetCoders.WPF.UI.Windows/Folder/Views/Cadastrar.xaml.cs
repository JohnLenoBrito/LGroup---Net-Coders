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

namespace NetCoders.WPF.UI.Windows.Folder.Views
{
    /// <summary>
    /// Interaction logic for Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        public void LimparTelaCadastro()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            datePickerDataNascimento.SelectedDate = null;

            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparTelaCadastro();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
