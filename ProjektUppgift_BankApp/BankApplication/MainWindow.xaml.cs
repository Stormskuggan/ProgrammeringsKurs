﻿using System;
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

            DisplayAccountButton.Click += DisplayButton_Click;
            DisplayCustomerButton.Click += DisplayCustomerButton_Click;
            AddCustomerButton.Click += AddCustomerButton_Click;
            ChangeCustomerName.Click += ChangeCustomerName_Click;
            CreateAccountButton.Click += CreateAccountButton_Click;
            MoneyTransactionButton.Click += MoneyTransactionButton_Click;
            CloseAccountButton.Click += CloseAccountButton_Click;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            DisplayAllCustomers.Click += DisplayAllCustomers_Click;
            WriteCustomersButton.Click += WriteCustomersButton_Click;
        }

        private void WriteCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            //if (File.Exists("Bank_Customers.txt"))
            //{
            //    File.Delete("Bank_Customers.txt");
            //}
            try
            {
                StreamWriter sw = new StreamWriter("Bank_Customers.txt");
                foreach (string customer in BankLogic.GetAllCustomers())
                {
                    sw.WriteLine(customer);
                }
                label.Text = "Customers written to file!";
                sw.Close();
                
            }
            catch (UnauthorizedAccessException)
            {
                label.Text = "File is read-only! writing unsuccessful.";

            }
            catch (IOException)
            {
                label.Text = "There was a problem writing to file";
            }
            catch (Exception x)
            {
                label.Text = x.ToString();
            }
            
        }

        private void DisplayAllCustomers_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            label.Text = "";
            foreach (string customer in BankLogic.GetAllCustomers())
            {
                label.Text += customer;
            }
            
        }

        private void DisplayCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            label.Text = "";
            //throw new NotImplementedException();
            try
            {
                long Pnr = Convert.ToInt64(PersonIdBox.Text);

                if (Pnr.ToString().Length == 10)
                {
                    foreach (string s in BankLogic.GetCustomer(Pnr))
                    {
                        label.Text += s;
                    }
                }
                else
                    label.Text = "Invalid PersonID. Try this format YYMMDDXXXX";

            }
            catch (FormatException)
            {
                label.Text = "Invalid PersonID. Try this format YYMMDDXXXX";
            }

        }

        private void RemoveCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            W_RemoveCustomer window = new W_RemoveCustomer();
            window.ShowDialog();
        }

        private void CloseAccountButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            W_CloseAccount window = new W_CloseAccount();
            window.ShowDialog();
        }

        private void ChangeCustomerName_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            W_NameChange window = new W_NameChange();
            window.ShowDialog();
        }

        private void MoneyTransactionButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            //debug Code
            //BankLogic.AddCustomer(9876543219, "test", "placehoÖlder");
            //BankLogic.AddCustomer(1234567891, "teÖshgbt", "plgiacKLÅåeholder");
            //BankLogic.AddCustomer(9876543239, "ouyÄfo", "uckuyclu");
            //BankLogic.AddCustomer(9876543218, "jhvlhvl", "höigliku");
            //BankLogic.AddSavingsAccount(9876543219);
            W_WithdrawDeposit window = new W_WithdrawDeposit();
            window.ShowDialog();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            W_CreateAccount window = new W_CreateAccount();
            window.ShowDialog();
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            W_AddCustomer window = new W_AddCustomer();
            window.ShowDialog();
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            label.Text = "";
            try
            {
                long Pnr = Convert.ToInt64(PersonIdBox.Text);
                int AccountId = Convert.ToInt32(AccountIdBox.Text);
                if (Pnr.ToString().Length == 10)
                {
                    
                    
                    label.Text += BankLogic.GetAccount(AccountId, Pnr);

                }
                else
                    label.Text = "Invalid PersonID. Try this format YYMMDDXXXX";

            }
            catch (FormatException)
            {
                label.Text = "Invalid PersonID. Try this format YYMMDDXXXX, ";
            }



        }

        //private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    BankLogic.Withdraw(Convert.ToDecimal(WithdrawBox.Text), 1001);

        //}

        //private void MakeAccount_Click(object sender, RoutedEventArgs e)
        //{
        //    //throw new NotImplementedException();

        //        label.Text = "Account with Id: " + BankLogic.addSavingsAccount() + " created!";

        //}

    }
}
