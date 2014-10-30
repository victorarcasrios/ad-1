//gitUser> @juankza

using Gtk;
using MySql;
using MySql.Data.MySqlClient;
using PArticulo;
using SerpisAd;
using System;
using System.Collections.Generic;
using System.Data;

public partial class MainWindow: Gtk.Window
{	
	//GLOBAL VARS
	private MessageDialog msgDialog;

	//MAIN FUNCTION
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
<<<<<<< HEAD

=======
		
		
		
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4
	}

	//MY FUNCTIONS
	private void addNewPage (Widget widget, string label){
		noteBook.AppendPage (widget, new Label (label));

	}
	private string whatPgName (Widget widget){
		Label label = (Label)widget;
		return label.LabelProp;

	}
	private void removePage (string str){
		List<string> pgName = new List<string> ();
		if (noteBook.NPages != 0) {
			for (int i = 0; i < noteBook.NPages; i++) {
				pgName.Add (whatPgName (noteBook.GetTabLabel (noteBook.GetNthPage (i))));
			}

			int j = 0;
			for (int i = 0; i < pgName.Count; i++) {
				if (pgName[i] == str) {
					noteBook.RemovePage (i - j);
					j++;
				}

			}

		}

	}

	//FILE
	protected void OnArchivoActionActivated (object sender, EventArgs e)
	{
		List<string> pgName = new List<string> ();
		if (noteBook.NPages != 0){
			for (int i = 0; i < noteBook.NPages; i++){
				pgName.Add (whatPgName (noteBook.GetTabLabel (noteBook.GetNthPage (i))));
			}

			for (int i = 0; i < pgName.Count; i++){
				if (pgName[i] == "Articulo"){
					ArticuloCloseAct.Sensitive = true;
				}

				if (pgName[i] == "Categoria"){
					CategoriaCloseAct.Sensitive = true;
				}

			}

		} else {
			ArticuloCloseAct.Sensitive = false;
			CategoriaCloseAct.Sensitive = false;
		}

	}
	protected void OnArticuloOpenActActivated (object sender, EventArgs e)
	{
		MyWidgetTV myTreeView = new MyWidgetTV ("articulo");
		addNewPage (myTreeView, "Articulo");

	}
	protected void OnCategoriaOpenActActivated (object sender, EventArgs e)
	{
		MyWidgetTV myTreeView = new MyWidgetTV ("categoria");
		addNewPage (myTreeView, "Categoria");

	}
<<<<<<< HEAD
	protected void OnEditActionActivated (object sender, EventArgs e)
	{
		EditWindow eWin = new EditWindow ();
		eWin.ShowAll ();

		this.Destroy ();

	}
	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		//NOT IMPLEMENTED AND UNNECESSARY
		//AFTER EDIT, REFRESH ON OPEN ANY TAB
=======
	protected void OnEditarActionActivated (object sender, EventArgs e)
	{
		EditWindow eWin = new EditWindow ();
		eWin.ShowAll ();

		this.Destroy ();
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4

	}
	protected void OnArticuloCloseActActivated (object sender, EventArgs e)
	{
<<<<<<< HEAD
		removePage ("Articulo");

	}
	protected void OnCategoriaCloseActActivated (object sender, EventArgs e)
	{
		removePage ("Categoria");
=======
		//NOT IMPLEMENTED
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4

	}
	protected void OnArticuloCloseActActivated (object sender, EventArgs e)
	{
		removePage ("Articulo");

<<<<<<< HEAD
	//TAB
=======
	}
	protected void OnCategoriaCloseActActivated (object sender, EventArgs e)
	{
		removePage ("Categoria");

	}
	protected void OnSalirActionActivated (object sender, EventArgs e)
	{
		this.Destroy ();
		Application.Quit ();
	}

	//PESTANA
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4
	protected void OnPestanaActActivated (object sender, EventArgs e)
	{
		if (noteBook.NPages != 0){
			CerrarTodoAct.Sensitive = true;
		} else {
			CerrarTodoAct.Sensitive = false;
		}
	}
	protected void OnPestanaAnteriorActActivated (object sender, EventArgs e)
	{
		//NOT IMPLEMENTED

	}
	protected void OnPestanaSiguienteActActivated (object sender, EventArgs e)
	{
		//NOT IMPLEMENTED

	}
	protected void OnCerrarTodoActActivated (object sender, EventArgs e)
	{
		int pgNum = noteBook.NPages;
		for (int i = 0; i < pgNum; i++){
			noteBook.RemovePage (0);

		}

	}

<<<<<<< HEAD
	//ABOUT
=======


	//ACERCA DE
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4
	protected void OnAcercaDeActionActivated (object sender, EventArgs e)
	{
		msgDialog = new MessageDialog (
			this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close,
			"\t\tPArticulo v0.1 (Alpha)\t\t\nCreado por: Juan Cazalilla Costa");
		msgDialog.Title = "Acerca De";
		msgDialog.Run ();
		msgDialog.Destroy ();

	}
<<<<<<< HEAD

=======
	
>>>>>>> ef9423867ced2e2c4a0728cfb2e13cdd053f3de4
	//EXIT FUNCTION
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

}
