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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




      

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
          
            switch (cbProductos.SelectedIndex)
            {
                case 0:
                    gridproductos.Children.Add(new ParametrosTLOU());
                    break;

                case 1:
                    gridproductos.Children.Add(new ParametrosReach());
                    break;

                case 2:
                    gridproductos.Children.Add(new ParametrosCOD());
                    break;

                case 3:
                    gridproductos.Children.Add(new ParametrosRDR());
                    break;

                case 4:
                    gridproductos.Children.Add(new ParametrosPS());
                    break;

                case 5:
                    gridproductos.Children.Add(new ParametrosScarlett());
                    break;
            }
        }

        
    }

   
    }

