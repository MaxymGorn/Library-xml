namespace WindowsFormsApp6
{
    partial class Form1
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
            this.tabPageMode = new System.Windows.Forms.TabPage();
            this.ChooseItem = new System.Windows.Forms.ComboBox();
            this.PersonBoxList = new System.Windows.Forms.ListBox();
            this.But1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChanr = new System.Windows.Forms.Label();
            this.textBoxChnr = new System.Windows.Forms.TextBox();
            this.DeleteListBooks = new System.Windows.Forms.ListBox();
            this.labelAnotation = new System.Windows.Forms.Label();
            this.MessgeText = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.anotationfield = new System.Windows.Forms.TextBox();
            this.typefield = new System.Windows.Forms.TextBox();
            this.costfield = new System.Windows.Forms.TextBox();
            this.namefield = new System.Windows.Forms.TextBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.UniversalButton = new System.Windows.Forms.Button();
            this.But2 = new System.Windows.Forms.Button();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.ReaderBook = new System.Windows.Forms.ListBox();
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ModeBoxCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboxChanr = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageMode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageReader.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMode
            // 
            this.tabPageMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageMode.Controls.Add(this.ChooseItem);
            this.tabPageMode.Controls.Add(this.PersonBoxList);
            this.tabPageMode.Controls.Add(this.But1);
            this.tabPageMode.Controls.Add(this.panel1);
            this.tabPageMode.Controls.Add(this.But2);
            this.tabPageMode.Controls.Add(this.MessgeText);
            this.tabPageMode.Location = new System.Drawing.Point(4, 48);
            this.tabPageMode.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPageMode.Name = "tabPageMode";
            this.tabPageMode.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPageMode.Size = new System.Drawing.Size(1142, 375);
            this.tabPageMode.TabIndex = 3;
            this.tabPageMode.Text = "Journal";
            this.tabPageMode.Click += new System.EventHandler(this.tabPageMode_Click);
            // 
            // ChooseItem
            // 
            this.ChooseItem.FormattingEnabled = true;
            this.ChooseItem.Items.AddRange(new object[] {
            "Користувачі",
            "Сотрудники",
            "Админ"});
            this.ChooseItem.Location = new System.Drawing.Point(41, 166);
            this.ChooseItem.Name = "ChooseItem";
            this.ChooseItem.Size = new System.Drawing.Size(179, 47);
            this.ChooseItem.TabIndex = 5;
            this.ChooseItem.SelectedIndexChanged += new System.EventHandler(this.ChooseItem_SelectedIndexChanged);
            // 
            // PersonBoxList
            // 
            this.PersonBoxList.FormattingEnabled = true;
            this.PersonBoxList.ItemHeight = 39;
            this.PersonBoxList.Location = new System.Drawing.Point(273, 56);
            this.PersonBoxList.Name = "PersonBoxList";
            this.PersonBoxList.ScrollAlwaysVisible = true;
            this.PersonBoxList.Size = new System.Drawing.Size(837, 238);
            this.PersonBoxList.TabIndex = 4;
            this.PersonBoxList.SelectedIndexChanged += new System.EventHandler(this.PersonBoxList_SelectedIndexChanged);
            // 
            // But1
            // 
            this.But1.Location = new System.Drawing.Point(41, 40);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(179, 89);
            this.But1.TabIndex = 4;
            this.But1.Text = "Def1";
            this.But1.UseVisualStyleBackColor = true;
            this.But1.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelChanr);
            this.panel1.Controls.Add(this.textBoxChnr);
            this.panel1.Controls.Add(this.DeleteListBooks);
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
            this.panel1.Location = new System.Drawing.Point(282, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 285);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelChanr
            // 
            this.labelChanr.AutoSize = true;
            this.labelChanr.Location = new System.Drawing.Point(376, 71);
            this.labelChanr.Name = "labelChanr";
            this.labelChanr.Size = new System.Drawing.Size(80, 39);
            this.labelChanr.TabIndex = 12;
            this.labelChanr.Text = "Жанр";
            this.labelChanr.Visible = false;
            // 
            // textBoxChnr
            // 
            this.textBoxChnr.Location = new System.Drawing.Point(358, 131);
            this.textBoxChnr.Name = "textBoxChnr";
            this.textBoxChnr.Size = new System.Drawing.Size(118, 48);
            this.textBoxChnr.TabIndex = 11;
            this.textBoxChnr.Visible = false;
            // 
            // DeleteListBooks
            // 
            this.DeleteListBooks.FormattingEnabled = true;
            this.DeleteListBooks.ItemHeight = 39;
            this.DeleteListBooks.Location = new System.Drawing.Point(38, 34);
            this.DeleteListBooks.Name = "DeleteListBooks";
            this.DeleteListBooks.ScrollAlwaysVisible = true;
            this.DeleteListBooks.Size = new System.Drawing.Size(765, 160);
            this.DeleteListBooks.TabIndex = 10;
            this.DeleteListBooks.Click += new System.EventHandler(this.DeleteListBooks_Click);
            // 
            // labelAnotation
            // 
            this.labelAnotation.AutoSize = true;
            this.labelAnotation.Location = new System.Drawing.Point(676, 71);
            this.labelAnotation.Name = "labelAnotation";
            this.labelAnotation.Size = new System.Drawing.Size(137, 39);
            this.labelAnotation.TabIndex = 9;
            this.labelAnotation.Text = "Анотация";
            this.labelAnotation.Visible = false;
            // 
            // MessgeText
            // 
            this.MessgeText.AutoSize = true;
            this.MessgeText.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MessgeText.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessgeText.ForeColor = System.Drawing.Color.Lime;
            this.MessgeText.Location = new System.Drawing.Point(231, 333);
            this.MessgeText.Name = "MessgeText";
            this.MessgeText.Size = new System.Drawing.Size(258, 46);
            this.MessgeText.TabIndex = 6;
            this.MessgeText.Text = "Успешно удалено!";
            this.MessgeText.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(520, 71);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 39);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип";
            this.labelType.Visible = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(234, 71);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(74, 39);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Цена";
            this.labelCost.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(80, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 39);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            this.labelName.Visible = false;
            // 
            // anotationfield
            // 
            this.anotationfield.Location = new System.Drawing.Point(659, 131);
            this.anotationfield.Name = "anotationfield";
            this.anotationfield.Size = new System.Drawing.Size(172, 48);
            this.anotationfield.TabIndex = 5;
            this.anotationfield.Visible = false;
            // 
            // typefield
            // 
            this.typefield.Location = new System.Drawing.Point(495, 131);
            this.typefield.Name = "typefield";
            this.typefield.Size = new System.Drawing.Size(151, 48);
            this.typefield.TabIndex = 4;
            this.typefield.Visible = false;
            // 
            // costfield
            // 
            this.costfield.Location = new System.Drawing.Point(215, 131);
            this.costfield.Name = "costfield";
            this.costfield.Size = new System.Drawing.Size(118, 48);
            this.costfield.TabIndex = 3;
            this.costfield.Visible = false;
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(38, 131);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(151, 48);
            this.namefield.TabIndex = 2;
            this.namefield.Visible = false;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(495, 212);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(290, 58);
            this.Cancelbutton.TabIndex = 1;
            this.Cancelbutton.Tag = "EnterTag";
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.button6_Click);
            // 
            // UniversalButton
            // 
            this.UniversalButton.Location = new System.Drawing.Point(92, 212);
            this.UniversalButton.Name = "UniversalButton";
            this.UniversalButton.Size = new System.Drawing.Size(287, 58);
            this.UniversalButton.TabIndex = 0;
            this.UniversalButton.Text = "Default";
            this.UniversalButton.UseVisualStyleBackColor = true;
            this.UniversalButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // But2
            // 
            this.But2.Location = new System.Drawing.Point(41, 247);
            this.But2.Name = "But2";
            this.But2.Size = new System.Drawing.Size(179, 89);
            this.But2.TabIndex = 2;
            this.But2.Text = "Def2";
            this.But2.UseVisualStyleBackColor = true;
            this.But2.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPageReader
            // 
            this.tabPageReader.Controls.Add(this.ReaderBook);
            this.tabPageReader.Controls.Add(this.InfoText);
            this.tabPageReader.Location = new System.Drawing.Point(4, 48);
            this.tabPageReader.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPageReader.Size = new System.Drawing.Size(1142, 375);
            this.tabPageReader.TabIndex = 1;
            this.tabPageReader.Text = "Reader";
            this.tabPageReader.UseVisualStyleBackColor = true;
            this.tabPageReader.Click += new System.EventHandler(this.tabPageReader_Click);
            // 
            // ReaderBook
            // 
            this.ReaderBook.FormattingEnabled = true;
            this.ReaderBook.ItemHeight = 39;
            this.ReaderBook.Location = new System.Drawing.Point(28, 26);
            this.ReaderBook.Name = "ReaderBook";
            this.ReaderBook.Size = new System.Drawing.Size(388, 277);
            this.ReaderBook.TabIndex = 17;
            this.ReaderBook.SelectedIndexChanged += new System.EventHandler(this.ReaderBook_SelectedIndexChanged);
            // 
            // InfoText
            // 
            this.InfoText.BackColor = System.Drawing.Color.MediumOrchid;
            this.InfoText.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.ForeColor = System.Drawing.Color.Yellow;
            this.InfoText.ImeMode = System.Windows.Forms.ImeMode.On;
            this.InfoText.Location = new System.Drawing.Point(452, 62);
            this.InfoText.Name = "InfoText";
            this.InfoText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.InfoText.Size = new System.Drawing.Size(670, 205);
            this.InfoText.TabIndex = 16;
            this.InfoText.Text = "";
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.button3);
            this.tabPageBook.Controls.Add(this.label4);
            this.tabPageBook.Controls.Add(this.comboxChanr);
            this.tabPageBook.Controls.Add(this.button2);
            this.tabPageBook.Controls.Add(this.listView1);
            this.tabPageBook.Controls.Add(this.button1);
            this.tabPageBook.Controls.Add(this.label2);
            this.tabPageBook.Controls.Add(this.label1);
            this.tabPageBook.Controls.Add(this.comboBox2);
            this.tabPageBook.Controls.Add(this.comboBox1);
            this.tabPageBook.Location = new System.Drawing.Point(4, 48);
            this.tabPageBook.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPageBook.Size = new System.Drawing.Size(1142, 375);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Book";
            this.tabPageBook.UseVisualStyleBackColor = true;
            this.tabPageBook.Click += new System.EventHandler(this.tabPageBook_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 90);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сдать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(773, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 328);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 90);
            this.button1.TabIndex = 5;
            this.button1.Text = "Взять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "По цене";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "По жанру";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Все цены",
            "По убыванию",
            "По возрастанию"});
            this.comboBox2.Location = new System.Drawing.Point(287, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 47);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 47);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Controls.Add(this.tabPageMode);
            this.tabControl1.Location = new System.Drawing.Point(45, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 427);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "Admin";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // ModeBoxCombo
            // 
            this.ModeBoxCombo.FormattingEnabled = true;
            this.ModeBoxCombo.Items.AddRange(new object[] {
            "Користувач",
            "Бібліотекар",
            "Админ"});
            this.ModeBoxCombo.Location = new System.Drawing.Point(724, 28);
            this.ModeBoxCombo.Name = "ModeBoxCombo";
            this.ModeBoxCombo.Size = new System.Drawing.Size(201, 47);
            this.ModeBoxCombo.TabIndex = 2;
            this.ModeBoxCombo.SelectedIndexChanged += new System.EventHandler(this.ModeBoxCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(494, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Mode:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "По типу";
            // 
            // comboxChanr
            // 
            this.comboxChanr.FormattingEnabled = true;
            this.comboxChanr.Items.AddRange(new object[] {
            "Все цены",
            "По возрастанию",
            "По убыванию"});
            this.comboxChanr.Location = new System.Drawing.Point(531, 155);
            this.comboxChanr.Name = "comboxChanr";
            this.comboxChanr.Size = new System.Drawing.Size(226, 47);
            this.comboxChanr.TabIndex = 10;
            this.comboxChanr.SelectedIndexChanged += new System.EventHandler(this.comboxChanr_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Жанр";
            this.columnHeader4.Width = 100;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 90);
            this.button3.TabIndex = 12;
            this.button3.Text = "Управления журналом";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModeBoxCombo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Mistral", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form1";
            this.Text = "Library1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageMode.ResumeLayout(false);
            this.tabPageMode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageReader.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageMode;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox PersonBoxList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button UniversalButton;
        private System.Windows.Forms.Button But2;
        private System.Windows.Forms.Button But1;
        private System.Windows.Forms.Label labelAnotation;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox anotationfield;
        private System.Windows.Forms.TextBox typefield;
        private System.Windows.Forms.TextBox costfield;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.ComboBox ModeBoxCombo;
        private System.Windows.Forms.ComboBox ChooseItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MessgeText;
        private System.Windows.Forms.ListBox DeleteListBooks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ReaderBook;
        private System.Windows.Forms.Label labelChanr;
        private System.Windows.Forms.TextBox textBoxChnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboxChanr;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
    }
}

