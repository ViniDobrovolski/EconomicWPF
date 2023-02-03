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
using static System.Net.Mime.MediaTypeNames;
using EconomicWPFDESKTOP;

namespace EconomicWPF
{
    /// <summary>
    /// Lógica interna para frmNovoGasto.xaml
    /// </summary>
    public partial class frmNovoGasto : Window
    {
        public int usuariologado;
        public int idg;
        public frmNovoGasto(int idusuariologado)
        {
            InitializeComponent();
            usuariologado = idusuariologado;
            CarregarCombo();
        }

        public frmNovoGasto(int idusuariologado, int idgasto)
        {
            InitializeComponent();
            usuariologado = idusuariologado; 
            idg = idgasto;
            CarregarCombo();
            CarregarValores();

        }

        private void CarregarValores()
        {

            Model get = new Model();
            dtoGasto n = new dtoGasto();

            n = get.GetGasto(idg);

            txtID.Text = n.id.ToString();
            txtNome.Text = n.nome;
            txtValor.Text = n.valor.ToString();
            txtDescricao.Text = n.descricao;
        }

        private void CarregarCombo()
        {
            Model get = new Model();
            List<dtoTipo> lista = get.ListTipoGastos();
            cbTipo.ItemsSource = lista;
            cbTipo.DisplayMemberPath = "nomegasto";
            cbTipo.SelectedValuePath = "id";
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Model set = new Model();
            DbnovoGasto p = new DbnovoGasto();
            p.nome = txtNome.Text;
            p.valor = decimal.Parse(txtValor.Text);
            p.descricao = txtDescricao.Text;
            p.tipoid = Convert.ToInt32(cbTipo.SelectedValue);
            p.usuarioid = usuariologado;
            p.datagasto = DateTime.Now;
            if (txtID.Text != string.Empty)
            {
                p.id = int.Parse(txtID.Text);
                set.EditGasto(p);
                this.Close();
                frmMenuPrincipal n = new frmMenuPrincipal(usuariologado);
                n.Show();
                

            }
            else
            {
                set.SetGasto(p);
                this.Close();
                frmMenuPrincipal n = new frmMenuPrincipal(usuariologado);
                n.Show();
            }
           
            

        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                Model del = new Model();
                del.DeletarGasto(int.Parse(txtID.Text));

                this.Close();
                frmMenuPrincipal n = new frmMenuPrincipal(usuariologado);
                n.Show();

            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            frmMenuPrincipal n = new frmMenuPrincipal(usuariologado);
            n.Show();

        }
    }
    
}
