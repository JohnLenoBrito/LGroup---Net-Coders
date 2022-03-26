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
using NetCoders.WPF.DataAccess;
using NetCoders.WPF.Model;

namespace NetCoders.WPF.UI.Windows.Folder.Views
{
    /// <summary>
    /// Interaction logic for Listar.xaml
    /// </summary>
    public partial class Listar : Window
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListaContato();
        }

        private void CarregarListaContato()
        {
            DataGridContatos.ItemsSource = new ContatoREP().ListarContato();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregarListaContato();
        }
    }
}
