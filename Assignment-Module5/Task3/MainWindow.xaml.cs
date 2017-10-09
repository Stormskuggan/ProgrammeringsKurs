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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            


            if (File.Exists("LineNumbers.txt"))
            {
                File.Delete("LineNumbers.txt");
            }
                

            StreamWriter FileCreator = File.AppendText("LineNumbers.txt");
            FileCreator.WriteLine("This is line one");
            FileCreator.WriteLine("This is line two");
            FileCreator.WriteLine("This is line Three");
            FileCreator.WriteLine("This is line four");
            FileCreator.WriteLine("This is line five");
            FileCreator.WriteLine("This is line six");
            FileCreator.WriteLine("This is line seven");
            FileCreator.WriteLine("This is line eight");
            FileCreator.WriteLine("This is line nine");
            FileCreator.WriteLine("This is line ten");
            FileCreator.Close();

            ConfirmButton.Click += ConfirmButton_Click;


        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            string myFilename = InputBox.Text;

            if (!myFilename.EndsWith(".txt"))
            {
                myFilename += ".txt";
            }

            try
            {
                string[] Lines = File.ReadAllLines(myFilename);
                int lineNumber = 1;
                for (int i = 0; i < Lines.Length; i++)
                {

                    Lines[i] = Convert.ToString(lineNumber) + " " + Lines[i];
                    lineNumber++;
                }

                File.WriteAllLines(myFilename, Lines);
                label.Content = File.ReadAllText(myFilename);
            }
            catch (IndexOutOfRangeException r)
            {
                label.Content = r;
            }
            catch (FileNotFoundException)
            {
                label.Content = "Can't find an acceptable file";
            }
            catch (Exception)
            {

                label.Content = "Unknown Error";
            }
            
        }
    }
}
