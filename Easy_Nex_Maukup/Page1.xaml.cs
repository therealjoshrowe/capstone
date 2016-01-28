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
using Shared_Code;

namespace Easy_Nex_Maukup
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            App.f.T = new TaxaBlock();
            String s = textBox.Text.ToString();
            String[] array = s.Split(new char[] { ' '});
            foreach (String ele in array)
            {
                App.f.T.taxa.Add(ele);
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page2());
        }
    }
}
