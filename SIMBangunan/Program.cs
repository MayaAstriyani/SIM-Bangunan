using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace SIMBangunan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Splash a = new Splash();
            a.ShowDialog();
            Application.Run(new frmUtama());
        }
    }
}