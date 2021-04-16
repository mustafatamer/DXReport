using DevExpress.XtraReports.UI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXReport
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport1 xtraReport1 = new XtraReport1();
            
            excelDataSource1.Fill();
            //excelDataSource1.SourceOptions.SkipEmptyRows = false;
            ////excelDataSource1.SourceOptions.SkipHiddenColumns = false;
            ////excelDataSource1.SourceOptions.SkipHiddenRows = false;

            excelDataSource1.SourceOptions.SkipEmptyRows = false;
            excelDataSource1.SourceOptions.UseFirstRowAsHeader = false;
            List<string> values1 = new List<string>();
            List<string> values2 = new List<string>();
            int j;
            DevExpress.DataAccess.Native.Excel.DataView dv = ((IListSource)excelDataSource1).GetList() as DevExpress.DataAccess.Native.Excel.DataView;
            for (int i = 0; i < dv.Count; i++)
            {
                j = 0;
                DevExpress.DataAccess.Native.Excel.ViewRow row = dv[i] as DevExpress.DataAccess.Native.Excel.ViewRow;
                foreach (DevExpress.DataAccess.Native.Excel.ViewColumn col in dv.Columns)
                {
                    object val = col.GetValue(row);
                    if (val != null)
                    {
                        values2.Add($"col[{i}] row[{j}] value :{ val.ToString()}");
                        //values1.Add($"rowindex : {row.Index }] / {col.Name}: dv[{i}] : {j}                 : {val.ToString()}");
                    }
                    else
                    {
                        //values2.Add($"col[{j}] row[{i}] value : empty");
                        // col.SetValue();
                    }

                    j++;
                }
            }

            // var value1 = dv.Columns[2].GetValue(dv[5]);
            xtraReport1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            (xtraReport1.FindControl("xrTableCellAciklama", false) as XRTableCell ).Text = dv.Columns[1].GetValue(dv[38]).ToString();
            xtraReport1.AllControls<XRLabel>().First(x => x.Name == "xrLabel1").Text = dv.Columns[16].GetValue(dv[0]).ToString(); ;//.Text = "deneme";
            xtraReport1.AllControls<XRLabel>().First(x => x.Name == "xrBaslik").Text = dv.Columns[0].Name.ToString(); ;//.Text = "deneme";
            xtraReport1.ShowPreview();
        }
    }
}
