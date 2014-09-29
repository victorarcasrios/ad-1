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

		this.SetSizeRequest (300, 50);
		hboxPwd.Visible = true;
		vboxTable.Visible = false;
		vboxEdit.Visible = false;

		treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText (), "text", 1);

		listStore = new ListStore (typeof(ulong), typeof(string));

		treeView.Model = listStore; //Java> treeView.setModel(listStore);

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		try{
			this.mySqlConnection.Close ();
		}
		catch{
			Console.WriteLine ("\nError 404 Not Found");
		}

		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnGoForwardActionActivated (object sender, EventArgs e)
	{
		try{
			string connectionString = "Server=localhost;" + "Database=dbprueba;" +
				"User ID=root;" + "Password=" + entryPwd.Text.ToString();
			this.mySqlConnection = new MySqlConnection (connectionString);
			this.mySqlConnection.Open ();

			this.SetSizeRequest (300, 250);
			hboxPwd.Visible = false;
			vboxTable.Visible = true;
			vboxEdit.Visible = false;

		}
		catch (MySqlException){
			Console.WriteLine ("\nError de conexión");
			Application.Quit ();
		}
		catch{
			Console.WriteLine ("\nError");
			Application.Quit ();
		}
	}

	protected void OnEditActionActivated (object sender, EventArgs e)
	{
		hboxPwd.Visible = false;
		vboxTable.Visible = false;
		vboxEdit.Visible = true;

	}

	protected void OnApplyActionActivated (object sender, EventArgs e)
	{
		MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
		mySqlCommand.CommandText =
			string.Format (textView.Buffer.Text); //INSERT, DROP, CREATE, DELETE
		mySqlCommand.ExecuteNonQuery ();

	}

	protected void OnGoBackActionActivated (object sender, EventArgs e)
	{
		hboxPwd.Visible = false;
		vboxTable.Visible = true;
		vboxEdit.Visible = false;

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
