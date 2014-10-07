//gitUser> @juankza

using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using PCategoria;

public partial class EditWindow: Gtk.Window
{
	private MessageDialog messageDialog;
	private MySqlConnection mySqlConnection;

	public EditWindow (MySqlConnection mySqlConnection) : base(Gtk.WindowType.Toplevel)
	{
		Build ();

		this.mySqlConnection = mySqlConnection;
		this.SetSizeRequest (500, 250);



	}

	protected void OnExecuteActionActivated (object sender, EventArgs e)
	{

		try{
			if (textView_EW.Buffer.Text != ""){
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
				mySqlCommand.CommandText =
					string.Format (textView_EW.Buffer.Text); //CREATE, DROP, INSERT, DELETE, UPDATE
				mySqlCommand.ExecuteNonQuery ();

				messageDialog = new MessageDialog (
					this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "\t\tConsulta SQL realizada\t\t");
				messageDialog.Title = "SQL Query Executed Successfully";
				messageDialog.Run ();
				messageDialog.Destroy ();

			}
			else{
				messageDialog = new MessageDialog (
					this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "\t\tÁrea SQL vacía\t\t");
				messageDialog.Title = "SQL Error";
				messageDialog.Run ();
				messageDialog.Destroy ();

			}
		}
		catch (MySqlException error){
			Console.WriteLine (error.Message);

		}
		catch{
			Console.WriteLine ("Error");
		}

	}

	protected void OnGoBackActionActivated (object sender, EventArgs e)
	{
		this.Destroy ();

	}
	
}
