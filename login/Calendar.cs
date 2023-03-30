using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;



namespace login
{
    public partial class Calendar : Form
    {
        private List<FlowLayoutPanel> listFLDay = new List<FlowLayoutPanel>();
        private DateTime currentDate = DateTime.Today;
        Event @event = new Event();
    
        public Calendar()
        {
            InitializeComponent();
        }
        


        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Calendar_Load(object sender, EventArgs e)
        {
            GenerateDayPanel(42);
            DisplayCurrentDate();
           
        }
       /* private void AddNewEvent(object sender, EventArgs e)
        {
            int day = (int)((FlowLayoutPanel)sender).Tag;
            if (day != 0)
            {
                FrmProgramareServicii addEvent= new FrmProgramareServicii();

                //SETTERS FROM ADDEVENT FORM
                addEvent.AppID = 0;
                addEvent.textBox1 = "";
                addEvent.textBox2 = "";
                addEvent.textBox3 = "";
                addEvent.textBox4 = "";
                // addEvent.comboBox = "";
                //addEvent.comboBoxx = "";
                addEvent.textBox = "";
                addEvent.DatePicker = new DateTime(currentDate.Year, currentDate.Month, day);

                //--
                addEvent.ShowDialog();
                DisplayCurrentDate();
            }
        } */
        private void ShowEventDetails(object sender, EventArgs e)
        {
            int codProgr = Convert.ToInt32(((LinkLabel)sender).Tag);
            string npgsql = $"select* from programariservicii inner join programare on programare.codprogramare=programariservicii.codprogramare inner join serviciistomatologice on serviciistomatologice.codserviciustomatologic = programariservicii.codserviciustomatologic inner join  stomatolog on stomatolog.codstomatolog = programariservicii.codstomatolog inner join personalmedical on personalmedical.codangajat = stomatolog.codstomatolog  where programariservicii.codprogramare='{codProgr}' ";
            DataTable dt = @event.QueryAsDataTable(npgsql);


            if (dt.Rows.Count > 0)
            {
               
                DataRow dr = dt.Rows[0];
                FrmProgramareServicii addEvent = new FrmProgramareServicii();
                //SETTERS FROM ADDEVENT FORM
                addEvent.AppID= codProgr;
                addEvent.textBox4 = dr["codprogramare"].ToString();
                //addEvent.comboBox = dr["denumireserviciu"].ToString();
                //addEvent.comboBoxx = dr["numepersonalmedical"].ToString();
                addEvent.textBox2 = dr["codserviciustomatologic"].ToString();
                addEvent.textBox1 = dr["codstomatolog"].ToString();
                addEvent.textBox3 = dr["detalii"].ToString();
                addEvent.textBox = dr["denumireserviciu"].ToString();
                 addEvent.textBoxx = dr["numepersonalmedical"].ToString();
                addEvent.DatePicker = (DateTime)dr["dataora"];

                //--
                addEvent.ShowDialog();
                DisplayCurrentDate();
            }
        }
        private void AddAppointmentToFlDay(int startDayAtFlNumber)
        {
    
            DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            string npgsql = $"select * from programare inner join pacient on pacient.codpacient = programare.codpacient inner join persoane on persoane.codpersoana = pacient.codpacient where dataora between '{startDate.ToShortDateString()}' and '{endDate.ToShortDateString()}'"; 
            DataTable dt = @event.QueryAsDataTable(npgsql);


            foreach (DataRow dr in dt.Rows)
            {
                DateTime appday = DateTime.Parse(dr["dataora"].ToString());
                var link = new LinkLabel();
                link.Tag = dr["codprogramare"].ToString();
                link.Name = $"link{dr["codprogramare"]}";
                link.Text = dr["numepersoana"].ToString();
                link.LinkColor = Color.Black;
                link.Click += ShowEventDetails;
                link.AutoSize = true;
                listFLDay[(appday.Day - 1) + (startDayAtFlNumber - 1)].Controls.Add(link);
            }
   
        }

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDayOfMonth.DayOfWeek + 1;
        }

        private int GetTotalDayCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDayOfMonth.AddMonths(1).AddDays(-1).Day;
        }

        private void DisplayCurrentDate()
        {
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDayCurrentDate();
            lblMonthYear.Text = currentDate.ToString("MMMM, yyyy");
            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
            AddAppointmentToFlDay(firstDayAtFlNumber);
        }

        private void PrevMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void NextMonth()
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }

        private void Today()
        {
            currentDate = DateTime.Today;
            DisplayCurrentDate();
        }
        private void GenerateDayPanel(int totalDays)
        {
            flDays.Controls.Clear();
            listFLDay.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                var fl = new FlowLayoutPanel();
                fl.Name = $"flday{i}";
                fl.Size = new Size(102, 77);
                fl.BackColor = Color.White;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fl.Cursor = Cursors.Hand;
               // fl.Click += AddNewEvent;
                flDays.Controls.Add(fl);
                listFLDay.Add(fl);
            }
        }

        private void AddLabelDayToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            foreach (FlowLayoutPanel fl in listFLDay)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
                fl.BackColor = Color.White;
            }

            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                var lbl = new Label();
                lbl.Name = $"lblDay{i}";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(24, 23);
                lbl.Text = i.ToString();
                listFLDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFLDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listFLDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Gold;
                }
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PrevMonth();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            Today();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void flDays_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           


            //Validate Date


          
        }
    }

    class Event
        {
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=l1");

        //CHECK DATABASE CONNECTION STATUS
        public void Connected()
            {
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
              
            }
        
         
        }
       

        //Validate Date

     

        public DataTable QueryAsDataTable(string npgsql)
            {
                Connected();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(npgsql, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "result");
                return ds.Tables["result"];


        }
        }
    }



  
    



