using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParcialBonillaAndres
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new ValorVentas());
            }
            else
            {
                if (txtUsername.Text == "empleada" && txtPassword.Password == "4321")
                {
                    MainWindow w = (MainWindow)Window.GetWindow(this);
                    w.frameMain.NavigationService.Navigate(new Panes());
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
                }
            }
        }
    }
}
