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
using WPF_POS.View.PopUp;

namespace WPF_POS.View
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void addCust_Page_Btn_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer _addCustomer = new AddCustomer();
            _addCustomer.ShowDialog();
        }

        private void EditCust_Page_Btn_Click(object sender, RoutedEventArgs e)
        {
            EditCustomer _editCustomer = new EditCustomer();
            _editCustomer.ShowDialog();
        }
    }
}
