namespace FenixDatabaseSoftware
{
    partial class FormHome
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Link");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.office2013LightTheme = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.gbSoftware = new Telerik.WinControls.UI.RadGroupBox();
            this.lvSoftware = new Telerik.WinControls.UI.RadListView();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.btnUp = new Telerik.WinControls.UI.RadButton();
            this.btnDown = new Telerik.WinControls.UI.RadButton();
            this.cmOptions = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.miEditName = new Telerik.WinControls.UI.RadMenuItem();
            this.miEditLink = new Telerik.WinControls.UI.RadMenuItem();
            this.miDelete = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbSoftware)).BeginInit();
            this.gbSoftware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSoftware
            // 
            this.gbSoftware.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbSoftware.Controls.Add(this.lvSoftware);
            this.gbSoftware.HeaderText = "Software";
            this.gbSoftware.Location = new System.Drawing.Point(21, 27);
            this.gbSoftware.Name = "gbSoftware";
            this.gbSoftware.Size = new System.Drawing.Size(458, 203);
            this.gbSoftware.TabIndex = 0;
            this.gbSoftware.Text = "Software";
            this.gbSoftware.ThemeName = "Office2013Light";
            // 
            // lvSoftware
            // 
            listViewDetailColumn1.HeaderText = "Name";
            listViewDetailColumn2.HeaderText = "Link";
            this.lvSoftware.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2});
            this.lvSoftware.ItemSpacing = -1;
            this.lvSoftware.Location = new System.Drawing.Point(23, 33);
            this.lvSoftware.Name = "lvSoftware";
            this.lvSoftware.Size = new System.Drawing.Size(405, 142);
            this.lvSoftware.TabIndex = 0;
            this.lvSoftware.Text = "radListView1";
            this.lvSoftware.ThemeName = "Office2013Light";
            this.lvSoftware.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvSoftware.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSoftware_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeName = "Office2013Light";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(137, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 24);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ThemeName = "Office2013Light";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ThemeName = "Office2013Light";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "Office2013Light";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(485, 251);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 24);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.ThemeName = "Office2013Light";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(495, 81);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(110, 24);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Up";
            this.btnUp.ThemeName = "Office2013Light";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(495, 123);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(110, 24);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Down";
            this.btnDown.ThemeName = "Office2013Light";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // cmOptions
            // 
            this.cmOptions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miEdit,
            this.miDelete});
            this.cmOptions.ThemeName = "Office2013Light";
            // 
            // miEdit
            // 
            this.miEdit.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miEditName,
            this.miEditLink});
            this.miEdit.Name = "miEdit";
            this.miEdit.Text = "Edit";
            // 
            // miEditName
            // 
            this.miEditName.Name = "miEditName";
            this.miEditName.Text = "Name";
            // 
            // miEditLink
            // 
            this.miEditLink.Name = "miEditLink";
            this.miEditLink.Text = "Link";
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Text = "Delete";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 299);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSoftware);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Fenix Database Software 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbSoftware)).EndInit();
            this.gbSoftware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme;
        private Telerik.WinControls.UI.RadGroupBox gbSoftware;
        private Telerik.WinControls.UI.RadListView lvSoftware;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadButton btnUp;
        private Telerik.WinControls.UI.RadButton btnDown;
        private Telerik.WinControls.UI.RadContextMenu cmOptions;
        private Telerik.WinControls.UI.RadMenuItem miEdit;
        private Telerik.WinControls.UI.RadMenuItem miEditName;
        private Telerik.WinControls.UI.RadMenuItem miEditLink;
        private Telerik.WinControls.UI.RadMenuItem miDelete;
    }
}