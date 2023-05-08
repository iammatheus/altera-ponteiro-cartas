
using System;
using System.Windows.Forms;

namespace AlteraPonteiro
{
    partial class FormCurrentCards
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
            this.TxtOffset = new System.Windows.Forms.TextBox();
            this.TxtCurrentPointer = new System.Windows.Forms.TextBox();
            this.LblOffset = new System.Windows.Forms.Label();
            this.LblCurrentPointer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnChangePointer = new System.Windows.Forms.Button();
            this.lblMessageInfo = new System.Windows.Forms.Label();
            this.TxtCalculatedPointer = new System.Windows.Forms.TextBox();
            this.LblCalculatedPointer = new System.Windows.Forms.Label();
            this.TxtStartOffset = new System.Windows.Forms.TextBox();
            this.LblStartOffset = new System.Windows.Forms.Label();
            this.LblLastOffset = new System.Windows.Forms.Label();
            this.TxtLastOffset = new System.Windows.Forms.TextBox();
            this.LblTitleSearchCards = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.BtnSearchCards = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblNewCards = new System.Windows.Forms.Label();
            this.lListNewCards = new System.Windows.Forms.ListBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.LblTitleNewCard = new System.Windows.Forms.Label();
            this.BtnSearchNewCard = new System.Windows.Forms.Button();
            this.TxtLastOffsetNewCard = new System.Windows.Forms.TextBox();
            this.LblLastOffsetNewCard = new System.Windows.Forms.Label();
            this.LblStartOffsetNewCard = new System.Windows.Forms.Label();
            this.TxtStartOffsetNewCard = new System.Windows.Forms.TextBox();
            this.LblResultNewCard = new System.Windows.Forms.Label();
            this.LblPointerCard = new System.Windows.Forms.Label();
            this.TxtPointerNewCard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblOffsetNewCard = new System.Windows.Forms.Label();
            this.TxtOffsetNewCard = new System.Windows.Forms.TextBox();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lListCardsView = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtOffset
            // 
            this.TxtOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtOffset.Location = new System.Drawing.Point(516, 331);
            this.TxtOffset.Multiline = true;
            this.TxtOffset.Name = "TxtOffset";
            this.TxtOffset.ReadOnly = true;
            this.TxtOffset.Size = new System.Drawing.Size(83, 23);
            this.TxtOffset.TabIndex = 2;
            this.TxtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOffset.Visible = false;
            // 
            // TxtCurrentPointer
            // 
            this.TxtCurrentPointer.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCurrentPointer.Location = new System.Drawing.Point(516, 389);
            this.TxtCurrentPointer.MaxLength = 4;
            this.TxtCurrentPointer.Multiline = true;
            this.TxtCurrentPointer.Name = "TxtCurrentPointer";
            this.TxtCurrentPointer.Size = new System.Drawing.Size(83, 23);
            this.TxtCurrentPointer.TabIndex = 3;
            this.TxtCurrentPointer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCurrentPointer.Visible = false;
            this.TxtCurrentPointer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidatesHexFields);
            // 
            // LblOffset
            // 
            this.LblOffset.AutoSize = true;
            this.LblOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOffset.Location = new System.Drawing.Point(380, 334);
            this.LblOffset.Name = "LblOffset";
            this.LblOffset.Size = new System.Drawing.Size(83, 18);
            this.LblOffset.TabIndex = 4;
            this.LblOffset.Text = "Card offset";
            this.LblOffset.Visible = false;
            // 
            // LblCurrentPointer
            // 
            this.LblCurrentPointer.AutoSize = true;
            this.LblCurrentPointer.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCurrentPointer.Location = new System.Drawing.Point(380, 392);
            this.LblCurrentPointer.Name = "LblCurrentPointer";
            this.LblCurrentPointer.Size = new System.Drawing.Size(111, 18);
            this.LblCurrentPointer.TabIndex = 5;
            this.LblCurrentPointer.Text = "Current pointer";
            this.LblCurrentPointer.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // BtnChangePointer
            // 
            this.BtnChangePointer.BackColor = System.Drawing.Color.LightGreen;
            this.BtnChangePointer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePointer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangePointer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BtnChangePointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePointer.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnChangePointer.Location = new System.Drawing.Point(494, 426);
            this.BtnChangePointer.Name = "BtnChangePointer";
            this.BtnChangePointer.Size = new System.Drawing.Size(105, 30);
            this.BtnChangePointer.TabIndex = 8;
            this.BtnChangePointer.Text = "Change";
            this.BtnChangePointer.UseVisualStyleBackColor = false;
            this.BtnChangePointer.Visible = false;
            this.BtnChangePointer.Click += new System.EventHandler(this.BtnChangePointer_Click);
            // 
            // lblMessageInfo
            // 
            this.lblMessageInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessageInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMessageInfo.Location = new System.Drawing.Point(357, 463);
            this.lblMessageInfo.MaximumSize = new System.Drawing.Size(373, 300);
            this.lblMessageInfo.MinimumSize = new System.Drawing.Size(270, 80);
            this.lblMessageInfo.Name = "lblMessageInfo";
            this.lblMessageInfo.Size = new System.Drawing.Size(270, 80);
            this.lblMessageInfo.TabIndex = 9;
            this.lblMessageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCalculatedPointer
            // 
            this.TxtCalculatedPointer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCalculatedPointer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCalculatedPointer.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCalculatedPointer.Location = new System.Drawing.Point(516, 360);
            this.TxtCalculatedPointer.Multiline = true;
            this.TxtCalculatedPointer.Name = "TxtCalculatedPointer";
            this.TxtCalculatedPointer.ReadOnly = true;
            this.TxtCalculatedPointer.Size = new System.Drawing.Size(83, 23);
            this.TxtCalculatedPointer.TabIndex = 10;
            this.TxtCalculatedPointer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCalculatedPointer.Visible = false;
            // 
            // LblCalculatedPointer
            // 
            this.LblCalculatedPointer.AutoSize = true;
            this.LblCalculatedPointer.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCalculatedPointer.Location = new System.Drawing.Point(380, 362);
            this.LblCalculatedPointer.Name = "LblCalculatedPointer";
            this.LblCalculatedPointer.Size = new System.Drawing.Size(133, 18);
            this.LblCalculatedPointer.TabIndex = 11;
            this.LblCalculatedPointer.Text = "Calculated pointer";
            this.LblCalculatedPointer.Visible = false;
            // 
            // TxtStartOffset
            // 
            this.TxtStartOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStartOffset.Location = new System.Drawing.Point(482, 77);
            this.TxtStartOffset.MaxLength = 6;
            this.TxtStartOffset.Multiline = true;
            this.TxtStartOffset.Name = "TxtStartOffset";
            this.TxtStartOffset.Size = new System.Drawing.Size(83, 23);
            this.TxtStartOffset.TabIndex = 12;
            this.TxtStartOffset.Text = "1C66D0";
            this.TxtStartOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtStartOffset.Visible = false;
            this.TxtStartOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidatesHexFields);
            this.TxtStartOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidateOkButton);
            // 
            // LblStartOffset
            // 
            this.LblStartOffset.AutoSize = true;
            this.LblStartOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStartOffset.Location = new System.Drawing.Point(383, 80);
            this.LblStartOffset.Name = "LblStartOffset";
            this.LblStartOffset.Size = new System.Drawing.Size(94, 18);
            this.LblStartOffset.TabIndex = 13;
            this.LblStartOffset.Text = "Initial offset:";
            this.LblStartOffset.Visible = false;
            // 
            // LblLastOffset
            // 
            this.LblLastOffset.AutoSize = true;
            this.LblLastOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLastOffset.Location = new System.Drawing.Point(383, 109);
            this.LblLastOffset.Name = "LblLastOffset";
            this.LblLastOffset.Size = new System.Drawing.Size(89, 18);
            this.LblLastOffset.TabIndex = 14;
            this.LblLastOffset.Text = "Final offset:";
            this.LblLastOffset.Visible = false;
            // 
            // TxtLastOffset
            // 
            this.TxtLastOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLastOffset.Location = new System.Drawing.Point(482, 106);
            this.TxtLastOffset.MaxLength = 6;
            this.TxtLastOffset.Multiline = true;
            this.TxtLastOffset.Name = "TxtLastOffset";
            this.TxtLastOffset.Size = new System.Drawing.Size(83, 23);
            this.TxtLastOffset.TabIndex = 15;
            this.TxtLastOffset.Text = "1C92CB";
            this.TxtLastOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLastOffset.Visible = false;
            this.TxtLastOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidatesHexFields);
            this.TxtLastOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidateOkButton);
            // 
            // LblTitleSearchCards
            // 
            this.LblTitleSearchCards.AutoSize = true;
            this.LblTitleSearchCards.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LblTitleSearchCards.Location = new System.Drawing.Point(378, 37);
            this.LblTitleSearchCards.Name = "LblTitleSearchCards";
            this.LblTitleSearchCards.Size = new System.Drawing.Size(152, 29);
            this.LblTitleSearchCards.TabIndex = 27;
            this.LblTitleSearchCards.Text = "Search Cards";
            this.LblTitleSearchCards.Visible = false;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblResultTitle.Location = new System.Drawing.Point(378, 291);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(91, 29);
            this.lblResultTitle.TabIndex = 28;
            this.lblResultTitle.Text = "Results";
            this.lblResultTitle.Visible = false;
            // 
            // BtnSearchCards
            // 
            this.BtnSearchCards.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchCards.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearchCards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BtnSearchCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchCards.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchCards.Location = new System.Drawing.Point(460, 144);
            this.BtnSearchCards.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearchCards.Name = "BtnSearchCards";
            this.BtnSearchCards.Size = new System.Drawing.Size(105, 29);
            this.BtnSearchCards.TabIndex = 16;
            this.BtnSearchCards.Text = "Search";
            this.BtnSearchCards.UseVisualStyleBackColor = false;
            this.BtnSearchCards.Visible = false;
            this.BtnSearchCards.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1361, 538);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(15, 10);
            this.textBox1.TabIndex = 44;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1361, 82);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(14, 12);
            this.textBox2.TabIndex = 43;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1029, 81);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 1);
            this.textBox3.TabIndex = 42;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(1029, 33);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(347, 1);
            this.textBox4.TabIndex = 40;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(1376, 33);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1, 515);
            this.textBox5.TabIndex = 39;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(1040, 543);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(321, 5);
            this.textBox6.TabIndex = 38;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(1030, 82);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(10, 466);
            this.textBox7.TabIndex = 37;
            this.textBox7.Visible = false;
            // 
            // lblNewCards
            // 
            this.lblNewCards.AutoSize = true;
            this.lblNewCards.BackColor = System.Drawing.Color.White;
            this.lblNewCards.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewCards.Location = new System.Drawing.Point(1107, 41);
            this.lblNewCards.Name = "lblNewCards";
            this.lblNewCards.Size = new System.Drawing.Size(174, 33);
            this.lblNewCards.TabIndex = 36;
            this.lblNewCards.Text = "Cartas novas";
            this.lblNewCards.Visible = false;
            // 
            // lListNewCards
            // 
            this.lListNewCards.BackColor = System.Drawing.SystemColors.Window;
            this.lListNewCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lListNewCards.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lListNewCards.FormattingEnabled = true;
            this.lListNewCards.ItemHeight = 18;
            this.lListNewCards.Location = new System.Drawing.Point(1040, 93);
            this.lListNewCards.Name = "lListNewCards";
            this.lListNewCards.ScrollAlwaysVisible = true;
            this.lListNewCards.Size = new System.Drawing.Size(337, 450);
            this.lListNewCards.TabIndex = 35;
            this.lListNewCards.Visible = false;
            this.lListNewCards.SelectedIndexChanged += new System.EventHandler(this.ListNewCards_SelectedIndexChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(1030, 33);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(346, 60);
            this.textBox8.TabIndex = 41;
            this.textBox8.Visible = false;
            // 
            // LblTitleNewCard
            // 
            this.LblTitleNewCard.AutoSize = true;
            this.LblTitleNewCard.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LblTitleNewCard.Location = new System.Drawing.Point(819, 37);
            this.LblTitleNewCard.Name = "LblTitleNewCard";
            this.LblTitleNewCard.Size = new System.Drawing.Size(198, 29);
            this.LblTitleNewCard.TabIndex = 50;
            this.LblTitleNewCard.Text = "Search new cards";
            this.LblTitleNewCard.Visible = false;
            // 
            // BtnSearchNewCard
            // 
            this.BtnSearchNewCard.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchNewCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchNewCard.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearchNewCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BtnSearchNewCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchNewCard.Location = new System.Drawing.Point(907, 147);
            this.BtnSearchNewCard.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearchNewCard.Name = "BtnSearchNewCard";
            this.BtnSearchNewCard.Size = new System.Drawing.Size(105, 29);
            this.BtnSearchNewCard.TabIndex = 49;
            this.BtnSearchNewCard.Text = "Switch";
            this.BtnSearchNewCard.UseVisualStyleBackColor = false;
            this.BtnSearchNewCard.Visible = false;
            this.BtnSearchNewCard.Click += new System.EventHandler(this.BtnSearchNewCard_Click);
            // 
            // TxtLastOffsetNewCard
            // 
            this.TxtLastOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLastOffsetNewCard.Location = new System.Drawing.Point(929, 109);
            this.TxtLastOffsetNewCard.MaxLength = 6;
            this.TxtLastOffsetNewCard.Multiline = true;
            this.TxtLastOffsetNewCard.Name = "TxtLastOffsetNewCard";
            this.TxtLastOffsetNewCard.Size = new System.Drawing.Size(83, 23);
            this.TxtLastOffsetNewCard.TabIndex = 48;
            this.TxtLastOffsetNewCard.Text = "1C99B1";
            this.TxtLastOffsetNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLastOffsetNewCard.Visible = false;
            // 
            // LblLastOffsetNewCard
            // 
            this.LblLastOffsetNewCard.AutoSize = true;
            this.LblLastOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLastOffsetNewCard.Location = new System.Drawing.Point(830, 112);
            this.LblLastOffsetNewCard.Name = "LblLastOffsetNewCard";
            this.LblLastOffsetNewCard.Size = new System.Drawing.Size(85, 18);
            this.LblLastOffsetNewCard.TabIndex = 47;
            this.LblLastOffsetNewCard.Text = "Final offset";
            this.LblLastOffsetNewCard.Visible = false;
            // 
            // LblStartOffsetNewCard
            // 
            this.LblStartOffsetNewCard.AutoSize = true;
            this.LblStartOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStartOffsetNewCard.Location = new System.Drawing.Point(830, 83);
            this.LblStartOffsetNewCard.Name = "LblStartOffsetNewCard";
            this.LblStartOffsetNewCard.Size = new System.Drawing.Size(90, 18);
            this.LblStartOffsetNewCard.TabIndex = 46;
            this.LblStartOffsetNewCard.Text = "Initial offset";
            this.LblStartOffsetNewCard.Visible = false;
            // 
            // TxtStartOffsetNewCard
            // 
            this.TxtStartOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStartOffsetNewCard.Location = new System.Drawing.Point(929, 80);
            this.TxtStartOffsetNewCard.MaxLength = 6;
            this.TxtStartOffsetNewCard.Multiline = true;
            this.TxtStartOffsetNewCard.Name = "TxtStartOffsetNewCard";
            this.TxtStartOffsetNewCard.Size = new System.Drawing.Size(83, 23);
            this.TxtStartOffsetNewCard.TabIndex = 45;
            this.TxtStartOffsetNewCard.Text = "1C9991";
            this.TxtStartOffsetNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtStartOffsetNewCard.Visible = false;
            // 
            // LblResultNewCard
            // 
            this.LblResultNewCard.AutoSize = true;
            this.LblResultNewCard.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LblResultNewCard.Location = new System.Drawing.Point(839, 291);
            this.LblResultNewCard.Name = "LblResultNewCard";
            this.LblResultNewCard.Size = new System.Drawing.Size(91, 29);
            this.LblResultNewCard.TabIndex = 56;
            this.LblResultNewCard.Text = "Results";
            this.LblResultNewCard.Visible = false;
            // 
            // LblPointerCard
            // 
            this.LblPointerCard.AutoSize = true;
            this.LblPointerCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPointerCard.Location = new System.Drawing.Point(840, 362);
            this.LblPointerCard.Name = "LblPointerCard";
            this.LblPointerCard.Size = new System.Drawing.Size(92, 18);
            this.LblPointerCard.TabIndex = 55;
            this.LblPointerCard.Text = "Card pointer";
            this.LblPointerCard.Visible = false;
            // 
            // TxtPointerNewCard
            // 
            this.TxtPointerNewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtPointerNewCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPointerNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPointerNewCard.Location = new System.Drawing.Point(935, 360);
            this.TxtPointerNewCard.Multiline = true;
            this.TxtPointerNewCard.Name = "TxtPointerNewCard";
            this.TxtPointerNewCard.ReadOnly = true;
            this.TxtPointerNewCard.Size = new System.Drawing.Size(83, 23);
            this.TxtPointerNewCard.TabIndex = 54;
            this.TxtPointerNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPointerNewCard.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(797, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 53;
            // 
            // LblOffsetNewCard
            // 
            this.LblOffsetNewCard.AutoSize = true;
            this.LblOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOffsetNewCard.Location = new System.Drawing.Point(840, 334);
            this.LblOffsetNewCard.Name = "LblOffsetNewCard";
            this.LblOffsetNewCard.Size = new System.Drawing.Size(83, 18);
            this.LblOffsetNewCard.TabIndex = 52;
            this.LblOffsetNewCard.Text = "Card offset";
            this.LblOffsetNewCard.Visible = false;
            // 
            // TxtOffsetNewCard
            // 
            this.TxtOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtOffsetNewCard.Location = new System.Drawing.Point(935, 331);
            this.TxtOffsetNewCard.Multiline = true;
            this.TxtOffsetNewCard.Name = "TxtOffsetNewCard";
            this.TxtOffsetNewCard.ReadOnly = true;
            this.TxtOffsetNewCard.Size = new System.Drawing.Size(83, 23);
            this.TxtOffsetNewCard.TabIndex = 51;
            this.TxtOffsetNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOffsetNewCard.Visible = false;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SairToolStripMenuItem.Text = "&Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.AboutToolStripMenuItem.Text = "&Sobre";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1377, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lListCardsView
            // 
            this.lListCardsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Name});
            this.lListCardsView.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lListCardsView.FullRowSelect = true;
            this.lListCardsView.GridLines = true;
            this.lListCardsView.HideSelection = false;
            this.lListCardsView.Location = new System.Drawing.Point(0, 27);
            this.lListCardsView.Name = "lListCardsView";
            this.lListCardsView.Size = new System.Drawing.Size(350, 530);
            this.lListCardsView.TabIndex = 57;
            this.lListCardsView.UseCompatibleStateImageBehavior = false;
            this.lListCardsView.View = System.Windows.Forms.View.Details;
            this.lListCardsView.SelectedIndexChanged += new System.EventHandler(this.ListCardsView_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 275;
            // 
            // FormCurrentCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 552);
            this.Controls.Add(this.lListCardsView);
            this.Controls.Add(this.LblResultNewCard);
            this.Controls.Add(this.LblPointerCard);
            this.Controls.Add(this.TxtPointerNewCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblOffsetNewCard);
            this.Controls.Add(this.TxtOffsetNewCard);
            this.Controls.Add(this.LblTitleNewCard);
            this.Controls.Add(this.BtnSearchNewCard);
            this.Controls.Add(this.TxtLastOffsetNewCard);
            this.Controls.Add(this.LblLastOffsetNewCard);
            this.Controls.Add(this.LblStartOffsetNewCard);
            this.Controls.Add(this.TxtStartOffsetNewCard);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lblNewCards);
            this.Controls.Add(this.lListNewCards);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.LblTitleSearchCards);
            this.Controls.Add(this.BtnSearchCards);
            this.Controls.Add(this.TxtLastOffset);
            this.Controls.Add(this.LblLastOffset);
            this.Controls.Add(this.LblStartOffset);
            this.Controls.Add(this.TxtStartOffset);
            this.Controls.Add(this.LblCalculatedPointer);
            this.Controls.Add(this.TxtCalculatedPointer);
            this.Controls.Add(this.lblMessageInfo);
            this.Controls.Add(this.BtnChangePointer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblCurrentPointer);
            this.Controls.Add(this.LblOffset);
            this.Controls.Add(this.TxtCurrentPointer);
            this.Controls.Add(this.TxtOffset);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Ponteiros Yu-Gi-Oh!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public System.Windows.Forms.TextBox TxtOffset;
        public System.Windows.Forms.TextBox TxtCurrentPointer;
        public System.Windows.Forms.Label LblOffset;
        public System.Windows.Forms.Label LblCurrentPointer;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnChangePointer;
        public System.Windows.Forms.Label lblMessageInfo;
        public System.Windows.Forms.TextBox TxtCalculatedPointer;
        public System.Windows.Forms.Label LblCalculatedPointer;
        public System.Windows.Forms.TextBox TxtStartOffset;
        public System.Windows.Forms.Label LblStartOffset;
        public System.Windows.Forms.Label LblLastOffset;
        public System.Windows.Forms.TextBox TxtLastOffset;
        public System.Windows.Forms.Label LblTitleSearchCards;
        public System.Windows.Forms.Label lblResultTitle;
        public System.Windows.Forms.Button BtnSearchCards;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.Label lblNewCards;
        public System.Windows.Forms.ListBox lListNewCards;
        private System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.Label LblTitleNewCard;
        public System.Windows.Forms.Button BtnSearchNewCard;
        public System.Windows.Forms.TextBox TxtLastOffsetNewCard;
        public System.Windows.Forms.Label LblLastOffsetNewCard;
        public System.Windows.Forms.Label LblStartOffsetNewCard;
        public System.Windows.Forms.TextBox TxtStartOffsetNewCard;
        public System.Windows.Forms.Label LblResultNewCard;
        public System.Windows.Forms.Label LblPointerCard;
        public System.Windows.Forms.TextBox TxtPointerNewCard;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label LblOffsetNewCard;
        public System.Windows.Forms.TextBox TxtOffsetNewCard;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lListCardsView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Name;
    }
}

