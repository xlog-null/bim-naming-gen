namespace bim_naming_generator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlFormPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lblOriginator = new System.Windows.Forms.Label();
            this.lblVolumeOrSystem = new System.Windows.Forms.Label();
            this.lblLevelsAndLocations = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.cbOriginator = new System.Windows.Forms.ComboBox();
            this.cbFunctionalBreakdown = new System.Windows.Forms.ComboBox();
            this.cbSpatialBreakdown = new System.Windows.Forms.ComboBox();
            this.cbForm = new System.Windows.Forms.ComboBox();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pbProjectCode = new System.Windows.Forms.PictureBox();
            this.cbProjectCode = new System.Windows.Forms.ComboBox();
            this.pbOriginator = new System.Windows.Forms.PictureBox();
            this.pbFunctionalBreakdown = new System.Windows.Forms.PictureBox();
            this.pbSpatialBreakdown = new System.Windows.Forms.PictureBox();
            this.pbForm = new System.Windows.Forms.PictureBox();
            this.pbDiscipline = new System.Windows.Forms.PictureBox();
            this.tlFormActionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.tlClaimCopyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClaim = new System.Windows.Forms.Button();
            this.tlInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExpandClaimed = new System.Windows.Forms.Button();
            this.tlClaimedPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lvClaimed = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClaimDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblClaimedPanel = new System.Windows.Forms.Label();
            this.flMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tlFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFunctionalBreakdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpatialBreakdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscipline)).BeginInit();
            this.tlFormActionPanel.SuspendLayout();
            this.tlClaimCopyPanel.SuspendLayout();
            this.tlInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.tlClaimedPanel.SuspendLayout();
            this.flMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlFormPanel
            // 
            this.tlFormPanel.AutoSize = true;
            this.tlFormPanel.ColumnCount = 4;
            this.tlFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlFormPanel.Controls.Add(this.lblProjectCode, 1, 0);
            this.tlFormPanel.Controls.Add(this.lblOriginator, 1, 1);
            this.tlFormPanel.Controls.Add(this.lblVolumeOrSystem, 1, 2);
            this.tlFormPanel.Controls.Add(this.lblLevelsAndLocations, 1, 3);
            this.tlFormPanel.Controls.Add(this.lblType, 1, 4);
            this.tlFormPanel.Controls.Add(this.lblRole, 1, 5);
            this.tlFormPanel.Controls.Add(this.label2, 0, 5);
            this.tlFormPanel.Controls.Add(this.lblNumber, 1, 6);
            this.tlFormPanel.Controls.Add(this.cbOriginator, 2, 1);
            this.tlFormPanel.Controls.Add(this.cbFunctionalBreakdown, 2, 2);
            this.tlFormPanel.Controls.Add(this.cbSpatialBreakdown, 2, 3);
            this.tlFormPanel.Controls.Add(this.cbForm, 2, 4);
            this.tlFormPanel.Controls.Add(this.cbDiscipline, 2, 5);
            this.tlFormPanel.Controls.Add(this.tbNumber, 2, 6);
            this.tlFormPanel.Controls.Add(this.btnGenerate, 3, 6);
            this.tlFormPanel.Controls.Add(this.pbProjectCode, 3, 0);
            this.tlFormPanel.Controls.Add(this.cbProjectCode, 2, 0);
            this.tlFormPanel.Controls.Add(this.pbOriginator, 3, 1);
            this.tlFormPanel.Controls.Add(this.pbFunctionalBreakdown, 3, 2);
            this.tlFormPanel.Controls.Add(this.pbSpatialBreakdown, 3, 3);
            this.tlFormPanel.Controls.Add(this.pbForm, 3, 4);
            this.tlFormPanel.Controls.Add(this.pbDiscipline, 3, 5);
            this.tlFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlFormPanel.Location = new System.Drawing.Point(2, 2);
            this.tlFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tlFormPanel.Name = "tlFormPanel";
            this.tlFormPanel.RowCount = 7;
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlFormPanel.Size = new System.Drawing.Size(823, 252);
            this.tlFormPanel.TabIndex = 1;
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectCode.Location = new System.Drawing.Point(125, 0);
            this.lblProjectCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(160, 36);
            this.lblProjectCode.TabIndex = 1;
            this.lblProjectCode.Text = "Project Code";
            this.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginator
            // 
            this.lblOriginator.AutoSize = true;
            this.lblOriginator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOriginator.Location = new System.Drawing.Point(125, 36);
            this.lblOriginator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOriginator.Name = "lblOriginator";
            this.lblOriginator.Size = new System.Drawing.Size(160, 36);
            this.lblOriginator.TabIndex = 2;
            this.lblOriginator.Text = "Originator";
            this.lblOriginator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolumeOrSystem
            // 
            this.lblVolumeOrSystem.AutoSize = true;
            this.lblVolumeOrSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVolumeOrSystem.Location = new System.Drawing.Point(125, 72);
            this.lblVolumeOrSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeOrSystem.Name = "lblVolumeOrSystem";
            this.lblVolumeOrSystem.Size = new System.Drawing.Size(160, 36);
            this.lblVolumeOrSystem.TabIndex = 3;
            this.lblVolumeOrSystem.Text = "Functional Break-down";
            this.lblVolumeOrSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevelsAndLocations
            // 
            this.lblLevelsAndLocations.AutoSize = true;
            this.lblLevelsAndLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLevelsAndLocations.Location = new System.Drawing.Point(125, 108);
            this.lblLevelsAndLocations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevelsAndLocations.Name = "lblLevelsAndLocations";
            this.lblLevelsAndLocations.Size = new System.Drawing.Size(160, 36);
            this.lblLevelsAndLocations.TabIndex = 4;
            this.lblLevelsAndLocations.Text = "Spatial Break-down";
            this.lblLevelsAndLocations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(125, 144);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(160, 36);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Form";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Location = new System.Drawing.Point(125, 180);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(160, 36);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Discipline";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 2);
            this.label2.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumber.Location = new System.Drawing.Point(125, 216);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(160, 36);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Number";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbOriginator
            // 
            this.cbOriginator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOriginator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOriginator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOriginator.FormattingEnabled = true;
            this.cbOriginator.Location = new System.Drawing.Point(289, 43);
            this.cbOriginator.Margin = new System.Windows.Forms.Padding(2);
            this.cbOriginator.Name = "cbOriginator";
            this.cbOriginator.Size = new System.Drawing.Size(407, 21);
            this.cbOriginator.TabIndex = 9;
            this.cbOriginator.Tag = "originator";
            this.cbOriginator.TextChanged += new System.EventHandler(this.OnFieldInput);
            // 
            // cbFunctionalBreakdown
            // 
            this.cbFunctionalBreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFunctionalBreakdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFunctionalBreakdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFunctionalBreakdown.FormattingEnabled = true;
            this.cbFunctionalBreakdown.Location = new System.Drawing.Point(289, 79);
            this.cbFunctionalBreakdown.Margin = new System.Windows.Forms.Padding(2);
            this.cbFunctionalBreakdown.Name = "cbFunctionalBreakdown";
            this.cbFunctionalBreakdown.Size = new System.Drawing.Size(407, 21);
            this.cbFunctionalBreakdown.TabIndex = 10;
            this.cbFunctionalBreakdown.Tag = "functional_breakdown";
            this.cbFunctionalBreakdown.TextChanged += new System.EventHandler(this.OnFieldInput);
            // 
            // cbSpatialBreakdown
            // 
            this.cbSpatialBreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpatialBreakdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSpatialBreakdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSpatialBreakdown.FormattingEnabled = true;
            this.cbSpatialBreakdown.Location = new System.Drawing.Point(289, 115);
            this.cbSpatialBreakdown.Margin = new System.Windows.Forms.Padding(2);
            this.cbSpatialBreakdown.Name = "cbSpatialBreakdown";
            this.cbSpatialBreakdown.Size = new System.Drawing.Size(407, 21);
            this.cbSpatialBreakdown.TabIndex = 11;
            this.cbSpatialBreakdown.Tag = "spatial_breakdown";
            this.cbSpatialBreakdown.TextChanged += new System.EventHandler(this.OnFieldInput);
            // 
            // cbForm
            // 
            this.cbForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbForm.FormattingEnabled = true;
            this.cbForm.Location = new System.Drawing.Point(289, 151);
            this.cbForm.Margin = new System.Windows.Forms.Padding(2);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(407, 21);
            this.cbForm.TabIndex = 12;
            this.cbForm.Tag = "form";
            this.cbForm.TextChanged += new System.EventHandler(this.OnFieldInput);
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscipline.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDiscipline.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.Location = new System.Drawing.Point(289, 187);
            this.cbDiscipline.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(407, 21);
            this.cbDiscipline.TabIndex = 13;
            this.cbDiscipline.Tag = "discipline";
            this.cbDiscipline.TextChanged += new System.EventHandler(this.OnFieldInput);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNumber.Enabled = false;
            this.tbNumber.Location = new System.Drawing.Point(289, 224);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(407, 20);
            this.tbNumber.TabIndex = 15;
            this.tbNumber.Tag = "number";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(700, 218);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 32);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbProjectCode
            // 
            this.pbProjectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProjectCode.Image = ((System.Drawing.Image)(resources.GetObject("pbProjectCode.Image")));
            this.pbProjectCode.Location = new System.Drawing.Point(701, 3);
            this.pbProjectCode.Name = "pbProjectCode";
            this.pbProjectCode.Size = new System.Drawing.Size(119, 30);
            this.pbProjectCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProjectCode.TabIndex = 17;
            this.pbProjectCode.TabStop = false;
            this.pbProjectCode.Visible = false;
            // 
            // cbProjectCode
            // 
            this.cbProjectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjectCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProjectCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProjectCode.FormattingEnabled = true;
            this.cbProjectCode.Location = new System.Drawing.Point(289, 7);
            this.cbProjectCode.Margin = new System.Windows.Forms.Padding(2);
            this.cbProjectCode.Name = "cbProjectCode";
            this.cbProjectCode.Size = new System.Drawing.Size(407, 21);
            this.cbProjectCode.TabIndex = 8;
            this.cbProjectCode.Tag = "projectCode";
            this.cbProjectCode.SelectedValueChanged += new System.EventHandler(this.OnProjectCodeChanged);
            this.cbProjectCode.TextChanged += new System.EventHandler(this.OnFieldInput);
            // 
            // pbOriginator
            // 
            this.pbOriginator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOriginator.Image = ((System.Drawing.Image)(resources.GetObject("pbOriginator.Image")));
            this.pbOriginator.Location = new System.Drawing.Point(701, 39);
            this.pbOriginator.Name = "pbOriginator";
            this.pbOriginator.Size = new System.Drawing.Size(119, 30);
            this.pbOriginator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginator.TabIndex = 18;
            this.pbOriginator.TabStop = false;
            this.pbOriginator.Visible = false;
            // 
            // pbFunctionalBreakdown
            // 
            this.pbFunctionalBreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFunctionalBreakdown.Image = ((System.Drawing.Image)(resources.GetObject("pbFunctionalBreakdown.Image")));
            this.pbFunctionalBreakdown.Location = new System.Drawing.Point(701, 75);
            this.pbFunctionalBreakdown.Name = "pbFunctionalBreakdown";
            this.pbFunctionalBreakdown.Size = new System.Drawing.Size(119, 30);
            this.pbFunctionalBreakdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFunctionalBreakdown.TabIndex = 19;
            this.pbFunctionalBreakdown.TabStop = false;
            this.pbFunctionalBreakdown.Visible = false;
            // 
            // pbSpatialBreakdown
            // 
            this.pbSpatialBreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSpatialBreakdown.Image = ((System.Drawing.Image)(resources.GetObject("pbSpatialBreakdown.Image")));
            this.pbSpatialBreakdown.Location = new System.Drawing.Point(701, 111);
            this.pbSpatialBreakdown.Name = "pbSpatialBreakdown";
            this.pbSpatialBreakdown.Size = new System.Drawing.Size(119, 30);
            this.pbSpatialBreakdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpatialBreakdown.TabIndex = 20;
            this.pbSpatialBreakdown.TabStop = false;
            this.pbSpatialBreakdown.Visible = false;
            // 
            // pbForm
            // 
            this.pbForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbForm.Image = ((System.Drawing.Image)(resources.GetObject("pbForm.Image")));
            this.pbForm.Location = new System.Drawing.Point(701, 147);
            this.pbForm.Name = "pbForm";
            this.pbForm.Size = new System.Drawing.Size(119, 30);
            this.pbForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForm.TabIndex = 21;
            this.pbForm.TabStop = false;
            this.pbForm.Visible = false;
            // 
            // pbDiscipline
            // 
            this.pbDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("pbDiscipline.Image")));
            this.pbDiscipline.Location = new System.Drawing.Point(701, 183);
            this.pbDiscipline.Name = "pbDiscipline";
            this.pbDiscipline.Size = new System.Drawing.Size(119, 30);
            this.pbDiscipline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiscipline.TabIndex = 22;
            this.pbDiscipline.TabStop = false;
            this.pbDiscipline.Visible = false;
            // 
            // tlFormActionPanel
            // 
            this.tlFormActionPanel.AutoSize = true;
            this.tlFormActionPanel.ColumnCount = 1;
            this.tlFormActionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlFormActionPanel.Controls.Add(this.lblFileName, 0, 0);
            this.tlFormActionPanel.Controls.Add(this.tlClaimCopyPanel, 0, 1);
            this.tlFormActionPanel.Controls.Add(this.tlInfoPanel, 0, 2);
            this.tlFormActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlFormActionPanel.Location = new System.Drawing.Point(830, 3);
            this.tlFormActionPanel.Name = "tlFormActionPanel";
            this.tlFormActionPanel.RowCount = 3;
            this.tlFormActionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlFormActionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlFormActionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlFormActionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlFormActionPanel.Size = new System.Drawing.Size(821, 117);
            this.tlFormActionPanel.TabIndex = 9;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(2, 9);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(817, 20);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "E21356-EHL-XX-XX-GU-XX-000001";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlClaimCopyPanel
            // 
            this.tlClaimCopyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlClaimCopyPanel.ColumnCount = 2;
            this.tlClaimCopyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlClaimCopyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlClaimCopyPanel.Controls.Add(this.btnCopy, 0, 0);
            this.tlClaimCopyPanel.Controls.Add(this.btnClaim, 0, 0);
            this.tlClaimCopyPanel.Location = new System.Drawing.Point(3, 41);
            this.tlClaimCopyPanel.Name = "tlClaimCopyPanel";
            this.tlClaimCopyPanel.RowCount = 1;
            this.tlClaimCopyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlClaimCopyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlClaimCopyPanel.Size = new System.Drawing.Size(815, 33);
            this.tlClaimCopyPanel.TabIndex = 11;
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(427, 2);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(86, 29);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy file name";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnClaim
            // 
            this.btnClaim.AutoSize = true;
            this.btnClaim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClaim.Enabled = false;
            this.btnClaim.Location = new System.Drawing.Point(300, 2);
            this.btnClaim.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(87, 29);
            this.btnClaim.TabIndex = 1;
            this.btnClaim.Text = "Claim file name";
            this.btnClaim.UseVisualStyleBackColor = true;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // tlInfoPanel
            // 
            this.tlInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlInfoPanel.ColumnCount = 3;
            this.tlInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlInfoPanel.Controls.Add(this.pbLoading, 0, 0);
            this.tlInfoPanel.Controls.Add(this.lblInfo, 1, 0);
            this.tlInfoPanel.Controls.Add(this.btnExpandClaimed, 2, 0);
            this.tlInfoPanel.Location = new System.Drawing.Point(3, 80);
            this.tlInfoPanel.Name = "tlInfoPanel";
            this.tlInfoPanel.RowCount = 1;
            this.tlInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInfoPanel.Size = new System.Drawing.Size(815, 34);
            this.tlInfoPanel.TabIndex = 9;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.SystemColors.Control;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(3, 3);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(24, 24);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 8;
            this.pbLoading.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(83, 0);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(648, 34);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // btnExpandClaimed
            // 
            this.btnExpandClaimed.BackColor = System.Drawing.SystemColors.Control;
            this.btnExpandClaimed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpandClaimed.Location = new System.Drawing.Point(736, 3);
            this.btnExpandClaimed.Name = "btnExpandClaimed";
            this.btnExpandClaimed.Size = new System.Drawing.Size(76, 28);
            this.btnExpandClaimed.TabIndex = 9;
            this.btnExpandClaimed.Text = "History";
            this.btnExpandClaimed.UseVisualStyleBackColor = false;
            this.btnExpandClaimed.Click += new System.EventHandler(this.btnExpandClaimed_Click);
            // 
            // tlClaimedPanel
            // 
            this.tlClaimedPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tlClaimedPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlClaimedPanel.ColumnCount = 1;
            this.tlClaimedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlClaimedPanel.Controls.Add(this.lvClaimed, 0, 1);
            this.tlClaimedPanel.Controls.Add(this.lblClaimedPanel, 0, 0);
            this.tlClaimedPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlClaimedPanel.Location = new System.Drawing.Point(0, 376);
            this.tlClaimedPanel.Name = "tlClaimedPanel";
            this.tlClaimedPanel.RowCount = 2;
            this.tlClaimedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlClaimedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlClaimedPanel.Size = new System.Drawing.Size(827, 222);
            this.tlClaimedPanel.TabIndex = 10;
            this.tlClaimedPanel.Visible = false;
            // 
            // lvClaimed
            // 
            this.lvClaimed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClaimed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chClaimDate});
            this.lvClaimed.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClaimed.GridLines = true;
            this.lvClaimed.HideSelection = false;
            this.lvClaimed.Location = new System.Drawing.Point(5, 39);
            this.lvClaimed.Name = "lvClaimed";
            this.lvClaimed.Size = new System.Drawing.Size(817, 178);
            this.lvClaimed.TabIndex = 0;
            this.lvClaimed.UseCompatibleStateImageBehavior = false;
            this.lvClaimed.View = System.Windows.Forms.View.Details;
            this.lvClaimed.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvClaimed_ColumnClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 433;
            // 
            // chClaimDate
            // 
            this.chClaimDate.Text = "Claimed on";
            this.chClaimDate.Width = 379;
            // 
            // lblClaimedPanel
            // 
            this.lblClaimedPanel.AutoSize = true;
            this.lblClaimedPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimedPanel.Location = new System.Drawing.Point(5, 2);
            this.lblClaimedPanel.Name = "lblClaimedPanel";
            this.lblClaimedPanel.Size = new System.Drawing.Size(149, 17);
            this.lblClaimedPanel.TabIndex = 1;
            this.lblClaimedPanel.Text = "History of files claimed";
            // 
            // flMainPanel
            // 
            this.flMainPanel.AutoSize = true;
            this.flMainPanel.Controls.Add(this.tlFormPanel);
            this.flMainPanel.Controls.Add(this.tlFormActionPanel);
            this.flMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flMainPanel.Location = new System.Drawing.Point(0, 0);
            this.flMainPanel.Name = "flMainPanel";
            this.flMainPanel.Size = new System.Drawing.Size(827, 376);
            this.flMainPanel.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 598);
            this.Controls.Add(this.flMainPanel);
            this.Controls.Add(this.tlClaimedPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EHL File Name Generator";
            this.tlFormPanel.ResumeLayout(false);
            this.tlFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFunctionalBreakdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpatialBreakdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscipline)).EndInit();
            this.tlFormActionPanel.ResumeLayout(false);
            this.tlClaimCopyPanel.ResumeLayout(false);
            this.tlClaimCopyPanel.PerformLayout();
            this.tlInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.tlClaimedPanel.ResumeLayout(false);
            this.tlClaimedPanel.PerformLayout();
            this.flMainPanel.ResumeLayout(false);
            this.flMainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlFormPanel;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.Label lblOriginator;
        private System.Windows.Forms.Label lblVolumeOrSystem;
        private System.Windows.Forms.Label lblLevelsAndLocations;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOriginator;
        private System.Windows.Forms.ComboBox cbFunctionalBreakdown;
        private System.Windows.Forms.ComboBox cbSpatialBreakdown;
        private System.Windows.Forms.ComboBox cbForm;
        private System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.PictureBox pbProjectCode;
        private System.Windows.Forms.ComboBox cbProjectCode;
        private System.Windows.Forms.PictureBox pbOriginator;
        private System.Windows.Forms.PictureBox pbFunctionalBreakdown;
        private System.Windows.Forms.PictureBox pbSpatialBreakdown;
        private System.Windows.Forms.PictureBox pbForm;
        private System.Windows.Forms.PictureBox pbDiscipline;
        private System.Windows.Forms.TableLayoutPanel tlFormActionPanel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TableLayoutPanel tlClaimCopyPanel;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.TableLayoutPanel tlClaimedPanel;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.TableLayoutPanel tlInfoPanel;
        private System.Windows.Forms.ListView lvClaimed;
        private System.Windows.Forms.Label lblClaimedPanel;
        private System.Windows.Forms.Button btnExpandClaimed;
        private System.Windows.Forms.FlowLayoutPanel flMainPanel;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chClaimDate;
    }
}

