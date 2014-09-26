using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Data;

public partial class MainWindow: Gtk.Window
{	
	private ListStore listStore;

	private MySqlConnection mySqlConnection;

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
		try{
			this.mySqlConnection.Close ();
		}
		catch{
			Console.WriteLine ("Error 404 Not Found");
		}

		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnGoForwardActionActivated (object sender, EventArgs e)
	{
		string connectionString = "Server=localhost;" + "Database=dbprueba;" +
			"User ID=root;" + "Password=" + entryPwd.Text.ToString();
		this.mySqlConnection = new MySqlConnection (connectionString);
		this.mySqlConnection.Open ();

		this.SetSizeRequest (300, 250);

		vboxTable.Visible = true;
		hboxPwd.Visible = false;

	}

	protected void OnEditActionActivated (object sender, EventArgs e)
	{
		hboxPwd.Visible = false;
		vboxTable.Visible = false;

	}

	protected void OnApplyActionActivated (object sender, EventArgs e)
	{


	}

	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
		mySqlCommand.CommandText = "SELECT * FROM categoria";

		MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();

		while (mySqlDataReader.Read())
		{
			object id = mySqlDataReader ["id"].ToString ();
			object nombre = mySqlDataReader ["nombre"].ToString ();
			listStore.AppendValues (id, nombre);
		}

		mySqlDataReader.Close ();

	}

	protected void OnCloseActionActivated (object sender, EventArgs e)
	{
		listStore.Clear ();

	}
	
}
