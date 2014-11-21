
// This file has been generated by the GUI designer. Do not modify.
public partial class LoginWindow
{
	private global::Gtk.VBox mainVBox;
	private global::Gtk.HBox mainHBox;
	private global::Gtk.VBox labelVBox;
	private global::Gtk.Label userLabel;
	private global::Gtk.Label pwdLabel;
	private global::Gtk.VBox entryVBox;
	private global::Gtk.Entry userEntry;
	private global::Gtk.Entry pwdEntry;
	private global::Gtk.CheckButton pwdCheckBtn;
	private global::Gtk.Button loginButton;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget LoginWindow
		this.Name = "LoginWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Iniciar sesión");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-disconnect", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.DefaultWidth = 300;
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child LoginWindow.Gtk.Container+ContainerChild
		this.mainVBox = new global::Gtk.VBox ();
		this.mainVBox.Name = "mainVBox";
		this.mainVBox.Spacing = 6;
		// Container child mainVBox.Gtk.Box+BoxChild
		this.mainHBox = new global::Gtk.HBox ();
		this.mainHBox.Name = "mainHBox";
		this.mainHBox.Spacing = 6;
		// Container child mainHBox.Gtk.Box+BoxChild
		this.labelVBox = new global::Gtk.VBox ();
		this.labelVBox.Name = "labelVBox";
		this.labelVBox.Spacing = 6;
		// Container child labelVBox.Gtk.Box+BoxChild
		this.userLabel = new global::Gtk.Label ();
		this.userLabel.Name = "userLabel";
		this.userLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Usuario");
		this.labelVBox.Add (this.userLabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.labelVBox [this.userLabel]));
		w1.Position = 0;
		// Container child labelVBox.Gtk.Box+BoxChild
		this.pwdLabel = new global::Gtk.Label ();
		this.pwdLabel.Name = "pwdLabel";
		this.pwdLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Contraseña");
		this.labelVBox.Add (this.pwdLabel);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.labelVBox [this.pwdLabel]));
		w2.Position = 1;
		this.mainHBox.Add (this.labelVBox);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.mainHBox [this.labelVBox]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child mainHBox.Gtk.Box+BoxChild
		this.entryVBox = new global::Gtk.VBox ();
		this.entryVBox.Name = "entryVBox";
		this.entryVBox.Spacing = 6;
		// Container child entryVBox.Gtk.Box+BoxChild
		this.userEntry = new global::Gtk.Entry ();
		this.userEntry.CanFocus = true;
		this.userEntry.Name = "userEntry";
		this.userEntry.IsEditable = true;
		this.userEntry.InvisibleChar = '•';
		this.entryVBox.Add (this.userEntry);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.entryVBox [this.userEntry]));
		w4.Position = 0;
		// Container child entryVBox.Gtk.Box+BoxChild
		this.pwdEntry = new global::Gtk.Entry ();
		this.pwdEntry.CanFocus = true;
		this.pwdEntry.Name = "pwdEntry";
		this.pwdEntry.IsEditable = true;
		this.pwdEntry.Visibility = false;
		this.pwdEntry.InvisibleChar = '•';
		this.entryVBox.Add (this.pwdEntry);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.entryVBox [this.pwdEntry]));
		w5.Position = 1;
		this.mainHBox.Add (this.entryVBox);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.mainHBox [this.entryVBox]));
		w6.Position = 1;
		this.mainVBox.Add (this.mainHBox);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.mainHBox]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child mainVBox.Gtk.Box+BoxChild
		this.pwdCheckBtn = new global::Gtk.CheckButton ();
		this.pwdCheckBtn.CanFocus = true;
		this.pwdCheckBtn.Name = "pwdCheckBtn";
		this.pwdCheckBtn.Label = global::Mono.Unix.Catalog.GetString ("Mostrar contraseña");
		this.pwdCheckBtn.DrawIndicator = true;
		this.pwdCheckBtn.UseUnderline = true;
		this.mainVBox.Add (this.pwdCheckBtn);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.pwdCheckBtn]));
		w8.Position = 1;
		// Container child mainVBox.Gtk.Box+BoxChild
		this.loginButton = new global::Gtk.Button ();
		this.loginButton.CanFocus = true;
		this.loginButton.Name = "loginButton";
		this.loginButton.UseUnderline = true;
		this.loginButton.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
		this.mainVBox.Add (this.loginButton);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.loginButton]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.Add (this.mainVBox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultHeight = 125;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.pwdCheckBtn.Toggled += new global::System.EventHandler (this.OnPwdCheckBtnToggled);
		this.loginButton.Clicked += new global::System.EventHandler (this.OnLoginButtonClicked);
	}
}
