using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Data;

public partial class MainWindow: Gtk.Window
{	
	private ListStore listStore;

	private MySqlConnection MySqlConnection;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText (), "text", 1);

		listStore = new ListStore (typeof(string), typeof(string));

		treeView.Model = listStore; //Java> treeView.setModel(listStore);



	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnAddActionActivated (object sender, EventArgs e)
	{
		listStore.AppendValues ("1", "uno");

	}

	protected void OnRemoveActionActivated (object sender, EventArgs e)
	{
		listStore.Clear ();

	}

	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		string connectionString = "Server=localhost;" + "Database=dbprueba;" +
				"User ID=root;" + "Password=" + entryPwd.Text.ToString();
		MySqlConnection mySqlConnection = new MySqlConnection (connectionString);

	}

}
