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
    /// Interaction logic for W_AddCustomer.xaml
    /// </summary>
    public partial class W_AddCustomer : Window
    {
        public W_AddCustomer()
        {
            InitializeComponent();

            AddCustomerButton.Click += AddCustomerButton_Click;
            
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                string FirstName = FirstNameInput.Text;
                string LastName = LastNameInput.Text;
                long Pnr = Convert.ToInt64(PersonalNumberInput.Text);

                if (Pnr.ToString().Length == 10)
                {
                    if (BankLogic.AddCustomer(Pnr, FirstName, LastName))
                    {
                        InfoBlock.Text = "Customer Added!";
                    }
                    else
                        InfoBlock.Text = "A customer with that PersonID already exists";
                }
                else
                    InfoBlock.Text = "Invalid PersonID. Try this format YYMMDDXXXX";

                
            }
            catch (FormatException)
            {
                InfoBlock.Text = "Invalid PersonID. Try this format YYMMDDXXXX";

            }
            catch (Exception x)
            {
                InfoBlock.Text = x.ToString();
            }

        }
    }
}
