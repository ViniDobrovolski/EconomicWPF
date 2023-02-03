using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
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
using E_conomic;

namespace EconomicWPF
{
    /// <summary>
    /// Lógica interna para frmResumoGastos.xaml
    /// </summary>
    public partial class frmResumoGastos : Window
    {
        public int idusu = 0;
        public frmResumoGastos(int idusuario)
        {
            idusu = idusuario;
            InitializeComponent();
            CarregarCampos();
            

           
        }

        public double qtdesaude()
        {
            Model m = new Model();
            return Convert.ToDouble(m.getTotalTipo(5));
        }

        public double qtdeEduc()
        {
            Model m = new Model();
            return Convert.ToDouble(m.getTotalTipo(6));
        }
        public double qtdeMerc()
        {
            Model m = new Model();
            return Convert.ToDouble(m.getTotalTipo(7));
        }
        public double qtdeOutros()
        {
            Model m = new Model();
            return Convert.ToDouble(m.getTotalTipo(8));
        }

        private void CarregarCampos()
        {
            Model m = new Model();
            decimal rendaMes = m.GetUsuarioRenda(idusu);
            decimal sobra = m.GetSomaGastosMensais(idusu, DateTime.Now.Month);
            decimal ano = m.GetSomaGastosAnuais(idusu, DateTime.Now.Year);
            txtRenda.Text = m.GetUsuarioRenda(idusu).ToString();
            txtSaldo.Text = (rendaMes - sobra).ToString();
            txtEduc.Text = qtdeEduc().ToString();
            txtSaude.Text = qtdesaude().ToString();
            txtMerc.Text = qtdeMerc().ToString();
            txtOutros.Text = qtdeOutros().ToString();
            
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
