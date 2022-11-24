namespace WFA221124
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAdatok = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szuletett = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAdult = new System.Windows.Forms.CheckBox();
            this.gbModify = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.dtpModify = new System.Windows.Forms.DateTimePicker();
            this.rbManModify = new System.Windows.Forms.RadioButton();
            this.rbWomanModify = new System.Windows.Forms.RadioButton();
            this.tbNameModify = new System.Windows.Forms.TextBox();
            this.lblSzulModify = new System.Windows.Forms.Label();
            this.lblNemModify = new System.Windows.Forms.Label();
            this.lblNameModify = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.rbManAdd = new System.Windows.Forms.RadioButton();
            this.rbWomanAdd = new System.Windows.Forms.RadioButton();
            this.tbNameAdd = new System.Windows.Forms.TextBox();
            this.lblDateBornAdd = new System.Windows.Forms.Label();
            this.lblSexAdd = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).BeginInit();
            this.gbModify.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdatok
            // 
            this.dgvAdatok.AllowUserToAddRows = false;
            this.dgvAdatok.AllowUserToDeleteRows = false;
            this.dgvAdatok.AllowUserToResizeColumns = false;
            this.dgvAdatok.AllowUserToResizeRows = false;
            this.dgvAdatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdatok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nev,
            this.Nem,
            this.Szuletett});
            this.dgvAdatok.Location = new System.Drawing.Point(12, 12);
            this.dgvAdatok.Name = "dgvAdatok";
            this.dgvAdatok.ReadOnly = true;
            this.dgvAdatok.RowTemplate.Height = 25;
            this.dgvAdatok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdatok.Size = new System.Drawing.Size(776, 201);
            this.dgvAdatok.TabIndex = 0;
            this.dgvAdatok.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Név";
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            // 
            // Nem
            // 
            this.Nem.HeaderText = "Nem";
            this.Nem.Name = "Nem";
            this.Nem.ReadOnly = true;
            // 
            // Szuletett
            // 
            this.Szuletett.HeaderText = "Született";
            this.Szuletett.Name = "Szuletett";
            this.Szuletett.ReadOnly = true;
            // 
            // cbAdult
            // 
            this.cbAdult.AutoSize = true;
            this.cbAdult.Location = new System.Drawing.Point(12, 233);
            this.cbAdult.Name = "cbAdult";
            this.cbAdult.Size = new System.Drawing.Size(99, 19);
            this.cbAdult.TabIndex = 1;
            this.cbAdult.Text = "csak felnőttek";
            this.cbAdult.UseVisualStyleBackColor = true;
            this.cbAdult.CheckedChanged += new System.EventHandler(this.OnAdultCheckedChanged);
            // 
            // gbModify
            // 
            this.gbModify.Controls.Add(this.btnModify);
            this.gbModify.Controls.Add(this.dtpModify);
            this.gbModify.Controls.Add(this.rbManModify);
            this.gbModify.Controls.Add(this.rbWomanModify);
            this.gbModify.Controls.Add(this.tbNameModify);
            this.gbModify.Controls.Add(this.lblSzulModify);
            this.gbModify.Controls.Add(this.lblNemModify);
            this.gbModify.Controls.Add(this.lblNameModify);
            this.gbModify.Location = new System.Drawing.Point(198, 233);
            this.gbModify.Name = "gbModify";
            this.gbModify.Size = new System.Drawing.Size(236, 164);
            this.gbModify.TabIndex = 2;
            this.gbModify.TabStop = false;
            this.gbModify.Text = "Módosítás";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(20, 126);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(188, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Módosítás";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ModifyData);
            // 
            // dtpModify
            // 
            this.dtpModify.CustomFormat = "yyyy";
            this.dtpModify.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModify.Location = new System.Drawing.Point(71, 88);
            this.dtpModify.Name = "dtpModify";
            this.dtpModify.Size = new System.Drawing.Size(137, 23);
            this.dtpModify.TabIndex = 6;
            // 
            // rbManModify
            // 
            this.rbManModify.AutoSize = true;
            this.rbManModify.Location = new System.Drawing.Point(145, 62);
            this.rbManModify.Name = "rbManModify";
            this.rbManModify.Size = new System.Drawing.Size(46, 19);
            this.rbManModify.TabIndex = 5;
            this.rbManModify.TabStop = true;
            this.rbManModify.Text = "férfi";
            this.rbManModify.UseVisualStyleBackColor = true;
            // 
            // rbWomanModify
            // 
            this.rbWomanModify.AutoSize = true;
            this.rbWomanModify.Location = new System.Drawing.Point(82, 62);
            this.rbWomanModify.Name = "rbWomanModify";
            this.rbWomanModify.Size = new System.Drawing.Size(39, 19);
            this.rbWomanModify.TabIndex = 4;
            this.rbWomanModify.TabStop = true;
            this.rbWomanModify.Text = "nő";
            this.rbWomanModify.UseVisualStyleBackColor = true;
            // 
            // tbNameModify
            // 
            this.tbNameModify.Location = new System.Drawing.Point(71, 31);
            this.tbNameModify.Name = "tbNameModify";
            this.tbNameModify.Size = new System.Drawing.Size(137, 23);
            this.tbNameModify.TabIndex = 3;
            // 
            // lblSzulModify
            // 
            this.lblSzulModify.AutoSize = true;
            this.lblSzulModify.Location = new System.Drawing.Point(20, 94);
            this.lblSzulModify.Name = "lblSzulModify";
            this.lblSzulModify.Size = new System.Drawing.Size(31, 15);
            this.lblSzulModify.TabIndex = 2;
            this.lblSzulModify.Text = "Szül:";
            // 
            // lblNemModify
            // 
            this.lblNemModify.AutoSize = true;
            this.lblNemModify.Location = new System.Drawing.Point(20, 62);
            this.lblNemModify.Name = "lblNemModify";
            this.lblNemModify.Size = new System.Drawing.Size(36, 15);
            this.lblNemModify.TabIndex = 1;
            this.lblNemModify.Text = "Nem:";
            // 
            // lblNameModify
            // 
            this.lblNameModify.AutoSize = true;
            this.lblNameModify.Location = new System.Drawing.Point(20, 34);
            this.lblNameModify.Name = "lblNameModify";
            this.lblNameModify.Size = new System.Drawing.Size(31, 15);
            this.lblNameModify.TabIndex = 0;
            this.lblNameModify.Text = "Név:";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.dtpAdd);
            this.gbAdd.Controls.Add(this.rbManAdd);
            this.gbAdd.Controls.Add(this.rbWomanAdd);
            this.gbAdd.Controls.Add(this.tbNameAdd);
            this.gbAdd.Controls.Add(this.lblDateBornAdd);
            this.gbAdd.Controls.Add(this.lblSexAdd);
            this.gbAdd.Controls.Add(this.lblNameAdd);
            this.gbAdd.Location = new System.Drawing.Point(490, 233);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(236, 164);
            this.gbAdd.TabIndex = 8;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Új ember hozzáadása";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Hozzáadás";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddData);
            // 
            // dtpAdd
            // 
            this.dtpAdd.CustomFormat = "yyyy";
            this.dtpAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdd.Location = new System.Drawing.Point(71, 88);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.Size = new System.Drawing.Size(137, 23);
            this.dtpAdd.TabIndex = 6;
            // 
            // rbManAdd
            // 
            this.rbManAdd.AutoSize = true;
            this.rbManAdd.Location = new System.Drawing.Point(145, 62);
            this.rbManAdd.Name = "rbManAdd";
            this.rbManAdd.Size = new System.Drawing.Size(46, 19);
            this.rbManAdd.TabIndex = 5;
            this.rbManAdd.TabStop = true;
            this.rbManAdd.Text = "férfi";
            this.rbManAdd.UseVisualStyleBackColor = true;
            // 
            // rbWomanAdd
            // 
            this.rbWomanAdd.AutoSize = true;
            this.rbWomanAdd.Location = new System.Drawing.Point(82, 62);
            this.rbWomanAdd.Name = "rbWomanAdd";
            this.rbWomanAdd.Size = new System.Drawing.Size(39, 19);
            this.rbWomanAdd.TabIndex = 4;
            this.rbWomanAdd.TabStop = true;
            this.rbWomanAdd.Text = "nő";
            this.rbWomanAdd.UseVisualStyleBackColor = true;
            // 
            // tbNameAdd
            // 
            this.tbNameAdd.Location = new System.Drawing.Point(71, 31);
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(137, 23);
            this.tbNameAdd.TabIndex = 3;
            // 
            // lblDateBornAdd
            // 
            this.lblDateBornAdd.AutoSize = true;
            this.lblDateBornAdd.Location = new System.Drawing.Point(20, 94);
            this.lblDateBornAdd.Name = "lblDateBornAdd";
            this.lblDateBornAdd.Size = new System.Drawing.Size(31, 15);
            this.lblDateBornAdd.TabIndex = 2;
            this.lblDateBornAdd.Text = "Szül:";
            // 
            // lblSexAdd
            // 
            this.lblSexAdd.AutoSize = true;
            this.lblSexAdd.Location = new System.Drawing.Point(20, 62);
            this.lblSexAdd.Name = "lblSexAdd";
            this.lblSexAdd.Size = new System.Drawing.Size(36, 15);
            this.lblSexAdd.TabIndex = 1;
            this.lblSexAdd.Text = "Nem:";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(20, 34);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(31, 15);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Név:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbModify);
            this.Controls.Add(this.cbAdult);
            this.Controls.Add(this.dgvAdatok);
            this.Name = "Form1";
            this.Text = "Összefoglalás";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).EndInit();
            this.gbModify.ResumeLayout(false);
            this.gbModify.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAdatok;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Nem;
        private DataGridViewTextBoxColumn Szuletett;
        private CheckBox cbAdult;
        private GroupBox gbModify;
        private DateTimePicker dtpModify;
        private RadioButton rbManModify;
        private RadioButton rbWomanModify;
        private TextBox tbNameModify;
        private Label lblSzulModify;
        private Label lblNemModify;
        private Label lblNameModify;
        private Button btnModify;
        private GroupBox gbAdd;
        private Button btnAdd;
        private DateTimePicker dtpAdd;
        private RadioButton rbManAdd;
        private RadioButton rbWomanAdd;
        private TextBox tbNameAdd;
        private Label lblDateBornAdd;
        private Label lblSexAdd;
        private Label lblNameAdd;
    }
}