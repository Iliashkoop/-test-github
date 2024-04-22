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

namespace Флажки
{
    /// <summary>
    /// радиоТорты
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            Base.IsReadOnly = true;
            Base.Text = "0";
           
        }
        int a;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void Bis_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 2500).ToString();
        }
        private void Bis_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 2500).ToString();
        }

    

        private void Nap_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 2600).ToString();
            Vish.IsEnabled = false; Mango.IsEnabled = false; Limon.IsEnabled = false; Cherry.IsEnabled = false; marakya.IsEnabled = false; chernika.IsEnabled = false;
        }
        private void Nap_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 2600).ToString();
            Vish.IsEnabled = true; Mango.IsEnabled = true; Limon.IsEnabled = true; Cherry.IsEnabled = true; marakya.IsEnabled = true; chernika.IsEnabled = true;
        } 

        private void Mol_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 2900).ToString();
            Limon.IsEnabled = false; chernika.IsEnabled = false;
        }
        private void Mol_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 2900).ToString();
            Limon.IsEnabled = true; chernika.IsEnabled = true;
        }

        private void Med_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 2800).ToString();
            Mango.IsEnabled = false; Limon.IsEnabled = false; marakya.IsEnabled = false; chernika.IsEnabled=false;
        }
        private void Med_Uncheck(object sender, RoutedEventArgs e)
        {
             a = Int32.Parse(Base.Text);
            Base.Text = (a - 2800).ToString();
            Mango.IsEnabled= true; Limon.IsEnabled = true; marakya.IsEnabled=true; chernika.IsEnabled=true;
        }
        private void Kras_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 3300).ToString();
        }
        private void Kras_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 3300).ToString();
        }
        /// <summary>
        /// Начинки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vish_Checked(object sender, RoutedEventArgs e)
        {

            a = Int32.Parse(Base.Text);
            Base.Text = (a + 300).ToString();
        }
        private void Vish_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 300).ToString();
        }

        private void Mal_check (object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 360).ToString();
        }
        private void Mal_unChecked (object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 360).ToString();
        }

        private void Mango_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 350).ToString();
        }
        private void Mango_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 350).ToString();
        }

        private void Limon_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 380).ToString();
        }
        private void Limon_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 380).ToString();
        }

        private void Smor_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 320).ToString();
        }
        private void Smor_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 320).ToString();
        }
        /// <summary>
        /// дополнительные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toti_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void Toti_Uncheck(object sender, RoutedEventArgs e)
        {

        }
        private void Avtor_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 200).ToString();
        }
        private void Avtor_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 200).ToString();
        }
        private void Kan_Checked(object sender, RoutedEventArgs e)
        {
             a = Int32.Parse(Base.Text);
            Base.Text = (a + 100).ToString();
        }
        private void Kan_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 100).ToString();
        }
        private void Dop_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void Dop_Uncheck(object sender, RoutedEventArgs e)
        {

        }
        private void Nad_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 100).ToString();
        }
        private void Nad_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 100).ToString();
        }
        /// <summary>
        /// курьер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Kyr_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 300).ToString();
        }
        private void Kyr_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 300).ToString();
        }

        ///радиобатонны для начинок
        private void Cherry_Uncheck (object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 300).ToString();
        }
        private void Cherry_Checked (object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 300).ToString();
        }
        private void linka_Uncheck (object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 360).ToString();
        }
    
        private void linka_Checked (object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 360).ToString();
        }
    
        private void marakya_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 350).ToString();
        }
        private void marakya_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 350).ToString();
        }
        private void chernika_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 380).ToString();
        }
        private void chernika_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 380).ToString();
        }
        private void smorodok_Uncheck(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a - 320).ToString();
        }
        private void smorodok_Checked(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(Base.Text);
            Base.Text = (a + 320).ToString();
        }

    }
}
