
// This file has been generated by the GUI designer. Do not modify.
public partial class EditWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action applyAction;
	private global::Gtk.Action executeAction;
	private global::Gtk.Action goBackAction;
	private global::Gtk.VBox vboxMain_EW;
	private global::Gtk.HBox hboxEditTB_EW;
	private global::Gtk.Toolbar editTB1_EW;
	private global::Gtk.Toolbar editTB3_EW;
	private global::Gtk.ScrolledWindow GtkSWEdit_EW;
	private global::Gtk.TextView textView_EW;
	private global::Gtk.HBox hboxEditBtn_EW;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget EditWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.applyAction = new global::Gtk.Action ("applyAction", null, null, "gtk-apply");
		w1.Add (this.applyAction, null);
		this.executeAction = new global::Gtk.Action ("executeAction", global::Mono.Unix.Catalog.GetString ("Ejecutar"), null, "gtk-execute");
		this.executeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ejecutar");
		w1.Add (this.executeAction, null);
		this.goBackAction = new global::Gtk.Action ("goBackAction", global::Mono.Unix.Catalog.GetString ("Volver"), null, "gtk-go-back");
		this.goBackAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Volver");
		w1.Add (this.goBackAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "EditWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("EditWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(3));
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child EditWindow.Gtk.Container+ContainerChild
		this.vboxMain_EW = new global::Gtk.VBox ();
		this.vboxMain_EW.Name = "vboxMain_EW";
		this.vboxMain_EW.Spacing = 6;
		// Container child vboxMain_EW.Gtk.Box+BoxChild
		this.hboxEditTB_EW = new global::Gtk.HBox ();
		this.hboxEditTB_EW.Name = "hboxEditTB_EW";
		this.hboxEditTB_EW.Spacing = 6;
		// Container child hboxEditTB_EW.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='editTB1_EW'><toolitem name='executeAction' action='executeAction'/></toolbar></ui>");
		this.editTB1_EW = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/editTB1_EW")));
		this.editTB1_EW.Name = "editTB1_EW";
		this.editTB1_EW.ShowArrow = false;
		this.hboxEditTB_EW.Add (this.editTB1_EW);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxEditTB_EW [this.editTB1_EW]));
		w2.Position = 0;
		// Container child hboxEditTB_EW.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='editTB3_EW'><toolitem name='goBackAction' action='goBackAction'/></toolbar></ui>");
		this.editTB3_EW = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/editTB3_EW")));
		this.editTB3_EW.Name = "editTB3_EW";
		this.editTB3_EW.ShowArrow = false;
		this.hboxEditTB_EW.Add (this.editTB3_EW);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxEditTB_EW [this.editTB3_EW]));
		w3.Position = 2;
		this.vboxMain_EW.Add (this.hboxEditTB_EW);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxMain_EW [this.hboxEditTB_EW]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vboxMain_EW.Gtk.Box+BoxChild
		this.GtkSWEdit_EW = new global::Gtk.ScrolledWindow ();
		this.GtkSWEdit_EW.Name = "GtkSWEdit_EW";
		this.GtkSWEdit_EW.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkSWEdit_EW.Gtk.Container+ContainerChild
		this.textView_EW = new global::Gtk.TextView ();
		this.textView_EW.CanFocus = true;
		this.textView_EW.Name = "textView_EW";
		this.GtkSWEdit_EW.Add (this.textView_EW);
		this.vboxMain_EW.Add (this.GtkSWEdit_EW);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxMain_EW [this.GtkSWEdit_EW]));
		w6.Position = 1;
		// Container child vboxMain_EW.Gtk.Box+BoxChild
		this.hboxEditBtn_EW = new global::Gtk.HBox ();
		this.hboxEditBtn_EW.Name = "hboxEditBtn_EW";
		this.hboxEditBtn_EW.Spacing = 6;
		this.vboxMain_EW.Add (this.hboxEditBtn_EW);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxMain_EW [this.hboxEditBtn_EW]));
		w7.Position = 2;
		this.Add (this.vboxMain_EW);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.executeAction.Activated += new global::System.EventHandler (this.OnExecuteActionActivated);
		this.goBackAction.Activated += new global::System.EventHandler (this.OnGoBackActionActivated);
	}
}