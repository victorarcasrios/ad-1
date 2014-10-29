
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action ArchivoAction;
	private global::Gtk.Action AbrirAction;
	private global::Gtk.Action ArticuloOpenAct;
	private global::Gtk.Action CategoriaOpenAct;
	private global::Gtk.Action EditarAction;
	private global::Gtk.Action CerrarAction;
	private global::Gtk.Action ArticuloCloseAct;
	private global::Gtk.Action CategoriaCloseAct;
	private global::Gtk.Action SalirAction;
	private global::Gtk.Action AyudaAction;
	private global::Gtk.Action AcercaDeAction;
	private global::Gtk.Action PestanaAction;
	private global::Gtk.Action PestanaAnteriorAct;
	private global::Gtk.Action PestanaSiguienteAct;
	private global::Gtk.Action CerrarTodoAct;
	private global::Gtk.Action ArticuloEditAct;
	private global::Gtk.Action CategoriaEditAct;
	private global::Gtk.Action RefrescarAction;
	private global::Gtk.VBox mainVBox;
	private global::Gtk.MenuBar menuBar;
	private global::Gtk.Notebook noteBook;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.ArchivoAction = new global::Gtk.Action ("ArchivoAction", global::Mono.Unix.Catalog.GetString ("Archivo"), null, null);
		this.ArchivoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Archivo");
		w1.Add (this.ArchivoAction, null);
		this.AbrirAction = new global::Gtk.Action ("AbrirAction", global::Mono.Unix.Catalog.GetString ("Abrir"), null, null);
		this.AbrirAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Abrir");
		w1.Add (this.AbrirAction, null);
		this.ArticuloOpenAct = new global::Gtk.Action ("ArticuloOpenAct", global::Mono.Unix.Catalog.GetString ("Artículo"), null, null);
		this.ArticuloOpenAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Artículo");
		w1.Add (this.ArticuloOpenAct, null);
		this.CategoriaOpenAct = new global::Gtk.Action ("CategoriaOpenAct", global::Mono.Unix.Catalog.GetString ("Categoría"), null, null);
		this.CategoriaOpenAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Categoría");
		w1.Add (this.CategoriaOpenAct, null);
		this.EditarAction = new global::Gtk.Action ("EditarAction", global::Mono.Unix.Catalog.GetString ("Editar"), null, null);
		this.EditarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Editar");
		w1.Add (this.EditarAction, null);
		this.CerrarAction = new global::Gtk.Action ("CerrarAction", global::Mono.Unix.Catalog.GetString ("Cerrar"), null, null);
		this.CerrarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Cerrar");
		w1.Add (this.CerrarAction, null);
		this.ArticuloCloseAct = new global::Gtk.Action ("ArticuloCloseAct", global::Mono.Unix.Catalog.GetString ("Artículo"), null, null);
		this.ArticuloCloseAct.Sensitive = false;
		this.ArticuloCloseAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Artículo");
		w1.Add (this.ArticuloCloseAct, null);
		this.CategoriaCloseAct = new global::Gtk.Action ("CategoriaCloseAct", global::Mono.Unix.Catalog.GetString ("Categoría"), null, null);
		this.CategoriaCloseAct.Sensitive = false;
		this.CategoriaCloseAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Categoría");
		w1.Add (this.CategoriaCloseAct, null);
		this.SalirAction = new global::Gtk.Action ("SalirAction", global::Mono.Unix.Catalog.GetString ("Salir"), null, null);
		this.SalirAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Salir");
		w1.Add (this.SalirAction, null);
		this.AyudaAction = new global::Gtk.Action ("AyudaAction", global::Mono.Unix.Catalog.GetString ("Ayuda"), null, null);
		this.AyudaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ayuda");
		w1.Add (this.AyudaAction, null);
		this.AcercaDeAction = new global::Gtk.Action ("AcercaDeAction", global::Mono.Unix.Catalog.GetString ("Acerca de"), null, null);
		this.AcercaDeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Acerca de");
		w1.Add (this.AcercaDeAction, null);
		this.PestanaAction = new global::Gtk.Action ("PestanaAction", global::Mono.Unix.Catalog.GetString ("Pestaña"), null, null);
		this.PestanaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Pestaña");
		w1.Add (this.PestanaAction, null);
		this.PestanaAnteriorAct = new global::Gtk.Action ("PestanaAnteriorAct", global::Mono.Unix.Catalog.GetString ("Pestaña Anterior"), null, null);
		this.PestanaAnteriorAct.Sensitive = false;
		this.PestanaAnteriorAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Pestaña Anterior");
		w1.Add (this.PestanaAnteriorAct, null);
		this.PestanaSiguienteAct = new global::Gtk.Action ("PestanaSiguienteAct", global::Mono.Unix.Catalog.GetString ("Pestaña Siguiente"), null, null);
		this.PestanaSiguienteAct.Sensitive = false;
		this.PestanaSiguienteAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Pestaña Siguiente");
		w1.Add (this.PestanaSiguienteAct, null);
		this.CerrarTodoAct = new global::Gtk.Action ("CerrarTodoAct", global::Mono.Unix.Catalog.GetString ("Cerrar todo"), null, null);
		this.CerrarTodoAct.Sensitive = false;
		this.CerrarTodoAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Cerrar todo");
		w1.Add (this.CerrarTodoAct, null);
		this.ArticuloEditAct = new global::Gtk.Action ("ArticuloEditAct", global::Mono.Unix.Catalog.GetString ("Artículo"), null, null);
		this.ArticuloEditAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Artículo");
		w1.Add (this.ArticuloEditAct, null);
		this.CategoriaEditAct = new global::Gtk.Action ("CategoriaEditAct", global::Mono.Unix.Catalog.GetString ("Categoría"), null, null);
		this.CategoriaEditAct.ShortLabel = global::Mono.Unix.Catalog.GetString ("Categoría");
		w1.Add (this.CategoriaEditAct, null);
		this.RefrescarAction = new global::Gtk.Action ("RefrescarAction", global::Mono.Unix.Catalog.GetString ("Refrescar"), null, null);
		this.RefrescarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Refrescar");
		w1.Add (this.RefrescarAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainVBox = new global::Gtk.VBox ();
		this.mainVBox.Name = "mainVBox";
		this.mainVBox.Spacing = 6;
		// Container child mainVBox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menuBar'><menu name='ArchivoAction' action='ArchivoAction'><menu name='AbrirAction' action='AbrirAction'><menuitem name='ArticuloOpenAct' action='ArticuloOpenAct'/><menuitem name='CategoriaOpenAct' action='CategoriaOpenAct'/></menu><menu name='CerrarAction' action='CerrarAction'><menuitem name='ArticuloCloseAct' action='ArticuloCloseAct'/><menuitem name='CategoriaCloseAct' action='CategoriaCloseAct'/></menu><menuitem name='RefrescarAction' action='RefrescarAction'/><separator/><menuitem name='SalirAction' action='SalirAction'/></menu><menu name='EditarAction' action='EditarAction'><menuitem name='ArticuloEditAct' action='ArticuloEditAct'/><menuitem name='CategoriaEditAct' action='CategoriaEditAct'/></menu><menu name='PestanaAction' action='PestanaAction'><menuitem name='PestanaAnteriorAct' action='PestanaAnteriorAct'/><menuitem name='PestanaSiguienteAct' action='PestanaSiguienteAct'/><separator/><menuitem name='CerrarTodoAct' action='CerrarTodoAct'/></menu><menu name='AyudaAction' action='AyudaAction'><menuitem name='AcercaDeAction' action='AcercaDeAction'/></menu></menubar></ui>");
		this.menuBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menuBar")));
		this.menuBar.Name = "menuBar";
		this.mainVBox.Add (this.menuBar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.menuBar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child mainVBox.Gtk.Box+BoxChild
		this.noteBook = new global::Gtk.Notebook ();
		this.noteBook.CanFocus = true;
		this.noteBook.Name = "noteBook";
		this.noteBook.CurrentPage = -1;
		this.mainVBox.Add (this.noteBook);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.noteBook]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		this.Add (this.mainVBox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 550;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.ArchivoAction.Activated += new global::System.EventHandler (this.OnArchivoActionActivated);
		this.ArticuloOpenAct.Activated += new global::System.EventHandler (this.OnArticuloOpenActActivated);
		this.CategoriaOpenAct.Activated += new global::System.EventHandler (this.OnCategoriaOpenActActivated);
		this.ArticuloCloseAct.Activated += new global::System.EventHandler (this.OnArticuloCloseActActivated);
		this.CategoriaCloseAct.Activated += new global::System.EventHandler (this.OnCategoriaCloseActActivated);
		this.SalirAction.Activated += new global::System.EventHandler (this.OnSalirActionActivated);
		this.AcercaDeAction.Activated += new global::System.EventHandler (this.OnAcercaDeActionActivated);
		this.PestanaAction.Activated += new global::System.EventHandler (this.OnPestanaActActivated);
		this.PestanaAnteriorAct.Activated += new global::System.EventHandler (this.OnPestanaAnteriorActActivated);
		this.PestanaSiguienteAct.Activated += new global::System.EventHandler (this.OnPestanaSiguienteActActivated);
		this.CerrarTodoAct.Activated += new global::System.EventHandler (this.OnCerrarTodoActActivated);
		this.ArticuloEditAct.Activated += new global::System.EventHandler (this.OnArticuloEditActActivated);
		this.CategoriaEditAct.Activated += new global::System.EventHandler (this.OnCategoriaEditActActivated);
		this.RefrescarAction.Activated += new global::System.EventHandler (this.OnRefrescarActionActivated);
	}
}
