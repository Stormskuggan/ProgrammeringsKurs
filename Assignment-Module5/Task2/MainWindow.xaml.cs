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
using System.IO;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string myName;
        
        

        public MainWindow()
        {

            InitializeComponent();

            DisplayButton.Click += DisplayButton_Click;
            SaveButton.Click += SaveButton_Click;
            
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            //string path = Directory.GetCurrentDirectory();


            try
            {

                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\Names.txt");
                DisplayLabel.Content = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Names.txt");
                sr.Close();

            }
            catch (FileNotFoundException)
            {
                DisplayLabel.Content = "File not found. Maybe save a name first";
            }
            catch (Exception)
            {
                DisplayLabel.Content = "Error";
            }


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            try
            {
                if (InputNameBox.Text == "")
                {
                    throw new FormatException();
                }

                myName = InputNameBox.Text;

                //StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\Names.txt");
                StreamWriter sw = File.AppendText(Directory.GetCurrentDirectory() + @"\Names.txt");
                sw.WriteLine(myName);
                
                sw.Close();

                DisplayLabel.Content = "Name has been saved successfully";

            }
            catch (FormatException)
            {
                DisplayLabel.Content = "Please type in a name";
            }
            catch (EncoderFallbackException f)
            {
                DisplayLabel.Content = f;
            }
            catch (IOException i)
            {
                DisplayLabel.Content = i;
            }
            catch (Exception)
            {
                DisplayLabel.Content = "Error";
            }

        }
    }
}
