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
    /// Lógica de interacción para ValorVentas.xaml
    /// </summary>
    public partial class ValorVentas : Page
    {
        public ValorVentas()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }

    }
}
