namespace WindowsFormsApp6
{
    partial class Authorization
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
            this.TakeOrGetBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNamePersonFields = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChanr = new System.Windows.Forms.Label();
            this.textBoxChnr = new System.Windows.Forms.TextBox();
            this.labelAnotation = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.anotationfield = new System.Windows.Forms.TextBox();
            this.typefield = new System.Windows.Forms.TextBox();
            this.costfield = new System.Windows.Forms.TextBox();
            this.namefield = new System.Windows.Forms.TextBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.UniversalButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TakeOrGetBtn
            // 
            this.TakeOrGetBtn.Location = new System.Drawing.Point(61, 294);
            this.TakeOrGetBtn.Name = "TakeOrGetBtn";
            this.TakeOrGetBtn.Size = new System.Drawing.Size(188, 72);
            this.TakeOrGetBtn.TabIndex = 0;
            this.TakeOrGetBtn.Text = "Взять";
            this.TakeOrGetBtn.UseVisualStyleBackColor = true;
            this.TakeOrGetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(305, 296);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(186, 70);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя";
            // 
            // textNamePersonFields
            // 
            this.textNamePersonFields.Location = new System.Drawing.Point(61, 62);
            this.textNamePersonFields.Name = "textNamePersonFields";
            this.textNamePersonFields.Size = new System.Drawing.Size(430, 48);
            this.textNamePersonFields.TabIndex = 2;
            this.textNamePersonFields.TextChanged += new System.EventHandler(this.textNamePersonFields_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 47);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(61, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 153);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Жанр";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 72);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelChanr);
            this.panel1.Controls.Add(this.textBoxChnr);
            this.panel1.Controls.Add(this.labelAnotation);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.labelCost);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.anotationfield);
            this.panel1.Controls.Add(this.typefield);
            this.panel1.Controls.Add(this.costfield);
            this.panel1.Controls.Add(this.namefield);
            this.panel1.Controls.Add(this.Cancelbutton);
            this.panel1.Controls.Add(this.UniversalButton);
            this.panel1.Location = new System.Drawing.Point(51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 383);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // labelChanr
            // 
            this.labelChanr.AutoSize = true;
            this.labelChanr.Location = new System.Drawing.Point(361, 170);
            this.labelChanr.Name = "labelChanr";
            this.labelChanr.Size = new System.Drawing.Size(80, 39);
            this.labelChanr.TabIndex = 12;
            this.labelChanr.Text = "Жанр";
            // 
            // textBoxChnr
            // 
            this.textBoxChnr.Location = new System.Drawing.Point(345, 228);
            this.textBoxChnr.Name = "textBoxChnr";
            this.textBoxChnr.Size = new System.Drawing.Size(118, 48);
            this.textBoxChnr.TabIndex = 11;
            // 
            // labelAnotation
            // 
            this.labelAnotation.AutoSize = true;
            this.labelAnotation.Location = new System.Drawing.Point(248, 36);
            this.labelAnotation.Name = "labelAnotation";
            this.labelAnotation.Size = new System.Drawing.Size(137, 39);
            this.labelAnotation.TabIndex = 9;
            this.labelAnotation.Text = "Анотация";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(81, 170);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 39);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(226, 170);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(74, 39);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Цена";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 39);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            // 
            // anotationfield
            // 
            this.anotationfield.Location = new System.Drawing.Point(173, 85);
            this.anotationfield.Name = "anotationfield";
            this.anotationfield.Size = new System.Drawing.Size(232, 48);
            this.anotationfield.TabIndex = 5;
            // 
            // typefield
            // 
            this.typefield.Location = new System.Drawing.Point(38, 228);
            this.typefield.Name = "typefield";
            this.typefield.Size = new System.Drawing.Size(151, 48);
            this.typefield.TabIndex = 4;
            // 
            // costfield
            // 
            this.costfield.Location = new System.Drawing.Point(205, 230);
            this.costfield.Name = "costfield";
            this.costfield.Size = new System.Drawing.Size(118, 48);
            this.costfield.TabIndex = 3;
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(16, 85);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(151, 48);
            this.namefield.TabIndex = 2;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(269, 296);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(202, 58);
            this.Cancelbutton.TabIndex = 1;
            this.Cancelbutton.Tag = "EnterTag";
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // UniversalButton
            // 
            this.UniversalButton.Location = new System.Drawing.Point(30, 296);
            this.UniversalButton.Name = "UniversalButton";
            this.UniversalButton.Size = new System.Drawing.Size(204, 58);
            this.UniversalButton.TabIndex = 0;
            this.UniversalButton.Text = "Добавить";
            this.UniversalButton.UseVisualStyleBackColor = true;
            this.UniversalButton.Click += new System.EventHandler(this.UniversalButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNamePersonFields);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TakeOrGetBtn);
            this.Font = new System.Drawing.Font("Mistral", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.TextBox textNamePersonFields;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.Button TakeOrGetBtn;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelChanr;
        private System.Windows.Forms.TextBox textBoxChnr;
        private System.Windows.Forms.Label labelAnotation;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox anotationfield;
        private System.Windows.Forms.TextBox typefield;
        private System.Windows.Forms.TextBox costfield;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button UniversalButton;
    }
}