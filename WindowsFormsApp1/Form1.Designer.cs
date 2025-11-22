namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CodeField = new DevExpress.XtraEditors.TextEdit();
            this.CompanyNameField = new DevExpress.XtraEditors.TextEdit();
            this.CountryField = new DevExpress.XtraEditors.TextEdit();
            this.AddressField = new DevExpress.XtraEditors.TextEdit();
            this.ContactNumberField = new DevExpress.XtraEditors.TextEdit();
            this.LastOrderDateField = new DevExpress.XtraEditors.DateEdit();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.ClearButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.CountryChart = new DevExpress.XtraCharts.ChartControl();
            this.RefreshChartButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumberField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastOrderDateField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastOrderDateField.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(31, 405);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1498, 507);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.CustomizationFormHint.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.CustomizationFormHint.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseBorderColor = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseForeColor = true;
            this.gridView1.Appearance.DetailTip.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.DetailTip.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.DetailTip.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.DetailTip.Options.UseBackColor = true;
            this.gridView1.Appearance.DetailTip.Options.UseBorderColor = true;
            this.gridView1.Appearance.DetailTip.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.Empty.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.Empty.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.Empty.Options.UseBorderColor = true;
            this.gridView1.Appearance.Empty.Options.UseForeColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FilterPanel.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FocusedCell.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HorzLine.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HorzLine.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.HorzLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.HorzLine.Options.UseForeColor = true;
            this.gridView1.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HotTrackedRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.HotTrackedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.NoSearchResults.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.NoSearchResults.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.NoSearchResults.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.NoSearchResults.Options.UseBackColor = true;
            this.gridView1.Appearance.NoSearchResults.Options.UseBorderColor = true;
            this.gridView1.Appearance.NoSearchResults.Options.UseForeColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.Preview.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseBorderColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.RowSeparator.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.Options.UseBorderColor = true;
            this.gridView1.Appearance.RowSeparator.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.TopNewRow.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.VertLine.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.VertLine.Options.UseForeColor = true;
            this.gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.ViewCaption.BorderColor = System.Drawing.Color.LavenderBlush;
            this.gridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CompanyName";
            this.gridColumn2.FieldName = "CompanyName";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 348;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "LastOrderDate";
            this.gridColumn3.FieldName = "LastOrderDate";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 209;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ContactNumber";
            this.gridColumn6.FieldName = "ContactNumber";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 198;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Address";
            this.gridColumn4.FieldName = "Address";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 260;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Country";
            this.gridColumn5.FieldName = "Country";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 234;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 169;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(130, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Code:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ContactNumber:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(110, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Country:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(109, 205);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 19);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Address:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 19);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "CompanyName:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(65, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(107, 19);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "LastOrderDate:";
            // 
            // CodeField
            // 
            this.CodeField.Location = new System.Drawing.Point(178, 37);
            this.CodeField.Name = "CodeField";
            this.CodeField.Size = new System.Drawing.Size(131, 26);
            this.CodeField.TabIndex = 8;
            // 
            // CompanyNameField
            // 
            this.CompanyNameField.Location = new System.Drawing.Point(178, 79);
            this.CompanyNameField.Name = "CompanyNameField";
            this.CompanyNameField.Size = new System.Drawing.Size(397, 26);
            this.CompanyNameField.TabIndex = 9;
            // 
            // CountryField
            // 
            this.CountryField.Location = new System.Drawing.Point(178, 164);
            this.CountryField.Name = "CountryField";
            this.CountryField.Size = new System.Drawing.Size(150, 26);
            this.CountryField.TabIndex = 10;
            // 
            // AddressField
            // 
            this.AddressField.Location = new System.Drawing.Point(178, 202);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(184, 26);
            this.AddressField.TabIndex = 11;
            // 
            // ContactNumberField
            // 
            this.ContactNumberField.Location = new System.Drawing.Point(178, 121);
            this.ContactNumberField.Name = "ContactNumberField";
            this.ContactNumberField.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.ContactNumberField.Properties.MaskSettings.Set("mask", "000-000-000");
            this.ContactNumberField.Properties.UseMaskAsDisplayFormat = true;
            this.ContactNumberField.Size = new System.Drawing.Size(131, 26);
            this.ContactNumberField.TabIndex = 12;
            // 
            // LastOrderDateField
            // 
            this.LastOrderDateField.EditValue = null;
            this.LastOrderDateField.Location = new System.Drawing.Point(178, 242);
            this.LastOrderDateField.Name = "LastOrderDateField";
            this.LastOrderDateField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LastOrderDateField.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LastOrderDateField.Size = new System.Drawing.Size(184, 26);
            this.LastOrderDateField.TabIndex = 14;
            // 
            // DeleteButton
            // 
            this.DeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageOptions.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(560, 346);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteButton.Size = new System.Drawing.Size(115, 34);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.ImageOptions.Image")));
            this.SaveButton.Location = new System.Drawing.Point(46, 346);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveButton.Size = new System.Drawing.Size(115, 34);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.ImageOptions.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(439, 346);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateButton.Size = new System.Drawing.Size(115, 34);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.ImageOptions.Image")));
            this.ClearButton.Location = new System.Drawing.Point(167, 346);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClearButton.Size = new System.Drawing.Size(115, 34);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(0, 0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(0, 19);
            this.labelControl7.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(516, 321);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 19);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Modify Data";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(110, 321);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(102, 19);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Add New Data";
            // 
            // CountryChart
            // 
            this.CountryChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryChart.BackColor = System.Drawing.Color.White;
            this.CountryChart.Legend.BackColor = System.Drawing.Color.White;
            this.CountryChart.Location = new System.Drawing.Point(919, 17);
            this.CountryChart.Name = "CountryChart";
            this.CountryChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CountryChart.SeriesTemplate.View = doughnutSeriesView1;
            this.CountryChart.Size = new System.Drawing.Size(610, 363);
            this.CountryChart.TabIndex = 21;
            this.CountryChart.Click += new System.EventHandler(this.CountryChart_Click);
            // 
            // RefreshChartButton
            // 
            this.RefreshChartButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreshChartButton.ImageOptions.Image")));
            this.RefreshChartButton.Location = new System.Drawing.Point(690, 17);
            this.RefreshChartButton.Name = "RefreshChartButton";
            this.RefreshChartButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RefreshChartButton.Size = new System.Drawing.Size(182, 34);
            this.RefreshChartButton.TabIndex = 22;
            this.RefreshChartButton.Text = "Debug Refresh Chart";
            this.RefreshChartButton.Visible = false;
            this.RefreshChartButton.Click += new System.EventHandler(this.RefreshChartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.RefreshChartButton);
            this.Controls.Add(this.CountryChart);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LastOrderDateField);
            this.Controls.Add(this.ContactNumberField);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.CountryField);
            this.Controls.Add(this.CompanyNameField);
            this.Controls.Add(this.CodeField);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerniCRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumberField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastOrderDateField.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastOrderDateField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit CodeField;
        private DevExpress.XtraEditors.TextEdit CompanyNameField;
        private DevExpress.XtraEditors.TextEdit CountryField;
        private DevExpress.XtraEditors.TextEdit AddressField;
        private DevExpress.XtraEditors.TextEdit ContactNumberField;
        private DevExpress.XtraEditors.DateEdit LastOrderDateField;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraEditors.SimpleButton ClearButton;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraCharts.ChartControl CountryChart;
        private DevExpress.XtraEditors.SimpleButton RefreshChartButton;
    }
}

