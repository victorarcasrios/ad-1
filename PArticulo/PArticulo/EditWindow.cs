//gitUser> @juankza

using Gtk;
using MySql;
using MySql.Data.MySqlClient;
using SerpisAd;
using System;
using System.Collections.Generic;
using System.Data;

namespace PArticulo
{
	public partial class EditWindow : Gtk.Window
	{
		//GLOBAL VARS
		private MessageDialog msgDialog;

		private IDbCommand dbCommand;

		//MAIN FUNCTION
		public EditWindow () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}

		//EDIT BOX (NOT FINISHED, BUT WORKS)
		protected void OnBtnInsertClicked (object sender, EventArgs e)
		{
			if (textView.Buffer.Text == "") { textView.Buffer.Text =
				"INSERT INTO `[tabName]`(`[column1]`, `[column2]`) \nVALUES ([value1], [value2])";}
			else { textView.Buffer.Text = textView.Buffer.Text +
				"\nINSERT INTO `[tabName]`(`[column1]`, `[column2]`) \nVALUES ([value1], [value2])";}

		}
		protected void OnBtnUpdateClicked (object sender, EventArgs e)
		{
			if (textView.Buffer.Text == "") { textView.Buffer.Text =
				"UPDATE `[tabName]` \nSET `[column1]`=[value1], `[column2]`=[value2] \nWHERE [condition]";}
			else { textView.Buffer.Text = textView.Buffer.Text +
				"\nUPDATE `[tabName]` \nSET `[column1]`=[value1], `[column2]`=[value2] \nWHERE [condition]";}

		}
		protected void OnBtnDeleteClicked (object sender, EventArgs e)
		{
			if (textView.Buffer.Text == "") { textView.Buffer.Text =
				"DELETE FROM `[tabName]` \nWHERE [condition]";}
			else { textView.Buffer.Text = textView.Buffer.Text +
				"\nDELETE FROM `[tabName]` \nWHERE [condition]";}

		}
		protected void OnBtnExecuteClicked (object sender, EventArgs e)
		{
			try{
				if (textView.Buffer.Text != ""){
					this.dbCommand = App.Instance.DbConnection.CreateCommand ();
					dbCommand.CommandText = String.Format (
						textView.Buffer.Text); //CREATE, DROP, INSERT, UPDATE, DELETE

					msgDialog = new MessageDialog (
						this, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, "\t\tAre you sure?\t\t");
					msgDialog.Title = "SQL EditWindow";

					if ((ResponseType)msgDialog.Run () == ResponseType.Yes){
						msgDialog.Destroy ();
						dbCommand.ExecuteNonQuery ();

						msgDialog = new MessageDialog (
							this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "\t\tSQL Script Executed Successfully\t\t");
						msgDialog.Title = "SQL EditWindow";
						msgDialog.Run ();
						msgDialog.Destroy ();

					}
					else{ msgDialog.Destroy ();}

				}
				else{
					msgDialog = new MessageDialog (
						this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "\t\tSQL Script Error. Script 'NULL'\t\t");
					msgDialog.Title = "SQL EditWindow";
					msgDialog.Run ();
					msgDialog.Destroy ();

				}
			}
			catch (MySqlException error){
				Console.WriteLine (error.Message);

			}
			catch{
				Console.WriteLine ("Error");
			}

		}

		//EXIT FUNCTION
		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			MainWindow mWin = new MainWindow ();
			mWin.ShowAll ();

		}

	}

}

