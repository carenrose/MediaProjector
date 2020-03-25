using System;
namespace MediaProjector
{
    public partial class DisplayWindow : Gtk.Window
    {
        public DisplayWindow() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
