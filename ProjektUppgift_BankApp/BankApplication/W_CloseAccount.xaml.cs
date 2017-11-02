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
    /// Interaction logic for W_CloseAccount.xaml
    /// </summary>
    public partial class W_CloseAccount : Window
    {
        public W_CloseAccount()
        {
            InitializeComponent();
            CloseAccountButton.Click += CloseAccountButton_Click;
        }

        private void CloseAccountButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                int id = Convert.ToInt32(AccountIdInput.Text);
                long Pnr = Convert.ToInt64(PersonNumberInput.Text);
                InfoBlock.Text = BankLogic.CloseAccount(id, Pnr);
            }
            catch (FormatException) 
            {
                InfoBlock.Text = "Wrong Input credentials!";
            }
            catch (Exception x)
            {
                InfoBlock.Text = x.ToString();
            }
            
            
        }
    }
}
