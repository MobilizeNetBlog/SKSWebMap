
namespace SKS
{
	partial class frmAddStockManual
	{

		#region "Upgrade Support "
		private static frmAddStockManual m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAddStockManual DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmAddStockManual CreateInstance()
		{
			frmAddStockManual theInstance = new frmAddStockManual();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdSave", "cmdClose", "sbStatusBar_Panels_Panel1", "sbStatusBar", "txtUnit", "txtProductName", "txtQuantityPerUnit", "_txtValues_2", "_txtValues_1", "_txtValues_0", "cmdProducts", "txtName", "txtCode", "Label4", "Label5", "Frame1", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "lblNewQuantity", "Label10", "Label9", "Label8", "Label7", "Label6", "Label1", "Label2", "Label3", "txtValues", "listViewHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.TextBox txtUnit;
		public System.Windows.Forms.TextBox txtProductName;
		public System.Windows.Forms.TextBox txtQuantityPerUnit;
		private System.Windows.Forms.TextBox _txtValues_2;
		private System.Windows.Forms.TextBox _txtValues_1;
		private System.Windows.Forms.TextBox _txtValues_0;
		public System.Windows.Forms.Button cmdProducts;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvProducts;
		public System.Windows.Forms.Label lblNewQuantity;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.TextBox[] txtValues = new System.Windows.Forms.TextBox[3];
		public UpgradeHelpers.Gui.ListViewHelper listViewHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStockManual));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.sbStatusBar = new System.Windows.Forms.StatusStrip();
			this.sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
			this._txtValues_2 = new System.Windows.Forms.TextBox();
			this._txtValues_1 = new System.Windows.Forms.TextBox();
			this._txtValues_0 = new System.Windows.Forms.TextBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.cmdProducts = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.lvProducts = new System.Windows.Forms.ListView();
			this.lvProducts_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			this.lblNewQuantity = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.sbStatusBar.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.lvProducts.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			// 
			// cmdSave
			// 
			this.cmdSave.AllowDrop = true;
			this.cmdSave.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSave.Location = new System.Drawing.Point(224, 376);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSave.Size = new System.Drawing.Size(89, 25);
			this.cmdSave.TabIndex = 24;
			this.cmdSave.Text = "&Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdClose
			// 
			this.cmdClose.AllowDrop = true;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Location = new System.Drawing.Point(328, 376);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(89, 25);
			this.cmdClose.TabIndex = 23;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// sbStatusBar
			// 
			this.sbStatusBar.AllowDrop = true;
			this.sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbStatusBar.Location = new System.Drawing.Point(0, 416);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.ShowItemToolTips = true;
			this.sbStatusBar.Size = new System.Drawing.Size(424, 23);
			this.sbStatusBar.TabIndex = 20;
			this.sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			this.sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			this.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			this.sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(423, 23);
			this.sbStatusBar_Panels_Panel1.Spring = true;
			this.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// txtUnit
			// 
			this.txtUnit.AcceptsReturn = true;
			this.txtUnit.AllowDrop = true;
			this.txtUnit.BackColor = System.Drawing.SystemColors.Menu;
			this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUnit.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtUnit.Location = new System.Drawing.Point(320, 264);
			this.txtUnit.MaxLength = 0;
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.ReadOnly = true;
			this.txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtUnit.Size = new System.Drawing.Size(81, 20);
			this.txtUnit.TabIndex = 18;
			this.txtUnit.TabStop = false;
			// 
			// txtProductName
			// 
			this.txtProductName.AcceptsReturn = true;
			this.txtProductName.AllowDrop = true;
			this.txtProductName.BackColor = System.Drawing.SystemColors.Menu;
			this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtProductName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtProductName.Location = new System.Drawing.Point(96, 264);
			this.txtProductName.MaxLength = 0;
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.ReadOnly = true;
			this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtProductName.Size = new System.Drawing.Size(145, 20);
			this.txtProductName.TabIndex = 16;
			this.txtProductName.TabStop = false;
			// 
			// txtQuantityPerUnit
			// 
			this.txtQuantityPerUnit.AcceptsReturn = true;
			this.txtQuantityPerUnit.AllowDrop = true;
			this.txtQuantityPerUnit.BackColor = System.Drawing.SystemColors.Menu;
			this.txtQuantityPerUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtQuantityPerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtQuantityPerUnit.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtQuantityPerUnit.Location = new System.Drawing.Point(320, 296);
			this.txtQuantityPerUnit.MaxLength = 0;
			this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
			this.txtQuantityPerUnit.ReadOnly = true;
			this.txtQuantityPerUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtQuantityPerUnit.Size = new System.Drawing.Size(81, 20);
			this.txtQuantityPerUnit.TabIndex = 15;
			this.txtQuantityPerUnit.TabStop = false;
			this.txtQuantityPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _txtValues_2
			// 
			this._txtValues_2.AcceptsReturn = true;
			this._txtValues_2.AllowDrop = true;
			this._txtValues_2.BackColor = System.Drawing.SystemColors.Window;
			this._txtValues_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtValues_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtValues_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtValues_2.Location = new System.Drawing.Point(320, 328);
			this._txtValues_2.MaxLength = 0;
			this._txtValues_2.Name = "_txtValues_2";
			this._txtValues_2.ReadOnly = true;
			this._txtValues_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtValues_2.Size = new System.Drawing.Size(81, 20);
			this._txtValues_2.TabIndex = 5;
			this._txtValues_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtValues_2.Enter += new System.EventHandler(this.txtValues_Enter);
			this._txtValues_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValues_KeyPress);
			this._txtValues_2.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
			// 
			// _txtValues_1
			// 
			this._txtValues_1.AcceptsReturn = true;
			this._txtValues_1.AllowDrop = true;
			this._txtValues_1.BackColor = System.Drawing.SystemColors.Window;
			this._txtValues_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtValues_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtValues_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtValues_1.Location = new System.Drawing.Point(96, 328);
			this._txtValues_1.MaxLength = 0;
			this._txtValues_1.Name = "_txtValues_1";
			this._txtValues_1.ReadOnly = true;
			this._txtValues_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtValues_1.Size = new System.Drawing.Size(81, 20);
			this._txtValues_1.TabIndex = 4;
			this._txtValues_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtValues_1.Enter += new System.EventHandler(this.txtValues_Enter);
			this._txtValues_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValues_KeyPress);
			this._txtValues_1.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
			// 
			// _txtValues_0
			// 
			this._txtValues_0.AcceptsReturn = true;
			this._txtValues_0.AllowDrop = true;
			this._txtValues_0.BackColor = System.Drawing.SystemColors.Window;
			this._txtValues_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtValues_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtValues_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtValues_0.Location = new System.Drawing.Point(96, 296);
			this._txtValues_0.MaxLength = 0;
			this._txtValues_0.Name = "_txtValues_0";
			this._txtValues_0.ReadOnly = true;
			this._txtValues_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtValues_0.Size = new System.Drawing.Size(81, 20);
			this._txtValues_0.TabIndex = 3;
			this._txtValues_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtValues_0.Enter += new System.EventHandler(this.txtValues_Enter);
			this._txtValues_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValues_KeyPress);
			this._txtValues_0.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.cmdProducts);
			this.Frame1.Controls.Add(this.txtName);
			this.Frame1.Controls.Add(this.txtCode);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 32);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(409, 65);
			this.Frame1.TabIndex = 6;
			this.Frame1.Text = "Search product ";
			this.Frame1.Visible = true;
			// 
			// cmdProducts
			// 
			this.cmdProducts.AllowDrop = true;
			this.cmdProducts.BackColor = System.Drawing.SystemColors.Control;
			this.cmdProducts.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdProducts.Location = new System.Drawing.Point(360, 16);
			this.cmdProducts.Name = "cmdProducts";
			this.cmdProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdProducts.Size = new System.Drawing.Size(25, 21);
			this.cmdProducts.TabIndex = 7;
			this.cmdProducts.TabStop = false;
			this.cmdProducts.Text = "...";
			this.cmdProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdProducts.UseVisualStyleBackColor = false;
			this.cmdProducts.Click += new System.EventHandler(this.cmdProducts_Click);
			// 
			// txtName
			// 
			this.txtName.AcceptsReturn = true;
			this.txtName.AllowDrop = true;
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtName.Location = new System.Drawing.Point(112, 40);
			this.txtName.MaxLength = 0;
			this.txtName.Name = "txtName";
			this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtName.Size = new System.Drawing.Size(145, 20);
			this.txtName.TabIndex = 1;
			this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtCode
			// 
			this.txtCode.AcceptsReturn = true;
			this.txtCode.AllowDrop = true;
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCode.Location = new System.Drawing.Point(112, 16);
			this.txtCode.MaxLength = 0;
			this.txtCode.Name = "txtCode";
			this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCode.Size = new System.Drawing.Size(97, 20);
			this.txtCode.TabIndex = 0;
			this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
			this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(16, 40);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Name ";
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(16, 16);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Code";
			// 
			// lvProducts
			// 
			this.lvProducts.AllowDrop = true;
			this.lvProducts.BackColor = System.Drawing.SystemColors.Window;
			this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lvProducts.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lvProducts.FullRowSelect = true;
			this.lvProducts.GridLines = true;
			this.lvProducts.HideSelection = false;
			this.lvProducts.HotTracking = true;
			this.lvProducts.LabelEdit = false;
			this.lvProducts.Location = new System.Drawing.Point(8, 104);
			this.lvProducts.MultiSelect = false;
			this.lvProducts.Name = "lvProducts";
			this.lvProducts.Size = new System.Drawing.Size(409, 153);
			this.lvProducts.TabIndex = 2;
			this.lvProducts.View = System.Windows.Forms.View.Details;
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_1_);
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_2_);
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_3_);
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_4_);
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_5_);
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_6_);
			this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_7_);
			this.lvProducts.Click += new System.EventHandler(this.lvProducts_Click);
			// 
			// lvProducts_ColumnHeader_1_
			// 
			this.lvProducts_ColumnHeader_1_.Text = "Code";
			this.lvProducts_ColumnHeader_1_.Width = 97;
			// 
			// lvProducts_ColumnHeader_2_
			// 
			this.lvProducts_ColumnHeader_2_.Text = "Name";
			this.lvProducts_ColumnHeader_2_.Width = 97;
			// 
			// lvProducts_ColumnHeader_3_
			// 
			this.lvProducts_ColumnHeader_3_.Text = "Price";
			this.lvProducts_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_3_.Width = 97;
			// 
			// lvProducts_ColumnHeader_4_
			// 
			this.lvProducts_ColumnHeader_4_.Text = "Existence";
			this.lvProducts_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_4_.Width = 97;
			// 
			// lvProducts_ColumnHeader_5_
			// 
			this.lvProducts_ColumnHeader_5_.Text = "Ordered";
			this.lvProducts_ColumnHeader_5_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_5_.Width = 97;
			// 
			// lvProducts_ColumnHeader_6_
			// 
			this.lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
			this.lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_6_.Width = 97;
			// 
			// lvProducts_ColumnHeader_7_
			// 
			this.lvProducts_ColumnHeader_7_.Text = "Unit";
			this.lvProducts_ColumnHeader_7_.Width = 97;
			// 
			// lblNewQuantity
			// 
			this.lblNewQuantity.AllowDrop = true;
			this.lblNewQuantity.BackColor = System.Drawing.SystemColors.Control;
			this.lblNewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblNewQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNewQuantity.Location = new System.Drawing.Point(104, 363);
			this.lblNewQuantity.Name = "lblNewQuantity";
			this.lblNewQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNewQuantity.Size = new System.Drawing.Size(89, 17);
			this.lblNewQuantity.TabIndex = 22;
			// 
			// Label10
			// 
			this.Label10.AllowDrop = true;
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(8, 363);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(73, 17);
			this.Label10.TabIndex = 21;
			this.Label10.Text = "Stock quantity";
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(288, 264);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(25, 17);
			this.Label9.TabIndex = 19;
			this.Label9.Text = "Unit";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 264);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(74, 17);
			this.Label8.TabIndex = 17;
			this.Label8.Text = "Product";
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(224, 296);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(89, 17);
			this.Label7.TabIndex = 14;
			this.Label7.Text = "Units";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(224, 331);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(73, 17);
			this.Label6.TabIndex = 13;
			this.Label6.Text = "Unit Price";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 331);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(73, 17);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Price";
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 299);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(74, 17);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Quantity";
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(16, 8);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(121, 17);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Select a product first";
			// 
			// frmAddStockManual
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(424, 439);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.sbStatusBar);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.txtQuantityPerUnit);
			this.Controls.Add(this._txtValues_2);
			this.Controls.Add(this._txtValues_1);
			this.Controls.Add(this._txtValues_0);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.lvProducts);
			this.Controls.Add(this.lblNewQuantity);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 25);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddStockManual";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Inventory Update";
			this.Activated += new System.EventHandler(this.frmAddStockManual_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
			this.listViewHelper1.SetItemClickMethod(this.lvProducts, "lvProducts_ItemClick");
			this.listViewHelper1.SetCorrectEventsBehavior(this.lvProducts, true);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
			this.sbStatusBar.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.lvProducts.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializetxtValues();
			//This form is an MDI child.
			//This code simulates the VB6 
			// functionality of automatically
			// loading and showing an MDI
			// child's parent.
			this.MdiParent = SKS.frmMain.DefInstance;
			SKS.frmMain.DefInstance.Show();
		}
		void InitializetxtValues()
		{
			this.txtValues = new System.Windows.Forms.TextBox[3];
			this.txtValues[2] = _txtValues_2;
			this.txtValues[1] = _txtValues_1;
			this.txtValues[0] = _txtValues_0;
		}
		#endregion
	}
}