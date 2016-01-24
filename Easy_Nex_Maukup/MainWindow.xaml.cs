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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NexusWriter w;
        String s;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Taxa_Data_TextChanged(object sender, TextChangedEventArgs e)
        {
            s = Taxa_Data.Text.ToString();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<String> l = new List<String>();
            String [] array = s.Split(new char[] { ' ' } );
            for (var i = 0; i < array.Length; ++i)
            {
                l.Add(array[i]);
            }
            w = new NexusWriter(l);
            w.WriteToFile();
        }
    }
}
