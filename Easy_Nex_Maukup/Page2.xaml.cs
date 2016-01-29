using Shared_Code;
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

namespace Easy_Nex_Maukup
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            App.f.C = new CharactersBlock();
            String s = textBox.Text.ToString();
            String[] array = s.Split(new char[] { '\n' });
            foreach (String seq in array)
            {
                String [] array2  = seq.Split(new char [] { ':' });
                App.f.C.sequences.Add(new Sequence(array2[0], array2[1]));
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page3());
        }
    }
}
