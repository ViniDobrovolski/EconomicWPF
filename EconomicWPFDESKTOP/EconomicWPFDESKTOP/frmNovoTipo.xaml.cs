using E_conomic.Class;
using E_conomic;
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
    /// Lógica interna para frmNovoTipo.xaml
    /// </summary>
    public partial class frmNovoTipo : Window
    {
        public frmNovoTipo()
        {
            InitializeComponent();
        }

        public frmNovoTipo(int id)
        {
            InitializeComponent();
            txtID.Text = id.ToString();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Model set = new Model();
            tipoGastos p = new tipoGastos();
            p.nomegasto = txtNome.Text;

            if (txtID.Text != string.Empty)
            {
                p.id = int.Parse(txtID.Text);
                set.EditTipoGasto(p);
            }
            else
            {
                set.SetTipoGasto(p);
            }

            this.Close();

            frmAcoesTipoGasto ac = new frmAcoesTipoGasto();
            ac.Show();
        }
    }
}
