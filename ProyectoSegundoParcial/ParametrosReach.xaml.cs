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
    /// Lógica de interacción para ParametrosReach.xaml
    /// </summary>
    public partial class ParametrosReach : UserControl
    {
        public ParametrosReach()
        {
            InitializeComponent();
        }

        private void Btng_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb1.Text))
            {

                ERROR.Visibility = Visibility.Visible;

                return;
            }

            if (string.IsNullOrEmpty(tb2.Text))
            {

                ERROR.Visibility = Visibility.Visible;

                return;
            }

            if (string.IsNullOrEmpty(tb3.Text))
            {

                ERROR.Visibility = Visibility.Visible;

                return;
            }

            if (string.IsNullOrEmpty(tb4.Text))
            {

                ERROR.Visibility = Visibility.Visible;

                return;
            }

            if (string.IsNullOrEmpty(tb5.Text))
            {

                ERROR.Visibility = Visibility.Visible;

                return;
            }

            if (string.IsNullOrEmpty(tb6.Text))
            {

                ERROR.Visibility = Visibility.Visible;

                return;
            }

            else grdREACH.Children.Clear();
        }

        private void Btnc_Click(object sender, RoutedEventArgs e)
        {
            grdREACH.Children.Clear();
        }
    }
}
