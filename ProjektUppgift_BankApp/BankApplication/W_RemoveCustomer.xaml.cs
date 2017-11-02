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
using System.Windows.Shapes;

namespace BankApplication
{
    /// <summary>
    /// Interaction logic for W_RemoveCustomer.xaml
    /// </summary>
    public partial class W_RemoveCustomer : Window
    {
        public W_RemoveCustomer()
        {
            InitializeComponent();
            RemoveButton.Click += RemoveButton_Click;
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            InfoBlock.Text = "Removing Customer and closing associated accounts...\n";
            long Pnr = Convert.ToInt64(PersonNumberInput.Text);
            List<string> result = BankLogic.RemoveCustomer(Pnr);
            foreach (string s in result)
            {
                InfoBlock.Text += s;
            }

        }
    }
}
