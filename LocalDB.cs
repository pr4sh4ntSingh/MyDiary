using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;
using System.Windows;
namespace MyDiary {
    class set {
        public string id;
         public string time;
        public string date;
           public string mood;
           public string notes;
           public string encrypt() {
			   
			   /*
			   this is small ceaser-cipher encryption invented by me.
			   Well, may be later I will change it with something more complex.
			   
			   */
               char[] str=notes.ToCharArray();
               String final="";
               for (int i = 0; i < notes.Length; i++) {
                   int x=str[i];
                   if (x == 13 || x == 10) {
                       final = final + (char)x;
                   }
                   else if (x <= 100) {
                       x = 132 - x;
                       final = final + (char)x;
                   }
                   else {
                       x = 227 - x;
                       final = final + (char)x;
                   }
               }
               return final;
           }
    }
    class LocalDB {
         private SQLiteConnection con;
        public void createConnection(String Filename){
            try
            {
                Filename = "MyD.db";
              //  String s = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                 con= new SQLiteConnection("Data Source=D:\\!! Your Path\\"+Filename+";Version=3;New=False;Compress=True");
                con.Open();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        public void closeConnection() {

            con.Close();
        }

        public void Insert(String time,String date, String mood, String notes) {

            createConnection("MyD.db");
            SQLiteCommand sqlite_cmd = con.CreateCommand();
           
            sqlite_cmd.CommandText = "INSERT INTO MyD (time,date,mood,notes) values('" +time + "','" + date + "','" + mood + "','" +notes + "')";
            sqlite_cmd.ExecuteNonQuery();
            closeConnection();
        }
        public void Update(String time, String date, String mood, String notes,int id) {
            createConnection("MyD.db");
            SQLiteCommand sqlite_cmd = con.CreateCommand();

            sqlite_cmd.CommandText = "Update MyD set time='" + time + "',date='" + date + "',mood='" + mood + "',notes='" + notes + "' where id='"+id+"'";
            sqlite_cmd.ExecuteNonQuery();
          //  MessageBox.Show("Update MyD set time='" + time + "',date='" + date + "',mood='" + mood + "',notes='" + notes + "' where id='" + id + "'");
            closeConnection();
        }
       public int getId(String time, String date) {
           createConnection("MyD.db");
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select id from MyD where time='" + time+"' and date='"+date+"' " ;
            SQLiteDataReader sdr = cmd.ExecuteReader();
           // closeConnection();
            if (sdr.Read()) {
                return Convert.ToInt32(sdr["id"]);

            }
            else return -1;
        
        //closeConnection();
    }

    public String info(){
     createConnection("MyD.db");
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select id,time,date,mood from MyD" ;
            SQLiteDataReader sdr = cmd.ExecuteReader();
    String res=" ";
           // closeConnection();
            while (sdr.Read()) {
                res=res+sdr["id"]+"_"+sdr["date"]+"=>"+sdr["mood"]+"\n";
            }
           return res;
        
         }

    public set openThis(int id) {
        
        set s = new set();
        try {
            createConnection("MyD.db");
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select id,time,date,notes,mood from MyD where id=" + id;
            SQLiteDataReader sdr = cmd.ExecuteReader();
           
            // closeConnection();
            while (sdr.Read()) {
             //   res = sdr["id"] + "_~_" + sdr["date"] + "_~_" + sdr["time"] + "_~_" + sdr["notes"];
                s.id = sdr["id"].ToString();
                s.date = sdr["date"].ToString();
                s.time = sdr["time"].ToString();
                s.mood=sdr["mood"].ToString();
                s.notes = sdr["notes"].ToString();
            }
        }
        catch (Exception e) {
            MessageBox.Show(e.ToString());
        }

        closeConnection();
        return s;

    }
}
}
