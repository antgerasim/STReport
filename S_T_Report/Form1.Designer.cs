namespace S_T_Report
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
         this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.OrdersAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.DataSet1 = new S_T_Report.DataSet1();
         this.CarBindingSource = new System.Windows.Forms.BindingSource(this.components);
         //this.CarTableAdapter = new S_T_Report.DataSet1TableAdapters.CarTableAdapter();
         this.OrdersAllTableAdapter = new S_T_Report.DataSet1TableAdapters.OrdersAllTableAdapter();
         this.btnTop10 = new System.Windows.Forms.Button();
         this.btnExpensive = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.OrdersAllBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // reportViewer1
         // 
         reportDataSource2.Name = "DataSet1";
         reportDataSource2.Value = this.OrdersAllBindingSource;
         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
         this.reportViewer1.LocalReport.ReportEmbeddedResource = "S_T_Report.Report2.rdlc";
         this.reportViewer1.Location = new System.Drawing.Point(161, 12);
         this.reportViewer1.Name = "reportViewer1";
         this.reportViewer1.Size = new System.Drawing.Size(699, 506);
         this.reportViewer1.TabIndex = 0;
         // 
         // OrdersAllBindingSource
         // 
         this.OrdersAllBindingSource.DataMember = "OrdersAll";
         this.OrdersAllBindingSource.DataSource = this.DataSet1;
         // 
         // DataSet1
         // 
         this.DataSet1.DataSetName = "DataSet1";
         this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // CarBindingSource
         // 
         this.CarBindingSource.DataMember = "Car";
         this.CarBindingSource.DataSource = this.DataSet1;
         // 
         // CarTableAdapter
         // 
         //this.CarTableAdapter.ClearBeforeFill = true;
         // 
         // OrdersAllTableAdapter
         // 
         this.OrdersAllTableAdapter.ClearBeforeFill = true;
         // 
         // btnTop10
         // 
         this.btnTop10.Location = new System.Drawing.Point(12, 30);
         this.btnTop10.Name = "btnTop10";
         this.btnTop10.Size = new System.Drawing.Size(143, 23);
         this.btnTop10.TabIndex = 1;
         this.btnTop10.Text = "Top10";
         this.btnTop10.UseVisualStyleBackColor = true;
         this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
         // 
         // btnExpensive
         // 
         this.btnExpensive.Location = new System.Drawing.Point(12, 78);
         this.btnExpensive.Name = "btnExpensive";
         this.btnExpensive.Size = new System.Drawing.Size(143, 25);
         this.btnExpensive.TabIndex = 2;
         this.btnExpensive.Text = "Most Expensive";
         this.btnExpensive.UseVisualStyleBackColor = true;
         this.btnExpensive.Click += new System.EventHandler(this.btnExpensive_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(872, 574);
         this.Controls.Add(this.btnExpensive);
         this.Controls.Add(this.btnTop10);
         this.Controls.Add(this.reportViewer1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.OrdersAllBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
         //((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
      private System.Windows.Forms.BindingSource CarBindingSource;
      private DataSet1 DataSet1;
      //private DataSet1TableAdapters.CarTableAdapter CarTableAdapter;
      private System.Windows.Forms.BindingSource OrdersAllBindingSource;
      private DataSet1TableAdapters.OrdersAllTableAdapter OrdersAllTableAdapter;
      private System.Windows.Forms.Button btnTop10;
      private System.Windows.Forms.Button btnExpensive;
   }
}

