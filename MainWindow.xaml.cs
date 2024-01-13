using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace T4BindingObjetosNegocio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cont = 1;
        int final = 1;
        List<Superheroe> list;
       
        public MainWindow()
        {
            InitializeComponent();
            list = Superheroe.GetSamples();

            fondoMain.DataContext = list.FirstOrDefault();
            contador.Text = cont.ToString();
            final = (list.Count() - 1);
            total.Text = list.Count.ToString();
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image button = (Image)sender;
            list = Superheroe.GetSamples();

            if (button.Tag.ToString() == "R")
            {


                if (cont == list.Count)
                {
                    cont = 1;
                    fondoMain.DataContext = list[cont - 1] as Superheroe;
                    contador.Text = cont.ToString();
                }
                else
                {

                    cont++;
                    contador.Text = cont.ToString();
                    fondoMain.DataContext = list[cont - 1] as Superheroe;
                }

            }
            else
            {

                if (cont == 1)
                {
                    cont = 3;
                    contador.Text = cont.ToString();
                    fondoMain.DataContext = list[cont - 1] as Superheroe;
                }
                else
                {
                    cont--;
                    contador.Text = cont.ToString();
                    fondoMain.DataContext = list[cont - 1] as Superheroe;

                }


            }
        }

        
    }
}
