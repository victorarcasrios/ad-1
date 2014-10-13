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
		this.SetSizeRequest (750, 250);



	}

	protected void OnExecuteActionActivated (object sender, EventArgs e)
	{

		try{
			if (textView_EW.Buffer.Text != ""){
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
				mySqlCommand.CommandText =
					string.Format (textView_EW.Buffer.Text); //CREATE, DROP, INSERT, UPDATE, DELETE
				mySqlCommand.ExecuteNonQuery ();

				messageDialog = new MessageDialog (
					this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "\t\tSQL Script Executed Successfully\t\t");
				messageDialog.Title = "SQL EditWindow";
				messageDialog.Run ();
				messageDialog.Destroy ();

			}
			else{
				messageDialog = new MessageDialog (
					this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "\t\tSQL Script Error. Script 'NULL'\t\t");
				messageDialog.Title = "SQL EditWindow";
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
	
	protected void OnBtnCreateClicked (object sender, EventArgs e)
	{
		textView_EW.Buffer.Text = textView_EW.Buffer.Text +
			"\nCREATE TABLE [tabName]"; //CREATE

	}

	protected void OnBtnDropClicked (object sender, EventArgs e)
	{
		textView_EW.Buffer.Text = textView_EW.Buffer.Text +
			"\nDROP [DATABASE/TABLE] [dbName/tabName]"; //DROP

	}

	protected void OnBtnInsertClicked (object sender, EventArgs e)
	{
		textView_EW.Buffer.Text = textView_EW.Buffer.Text +
			"\nINSERT INTO `categoria`(`id`, `nombre`) VALUES ([value-1],[value-2])"; //INSERT

	}

	protected void OnBtnUpdateClicked (object sender, EventArgs e)
	{
		textView_EW.Buffer.Text = textView_EW.Buffer.Text +
			"\nUPDATE `categoria` SET `id`=[value-1],`nombre`=[value-2] WHERE [condition]"; //UPDATE

	}

	protected void OnBtnDeleteClicked (object sender, EventArgs e)
	{
		textView_EW.Buffer.Text = textView_EW.Buffer.Text +
			"\nDELETE FROM `categoria` WHERE [condition]"; //DELETE

	}
}
