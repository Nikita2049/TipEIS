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
    public partial class MarkaGSM : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private string sPath = Path.Combine(Application.StartupPath, "F:\\MyBD\\mybd0.db");
        public MarkaGSM()
        {
            InitializeComponent();
        }
        public void SelectTable(string ConnectionString, String selectCommand)

        {
            SQLiteConnection connect = new
           SQLiteConnection(ConnectionString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new
           SQLiteDataAdapter(selectCommand, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            connect.Close();
        }

        private void MarkaGSM_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=" + sPath +
           ";New=False;Version=3";
            String selectCommand = "Select * from MarkaGSM";
            SelectTable(ConnectionString, selectCommand);
        }


        public void changeValue(string ConnectionString, String selectCommand)
        {
            SQLiteConnection connect = new
           SQLiteConnection(ConnectionString);
            connect.Open();
            SQLiteTransaction trans;
            SQLiteCommand cmd = new SQLiteCommand();
            trans = connect.BeginTransaction();
            cmd.Connection = connect;
            cmd.CommandText = selectCommand;
            cmd.ExecuteNonQuery();
            trans.Commit();
            connect.Close();
        }

        public object selectValue(string ConnectionString, String selectCommand)
        {
            SQLiteConnection connect = new SQLiteConnection(ConnectionString);
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(selectCommand, connect);
            SQLiteDataReader reader = command.ExecuteReader();
            object value = "";
            while (reader.Read())
            {
                value = reader[0];
            }
            connect.Close();
            return value;
        }

        private void ExecuteQuery(string txtQuery)
        {
            sql_con = new SQLiteConnection("Data Source=" + sPath + ";Version=3;New=False;Compress=True;");
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        public void refreshForm(string ConnectionString, String selectCommand)
        {
            SelectTable(ConnectionString, selectCommand);
            dataGridView1.Update();
            dataGridView1.Refresh();
            toolStripTextBoxView.Text = "";
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            {
                string ConnectionString = @"Data Source=" + sPath +
                ";New=False;Version=3";
                String selectCommand = "select MAX(IDMarkaGSM) from MarkaGSM";
                object maxValue = selectValue(ConnectionString, selectCommand);
                if (Convert.ToString(maxValue) == "")
                    maxValue = 0;
                //вставка в таблицу
                string txtSQLQuery = "insert into MarkaGSM (IDMarkaGSM, View) values (" +
               (Convert.ToInt32(maxValue) + 1) + ", '" + toolStripTextBoxView.Text + "')";
                ExecuteQuery(txtSQLQuery);
                //обновление dataGridView1
                selectCommand = "select * from MarkaGSM";
                refreshForm(ConnectionString, selectCommand);
                toolStripTextBoxView.Text = "";
            }
        }

        private void toolStripButtonChange_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxView.Text == "")
            {
                MessageBox.Show("Ошибка!");
                return;
            }
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //получить значение Name выбранной строки
            string valueId = dataGridView1[0, CurrentRow].Value.ToString();
            string changeView = toolStripTextBoxView.Text;
            //обновление Name
            String selectCommand = "update MarkaGSM set View='" + changeView + "'where IDMarkaGSM = " + valueId;
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            changeValue(ConnectionString, selectCommand);
            //обновление dataGridView1
            selectCommand = "select * from MarkaGSM";
            refreshForm(ConnectionString, selectCommand);
            toolStripTextBoxView.Text = "";
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //выбрана строка CurrentRow
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //получить значение idGSM выбранной строки
            string valueId = dataGridView1[0, CurrentRow].Value.ToString();
            String selectCommand = "delete from MarkaGSM where IDMarkaGSM=" + valueId;
            string ConnectionString = @"Data Source=" + sPath +
           ";New=False;Version=3";
            changeValue(ConnectionString, selectCommand);
            //обновление dataGridView1
            selectCommand = "select * from MarkaGSM";
            refreshForm(ConnectionString, selectCommand);
            toolStripTextBoxView.Text = "";
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //выбрана строка CurrentRow
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            string StoreName = dataGridView1[1, CurrentRow].Value.ToString();
            toolStripTextBoxView.Text = StoreName;
        }
    }
}
