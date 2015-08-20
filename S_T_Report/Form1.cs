using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace S_T_Report
{

   public partial class Form1 : Form
   {

      private ReportDataSource rdts1;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         rdts1 = new ReportDataSource("DataSet1", OrdersAllBindingSource);

         this.OrdersAllTableAdapter.Fill(this.DataSet1.OrdersAll);

         //this.CarTableAdapter.Fill(this.DataSet1.Car);

         this.reportViewer1.RefreshReport();

         /*
                   reportDataSource2.Name = "DataSet1";
         reportDataSource2.Value = this.OrdersAllBindingSource;
         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
         this.reportViewer1.LocalReport.ReportEmbeddedResource = "S_T_Report.Report2.rdlc";
         this.reportViewer1.Location = new System.Drawing.Point(161, 12);
         this.reportViewer1.Name = "reportViewer1";
         this.reportViewer1.Size = new System.Drawing.Size(699, 506);
         this.reportViewer1.TabIndex = 0;
          */
      }

      private void btnTop10_Click(object sender, EventArgs e)
      {
         reportViewer1.Reset();
         reportViewer1.LocalReport.ReportEmbeddedResource = "S_T_Report.Report2.rdlc";
         //OrdersAllTableAdapter.Fill(DataSet1.OrdersAll)
         reportViewer1.LocalReport.DataSources.Clear();
         reportViewer1.LocalReport.DataSources.Add(rdts1);
         OrdersAllTableAdapter.Fill(DataSet1.OrdersAll);
         reportViewer1.RefreshReport();
      }

      private void btnExpensive_Click(object sender, EventArgs e)
      {
         reportViewer1.Reset();
         reportViewer1.LocalReport.ReportEmbeddedResource = "S_T_Report.Report2.rdlc";
         //OrdersAllTableAdapter.Fill(DataSet1.OrdersAll)
         reportViewer1.LocalReport.DataSources.Clear();
         reportViewer1.LocalReport.DataSources.Add(rdts1);
         OrdersAllTableAdapter.FillByOrderId(DataSet1.OrdersAll, 8);//replace by textbox
         reportViewer1.RefreshReport();
      }

   }

}