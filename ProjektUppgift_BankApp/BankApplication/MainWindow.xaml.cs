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

namespace BankApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            
            MakeAccount.Click += MakeAccount_Click;
            
            WithdrawButton.Click += WithdrawButton_Click;
            DisplayButton.Click += DisplayButton_Click;

        }


        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            label.Content = BankLogic.GetAccount(Convert.ToInt32(AccountIdBox.Text));
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            BankLogic.Withdraw(Convert.ToDecimal(WithdrawBox.Text), 1001);

        }

        private void MakeAccount_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            
                label.Content = "Account with Id: " + BankLogic.addSavingsAccount() + " created!";

        }
    }
}
