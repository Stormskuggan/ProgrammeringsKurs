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
    /// Interaction logic for W_CreateAccount.xaml
    /// </summary>
    public partial class W_CreateAccount : Window
    {

        private long tempPnr;
        private int tempAccountID;

        public W_CreateAccount()
        {
            InitializeComponent();
            tempPnr = 0;
            tempAccountID = 0;
            CreateAccountButton.Click += CreateAccountButton_Click;
            DepositButton.Click += DepositButton_Click;
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            decimal inputAmount = Convert.ToDecimal(DepositInput.Text);
            if (BankLogic.Deposit(inputAmount, tempAccountID, tempPnr))
            {
                InfoBlock.Text = "Deposit successful!";
            }
            else
            {
                InfoBlock.Text = "Account doesn't exist to deposit to.";
            }
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            //BankLogic.AddSavingsAccount(PersonNumberInput)
            try
            {

                tempPnr = Convert.ToInt64(PersonNumberInput.Text);

                

                if (tempPnr.ToString().Length == 10)
                {

                    int result = BankLogic.AddSavingsAccount(tempPnr);
                    if (result == 404)
                    {
                        InfoBlock.Text = "404 nullreference";
                    }
                    else if (result == 000)
                    {
                        InfoBlock.Text = "Unknown Error";
                    }
                    else
                    {
                        InfoBlock.Text = "AccountID: " + result + " created!";
                        tempAccountID = result;
                    }
                    

                }
                else
                    InfoBlock.Text = "Invalid PersonID. Try this format YYMMDDXXXX";
            }
            catch
            {

            }

        }
    }
}
