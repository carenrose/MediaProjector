using System;
using Gtk;
using MediaProjector;
using System.Diagnostics;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void TestButtonClick(object sender, EventArgs e)
    {
        Debug.WriteLine("Button click");
        var window = new DisplayWindow();
        window.SetPosition(WindowPosition.CenterOnParent);
        window.ShowNow();
        //window.Show();
    }
}
