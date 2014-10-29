//gitUser> @juankza

using Gtk;
using MySql;
using MySql.Data.MySqlClient;
using SerpisAd;
using System;
using System.Data;

public partial class LoginWindow : Gtk.Window
{
	private MessageDialog msgDialog;

	public LoginWindow () : base(Gtk.WindowType.Toplevel)
	{
		this.Build ();

	}

	protected void OnPwdCheckBtnToggled (object sender, EventArgs e)
	{
		if (pwdEntry.Visibility == true){ pwdEntry.Visibility = false;}
		else { pwdEntry.Visibility = true;}

	}

	protected void OnLoginButtonClicked (object sender, EventArgs e)
	{
		try{
			string connectionString = "Server=localhost;" + "Database=dbprueba;" +
				"User ID=" + userEntry.Text.ToString () + ";" + "Password=" + pwdEntry.Text.ToString ();
			App.Instance.DbConnection = new MySqlConnection (connectionString);
			App.Instance.DbConnection.Open ();

			MainWindow mWin = new MainWindow ();
			mWin.ShowAll ();

			this.Destroy ();

		}
		catch (MySqlException){
			msgDialog = new MessageDialog (
				this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "\t\tConnection Error\t\t\nCannot connect to database");
			msgDialog.Title = "SQL DataBase Error";
			msgDialog.Run ();
			msgDialog.Destroy ();

			pwdEntry.Text = "";

		}
		catch{
			Console.WriteLine ("\nError 404 Not Found");
			Application.Quit ();

		}

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
}

