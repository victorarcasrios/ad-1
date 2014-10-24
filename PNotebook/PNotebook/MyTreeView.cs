using System;
using Gtk;

namespace PNotebook
{
	public class MyTreeView : TreeView
	{
		public MyTreeView ()
		{
			AppendColumn ("id", new CellRendererText(), "text", 0);
			AppendColumn ("nombre", new CellRendererText(), "text", 1);
			Model = new ListStore (typeof (long), typeof (string));



		}
	}
}

