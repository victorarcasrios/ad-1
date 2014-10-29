using System;
using Gtk;

namespace PArticulo
{
	public class MyWidgetTV : TreeView
	{
		public MyWidgetTV ()
		{
			AppendColumn ("id", new CellRendererText(), "text", 0);
			AppendColumn ("nombre", new CellRendererText(), "text", 1);
			Model = new ListStore (typeof (long), typeof (string));

			((ListStore)Model).AppendValues (1L, "Uno");
			((ListStore)Model).AppendValues (2L, "Dos");
			((ListStore)Model).AppendValues (3L, "Tres");
			Visible = true;

		}
	}
}

