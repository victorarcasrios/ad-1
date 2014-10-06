//gitUser> @juankza

using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using PCategoria;

public partial class EditWindow: Gtk.Window
{
	public EditWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();

		this.SetSizeRequest (500, 250);



	}

	protected void OnExecuteActionActivated (object sender, EventArgs e)
	{


	}

	protected void OnGoBackActionActivated (object sender, EventArgs e)
	{
		this.Destroy ();

	}

}
