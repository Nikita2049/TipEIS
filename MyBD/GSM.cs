﻿using System;
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
	public partial class GSM : Form
	{
		private SQLiteConnection sql_con;
		private SQLiteCommand sql_cmd;
		private DataSet DS = new DataSet();
		private DataTable DT = new DataTable();
		private string sPath = Path.Combine(Application.StartupPath, "F:\\MyBD\\mybd0.db");

		public GSM()
		{
			InitializeComponent();
		}

		private void GSM_Load(object sender, EventArgs e)
		{
			string ConnectionString = @"Data Source=" + sPath +
			";New=False;Version=3";
			String selectCommand = "Select * from GSM";
			selectTable(ConnectionString, selectCommand);
		}

		private void toolStripButtonAdd_Click(object sender, EventArgs e)
		{
			string ConnectionString = @"Data Source=" + sPath +
			";New=False;Version=3";
			String selectCommand = "select MAX(IDGSM) from GSM";
			object maxValue = selectValue(ConnectionString, selectCommand);
			if (Convert.ToString(maxValue) == "")
				maxValue = 0;
			//вставка в таблицу
			string txtSQLQuery = "insert into GSM (IDGSM, Name, Price) values (" +
			(Convert.ToInt32(maxValue) + 1) + ", '" + toolStripTextBoxNameGSM.Text + "', '" + toolStripTextBoxPriceGSM.Text + "')";
			ExecuteQuery(txtSQLQuery);
			//обновление dataGridView1
			selectCommand = "select * from GSM";
			refreshForm(ConnectionString, selectCommand);
			toolStripTextBoxNameGSM.Text = "";
			toolStripTextBoxPriceGSM.Text = "";
		}

		public void selectTable(string ConnectionString, String selectCommand)
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
		private void ExecuteQuery(string txtQuery)
		{
			sql_con = new SQLiteConnection("Data Source=" + sPath +
			";Version=3;New=False;Compress=True;");
			sql_con.Open();
			sql_cmd = sql_con.CreateCommand();
			sql_cmd.CommandText = txtQuery;
			sql_cmd.ExecuteNonQuery();
			sql_con.Close();
		}
		public void refreshForm(string ConnectionString, String selectCommand)
		{
			selectTable(ConnectionString, selectCommand);
			dataGridView1.Update();
			dataGridView1.Refresh();
			toolStripTextBoxNameGSM.Text = "";
			toolStripTextBoxPriceGSM.Text = "";
		}
		public object selectValue(string ConnectionString, String selectCommand)
		{
			SQLiteConnection connect = new
			SQLiteConnection(ConnectionString);
			connect.Open();
			SQLiteCommand command = new SQLiteCommand(selectCommand,
			connect);
			SQLiteDataReader reader = command.ExecuteReader();
			object value = "";
			while (reader.Read())
			{
				value = reader[0];
			}
			connect.Close();
			return value;
		}
		private void toolStripButtonDelete_Click(object sender, EventArgs e)
		{
			//выбрана строка CurrentRow
			int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
			//получить значение id выбранной строки
			string valueId = dataGridView1[0, CurrentRow].Value.ToString();
			String selectCommand = "delete from GSM where IDGSM=" + valueId;
			string ConnectionString = @"Data Source=" + sPath +
			";New=False;Version=3";
			changeValue(ConnectionString, selectCommand);
			//обновление dataGridView1
			selectCommand = "select * from GSM";
			refreshForm(ConnectionString, selectCommand);
			toolStripTextBoxNameGSM.Text = "";
			toolStripTextBoxPriceGSM.Text = "";
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
		private void toolStripButtonChange_Click(object sender, EventArgs e)
		{
			//выбрана строка CurrentRow
			int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
			//получить значения выбранной строки
			string valueId = dataGridView1[0, CurrentRow].Value.ToString();
			string changeName = toolStripTextBoxNameGSM.Text;
			string changePrice = toolStripTextBoxPriceGSM.Text;
			//обновление
			String selectCommand = "update GSM set Name='" + changeName + "', " + "Price='" + changePrice + "'where IDGSM = " + valueId;
			string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
			changeValue(ConnectionString, selectCommand);
			//обновление dataGridView1
			selectCommand = "select * from GSM";
			refreshForm(ConnectionString, selectCommand);
			toolStripTextBoxNameGSM.Text = "";
			toolStripTextBoxPriceGSM.Text = "";
		}
		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//выбрана строка CurrentRow
			int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
			//получить значение выбранной строки
			string nameId = dataGridView1[1, CurrentRow].Value.ToString();
			toolStripTextBoxNameGSM.Text = nameId;
			string orgId = dataGridView1[2, CurrentRow].Value.ToString();
			toolStripTextBoxPriceGSM.Text = orgId;
		}
	}
}
