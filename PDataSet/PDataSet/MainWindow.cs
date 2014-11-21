//GitUser>@juankza

using Gtk;
using MySql.Data.MySqlClient;
using SerpisAd;
using System;
using System.Collections.Generic;
using System.Data;

public partial class MainWindow: Gtk.Window
{	
	//private List<object> lista = new List<object>();

	public MainWindow (MySqlConnection mySqlConnection): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		string sqlCommand = "SELECT * FROM articulo";
		IDbDataAdapter dbDataAdapter = new MySqlDataAdapter (sqlCommand, mySqlConnection);

		DataSet dataSet = new DataSet ();
		dbDataAdapter.Fill (dataSet);

		DataTable dataTable = dataSet.Tables [0];

		foreach (DataColumn dataColumn in dataTable.Columns)
			Console.WriteLine (dataColumn.ColumnName);

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
