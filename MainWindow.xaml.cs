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
using System.Drawing;


namespace MyDiary {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window {
        int i = 3;
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            if (PassBox.Password.Equals("Your Password Goes here")) {
                var win = new MainPage();
                win.Show();
                this.Close();

            }
            else {
                if (i > 0) {
                    MessageBox.Show("Unauthorised access!!! " + i + " attempt remained!");
                    i--;
                }
                else {
                    MessageBox.Show("System Locked!!");
                    Go.Visibility = Visibility.Hidden;
                }
            }
        }
       
       
    }

}
