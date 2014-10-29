//gitUser> @juankza

using System;
using Gtk;
using PArticulo;

public partial class MainWindow: Gtk.Window
{	
	private MessageDialog msgDialog;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();



	}

	private void addNewPage (Widget widget, string label){
		noteBook.AppendPage (widget, new Label (label));

	}

	private string whatPage (Widget widget){
		Label label = (Label)widget;
		return label.LabelProp;

	}

	protected void OnArchivoActionActivated (object sender, EventArgs e)
	{
		string pgName;
		if (noteBook.NPages != -1){
			for (int i = 0; i < noteBook.NPages; i++) {
				pgName = whatPage(noteBook.GetTabLabel(noteBook.GetNthPage(i)));

				if (pgName == "Articulo" || pgName == "Artículo"){
					ArticuloCloseAct.Sensitive = true;
				}
				if (pgName == "Categoria" || pgName == "Categoría"){
					CategoriaCloseAct.Sensitive = true;
				}

			}

		}

	}

	protected void OnArticuloOpenActActivated (object sender, EventArgs e)
	{
		MyWidgetTV myTreeView = new MyWidgetTV ();
		addNewPage (myTreeView, "Articulo");

	}

	protected void OnCategoriaOpenActActivated (object sender, EventArgs e)
	{


	}

	protected void OnArticuloCloseActActivated (object sender, EventArgs e)
	{


	}

	protected void OnCategoriaCloseActActivated (object sender, EventArgs e)
	{


	}

	protected void OnRefrescarActionActivated (object sender, EventArgs e)
	{


	}

	protected void OnSalirActionActivated (object sender, EventArgs e)
	{
		this.Destroy ();
		Application.Quit ();
	}

	protected void OnArticuloEditActActivated (object sender, EventArgs e)
	{


	}
	protected void OnCategoriaEditActActivated (object sender, EventArgs e)
	{


	}

	protected void OnPestanaActActivated (object sender, EventArgs e)
	{
		if (noteBook.NPages != -1) {


		}

	}
	protected void OnPestanaAnteriorActActivated (object sender, EventArgs e)
	{


	}
	protected void OnPestanaSiguienteActActivated (object sender, EventArgs e)
	{


	}
	protected void OnCerrarTodoActActivated (object sender, EventArgs e)
	{


	}

	protected void OnAcercaDeActionActivated (object sender, EventArgs e)
	{
		msgDialog = new MessageDialog (
			this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, "\t\tPArticulo v0.1a\t\t\nCreado por: Juan Cazalilla Costa");
		msgDialog.Title = "Acerca De";
		msgDialog.Run ();
		msgDialog.Destroy ();

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
}
