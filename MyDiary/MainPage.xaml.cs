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
using System.Text.RegularExpressions;
using System.Data;
using Finisar.SQLite;
using System.Windows.Forms;
using System;

namespace MyDiary {
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window  {
        int id;
        public MainPage() {
            InitializeComponent();
            TimeBox.Text  = DateTime.Now.ToString("hh:mm:ss tt");
            DateBox.Text = DateTime.Today.ToString("D");
            LocalDB ldb = new LocalDB();
            id = ldb.getId(TimeBox.Text.ToString(), DateBox.Text.ToString());
            idLabel.Content = id;
            
          

             SQLiteConnection con = new SQLiteConnection("Data Source=D:\\!! Prashant Credential info !!\\Prash\\MyD.db;Version=3;New=False;Compress=True");
            con.Open();
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select id as No,date as Date,mood as Mood from MyD ORDER BY id DESC ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            mydata.DataContext = ds.Tables[0].DefaultView;
            
            ldb.closeConnection();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e) {
            LocalDB ldb = new LocalDB();
            TimeBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
            DateBox.Text = DateTime.Today.ToString("D");
            //notesBox.Text = "";
            ldb.Insert(TimeBox.Text.ToString(), DateBox.Text.ToString(), MoodBox.Text.ToString(), null);
            id = ldb.getId(TimeBox.Text.ToString(), DateBox.Text.ToString());
            idLabel.Content = id;
            ldb.closeConnection();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            LocalDB ldb = new LocalDB();
           // int id = ldb.getId();
            set s = new set();
            TextRange tr = new TextRange(notesBox.Document.ContentStart, notesBox.Document.ContentEnd);
            
            s.notes=tr.Text.ToString();
            ldb.Update(TimeBox.Text.ToString(), DateBox.Text.ToString(), MoodBox.Text.ToString(),s.encrypt(),id);
            
        }

        private void openButton_Click(object sender, RoutedEventArgs e) {
            LocalDB ldb = new LocalDB();
           set s=ldb.openThis(Convert.ToInt32(idBox.Text));
           TimeBox.Text = s.time;
           DateBox.Text = s.date;
           idLabel.Content = s.id;
           try {
               id = Convert.ToInt16(s.id);
           }
           catch (Exception excx) {
           }
           //char []dec = s.encrypt().ToCharArray();
           //for (int i = 0; i < dec.Length; i++) {
           //    if (i < dec.Length) {
           //        if (dec[i] == 'l' && dec[i + 1] == 'i')
           //            dec[i] = ' ';
           //        dec[i + 1] = '\n';
           //    }
           //}
           string des = s.encrypt();
           //string normalized1 = Regex.Replace(des, @"li", "\n");
           TextRange tr = new TextRange(notesBox.Document.ContentStart, notesBox.Document.ContentEnd);
            tr.Text=des;
         //  notesBox.Content = des;
           MoodBox.Text = s.mood;
        }

        private void b1(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if ((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt) // Is Alt key pressed
            {
                if (Keyboard.IsKeyDown(Key.S))
                {
                    notesBox.SpellCheck.IsEnabled = !notesBox.SpellCheck.IsEnabled;
                }
            }
            if (Keyboard.IsKeyDown(Key.Home))
            {


            }
           
        }
       
       
      
    }
}
