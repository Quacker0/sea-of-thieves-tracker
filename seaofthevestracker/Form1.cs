using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
        
        
        private string DBCN;
        private SqlConnection con;

        private SQLiteConnection dbcon = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
        
        
        
        private DateTime startTime ;
        private DateTime endTime ;
        private int Streak;
        private string faction;
        private string shiptype;
        private bool outcome;
        private DateTime Session;
        
        
        private void createdb()
        {
            SQLiteConnection.CreateFile("db");
        }
        
        public Form1()
        {
            InitializeComponent();
            Session = DateTime.Now;
            shiptype = "S";
            faction = "A";
            DBCN = "server = 10.0.0.2; database = SOT; UID = sa; password = P@$$W0rd2021!.";
            con = new SqlConnection(DBCN);
            
            if (!File.Exists("db"))
            {
                createdb();
            }
            
            RefreshTable();
        }
        
        private void RefreshTable()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM defaultveiw", DBCN);
                        
                        DataSet ds = new DataSet();
                        da.Fill(ds,"defaultveiw");
                        dataGridView1.DataSource = ds.Tables["defaultveiw"].DefaultView;
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
            con.Open();
            string qur = $"INSERT INTO Matches VALUES (@startdate,@endTime,@Streak,@faction,@shiptype,@outcome,@Session)";
            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.Parameters.AddWithValue("@startdate", startTime);
            cmd.Parameters.AddWithValue("@endTime", endTime);
            cmd.Parameters.AddWithValue("@Streak", Streak);
            cmd.Parameters.AddWithValue("@faction", faction);
            cmd.Parameters.AddWithValue("@shiptype", shiptype);
            cmd.Parameters.AddWithValue("@outcome", outcome);
            cmd.Parameters.AddWithValue("@Session", Session);
            cmd.ExecuteNonQuery();
            con.Close();
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
    }
}