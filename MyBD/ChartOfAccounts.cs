using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBD
{
    public partial class ChartOfAccounts : Form
    {
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private string sPath = "C:\\Users\\nikit\\Downloads\\SQLiteStudio-3.2.1\\SQLiteStudio\\mybd0.db";
        public ChartOfAccounts()
        {
            InitializeComponent();
        }

        private void ChartOfAccounts_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            String selectCommand = "Select * from ChartOfAccounts";
            SelectTable(connectionString, selectCommand);
        }

        public void SelectTable(string connectionString, String selectCommand)
        {
            SQLiteConnection connect = new SQLiteConnection(connectionString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCommand, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.DataSource = ds;
            dataGridView.DataMember = ds.Tables[0].ToString();
            connect.Close();
        }
    }
}