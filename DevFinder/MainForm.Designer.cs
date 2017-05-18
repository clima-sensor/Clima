namespace DevFinder
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FindBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FindBtn
            // 
            this.FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindBtn.Location = new System.Drawing.Point(820, 240);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(75, 23);
            this.FindBtn.TabIndex = 0;
            this.FindBtn.Text = "Поиск";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checkbox_no.ico");
            this.imageList1.Images.SetKeyName(1, "checkbox_yes.ico");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.с3,
            this.с4,
            this.c5,
            this.c6,
            this.c7,
            this.c8});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(901, 234);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // DCType
            // 
            this.c1.DataPropertyName = "DC_Type";
            this.c1.HeaderText = "Тип устройства";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c1.Width = 120;
            // 
            // DCVer
            // 
            this.c2.DataPropertyName = "DC_Ver";
            this.c2.HeaderText = "Версия";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c2.Width = 65;
            // 
            // с3
            // 
            this.с3.DataPropertyName = "DC_ID";
            this.с3.HeaderText = "Идентификатор устройства (DeviceID)";
            this.с3.Name = "с3";
            this.с3.ReadOnly = true;
            this.с3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.с3.Width = 235;
            // 
            // с4
            // 
            this.с4.DataPropertyName = "DC_MAC";
            this.с4.HeaderText = "MAC адрес";
            this.с4.Name = "с4";
            this.с4.ReadOnly = true;
            this.с4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.с4.Width = 115;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "DC_DHCP";
            this.c5.FalseValue = "0";
            this.c5.HeaderText = "DHCP";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c5.TrueValue = "1";
            this.c5.Width = 45;
            // 
            // DCIP
            // 
            this.c6.DataPropertyName = "DC_IP";
            this.c6.HeaderText = "IP адрес";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            this.c6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // c7
            // 
            this.c7.DataPropertyName = "DC_Mask";
            this.c7.HeaderText = "Маска подсети";
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            this.c7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // c8
            // 
            this.c8.DataPropertyName = "DC_Gate";
            this.c8.HeaderText = "Шлюз";
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            this.c8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 269);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FindBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clima - DeviceFinder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn с3;
        private System.Windows.Forms.DataGridViewTextBoxColumn с4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
    }
}

