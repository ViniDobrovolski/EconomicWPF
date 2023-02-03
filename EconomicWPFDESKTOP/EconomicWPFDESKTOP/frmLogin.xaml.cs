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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EconomicWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int idusuariologado;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            Model set = new Model();
            DbUsuarios u = new DbUsuarios();
            u.email = txtLogin.Text;
            u.senha = txtSenha.Password;

            usuarioLogin login = set.LoginUsuario(u.email, u.senha);

            if (login != null)
            {
                idusuariologado = login.id;
                new frmMenuPrincipal(idusuariologado).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seu nome de usuario ou senha estão errados");
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }

        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.Show();
            this.Close();
        }

        private void txtLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if(txtLogin.Text == "Usuário")
                txtLogin.Clear();
        }

        private void txtSenha_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSenha.Clear();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
