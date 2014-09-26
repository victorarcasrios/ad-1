
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action addAction;
	private global::Gtk.Action removeAction;
	private global::Gtk.Action goForwardAction;
	private global::Gtk.Action Action;
	private global::Gtk.Action refreshAction;
	private global::Gtk.Action closeAction;
	private global::Gtk.VBox vboxMain;
	private global::Gtk.VBox vboxTable;
	private global::Gtk.HBox hboxEdit;
	private global::Gtk.Toolbar toolBar1;
	private global::Gtk.Toolbar toolBar3;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TreeView treeView;
	private global::Gtk.HBox hboxPwd;
	private global::Gtk.Label labelPwd;
	private global::Gtk.Entry entryPwd;
	private global::Gtk.Toolbar toolBarPwd;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.addAction = new global::Gtk.Action ("addAction", global::Mono.Unix.Catalog.GetString ("Añadir"), null, "gtk-add");
		this.addAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Añadir");
		w1.Add (this.addAction, null);
		this.removeAction = new global::Gtk.Action ("removeAction", global::Mono.Unix.Catalog.GetString ("Vaciar"), null, "gtk-remove");
		this.removeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Vaciar");
		w1.Add (this.removeAction, null);
		this.goForwardAction = new global::Gtk.Action ("goForwardAction", global::Mono.Unix.Catalog.GetString ("Actualizar"), null, "gtk-go-forward");
		this.goForwardAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Actualizar");
		w1.Add (this.goForwardAction, null);
		this.Action = new global::Gtk.Action ("Action", null, null, null);
		w1.Add (this.Action, null);
		this.refreshAction = new global::Gtk.Action ("refreshAction", global::Mono.Unix.Catalog.GetString ("Actualizar"), null, "gtk-refresh");
		this.refreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Actualizar");
		w1.Add (this.refreshAction, null);
		this.closeAction = new global::Gtk.Action ("closeAction", global::Mono.Unix.Catalog.GetString ("Vaciar"), null, "gtk-close");
		this.closeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Vaciar");
		w1.Add (this.closeAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 300;
		this.DefaultHeight = 50;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vboxMain = new global::Gtk.VBox ();
		this.vboxMain.Name = "vboxMain";
		this.vboxMain.Spacing = 6;
		// Container child vboxMain.Gtk.Box+BoxChild
		this.vboxTable = new global::Gtk.VBox ();
		this.vboxTable.Name = "vboxTable";
		this.vboxTable.Spacing = 6;
		// Container child vboxTable.Gtk.Box+BoxChild
		this.hboxEdit = new global::Gtk.HBox ();
		this.hboxEdit.Name = "hboxToolBar";
		this.hboxEdit.Spacing = 6;
		// Container child hboxToolBar.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolBar1'><toolitem name='addAction' action='addAction'/><separator/><toolitem name='removeAction' action='removeAction'/></toolbar></ui>");
		this.toolBar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolBar1")));
		this.toolBar1.Name = "toolBar1";
		this.toolBar1.ShowArrow = false;
		this.hboxEdit.Add (this.toolBar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxEdit [this.toolBar1]));
		w2.Position = 0;
		// Container child hboxToolBar.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolBar3'><toolitem name='refreshAction' action='refreshAction'/><separator/><toolitem name='closeAction' action='closeAction'/></toolbar></ui>");
		this.toolBar3 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolBar3")));
		this.toolBar3.Name = "toolBar3";
		this.toolBar3.ShowArrow = false;
		this.hboxEdit.Add (this.toolBar3);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxEdit [this.toolBar3]));
		w3.Position = 2;
		w3.Expand = false;
		this.vboxTable.Add (this.hboxEdit);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxTable [this.hboxEdit]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vboxTable.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeView = new global::Gtk.TreeView ();
		this.treeView.CanFocus = true;
		this.treeView.Name = "treeView";
		this.GtkScrolledWindow1.Add (this.treeView);
		this.vboxTable.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxTable [this.GtkScrolledWindow1]));
		w6.Position = 1;
		this.vboxMain.Add (this.vboxTable);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxMain [this.vboxTable]));
		w7.Position = 0;
		// Container child vboxMain.Gtk.Box+BoxChild
		this.hboxPwd = new global::Gtk.HBox ();
		this.hboxPwd.Name = "hboxPwd";
		this.hboxPwd.Spacing = 6;
		// Container child hboxPwd.Gtk.Box+BoxChild
		this.labelPwd = new global::Gtk.Label ();
		this.labelPwd.Name = "labelPwd";
		this.labelPwd.LabelProp = global::Mono.Unix.Catalog.GetString ("Contraseña");
		this.hboxPwd.Add (this.labelPwd);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxPwd [this.labelPwd]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hboxPwd.Gtk.Box+BoxChild
		this.entryPwd = new global::Gtk.Entry ();
		this.entryPwd.CanFocus = true;
		this.entryPwd.Name = "entryPwd";
		this.entryPwd.IsEditable = true;
		this.entryPwd.InvisibleChar = '•';
		this.hboxPwd.Add (this.entryPwd);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxPwd [this.entryPwd]));
		w9.Position = 1;
		// Container child hboxPwd.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolBarPwd'><toolitem name='goForwardAction' action='goForwardAction'/></toolbar></ui>");
		this.toolBarPwd = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolBarPwd")));
		this.toolBarPwd.Name = "toolBarPwd";
		this.toolBarPwd.ShowArrow = false;
		this.hboxPwd.Add (this.toolBarPwd);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxPwd [this.toolBarPwd]));
		w10.Position = 2;
		w10.Expand = false;
		this.vboxMain.Add (this.hboxPwd);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxMain [this.hboxPwd]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.Add (this.vboxMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.vboxTable.Hide ();
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.addAction.Activated += new global::System.EventHandler (this.OnAddActionActivated);
		this.removeAction.Activated += new global::System.EventHandler (this.OnRemoveActionActivated);
		this.goForwardAction.Activated += new global::System.EventHandler (this.OnGoForwardActionActivated);
		this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
		this.closeAction.Activated += new global::System.EventHandler (this.OnCloseActionActivated);
	}
}
