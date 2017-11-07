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
    /// Interaction logic for W_WithdrawDeposit.xaml
    /// </summary>
    public partial class W_WithdrawDeposit : Window
    {
        public W_WithdrawDeposit()
        {
            InitializeComponent();
            DepositButton.Click += DepositButton_Click;
            WithdrawButton.Click += WithdrawButton_Click;
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {

            //throw new NotImplementedException();

            try
            {
                decimal amount = Convert.ToDecimal(AmountInput.Text);
                if (amount >= 0m)
                {
                    int id = Convert.ToInt32(IdInput.Text);
                    long Pnr = Convert.ToInt64(PersonNumberInput.Text);
                    int result = BankLogic.Withdraw(amount, id, Pnr);
                    if (result == 1)
                    {
                        InfoBlock.Text = "Withdraw successful!\n" + BankLogic.GetAccount(id, Pnr);
                    }
                    else if (result == -1)
                    {
                        InfoBlock.Text = "Account doesn't have enough money, sorry\n" + BankLogic.GetAccount(id, Pnr);
                    }
                    else if (result == 4042)
                    {
                        InfoBlock.Text = "Account not found in database";
                    }
                    else if (result == 404)
                    {
                        InfoBlock.Text = "Customer not found in database";
                    }
                
                }
                else
                {
                    InfoBlock.Text = "Customer not found in database";
                }
            }
            catch (FormatException)
            {
                InfoBlock.Text = "Input credentials is not correct";
            }
            
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                decimal amount = Convert.ToDecimal(AmountInput.Text);
                if (amount >= 0m)
                {
                    int id = Convert.ToInt32(IdInput.Text);
                    long Pnr = Convert.ToInt64(PersonNumberInput.Text);
                    if (BankLogic.Deposit(amount, id, Pnr))
                    {
                        InfoBlock.Text = "Deposit successful!\n" + BankLogic.GetAccount(id, Pnr);

                    }
                    else
                    {
                        InfoBlock.Text = "Customer not found in database";
                    }
                }
                else
                {
                    InfoBlock.Text = "The deposit amount cannot be a negative value";
                }
   
            }
            catch (FormatException)
            {
                InfoBlock.Text = "Input credentials is not correct";
            }

            catch (Exception x)
            {
                InfoBlock.Text = x.ToString();
            }
            
        }
    
    }
}
