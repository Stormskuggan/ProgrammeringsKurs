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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FarenheitInputBox.GotFocus += FarenheitInputBox_GotFocus;
            //FarenheitInputBox.KeyDown += CelsiusInputBox_KeyDown;
            
        }

        private void FarenheitInputBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // throw new NotImplementedException();
            FarenheitInputBox.Text = "";
            FarenheitInputBox.KeyDown -= FarenheitInputBox_GotFocus;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            try
            {

                double Celsius;
                double farenheit;

                farenheit = Convert.ToDouble(FarenheitInputBox.Text);
                Celsius = (5d / 9d) * (farenheit - 32d);

                ResultLabel.Content = "Degree Celsius: " + Math.Round(Celsius, 1);
            }
            catch (FormatException)
            {
                ResultLabel.Content = "Wrong format, Use numbers instead";
            }
            catch (OverflowException)
            {
                ResultLabel.Content = "that number is too large!";
            }
            catch (Exception)
            {
                ResultLabel.Content = "Some error happened";
            }
           
            
        }
    }
}
