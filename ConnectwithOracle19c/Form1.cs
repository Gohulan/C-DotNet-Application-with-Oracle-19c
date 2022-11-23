using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConnectwithOracle19c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            string connectionstring = "Data Source = (DESCRIPTION = " +
             "(ADDRESS = (PROTOCOL = TCP)(HOST = YOUR ORACLE DATABASE SERVER IP/SERVER NAME HERE)(PORT = 1521))" +
             "(CONNECT_DATA = " +
               " (SERVER = DEDICATED)" +
               " (SERVICE_NAME = ORACLE DATABASE ID HERE)" +
             " )" +
           "); User Id = ORACLE DATABASE USER HERE ; password=ORACLE DATABASE PASSWORD HERE;";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionstring;
            con.Open();

            //OracleCommand oraCmd = new OracleCommand("DELETE FROM DEMODATA WHERE FNAME='HARRY'", conn);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select username from Employee where employeeid=1 ";

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            MessageBox.Show(dr.GetString(0));
            label1.Text = dr.GetString(0);

        } }
    }

