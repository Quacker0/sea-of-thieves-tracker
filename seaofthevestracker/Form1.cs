using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace seaofthevestracker
{
    public partial class Form1 : Form
    {
        private static string dbname = "testdb";
        //private static string dbname = "db";
        
        private SQLiteConnection dbcon = new SQLiteConnection("Data Source=" + dbname + ".sqlite;Version=3;");
        
        
        
        private DateTime startTime ;
        private DateTime endTime ;
        private int Streak;
        private string faction;
        private string shiptype;
        private bool outcome;
        private DateTime Session;
        
        
        private void createdb()
        {
            dbcon.Open();
            SQLiteConnection.CreateFile(dbname);
            var tb1 = "Create  Table Matches (" +
                       "ID integer PRIMARY KEY," +
                       "startTime DateTime NOT NULL," +
                       "endTime DateTime NOT NULL," +
                       "SteakNum int NOT NULL," +
                       "Faction VARCHAR(1) NOT NULL, " +
                       "ShipType VARCHAR(1) NOT NULL , " +
                       "Outcome BIT NOT NULL," +
                       "Session Datetime NOT NULL);";
            
            SQLiteCommand cmd = new SQLiteCommand(tb1, dbcon);
            cmd.ExecuteNonQuery();
            var v1 = "CREATE VIEW defaultveiw AS Select ID as 'Match number'" +
                     ",time(strftime('%s',endTime) - " +
                     "strftime('%s',startTime),'unixepoch') as 'Duration' ,SteakNum as 'Streak' , " +
                     "CASE WHEN Outcome = 0 THEN 'loss' ELSE 'Win' END as Outcome " +
                     "FROM (Select startTime ,endTime ,SteakNum,Outcome ," +
                     "ID FROM Matches order by ID desc LIMIT 5) as x;";

            cmd.CommandText = v1;
            cmd.ExecuteNonQuery();
            dbcon.Close();
        }
        
        public Form1()
        {
            InitializeComponent();
            Session = DateTime.Now;
            shiptype = "S";
            faction = "A";
            dbcon.Close();
            if (!File.Exists(dbname + ".sqlite"))
            {
                createdb();
            }
            
            RefreshTable();
        }
        
        private void RefreshTable()
        {
            dbcon.Open();
            
            SQLiteDataAdapter da = 
                new SQLiteDataAdapter(
                    "Select ID as 'Match number',time(strftime('%s',endTime) - strftime('%s',startTime)" +
                    ",'unixepoch') as 'Duration' ,SteakNum as 'Streak' ,CASE WHEN Outcome = 0 THEN 'loss' ELSE 'Win' " +
                    "END as Outcome FROM (Select startTime ,endTime ,SteakNum,Outcome " +
                    ",ID FROM Matches order by ID desc LIMIT 5) as x", dbcon);
            
            DataSet ds = new DataSet();
            
            da.Fill(ds,"defaultveiw");
            dataGridView1dadas.DataSource = ds.Tables["defaultveiw"].DefaultView;
                        
            dbcon.Close();
        }

     
        
        

        private void LblCurrentTime_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            

            LblCurrentTime.Text = ((startTime - DateTime.Now)).ToString("hh\\:mm\\:ss");
        }

        private void BtnStartMatch_Click(object sender, EventArgs e)
        {
            LblCurrentTime.Text = TimeSpan.Zero.ToString("hh\\:mm\\:ss");
            startTime = DateTime.Now;
            TmrMatchTimer.Start();
            BtnShipType.Enabled = false;
            NudStreak.Enabled = false;
            BtnStartMatch.Enabled = false;
            BtnChangeFaction.Enabled = false;
            BtnWin.Enabled = true;
            BtnLoss.Enabled = true;
            
            TmrSafeTimer.Stop();
            LblSafeTimer.Text = (TimeSpan.Zero).ToString("hh\\:mm\\:ss");
            
            
        }

        private void BtnShipType_Click(object sender, EventArgs e)
        {
            switch (LblShipType.Text)
            {
                case "Sloop" :
                    LblShipType.Text = "Brigantine";
                    shiptype = "B";
                    break;
                
                case "Brigantine" :
                    LblShipType.Text = "Galleon";
                    shiptype = "G";
                    break;
                
                case "Galleon" :
                    LblShipType.Text = "Sloop";
                    shiptype = "S";
                    break;
                
            }
            
            
        }

        private void BtnWin_Click(object sender, EventArgs e)
        {
            BtnShipType.Enabled = true;
            NudStreak.Enabled = true;
            BtnStartMatch.Enabled = true;
            BtnChangeFaction.Enabled = true;
            BtnWin.Enabled = false;
            BtnLoss.Enabled = false;
            TmrMatchTimer.Stop();
            TmrSafeTimer.Start();
            endTime = DateTime.Now;
            outcome = true;
            addtodb();
            Streak += 1;
            NudStreak.Value += Decimal.One;


        }

        public void addtodb()
        {
            dbcon.Open();
            string qur = $"INSERT INTO Matches VALUES (NULL,@startdate,@endTime,@Streak,@faction,@shiptype,@outcome,@Session)";
            SQLiteCommand cmd = new SQLiteCommand(qur, dbcon);
            cmd.Parameters.AddWithValue("@startdate", startTime);
            cmd.Parameters.AddWithValue("@endTime", endTime);
            cmd.Parameters.AddWithValue("@Streak", Streak);
            cmd.Parameters.AddWithValue("@faction", faction);
            cmd.Parameters.AddWithValue("@shiptype", shiptype);
            cmd.Parameters.AddWithValue("@outcome", outcome);
            cmd.Parameters.AddWithValue("@Session", Session);
            cmd.ExecuteNonQuery();
            dbcon.Close();
            RefreshTable();
        }


        private void BtnLoss_Click(object sender, EventArgs e)
        {
            BtnShipType.Enabled = true;
            NudStreak.Enabled = true;
            BtnStartMatch.Enabled = true;
            BtnChangeFaction.Enabled = true;
            BtnWin.Enabled = false;
            BtnLoss.Enabled = false;
            TmrMatchTimer.Stop();
            endTime = DateTime.Now;
            outcome = false;
            addtodb();
            Streak = 0;
            NudStreak.Value = Decimal.Zero;
            
            
        }

        private void BtnChangeFaction_Click(object sender, EventArgs e)
        {
            if (LblFaction.Text == "Athena")
            {
                LblFaction.Text = "Reapers";
                faction = "R";
            }
            else
            {
                LblFaction.Text = "Athena";
                faction = "A";
            }
        }

        private void NudStreak_ValueChanged(object sender, EventArgs e)
        {
            Streak = int.Parse( NudStreak.Value.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TmrSafeTimer_Tick(object sender, EventArgs e)
        {
            
            if ((TimeSpan.FromMinutes(20) - (DateTime.Now - endTime) < TimeSpan.Zero ))
            {
                TmrSafeTimer.Stop();
            }
        
            LblSafeTimer.Text = (TimeSpan.FromMinutes(20) - (DateTime.Now - endTime)).ToString("hh\\:mm\\:ss");
        }

        private void BtnRefreshTable_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnMatchDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1dadas.CurrentRow == null) return;
            var id = dataGridView1dadas.CurrentRow.Cells[0].Value;
            dbcon.Open();
            string qur = $"DELETE FROM Matches WHERE ID = @id";
            SQLiteCommand cmd = new SQLiteCommand(qur, dbcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            dbcon.Close();
            RefreshTable();

        }
    }
}