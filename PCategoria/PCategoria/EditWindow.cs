//gitUser> @juankza

using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using PCategoria;

public partial class EditWindow: Gtk.Window
{
	private MessageDialog messageDialog;

	public EditWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();

		this.SetSizeRequest (500, 250);



	}

	protected void OnExecuteActionActivated (object sender, EventArgs e)
	{
/*
		try{
			if (textView_EW.Buffer.Text != ""){
				MySqlCommand mySqlCommand = MainWindow.mySqlConnection.CreateCommand ();
				mySqlCommand.CommandText =
					string.Format (textView_EW.Buffer.Text); //CREATE, DROP, INSERT, DELETE, UPDATE
				mySqlCommand.ExecuteNonQuery ();

			}
			else{
				messageDialog = new MessageDialog (
					this, DialogFlags.Modal, MessageType.Question, ButtonsType.Ok, "Área SQL vacía");
				messageDialog.Title = "Error SQL";
				messageDialog.Run ();
				messageDialog.Destroy ();

			}
		}
		catch (MySqlException){
			Console.WriteLine ("SQL Syntax Error");
		}
		catch{
			Console.WriteLine ("Error");
		}
*/
	}

	protected void OnGoBackActionActivated (object sender, EventArgs e)
	{
		this.Destroy ();

	}
	
}
