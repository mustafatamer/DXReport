using DevExpress.XtraReports.UI;

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DXReport
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        protected override void OnPreviewClick(PreviewMouseEventArgs e)
        {
            base.OnPreviewClick(e);
        }

    }
}
