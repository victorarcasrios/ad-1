using System;
using Gtk;
using PNotebook;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		ArticuloAction.Activated += delegate {
			MyTreeView myTreeView = new MyTreeView ();
			addPage (myTreeView, "Articulo");
			whatPage(myTreeView);

		};
		
		CategoriaAction.Activated += delegate {
			MyTreeView myTreeView = new MyTreeView ();
			addPage (myTreeView, "Categoria");
			whatPage(myTreeView);

		};

		SalirAction.Activated += delegate {
			Application.Quit ();

		};

	}

	private void addPage (Widget widget, string label){
		HBox hBox = new HBox ();
		Button button = new Button (new Image (Stock.Cancel, IconSize.Button));
		hBox.Add (new Label (label));
		hBox.Add (button);
		hBox.ShowAll ();
		noteBook.AppendPage (widget, hBox);

		button.Clicked += delegate {
			widget.Destroy ();

		};

	}

	private void whatPage (Widget widget){
		for (int i = 0; i < noteBook.NPages; i++){
			Console.WriteLine(noteBook.GetTabLabelText (widget));

		}

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
