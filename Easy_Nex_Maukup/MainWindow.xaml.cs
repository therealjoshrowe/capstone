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
        String t;
        String d;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Taxa_Data_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Taxa_Data.Text.ToString();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<String> lt = new List<String>();
            List<String> ld = new List<String>();
            String [] arrayOfTaxa = t.Split(new char[] { ' ' } );
            for (var i = 0; i < arrayOfTaxa.Length; ++i)
            {
                lt.Add(arrayOfTaxa[i]);
            }

            String[] arrayOfData = d.Split(new char[] { ' '});
            foreach (String s in arrayOfData)
            {
                ld.Add(s);
            }

            w = new NexusWriter(lt, ld);
            w.WriteToFile();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            d = textBox.Text.ToString();
        }
    }
}
