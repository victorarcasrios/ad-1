//GitUser>@juankza

using Gtk;
using System;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		List<Categoria> categorias = new List<Categoria> ();
		categorias.Add (new Categoria (1, "Uno"));
		categorias.Add (new Categoria (2, "Dos"));
		categorias.Add (new Categoria (3, "Tres"));

		int categoriaId = 2;

		CellRendererText crText = new CellRendererText ();
		comboBox.PackStart (crText, false);
		comboBox.AddAttribute (crText, "text", 1);

		ListStore listStore = new ListStore (typeof (int), typeof(string));

		TreeIter initTI = listStore.AppendValues (0, "<sin asignar>");
		foreach (Categoria categoria in categorias) {
			TreeIter currentTI = listStore.AppendValues (categoria.Id, categoria.Nombre);

			if (categoria.Id == categoriaId){ initTI = currentTI;}

		}

		comboBox.Model = listStore;
		comboBox.SetActiveIter (initTI);

		propertiesAction.Activated += delegate{
			TreeIter ti;
			bool actIter = comboBox.GetActiveIter (out ti);
			object id = actIter ? listStore.GetValue (ti, 0) : "null";
			Console.WriteLine ("id={0}", id);
			
		};

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

}

public class Categoria
{
	public Categoria (int id, string nombre)
	{
		Id = id;
		Nombre = nombre;

	}

	public int Id{ set; get;}
	public string Nombre{ set; get;}

}
