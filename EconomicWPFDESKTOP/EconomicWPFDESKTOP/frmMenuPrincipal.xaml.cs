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
using E_conomic;
using EconomicWPFDESKTOP.Class;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Microsoft.SqlServer.Server;


namespace EconomicWPF
{
    /// <summary>
    /// Lógica interna para frmMenuPrincipal.xaml
    /// </summary>
    public partial class frmMenuPrincipal : Window
    {
        public int idusuariologado;
        public List<dtoGraficoMenu> lista;
        public decimal total;
        public frmMenuPrincipal(int usuariologado)
        {

            InitializeComponent();
            idusuariologado = usuariologado;
            verificarGastos();



            SeriesCollection = new SeriesCollection
            {
               

                new PieSeries
                {
                    Title = "Saúde",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(qtdesaude()) },
                    DataLabels = true,
                    Fill=Brushes.DarkRed
                    
                   
                   
                },
                new PieSeries
                {
                    Title = "Educação",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(qtdeEduc()) },
                    DataLabels = true,
                    Fill=Brushes.BlueViolet
                    
                },
                new PieSeries
                {
                    Title = "Mercado",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(qtdeMerc()) },
                    DataLabels = true,
                    Fill=Brushes.SandyBrown
                },
                new PieSeries
                {
                    Title = "Outros",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(qtdeOutros()) },
                    DataLabels = true,
                    Fill=Brushes.DarkBlue
                }
            };

            //adding values or series will update and animate the chart automatically
            //SeriesCollection.Add(new PieSeries());
            //SeriesCollection[0].Values.Add(5);

            DataContext = this;
        }

     
        public void verificarGastos()
        {
            if (qtdesaude() == 0 && qtdeEduc() == 0 && qtdeMerc() == 0 && qtdeOutros() == 0)
            {
                Chart.Visibility= Visibility.Collapsed;
            }
            else
                Chart.Visibility= Visibility.Visible;
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

        public SeriesCollection SeriesCollection { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frmNovoGasto f = new frmNovoGasto(idusuariologado);
            f.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmAcoesTipoGasto f = new frmAcoesTipoGasto();
            f.Show();
        }

        private void btnEditarUsu_Click(object sender, RoutedEventArgs e)
        {
            frmCadastro f = new frmCadastro(idusuariologado);
            f.Show();
            this.Close();
        }

        private void btnDeslogar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow f = new MainWindow();
            f.Show();
            this.Close();
        }

        private void btnComparar_Click(object sender, RoutedEventArgs e)
        {
            frmEscolhaComp f = new frmEscolhaComp(idusuariologado);
            f.Show();
            this.Close();
        }

        private void btnResumo_Click(object sender, RoutedEventArgs e)
        {
            frmResumoGastos f = new frmResumoGastos(idusuariologado);
            f.Show();
        }
    }
}
