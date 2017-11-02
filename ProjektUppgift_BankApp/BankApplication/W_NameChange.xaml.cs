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
    /// Interaction logic for W_NameChange.xaml
    /// </summary>
    public partial class W_NameChange : Window
    {
        public W_NameChange()
        {
            InitializeComponent();
            ChangeButton.Click += ChangeButton_Click;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            if (BankLogic.ChangeCustomerName(Convert.ToInt64(PersonNumberInput.Text), FirstNameInput.Text, LastNameInput.Text))
            {
                textBlock.Text = "Name changed";
            }
            else
                textBlock.Text = "Unsuccessful Namechange";


        }
    }
}
