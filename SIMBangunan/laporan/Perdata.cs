using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SIMBangunan.laporan
{
    public partial class Perdata : DevExpress.XtraReports.UI.XtraReport
    {
        string faktur;

        public Perdata(string nofaktur)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.faktur = nofaktur;
            Faktur.Value = faktur;
        }
    }
}
