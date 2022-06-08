
namespace QuanLyDeTai.BoMon.ThongKe
{
    partial class THONGKE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THONGKE));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cmbLocBB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.ListBB = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.footerpanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnXM = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBB)).BeginInit();
            this.footerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.cmbLocBB);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.bunifuPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1180, 67);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // cmbLocBB
            // 
            this.bunifuTransition1.SetDecoration(this.cmbLocBB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.cmbLocBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocBB.FormattingEnabled = true;
            this.cmbLocBB.Items.AddRange(new object[] {
            "Tất cả",
            "Đã xác minh",
            "Chưa xác minh"});
            this.cmbLocBB.Location = new System.Drawing.Point(1024, 17);
            this.cmbLocBB.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocBB.Name = "cmbLocBB";
            this.cmbLocBB.Size = new System.Drawing.Size(125, 28);
            this.cmbLocBB.TabIndex = 2;
            this.cmbLocBB.SelectedIndexChanged += new System.EventHandler(this.cmbLocBB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(926, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lọc bài báo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách bài báo";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.ListBB);
            this.bunifuTransition1.SetDecoration(this.bunifuPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 67);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1180, 496);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // ListBB
            // 
            this.ListBB.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ListBB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListBB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListBB.BackgroundColor = System.Drawing.Color.White;
            this.ListBB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListBB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListBB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListBB.ColumnHeadersHeight = 40;
            this.ListBB.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ListBB.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListBB.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListBB.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ListBB.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ListBB.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.ListBB.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ListBB.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ListBB.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ListBB.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListBB.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.ListBB.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ListBB.CurrentTheme.Name = null;
            this.ListBB.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListBB.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListBB.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListBB.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ListBB.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.ListBB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListBB.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListBB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBB.EnableHeadersVisualStyles = false;
            this.ListBB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ListBB.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.ListBB.HeaderBgColor = System.Drawing.Color.Empty;
            this.ListBB.HeaderForeColor = System.Drawing.Color.White;
            this.ListBB.Location = new System.Drawing.Point(0, 0);
            this.ListBB.Margin = new System.Windows.Forms.Padding(2);
            this.ListBB.Name = "ListBB";
            this.ListBB.RowHeadersVisible = false;
            this.ListBB.RowHeadersWidth = 51;
            this.ListBB.RowTemplate.Height = 40;
            this.ListBB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListBB.Size = new System.Drawing.Size(1180, 496);
            this.ListBB.TabIndex = 0;
            this.ListBB.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.ListBB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBB_CellClick);
            // 
            // footerpanel
            // 
            this.footerpanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.footerpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("footerpanel.BackgroundImage")));
            this.footerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.footerpanel.BorderColor = System.Drawing.Color.Transparent;
            this.footerpanel.BorderRadius = 3;
            this.footerpanel.BorderThickness = 1;
            this.footerpanel.Controls.Add(this.btnXM);
            this.footerpanel.Controls.Add(this.btnXem);
            this.bunifuTransition1.SetDecoration(this.footerpanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.footerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerpanel.Location = new System.Drawing.Point(0, 509);
            this.footerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.footerpanel.Name = "footerpanel";
            this.footerpanel.ShowBorders = true;
            this.footerpanel.Size = new System.Drawing.Size(1180, 54);
            this.footerpanel.TabIndex = 2;
            // 
            // btnXM
            // 
            this.btnXM.AllowAnimations = true;
            this.btnXM.AllowMouseEffects = true;
            this.btnXM.AllowToggling = false;
            this.btnXM.AnimationSpeed = 200;
            this.btnXM.AutoGenerateColors = false;
            this.btnXM.AutoRoundBorders = false;
            this.btnXM.AutoSizeLeftIcon = true;
            this.btnXM.AutoSizeRightIcon = true;
            this.btnXM.BackColor = System.Drawing.Color.Transparent;
            this.btnXM.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXM.BackgroundImage")));
            this.btnXM.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXM.ButtonText = "Xác minh";
            this.btnXM.ButtonTextMarginLeft = 0;
            this.btnXM.ColorContrastOnClick = 45;
            this.btnXM.ColorContrastOnHover = 45;
            this.btnXM.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXM.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.btnXM, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnXM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXM.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXM.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXM.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXM.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXM.ForeColor = System.Drawing.Color.White;
            this.btnXM.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXM.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXM.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXM.IconMarginLeft = 11;
            this.btnXM.IconPadding = 10;
            this.btnXM.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXM.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXM.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXM.IconSize = 25;
            this.btnXM.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXM.IdleBorderRadius = 1;
            this.btnXM.IdleBorderThickness = 1;
            this.btnXM.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXM.IdleIconLeftImage = null;
            this.btnXM.IdleIconRightImage = null;
            this.btnXM.IndicateFocus = false;
            this.btnXM.Location = new System.Drawing.Point(662, 13);
            this.btnXM.Margin = new System.Windows.Forms.Padding(2);
            this.btnXM.Name = "btnXM";
            this.btnXM.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXM.OnDisabledState.BorderRadius = 1;
            this.btnXM.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXM.OnDisabledState.BorderThickness = 1;
            this.btnXM.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXM.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXM.OnDisabledState.IconLeftImage = null;
            this.btnXM.OnDisabledState.IconRightImage = null;
            this.btnXM.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXM.onHoverState.BorderRadius = 1;
            this.btnXM.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXM.onHoverState.BorderThickness = 1;
            this.btnXM.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXM.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXM.onHoverState.IconLeftImage = null;
            this.btnXM.onHoverState.IconRightImage = null;
            this.btnXM.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXM.OnIdleState.BorderRadius = 1;
            this.btnXM.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXM.OnIdleState.BorderThickness = 1;
            this.btnXM.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXM.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXM.OnIdleState.IconLeftImage = null;
            this.btnXM.OnIdleState.IconRightImage = null;
            this.btnXM.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXM.OnPressedState.BorderRadius = 1;
            this.btnXM.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXM.OnPressedState.BorderThickness = 1;
            this.btnXM.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXM.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXM.OnPressedState.IconLeftImage = null;
            this.btnXM.OnPressedState.IconRightImage = null;
            this.btnXM.Size = new System.Drawing.Size(68, 32);
            this.btnXM.TabIndex = 1;
            this.btnXM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXM.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXM.TextMarginLeft = 0;
            this.btnXM.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXM.UseDefaultRadiusAndThickness = true;
            this.btnXM.Click += new System.EventHandler(this.btnXM_Click);
            // 
            // btnXem
            // 
            this.btnXem.AllowAnimations = true;
            this.btnXem.AllowMouseEffects = true;
            this.btnXem.AllowToggling = false;
            this.btnXem.AnimationSpeed = 200;
            this.btnXem.AutoGenerateColors = false;
            this.btnXem.AutoRoundBorders = false;
            this.btnXem.AutoSizeLeftIcon = true;
            this.btnXem.AutoSizeRightIcon = true;
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXem.BackgroundImage")));
            this.btnXem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.ButtonText = "Xem";
            this.btnXem.ButtonTextMarginLeft = 0;
            this.btnXem.ColorContrastOnClick = 45;
            this.btnXem.ColorContrastOnHover = 45;
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnXem.CustomizableEdges = borderEdges2;
            this.bunifuTransition1.SetDecoration(this.btnXem, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnXem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXem.IconMarginLeft = 11;
            this.btnXem.IconPadding = 10;
            this.btnXem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXem.IconSize = 25;
            this.btnXem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXem.IdleBorderRadius = 1;
            this.btnXem.IdleBorderThickness = 1;
            this.btnXem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXem.IdleIconLeftImage = null;
            this.btnXem.IdleIconRightImage = null;
            this.btnXem.IndicateFocus = false;
            this.btnXem.Location = new System.Drawing.Point(528, 13);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXem.OnDisabledState.BorderRadius = 1;
            this.btnXem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.OnDisabledState.BorderThickness = 1;
            this.btnXem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXem.OnDisabledState.IconLeftImage = null;
            this.btnXem.OnDisabledState.IconRightImage = null;
            this.btnXem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXem.onHoverState.BorderRadius = 1;
            this.btnXem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.onHoverState.BorderThickness = 1;
            this.btnXem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXem.onHoverState.IconLeftImage = null;
            this.btnXem.onHoverState.IconRightImage = null;
            this.btnXem.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXem.OnIdleState.BorderRadius = 1;
            this.btnXem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.OnIdleState.BorderThickness = 1;
            this.btnXem.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(225)))));
            this.btnXem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXem.OnIdleState.IconLeftImage = null;
            this.btnXem.OnIdleState.IconRightImage = null;
            this.btnXem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXem.OnPressedState.BorderRadius = 1;
            this.btnXem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.OnPressedState.BorderThickness = 1;
            this.btnXem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXem.OnPressedState.IconLeftImage = null;
            this.btnXem.OnPressedState.IconRightImage = null;
            this.btnXem.Size = new System.Drawing.Size(68, 32);
            this.btnXem.TabIndex = 0;
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXem.TextMarginLeft = 0;
            this.btnXem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXem.UseDefaultRadiusAndThickness = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 563);
            this.Controls.Add(this.footerpanel);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "THONGKE";
            this.Text = "THONGKE";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBB)).EndInit();
            this.footerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocBB;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuDataGridView ListBB;
        private Bunifu.UI.WinForms.BunifuPanel footerpanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXem;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXM;
    }
}