//gitUser> juankza

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

		treeView.Model = listStore; //JavaCode> treeView.setModel(listStore);
		//Habilita multiseleccion
		//treeView.Selection.Mode = SelectionMode.Multiple; 

		treeView.Selection.Changed += delegate
		{
			deleteAction.Sensitive = treeView.Selection.CountSelectedRows () > 0;

		};

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

			this.SetSizeRequest (500, 250);
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

	protected void OnDeleteActionActivated (object sender, EventArgs e)
	{
		TreeIter treeIter;
		treeView.Selection.GetSelected (out treeIter);
		object id = listStore.GetValue (treeIter, 0);
		//object nombre = listStore.GetValue (treeIter, 1);

		MessageDialog messageDialog = new MessageDialog (
			this, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "¿Desea eliminar el elemento seleccionado?");
		messageDialog.Title = "Eliminar";

		if ((ResponseType)messageDialog.Run () == ResponseType.Yes){
			try{
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
				mySqlCommand.CommandText =
					string.Format ("DELETE FROM `{0}`.`{1}` WHERE `{1}`.`id` = {2}",
					               mySqlConnection.Database, "categoria", id); //{1}Command> SHOW TABLES
				mySqlCommand.ExecuteNonQuery ();
			}
			catch (MySqlException){
				Console.WriteLine ("SQL Syntax Error");
			}

		}

		messageDialog.Destroy ();

	}

	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		try{
			listStore.Clear ();

			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = "SELECT * FROM categoria";

			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();

			while (mySqlDataReader.Read())
			{
				object id = mySqlDataReader ["id"];
				object nombre = mySqlDataReader ["nombre"];
				listStore.AppendValues (id, nombre);
			}

			mySqlDataReader.Close ();
		}
		catch (MySqlException){
			Console.WriteLine ("SQL Error");
			listStore.Clear ();
		}

	}

	protected void OnCloseActionActivated (object sender, EventArgs e)
	{
		listStore.Clear ();

	}

	protected void OnApplyActionActivated (object sender, EventArgs e)
	{
		try{
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText =
				string.Format (textView.Buffer.Text); //CREATE, DROP, INSERT, DELETE, UPDATE
			mySqlCommand.ExecuteNonQuery ();
		}
		catch (MySqlException){
			Console.WriteLine ("SQL Syntax Error");
			textView.Buffer.Clear ();
		}

	}

	protected void OnGoBackActionActivated (object sender, EventArgs e)
	{
		hboxPwd.Visible = false;
		vboxTable.Visible = true;
		vboxEdit.Visible = false;

	}
	
}
