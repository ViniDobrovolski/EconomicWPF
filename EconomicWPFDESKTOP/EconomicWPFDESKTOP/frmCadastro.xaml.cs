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
    /// Lógica interna para frmCadastro.xaml
    /// </summary>
    public partial class frmCadastro : Window
    {
        public int usu;
        public frmCadastro(int usuariologado)
        {
            usu = usuariologado;
            InitializeComponent();
            carregarCampos();
            txtIDlog.Text = usu.ToString();
        }

        private void carregarCampos()
        {
            Model set = new Model();
            dtoUsuario p = new dtoUsuario();
            p = set.GetUsuarioId(usu);
            txtUsuario.Text = p.nomecompleto.ToString();
            txtEmail.Text = p.email.ToString();
            txtSenha.Text = p.senha.ToString();
            txtTelefone.Text = p.telefone.ToString();
            txtRenda.Text = p.rendamensal.ToString();
        }

        public frmCadastro()
        {

            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "" && txtEmail.Text == "" && txtTelefone.Text == "")
            {
                MessageBox.Show("Algum campo está em branco");

                txtUsuario.Focus();

            }

            else
            {
                Model set = new Model();
                DbUsuarios p = new DbUsuarios();

                if (txtIDlog.Text == "")
                {

                    p.nomecompleto = txtUsuario.Text;
                    p.email = txtEmail.Text;
                    p.senha = txtSenha.Text;
                    p.telefone = txtTelefone.Text;
                    p.rendamensal = Convert.ToDecimal(txtRenda.Text);
                    set.SetUsuario(p);

                }

                else
                {


                    p.id = Convert.ToInt32(txtIDlog.Text);
                    p.nomecompleto = txtUsuario.Text;
                    p.email = txtEmail.Text;
                    p.senha = txtSenha.Text;
                    p.telefone = txtTelefone.Text;
                    p.rendamensal = Convert.ToDecimal(txtRenda.Text);
                    set.EditUsuario(p);

                }

                this.Close();
                frmMenuPrincipal m = new frmMenuPrincipal(p.id);
                m.Show();


            }
        }

        private void txtUsuario_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUsuario.Clear();
        }

        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtSenha_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSenha.Clear();
        }

        private void txtTelefone_GotFocus(object sender, RoutedEventArgs e)
        {
            txtTelefone.Clear();
        }

        private void txtRenda_GotFocus(object sender, RoutedEventArgs e)
        {
            txtRenda.Clear();
        }
    }
}
