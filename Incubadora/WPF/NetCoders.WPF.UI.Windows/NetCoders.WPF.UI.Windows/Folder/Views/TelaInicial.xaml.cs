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
    /// Interaction logic for TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void MenuItemCadastrar_Click(object sender, RoutedEventArgs e)
        {
            var telaCadastrar = new Cadastrar();
            telaCadastrar.Show();
        }

        private void MenuItemListar_Click(object sender, RoutedEventArgs e)
        {
            var telaListar = new Listar();
            telaListar.Show();
        }

        private void MenuItemLeitor_Click(object sender, RoutedEventArgs e)
        {
            var telaLeitor = new Leitor();
            telaLeitor.Show();
        }

        private void MenuItemRobo_Click(object sender, RoutedEventArgs e)
        {
            var telaRobo = new Robo();
            telaRobo.Show();
        }

        private void MenuItemSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
