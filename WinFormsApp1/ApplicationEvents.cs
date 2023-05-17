using System.IO;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;

namespace YourNamespace
{
    static class Program
    {
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.Run();
        }
    }

    partial class MyApplication : WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            this.MinimumSplashScreenDisplayTime = 4000;
            this.SplashScreen = new MySplashScreen();
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = new MainForm();
        }

        protected override void ApplyApplicationDefaults(ApplyApplicationDefaultsEventArgs e)
        {
            e.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            e.HighDpiMode = HighDpiMode.PerMonitorV2;
        }
    }

    class MainForm : Form
    {
        public MainForm()
        {
            // MainForm initialization code
        }
    }

    class MySplashScreen : Form
    {
        public MySplashScreen()
        {
            // SplashScreen initialization code
        }
    }
}
