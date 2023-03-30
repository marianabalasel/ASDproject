﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Test1
{
    class Event
    {
        public string Connection = ConfigurationManager.ConnectionStrings["Church"].ConnectionString; //GET DATABASE CONNECTION
        public NpgsqlConnection cn;

        //CHECK DATABASE CONNECTION STATUS
        public void Connected()
        {
            cn = new NpgsqlConnection(Connection); // GET SQL CONNECTION STATUS

            //CHECKS IF SQL CONNECTION IS CONNECTED
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        //INSERTING AND UPDATING EVENTS
        public bool InsertUpdateData(string sql)
        {
            Connected();
            SqlCommand cmd = new SqlCommand(sql, cn);

            return cmd.ExecuteNonQuery() > 0;
        }

        //Validate Date
        public bool dateValidation(DateTime start, DateTime end)
        {
            DateTime currentdate = DateTime.Now;

            string date = currentdate.ToShortDateString();
            if (start < Convert.ToDateTime(date))
            {
                MessageBox.Show("Can't add an event which start date passby the current date...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (end < start)
            {
                MessageBox.Show("Can't add an event which end date passby the start date...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (start >= Convert.ToDateTime(date) && end >= start)
            {
                return false;
            }
            return true;
        }

        public DataTable QueryAsDataTable(string sql)
        {
            Connected();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];
        }
    }
}
