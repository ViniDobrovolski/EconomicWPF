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
using EconomicWPF;

namespace EconomicWPFDESKTOP
{
    /// <summary>
    /// Lógica interna para frmComparar.xaml
    /// </summary>
    public partial class frmComparar : Window
    {

        public int idtipo = 0;
        public int idusuario = 0;
        public int finalid = 0;
        public frmComparar(int usuario, int finalidade)
        {
            idusuario = usuario;
            finalid = finalidade;
            InitializeComponent();
            CarregarComboDatas();
            dataList.Visibility = Visibility.Hidden;


            if (finalidade == 1)
            {
               
                cbMes.Visibility = Visibility.Hidden;
                dataList.Visibility = Visibility.Hidden;
                finalid = finalidade;
            }
        }

        private void CarregarComboDatas()
        {
            cbMes.Items.Insert(0, "");
            cbMes.Items.Insert(1, "Janeiro");
            cbMes.Items.Insert(2, "Fevereiro");
            cbMes.Items.Insert(3, "Março");
            cbMes.Items.Insert(4, "Abril");
            cbMes.Items.Insert(5, "Maio");
            cbMes.Items.Insert(6, "Junho");
            cbMes.Items.Insert(7, "Julho");
            cbMes.Items.Insert(8, "Agosto");
            cbMes.Items.Insert(9, "Setembro");
            cbMes.Items.Insert(10, "Outubro");
            cbMes.Items.Insert(11, "Novembro");
            cbMes.Items.Insert(12, "Dezembro");

            cbAno.Items.Insert(0, "");
            cbAno.Items.Insert(1, "2020");
            cbAno.Items.Insert(2, "2021");
            cbAno.Items.Insert(3, "2022");
            
        }

        private void btnComparar_Click(object sender, RoutedEventArgs e)
        {
            dataList.Visibility = Visibility.Visible;

            if (finalid == 0)
            {
                Model m = new Model();
                List<dtoGastoComparar> list1 = new List<dtoGastoComparar>();
                

                list1 = m.comparartipoGastosMes(idusuario, Convert.ToInt32(cbAno.SelectedValue), cbMes.SelectedIndex);



                dataList.ItemsSource = list1;
               
            }

            else
            {
                Model m = new Model();
                List<dtoGastoComparar> list1 = new List<dtoGastoComparar>();
                

                list1 = m.comparartipoGastosAno(idusuario, Convert.ToInt32(cbAno.SelectedValue));


                dataList.ItemsSource = list1;


            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void dataList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           var gasto = (dataList.CurrentItem);
           dtoGastoComparar teste = (dtoGastoComparar)gasto;
            frmNovoGasto n = new frmNovoGasto(idusuario,teste.id);
            n.Show();
            this.Close();

        }
    }
}
