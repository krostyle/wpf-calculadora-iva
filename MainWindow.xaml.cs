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

namespace WpfCalculadoraIVA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double iva = 0.19;
        string nombre, apellido, resultado;
        double subtotal, total;

        //Este metodo permite limpiar las cajas de texto (textbox)
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtSubtotal.Text = "";
            this.lblResultado.Content = "";
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            
            double.TryParse(txtSubtotal.Text, out this.subtotal);
            this.total = this.subtotal+this.subtotal *this.iva;
            this.resultado = this.txtNombre.Text + " " + this.txtApellido.Text + " Debe pagar un total de : $" + this.total.ToString()+ " pesos";
            this.lblResultado.Content = this.resultado;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
       
        
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

    }

  
}
