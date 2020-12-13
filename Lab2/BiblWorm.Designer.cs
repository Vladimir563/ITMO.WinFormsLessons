namespace Lab2
{
    partial class BiblWorm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdWatchBooksList = new System.Windows.Forms.Button();
            this.cmdAddBook = new System.Windows.Forms.Button();
            this.checkBoxIsBookReturnOnTime = new System.Windows.Forms.CheckBox();
            this.checkBoxIsBooksListSort = new System.Windows.Forms.CheckBox();
            this.checkBoxIsBookAvailable = new System.Windows.Forms.CheckBox();
            this.richTextBoxBooksList = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBookUsingPeriod = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBookInvNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBookYearPublished = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBookPagesCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxBookPublisher = new System.Windows.Forms.TextBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdWatchMagazinesList = new System.Windows.Forms.Button();
            this.checkBoxIsMagazineListSort = new System.Windows.Forms.CheckBox();
            this.richTextBoxMagazineList = new System.Windows.Forms.RichTextBox();
            this.cmdAddMagazine = new System.Windows.Forms.Button();
            this.checkBoxIsMagazineAvailable = new System.Windows.Forms.CheckBox();
            this.numericUpDowMagazineInvNumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownMagainePublishedDate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownMagazineNumber = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMagazineVolume = new System.Windows.Forms.TextBox();
            this.textBoxMagazineTitle = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookUsingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookInvNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookYearPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookPagesCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowMagazineInvNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagainePublishedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagazineNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdWatchBooksList);
            this.tabPage1.Controls.Add(this.cmdAddBook);
            this.tabPage1.Controls.Add(this.checkBoxIsBookReturnOnTime);
            this.tabPage1.Controls.Add(this.checkBoxIsBooksListSort);
            this.tabPage1.Controls.Add(this.checkBoxIsBookAvailable);
            this.tabPage1.Controls.Add(this.richTextBoxBooksList);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDownBookUsingPeriod);
            this.tabPage1.Controls.Add(this.numericUpDownBookInvNumber);
            this.tabPage1.Controls.Add(this.numericUpDownBookYearPublished);
            this.tabPage1.Controls.Add(this.numericUpDownBookPagesCount);
            this.tabPage1.Controls.Add(this.textBoxBookPublisher);
            this.tabPage1.Controls.Add(this.textBoxBookTitle);
            this.tabPage1.Controls.Add(this.textBoxBookAuthor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdWatchBooksList
            // 
            this.cmdWatchBooksList.Location = new System.Drawing.Point(320, 335);
            this.cmdWatchBooksList.Name = "cmdWatchBooksList";
            this.cmdWatchBooksList.Size = new System.Drawing.Size(83, 23);
            this.cmdWatchBooksList.TabIndex = 21;
            this.cmdWatchBooksList.Text = "Посмотреть";
            this.cmdWatchBooksList.UseVisualStyleBackColor = true;
            this.cmdWatchBooksList.Click += new System.EventHandler(this.cmdWatch_Click);
            // 
            // cmdAddBook
            // 
            this.cmdAddBook.Location = new System.Drawing.Point(77, 335);
            this.cmdAddBook.Name = "cmdAddBook";
            this.cmdAddBook.Size = new System.Drawing.Size(75, 23);
            this.cmdAddBook.TabIndex = 20;
            this.cmdAddBook.Text = "Добавить";
            this.cmdAddBook.UseVisualStyleBackColor = true;
            this.cmdAddBook.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // checkBoxIsBookReturnOnTime
            // 
            this.checkBoxIsBookReturnOnTime.AutoSize = true;
            this.checkBoxIsBookReturnOnTime.Location = new System.Drawing.Point(104, 284);
            this.checkBoxIsBookReturnOnTime.Name = "checkBoxIsBookReturnOnTime";
            this.checkBoxIsBookReturnOnTime.Size = new System.Drawing.Size(125, 17);
            this.checkBoxIsBookReturnOnTime.TabIndex = 19;
            this.checkBoxIsBookReturnOnTime.Text = "Возвращает в срок";
            this.checkBoxIsBookReturnOnTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsBooksListSort
            // 
            this.checkBoxIsBooksListSort.AutoSize = true;
            this.checkBoxIsBooksListSort.Location = new System.Drawing.Point(439, 339);
            this.checkBoxIsBooksListSort.Name = "checkBoxIsBooksListSort";
            this.checkBoxIsBooksListSort.Size = new System.Drawing.Size(181, 17);
            this.checkBoxIsBooksListSort.TabIndex = 18;
            this.checkBoxIsBooksListSort.Text = "Сортировать по инвентарному";
            this.checkBoxIsBooksListSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsBookAvailable
            // 
            this.checkBoxIsBookAvailable.AutoSize = true;
            this.checkBoxIsBookAvailable.Location = new System.Drawing.Point(14, 284);
            this.checkBoxIsBookAvailable.Name = "checkBoxIsBookAvailable";
            this.checkBoxIsBookAvailable.Size = new System.Drawing.Size(69, 17);
            this.checkBoxIsBookAvailable.TabIndex = 17;
            this.checkBoxIsBookAvailable.Text = "Наличие";
            this.checkBoxIsBookAvailable.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBooksList
            // 
            this.richTextBoxBooksList.Location = new System.Drawing.Point(303, 9);
            this.richTextBoxBooksList.Name = "richTextBoxBooksList";
            this.richTextBoxBooksList.Size = new System.Drawing.Size(318, 320);
            this.richTextBoxBooksList.TabIndex = 16;
            this.richTextBoxBooksList.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Срок пользования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Инвентарный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Автор";
            // 
            // numericUpDownBookUsingPeriod
            // 
            this.numericUpDownBookUsingPeriod.Location = new System.Drawing.Point(101, 246);
            this.numericUpDownBookUsingPeriod.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownBookUsingPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBookUsingPeriod.Name = "numericUpDownBookUsingPeriod";
            this.numericUpDownBookUsingPeriod.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBookUsingPeriod.TabIndex = 6;
            this.numericUpDownBookUsingPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBookInvNumber
            // 
            this.numericUpDownBookInvNumber.Location = new System.Drawing.Point(101, 204);
            this.numericUpDownBookInvNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBookInvNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBookInvNumber.Name = "numericUpDownBookInvNumber";
            this.numericUpDownBookInvNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBookInvNumber.TabIndex = 5;
            this.numericUpDownBookInvNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBookYearPublished
            // 
            this.numericUpDownBookYearPublished.Location = new System.Drawing.Point(101, 157);
            this.numericUpDownBookYearPublished.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownBookYearPublished.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDownBookYearPublished.Name = "numericUpDownBookYearPublished";
            this.numericUpDownBookYearPublished.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBookYearPublished.TabIndex = 4;
            this.numericUpDownBookYearPublished.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // numericUpDownBookPagesCount
            // 
            this.numericUpDownBookPagesCount.Location = new System.Drawing.Point(101, 113);
            this.numericUpDownBookPagesCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBookPagesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBookPagesCount.Name = "numericUpDownBookPagesCount";
            this.numericUpDownBookPagesCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBookPagesCount.TabIndex = 3;
            this.numericUpDownBookPagesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxBookPublisher
            // 
            this.textBoxBookPublisher.Location = new System.Drawing.Point(101, 80);
            this.textBoxBookPublisher.Name = "textBoxBookPublisher";
            this.textBoxBookPublisher.Size = new System.Drawing.Size(184, 20);
            this.textBoxBookPublisher.TabIndex = 2;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(101, 46);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(184, 20);
            this.textBoxBookTitle.TabIndex = 1;
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(101, 9);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(184, 20);
            this.textBoxBookAuthor.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdWatchMagazinesList);
            this.tabPage2.Controls.Add(this.checkBoxIsMagazineListSort);
            this.tabPage2.Controls.Add(this.richTextBoxMagazineList);
            this.tabPage2.Controls.Add(this.cmdAddMagazine);
            this.tabPage2.Controls.Add(this.checkBoxIsMagazineAvailable);
            this.tabPage2.Controls.Add(this.numericUpDowMagazineInvNumber);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numericUpDownMagainePublishedDate);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.numericUpDownMagazineNumber);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxMagazineVolume);
            this.tabPage2.Controls.Add(this.textBoxMagazineTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журналы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdWatchMagazinesList
            // 
            this.cmdWatchMagazinesList.Location = new System.Drawing.Point(315, 336);
            this.cmdWatchMagazinesList.Name = "cmdWatchMagazinesList";
            this.cmdWatchMagazinesList.Size = new System.Drawing.Size(83, 23);
            this.cmdWatchMagazinesList.TabIndex = 27;
            this.cmdWatchMagazinesList.Text = "Посмотреть";
            this.cmdWatchMagazinesList.UseVisualStyleBackColor = true;
            this.cmdWatchMagazinesList.Click += new System.EventHandler(this.cmdWatchMagazinesList_Click);
            // 
            // checkBoxIsMagazineListSort
            // 
            this.checkBoxIsMagazineListSort.AutoSize = true;
            this.checkBoxIsMagazineListSort.Location = new System.Drawing.Point(434, 340);
            this.checkBoxIsMagazineListSort.Name = "checkBoxIsMagazineListSort";
            this.checkBoxIsMagazineListSort.Size = new System.Drawing.Size(181, 17);
            this.checkBoxIsMagazineListSort.TabIndex = 26;
            this.checkBoxIsMagazineListSort.Text = "Сортировать по инвентарному";
            this.checkBoxIsMagazineListSort.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMagazineList
            // 
            this.richTextBoxMagazineList.Location = new System.Drawing.Point(308, 14);
            this.richTextBoxMagazineList.Name = "richTextBoxMagazineList";
            this.richTextBoxMagazineList.Size = new System.Drawing.Size(318, 320);
            this.richTextBoxMagazineList.TabIndex = 25;
            this.richTextBoxMagazineList.Text = "";
            // 
            // cmdAddMagazine
            // 
            this.cmdAddMagazine.Location = new System.Drawing.Point(98, 260);
            this.cmdAddMagazine.Name = "cmdAddMagazine";
            this.cmdAddMagazine.Size = new System.Drawing.Size(75, 23);
            this.cmdAddMagazine.TabIndex = 24;
            this.cmdAddMagazine.Text = "Добавить";
            this.cmdAddMagazine.UseVisualStyleBackColor = true;
            this.cmdAddMagazine.Click += new System.EventHandler(this.cmdAddMagazine_Click);
            // 
            // checkBoxIsMagazineAvailable
            // 
            this.checkBoxIsMagazineAvailable.AutoSize = true;
            this.checkBoxIsMagazineAvailable.Location = new System.Drawing.Point(11, 219);
            this.checkBoxIsMagazineAvailable.Name = "checkBoxIsMagazineAvailable";
            this.checkBoxIsMagazineAvailable.Size = new System.Drawing.Size(69, 17);
            this.checkBoxIsMagazineAvailable.TabIndex = 22;
            this.checkBoxIsMagazineAvailable.Text = "Наличие";
            this.checkBoxIsMagazineAvailable.UseVisualStyleBackColor = true;
            // 
            // numericUpDowMagazineInvNumber
            // 
            this.numericUpDowMagazineInvNumber.Location = new System.Drawing.Point(98, 174);
            this.numericUpDowMagazineInvNumber.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDowMagazineInvNumber.Name = "numericUpDowMagazineInvNumber";
            this.numericUpDowMagazineInvNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDowMagazineInvNumber.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Инв. номер";
            // 
            // numericUpDownMagainePublishedDate
            // 
            this.numericUpDownMagainePublishedDate.Location = new System.Drawing.Point(98, 97);
            this.numericUpDownMagainePublishedDate.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownMagainePublishedDate.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDownMagainePublishedDate.Name = "numericUpDownMagainePublishedDate";
            this.numericUpDownMagainePublishedDate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMagainePublishedDate.TabIndex = 19;
            this.numericUpDownMagainePublishedDate.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Номер";
            // 
            // numericUpDownMagazineNumber
            // 
            this.numericUpDownMagazineNumber.Location = new System.Drawing.Point(98, 131);
            this.numericUpDownMagazineNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMagazineNumber.Name = "numericUpDownMagazineNumber";
            this.numericUpDownMagazineNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMagazineNumber.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Дата выпуска";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Том";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Название";
            // 
            // textBoxMagazineVolume
            // 
            this.textBoxMagazineVolume.Location = new System.Drawing.Point(98, 48);
            this.textBoxMagazineVolume.Name = "textBoxMagazineVolume";
            this.textBoxMagazineVolume.Size = new System.Drawing.Size(184, 20);
            this.textBoxMagazineVolume.TabIndex = 12;
            // 
            // textBoxMagazineTitle
            // 
            this.textBoxMagazineTitle.Location = new System.Drawing.Point(98, 14);
            this.textBoxMagazineTitle.Name = "textBoxMagazineTitle";
            this.textBoxMagazineTitle.Size = new System.Drawing.Size(184, 20);
            this.textBoxMagazineTitle.TabIndex = 11;
            // 
            // BiblWorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BiblWorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookUsingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookInvNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookYearPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookPagesCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowMagazineInvNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagainePublishedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagazineNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBookUsingPeriod;
        private System.Windows.Forms.NumericUpDown numericUpDownBookInvNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownBookYearPublished;
        private System.Windows.Forms.NumericUpDown numericUpDownBookPagesCount;
        private System.Windows.Forms.TextBox textBoxBookPublisher;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdWatchBooksList;
        private System.Windows.Forms.Button cmdAddBook;
        private System.Windows.Forms.CheckBox checkBoxIsBookReturnOnTime;
        private System.Windows.Forms.CheckBox checkBoxIsBooksListSort;
        private System.Windows.Forms.CheckBox checkBoxIsBookAvailable;
        private System.Windows.Forms.RichTextBox richTextBoxBooksList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMagazineVolume;
        private System.Windows.Forms.TextBox textBoxMagazineTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownMagainePublishedDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownMagazineNumber;
        private System.Windows.Forms.NumericUpDown numericUpDowMagazineInvNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdWatchMagazinesList;
        private System.Windows.Forms.CheckBox checkBoxIsMagazineListSort;
        private System.Windows.Forms.RichTextBox richTextBoxMagazineList;
        private System.Windows.Forms.Button cmdAddMagazine;
        private System.Windows.Forms.CheckBox checkBoxIsMagazineAvailable;
    }
}