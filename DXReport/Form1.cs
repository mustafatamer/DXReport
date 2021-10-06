using DevExpress.XtraReports.UI;
using DXReport.Raporlar;
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
            //XtraReport1 xtraReport1 = new XtraReport1();

            Report2_Sayfa report2_Sayfa = new Report2_Sayfa();
            
            excelDataSource2_Sayfa.Fill();
            //excelDataSource1.SourceOptions.SkipEmptyRows = false;
            ////excelDataSource1.SourceOptions.SkipHiddenColumns = false;
            ////excelDataSource1.SourceOptions.SkipHiddenRows = false;

            excelDataSource2_Sayfa.SourceOptions.SkipEmptyRows = false;
            excelDataSource2_Sayfa.SourceOptions.UseFirstRowAsHeader = false;
            //List<string> values1 = new List<string>();
            //List<string> values2 = new List<string>();
            //int j;
            DevExpress.DataAccess.Native.Excel.DataView dv = ((IListSource)excelDataSource2_Sayfa).GetList() as DevExpress.DataAccess.Native.Excel.DataView;
            //for (int i = 0; i < dv.Count; i++)
            //{
            //    j = 0;
            //    DevExpress.DataAccess.Native.Excel.ViewRow row = dv[i] as DevExpress.DataAccess.Native.Excel.ViewRow;
            //    foreach (DevExpress.DataAccess.Native.Excel.ViewColumn col in dv.Columns)
            //    {
            //        object val = col.GetValue(row);
            //        if (val != null)
            //        {
            //            values2.Add($"col[{i}] row[{j}] value :{ val.ToString()}");
            //            //values1.Add($"rowindex : {row.Index }] / {col.Name}: dv[{i}] : {j}                 : {val.ToString()}");
            //        }
            //        else
            //        {
            //            //values2.Add($"col[{j}] row[{i}] value : empty");
            //            // col.SetValue();
            //        }

            //        j++;
            //    }
            //}

            // var value1 = dv.Columns[2].GetValue(dv[5]);
            //xtraReport1.PaperKind = System.Drawing.Printing.PaperKind.A4;

            //(xtraReport1.FindControl("xrTableCellAciklama", false) as XRTableCell ).Text = dv.Columns[1].GetValue(dv[38]).ToString();
            //xtraReport1.AllControls<XRLabel>().First(x => x.Name == "xrLabel1").Text = dv.Columns[16].GetValue(dv[0]).ToString(); ;//.Text = "deneme";
            //xtraReport1.AllControls<XRLabel>().First(x => x.Name == "xrBaslik").Text = dv.Columns[0].Name.ToString(); ;//.Text = "deneme";
            //xtraReport1.ShowPreview();

            (report2_Sayfa.FindControl("xrLabelBaslık", false) as XRLabel).Text = dv.Columns[0].GetValue(dv[0]).ToString();
            (report2_Sayfa.FindControl("xrLabelUygulamaYili", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[13]).ToString();
            (report2_Sayfa.FindControl("xrLabelYukleniciAdi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[14]).ToString();
            (report2_Sayfa.FindControl("xrLabelSozlesmeBedeli", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[15]).ToString();
            (report2_Sayfa.FindControl("xrLabelİhaleTarihi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[16]).ToString();
            (report2_Sayfa.FindControl("xrLabelSozlesmeTarihi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[17]).ToString();
            (report2_Sayfa.FindControl("xrLabelYerTeslimTarihi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[18]).ToString();
            (report2_Sayfa.FindControl("xrLabelİsinSuresi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[19]).ToString();
            (report2_Sayfa.FindControl("xrLabelSozlesmeİsinBitis", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[20]).ToString();
            (report2_Sayfa.FindControl("xrLabelSureUzatimİsBitim", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[21]).ToString();
            (report2_Sayfa.FindControl("xrYiliOdenegi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[22]).ToString();
            (report2_Sayfa.FindControl("xrLabelYiliOdenegi", false) as XRLabel).Text = dv.Columns[1].GetValue(dv[22]).ToString();
            (report2_Sayfa.FindControl("xrLabelKontrolMuh", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[23]).ToString();
            (report2_Sayfa.FindControl("xrLabelSantiyeSefi", false) as XRLabel).Text = dv.Columns[7].GetValue(dv[24]).ToString();
            (report2_Sayfa.FindControl("xrLabelIsinAdi", false) as XRLabel).Text = dv.Columns[1].GetValue(dv[7]).ToString();

            report2_Sayfa.ShowPreview();

        }
    }
}
