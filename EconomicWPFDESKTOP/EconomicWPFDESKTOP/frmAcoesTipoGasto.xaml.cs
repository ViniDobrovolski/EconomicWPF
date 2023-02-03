using E_conomic;
using E_conomic.Class;
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

namespace EconomicWPF
{
    /// <summary>
    /// Lógica interna para frmAcoesTipoGasto.xaml
    /// </summary>
    public partial class frmAcoesTipoGasto : Window
    {
        public frmAcoesTipoGasto()
        {
            InitializeComponent();
            CarregarCombo();
        }


      

        private void btnNovoTipo_Click(object sender, RoutedEventArgs e)
        {
            frmNovoTipo f = new frmNovoTipo();
            f.Show();
            this.Close();
        }



        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Model m = new Model();
            m.DeletarTipoGasto(Convert.ToInt32(cbTipo.SelectedValue));

            MessageBox.Show("O tipo de gasto foi excluído");
    
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            Model get = new Model();
            List<dtoTipo> lista = get.ListTipoGastos();
            cbTipo.ItemsSource = lista;
            cbTipo.DisplayMemberPath = "nomegasto";
            cbTipo.SelectedValuePath = "id";
        }

        private void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            frmNovoTipo f = new frmNovoTipo(Convert.ToInt32(cbTipo.SelectedValue));
            f.Show();
            this.Close();
        }
    }
}
