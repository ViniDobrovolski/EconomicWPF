using EconomicWPFDESKTOP;
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
    /// Lógica interna para frmEscolhaComp.xaml
    /// </summary>
    public partial class frmEscolhaComp : Window
    {
        public int idusu = 0;
        public frmEscolhaComp(int idusuario)
        {
            idusu = idusuario;
            InitializeComponent();
        }

        private void btnMensais_Click(object sender, RoutedEventArgs e)
        {
            frmComparar f = new frmComparar(idusu, 0);
            f.Show();
            this.Close();
        }

        private void btnAnuais_Click(object sender, RoutedEventArgs e)
        {
            frmComparar f = new frmComparar(idusu, 1);
            f.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            frmMenuPrincipal n = new frmMenuPrincipal(idusu);
            n.Show();
        }
    }
}
