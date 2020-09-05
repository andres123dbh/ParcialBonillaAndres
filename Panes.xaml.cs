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
    /// Lógica de interacción para Panes.xaml
    /// </summary>
    public partial class Panes : Page
    {
        public Panes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string cantidad = txtCantidad.Text;
            int cantidadPanes = Int32.Parse(cantidad);
            string nombreClientes = txtNombre.Text;
            string cedulaCliente = txtCedula.Text;
            var item = (ComboBoxItem)tipoPan.SelectedValue;
            var pan = (string)item.Content;
            var valorPan = cantidadPanes;
            DateTime dia = DateTime.Today;
            var hora = DateTime.Now.ToString("hh:mm:ss");
            if (pan == "Aliñado")
            {
                 valorPan = cantidadPanes * 1000;
            }
            else
            {
                if(pan == "No Aliñado")
                {
                     valorPan = cantidadPanes * 500;
                }
                else
                {
                    if(pan == "Espesial")
                    {
                         valorPan = cantidadPanes * 2000;
                    }
                }
            }
            
            var add = "Fecha: " + dia.ToString("d") + "     Hora: " + hora        
                + "\nPan: " + pan  + "     Cantidad de Panes: " + cantidadPanes + "\nTotal: "
                + valorPan + "\nNombre del Cliente: " + nombreClientes
                + "\nCedula del Cliente: " + cedulaCliente;
            txtVentas.Inlines.Add(new Run(add));
            txtVentas.Inlines.Add(new LineBreak());
            txtVentas.Inlines.Add(new Run("--------------------------------------------------"));
            txtVentas.Inlines.Add(new LineBreak());
        }

        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtVentas.Text = string.Empty;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
