using System;
using Gtk;
using PNotebook;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		addPage (new MyTreeView(), "Articulo");
		addPage (new MyTreeView(), "Categoria");

	}

	private void addPage (Widget widget, string label){
		HBox hBox = new HBox ();
		hBox.Add (new Label (label));
		hBox.ShowAll ();
		noteBook.AppendPage (widget, hBox);

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
