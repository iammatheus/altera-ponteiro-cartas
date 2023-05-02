
using System;

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
            this.lListaDeCartas = new System.Windows.Forms.ListBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.txtPonteiro = new System.Windows.Forms.TextBox();
            this.lblOffset = new System.Windows.Forms.Label();
            this.lblPonteiro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAlterarPonteiro = new System.Windows.Forms.Button();
            this.lblMessageInfo = new System.Windows.Forms.Label();
            this.txtPonteiroCalculado = new System.Windows.Forms.TextBox();
            this.lblPonteiroCalculado = new System.Windows.Forms.Label();
            this.txtOffsetInicial = new System.Windows.Forms.TextBox();
            this.lblOffsetInicial = new System.Windows.Forms.Label();
            this.lblOffsetFinal = new System.Windows.Forms.Label();
            this.txtOffsetFinal = new System.Windows.Forms.TextBox();
            this.lblTitleLista = new System.Windows.Forms.Label();
            this.backLeftLista = new System.Windows.Forms.TextBox();
            this.backBottomLista = new System.Windows.Forms.TextBox();
            this.borderRightLista = new System.Windows.Forms.TextBox();
            this.borderTopLista = new System.Windows.Forms.TextBox();
            this.backTitleLista = new System.Windows.Forms.TextBox();
            this.borderBottomTitleLista = new System.Windows.Forms.TextBox();
            this.backTopScroll = new System.Windows.Forms.TextBox();
            this.lblTitleBuscar = new System.Windows.Forms.Label();
            this.lblTitleResultados = new System.Windows.Forms.Label();
            this.backBottomScroll = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
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
            this.lblTitleNewCard = new System.Windows.Forms.Label();
            this.BtnSearchNewCard = new System.Windows.Forms.Button();
            this.txtLastOffsetNewCard = new System.Windows.Forms.TextBox();
            this.lblLastOffsetNewCard = new System.Windows.Forms.Label();
            this.lblStartOffsetNewCard = new System.Windows.Forms.Label();
            this.txtStartOffsetNewCard = new System.Windows.Forms.TextBox();
            this.lblResultNewCard = new System.Windows.Forms.Label();
            this.lblPointerCard = new System.Windows.Forms.Label();
            this.txtPointerNewCard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOffsetNewCard = new System.Windows.Forms.Label();
            this.txtOffsetNewCard = new System.Windows.Forms.TextBox();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lListaDeCartas
            // 
            this.lListaDeCartas.BackColor = System.Drawing.SystemColors.Window;
            this.lListaDeCartas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lListaDeCartas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lListaDeCartas.FormattingEnabled = true;
            this.lListaDeCartas.ItemHeight = 18;
            this.lListaDeCartas.Location = new System.Drawing.Point(11, 97);
            this.lListaDeCartas.Name = "lListaDeCartas";
            this.lListaDeCartas.ScrollAlwaysVisible = true;
            this.lListaDeCartas.Size = new System.Drawing.Size(337, 450);
            this.lListaDeCartas.TabIndex = 0;
            this.lListaDeCartas.Visible = false;
            this.lListaDeCartas.SelectedIndexChanged += new System.EventHandler(this.ListaDeCartas_SelectedIndexChanged);
            // 
            // txtOffset
            // 
            this.txtOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffset.Location = new System.Drawing.Point(516, 331);
            this.txtOffset.Multiline = true;
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.ReadOnly = true;
            this.txtOffset.Size = new System.Drawing.Size(83, 23);
            this.txtOffset.TabIndex = 2;
            this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffset.Visible = false;
            // 
            // txtPonteiro
            // 
            this.txtPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPonteiro.Location = new System.Drawing.Point(516, 389);
            this.txtPonteiro.MaxLength = 4;
            this.txtPonteiro.Multiline = true;
            this.txtPonteiro.Name = "txtPonteiro";
            this.txtPonteiro.Size = new System.Drawing.Size(83, 23);
            this.txtPonteiro.TabIndex = 3;
            this.txtPonteiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPonteiro.Visible = false;
            this.txtPonteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCamposHexadecimal);
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffset.Location = new System.Drawing.Point(383, 334);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(112, 18);
            this.lblOffset.TabIndex = 4;
            this.lblOffset.Text = "Offset da carta:";
            this.lblOffset.Visible = false;
            // 
            // lblPonteiro
            // 
            this.lblPonteiro.AutoSize = true;
            this.lblPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPonteiro.Location = new System.Drawing.Point(383, 392);
            this.lblPonteiro.Name = "lblPonteiro";
            this.lblPonteiro.Size = new System.Drawing.Size(109, 18);
            this.lblPonteiro.TabIndex = 5;
            this.lblPonteiro.Text = "Ponteiro atual:";
            this.lblPonteiro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // BtnAlterarPonteiro
            // 
            this.BtnAlterarPonteiro.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAlterarPonteiro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAlterarPonteiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BtnAlterarPonteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterarPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarPonteiro.Location = new System.Drawing.Point(494, 426);
            this.BtnAlterarPonteiro.Name = "BtnAlterarPonteiro";
            this.BtnAlterarPonteiro.Size = new System.Drawing.Size(105, 30);
            this.BtnAlterarPonteiro.TabIndex = 8;
            this.BtnAlterarPonteiro.Text = "Alterar";
            this.BtnAlterarPonteiro.UseVisualStyleBackColor = false;
            this.BtnAlterarPonteiro.Visible = false;
            this.BtnAlterarPonteiro.Click += new System.EventHandler(this.BtnAlterarPonteiro_Click);
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
            // txtPonteiroCalculado
            // 
            this.txtPonteiroCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPonteiroCalculado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPonteiroCalculado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPonteiroCalculado.Location = new System.Drawing.Point(516, 360);
            this.txtPonteiroCalculado.Multiline = true;
            this.txtPonteiroCalculado.Name = "txtPonteiroCalculado";
            this.txtPonteiroCalculado.ReadOnly = true;
            this.txtPonteiroCalculado.Size = new System.Drawing.Size(83, 23);
            this.txtPonteiroCalculado.TabIndex = 10;
            this.txtPonteiroCalculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPonteiroCalculado.Visible = false;
            // 
            // lblPonteiroCalculado
            // 
            this.lblPonteiroCalculado.AutoSize = true;
            this.lblPonteiroCalculado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPonteiroCalculado.Location = new System.Drawing.Point(383, 362);
            this.lblPonteiroCalculado.Name = "lblPonteiroCalculado";
            this.lblPonteiroCalculado.Size = new System.Drawing.Size(130, 18);
            this.lblPonteiroCalculado.TabIndex = 11;
            this.lblPonteiroCalculado.Text = "Ponteiro da carta:";
            this.lblPonteiroCalculado.Visible = false;
            // 
            // txtOffsetInicial
            // 
            this.txtOffsetInicial.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffsetInicial.Location = new System.Drawing.Point(482, 77);
            this.txtOffsetInicial.MaxLength = 6;
            this.txtOffsetInicial.Multiline = true;
            this.txtOffsetInicial.Name = "txtOffsetInicial";
            this.txtOffsetInicial.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetInicial.TabIndex = 12;
            this.txtOffsetInicial.Text = "1C66D0";
            this.txtOffsetInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetInicial.Visible = false;
            this.txtOffsetInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCamposHexadecimal);
            this.txtOffsetInicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaBotaoOk);
            // 
            // lblOffsetInicial
            // 
            this.lblOffsetInicial.AutoSize = true;
            this.lblOffsetInicial.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffsetInicial.Location = new System.Drawing.Point(383, 80);
            this.lblOffsetInicial.Name = "lblOffsetInicial";
            this.lblOffsetInicial.Size = new System.Drawing.Size(98, 18);
            this.lblOffsetInicial.TabIndex = 13;
            this.lblOffsetInicial.Text = "Offset inicial:";
            this.lblOffsetInicial.Visible = false;
            // 
            // lblOffsetFinal
            // 
            this.lblOffsetFinal.AutoSize = true;
            this.lblOffsetFinal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffsetFinal.Location = new System.Drawing.Point(383, 109);
            this.lblOffsetFinal.Name = "lblOffsetFinal";
            this.lblOffsetFinal.Size = new System.Drawing.Size(87, 18);
            this.lblOffsetFinal.TabIndex = 14;
            this.lblOffsetFinal.Text = "Offset final:";
            this.lblOffsetFinal.Visible = false;
            // 
            // txtOffsetFinal
            // 
            this.txtOffsetFinal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffsetFinal.Location = new System.Drawing.Point(482, 106);
            this.txtOffsetFinal.MaxLength = 6;
            this.txtOffsetFinal.Multiline = true;
            this.txtOffsetFinal.Name = "txtOffsetFinal";
            this.txtOffsetFinal.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetFinal.TabIndex = 15;
            this.txtOffsetFinal.Text = "1C92CB";
            this.txtOffsetFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetFinal.Visible = false;
            this.txtOffsetFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCamposHexadecimal);
            this.txtOffsetFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaBotaoOk);
            // 
            // lblTitleLista
            // 
            this.lblTitleLista.AutoSize = true;
            this.lblTitleLista.BackColor = System.Drawing.Color.White;
            this.lblTitleLista.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleLista.Location = new System.Drawing.Point(78, 45);
            this.lblTitleLista.Name = "lblTitleLista";
            this.lblTitleLista.Size = new System.Drawing.Size(176, 33);
            this.lblTitleLista.TabIndex = 17;
            this.lblTitleLista.Text = "Cartas atuais";
            this.lblTitleLista.Visible = false;
            // 
            // backLeftLista
            // 
            this.backLeftLista.BackColor = System.Drawing.Color.White;
            this.backLeftLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backLeftLista.Enabled = false;
            this.backLeftLista.Location = new System.Drawing.Point(1, 86);
            this.backLeftLista.Multiline = true;
            this.backLeftLista.Name = "backLeftLista";
            this.backLeftLista.Size = new System.Drawing.Size(10, 466);
            this.backLeftLista.TabIndex = 19;
            this.backLeftLista.Visible = false;
            // 
            // backBottomLista
            // 
            this.backBottomLista.BackColor = System.Drawing.Color.White;
            this.backBottomLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backBottomLista.Enabled = false;
            this.backBottomLista.Location = new System.Drawing.Point(11, 547);
            this.backBottomLista.Multiline = true;
            this.backBottomLista.Name = "backBottomLista";
            this.backBottomLista.Size = new System.Drawing.Size(321, 5);
            this.backBottomLista.TabIndex = 21;
            this.backBottomLista.Visible = false;
            // 
            // borderRightLista
            // 
            this.borderRightLista.BackColor = System.Drawing.Color.Black;
            this.borderRightLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borderRightLista.Enabled = false;
            this.borderRightLista.Location = new System.Drawing.Point(347, 37);
            this.borderRightLista.Multiline = true;
            this.borderRightLista.Name = "borderRightLista";
            this.borderRightLista.Size = new System.Drawing.Size(1, 515);
            this.borderRightLista.TabIndex = 22;
            this.borderRightLista.Visible = false;
            // 
            // borderTopLista
            // 
            this.borderTopLista.BackColor = System.Drawing.Color.Black;
            this.borderTopLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borderTopLista.Enabled = false;
            this.borderTopLista.Location = new System.Drawing.Point(0, 37);
            this.borderTopLista.Multiline = true;
            this.borderTopLista.Name = "borderTopLista";
            this.borderTopLista.Size = new System.Drawing.Size(347, 1);
            this.borderTopLista.TabIndex = 23;
            this.borderTopLista.Visible = false;
            // 
            // backTitleLista
            // 
            this.backTitleLista.BackColor = System.Drawing.Color.White;
            this.backTitleLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backTitleLista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.backTitleLista.Enabled = false;
            this.backTitleLista.Location = new System.Drawing.Point(1, 37);
            this.backTitleLista.Multiline = true;
            this.backTitleLista.Name = "backTitleLista";
            this.backTitleLista.ReadOnly = true;
            this.backTitleLista.Size = new System.Drawing.Size(346, 60);
            this.backTitleLista.TabIndex = 24;
            this.backTitleLista.Visible = false;
            // 
            // borderBottomTitleLista
            // 
            this.borderBottomTitleLista.BackColor = System.Drawing.Color.Black;
            this.borderBottomTitleLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borderBottomTitleLista.Enabled = false;
            this.borderBottomTitleLista.Location = new System.Drawing.Point(0, 85);
            this.borderBottomTitleLista.Multiline = true;
            this.borderBottomTitleLista.Name = "borderBottomTitleLista";
            this.borderBottomTitleLista.Size = new System.Drawing.Size(347, 1);
            this.borderBottomTitleLista.TabIndex = 25;
            this.borderBottomTitleLista.Visible = false;
            // 
            // backTopScroll
            // 
            this.backTopScroll.BackColor = System.Drawing.SystemColors.Control;
            this.backTopScroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backTopScroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.backTopScroll.Enabled = false;
            this.backTopScroll.Location = new System.Drawing.Point(332, 86);
            this.backTopScroll.Multiline = true;
            this.backTopScroll.Name = "backTopScroll";
            this.backTopScroll.ReadOnly = true;
            this.backTopScroll.Size = new System.Drawing.Size(14, 12);
            this.backTopScroll.TabIndex = 26;
            this.backTopScroll.Visible = false;
            // 
            // lblTitleBuscar
            // 
            this.lblTitleBuscar.AutoSize = true;
            this.lblTitleBuscar.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBuscar.Location = new System.Drawing.Point(378, 37);
            this.lblTitleBuscar.Name = "lblTitleBuscar";
            this.lblTitleBuscar.Size = new System.Drawing.Size(158, 29);
            this.lblTitleBuscar.TabIndex = 27;
            this.lblTitleBuscar.Text = "Buscar cartas";
            this.lblTitleBuscar.Visible = false;
            // 
            // lblTitleResultados
            // 
            this.lblTitleResultados.AutoSize = true;
            this.lblTitleResultados.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTitleResultados.Location = new System.Drawing.Point(378, 291);
            this.lblTitleResultados.Name = "lblTitleResultados";
            this.lblTitleResultados.Size = new System.Drawing.Size(135, 29);
            this.lblTitleResultados.TabIndex = 28;
            this.lblTitleResultados.Text = "Resultados:";
            this.lblTitleResultados.Visible = false;
            // 
            // backBottomScroll
            // 
            this.backBottomScroll.BackColor = System.Drawing.SystemColors.Control;
            this.backBottomScroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backBottomScroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.backBottomScroll.Enabled = false;
            this.backBottomScroll.Location = new System.Drawing.Point(332, 542);
            this.backBottomScroll.Multiline = true;
            this.backBottomScroll.Name = "backBottomScroll";
            this.backBottomScroll.ReadOnly = true;
            this.backBottomScroll.Size = new System.Drawing.Size(15, 10);
            this.backBottomScroll.TabIndex = 34;
            this.backBottomScroll.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Location = new System.Drawing.Point(460, 144);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(105, 29);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Ok";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Visible = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            // lblTitleNewCard
            // 
            this.lblTitleNewCard.AutoSize = true;
            this.lblTitleNewCard.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNewCard.Location = new System.Drawing.Point(797, 37);
            this.lblTitleNewCard.Name = "lblTitleNewCard";
            this.lblTitleNewCard.Size = new System.Drawing.Size(227, 29);
            this.lblTitleNewCard.TabIndex = 50;
            this.lblTitleNewCard.Text = "Buscar cartas novas";
            this.lblTitleNewCard.Visible = false;
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
            this.BtnSearchNewCard.Text = "Trocar";
            this.BtnSearchNewCard.UseVisualStyleBackColor = false;
            this.BtnSearchNewCard.Visible = false;
            this.BtnSearchNewCard.Click += new System.EventHandler(this.BtnSearchNewCard_Click);
            // 
            // txtLastOffsetNewCard
            // 
            this.txtLastOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastOffsetNewCard.Location = new System.Drawing.Point(929, 109);
            this.txtLastOffsetNewCard.MaxLength = 6;
            this.txtLastOffsetNewCard.Multiline = true;
            this.txtLastOffsetNewCard.Name = "txtLastOffsetNewCard";
            this.txtLastOffsetNewCard.Size = new System.Drawing.Size(83, 23);
            this.txtLastOffsetNewCard.TabIndex = 48;
            this.txtLastOffsetNewCard.Text = "1C99B1";
            this.txtLastOffsetNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastOffsetNewCard.Visible = false;
            // 
            // lblLastOffsetNewCard
            // 
            this.lblLastOffsetNewCard.AutoSize = true;
            this.lblLastOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastOffsetNewCard.Location = new System.Drawing.Point(830, 112);
            this.lblLastOffsetNewCard.Name = "lblLastOffsetNewCard";
            this.lblLastOffsetNewCard.Size = new System.Drawing.Size(87, 18);
            this.lblLastOffsetNewCard.TabIndex = 47;
            this.lblLastOffsetNewCard.Text = "Offset final:";
            this.lblLastOffsetNewCard.Visible = false;
            // 
            // lblStartOffsetNewCard
            // 
            this.lblStartOffsetNewCard.AutoSize = true;
            this.lblStartOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartOffsetNewCard.Location = new System.Drawing.Point(830, 83);
            this.lblStartOffsetNewCard.Name = "lblStartOffsetNewCard";
            this.lblStartOffsetNewCard.Size = new System.Drawing.Size(98, 18);
            this.lblStartOffsetNewCard.TabIndex = 46;
            this.lblStartOffsetNewCard.Text = "Offset inicial:";
            this.lblStartOffsetNewCard.Visible = false;
            // 
            // txtStartOffsetNewCard
            // 
            this.txtStartOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartOffsetNewCard.Location = new System.Drawing.Point(929, 80);
            this.txtStartOffsetNewCard.MaxLength = 6;
            this.txtStartOffsetNewCard.Multiline = true;
            this.txtStartOffsetNewCard.Name = "txtStartOffsetNewCard";
            this.txtStartOffsetNewCard.Size = new System.Drawing.Size(83, 23);
            this.txtStartOffsetNewCard.TabIndex = 45;
            this.txtStartOffsetNewCard.Text = "1C9991";
            this.txtStartOffsetNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartOffsetNewCard.Visible = false;
            // 
            // lblResultNewCard
            // 
            this.lblResultNewCard.AutoSize = true;
            this.lblResultNewCard.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblResultNewCard.Location = new System.Drawing.Point(797, 291);
            this.lblResultNewCard.Name = "lblResultNewCard";
            this.lblResultNewCard.Size = new System.Drawing.Size(135, 29);
            this.lblResultNewCard.TabIndex = 56;
            this.lblResultNewCard.Text = "Resultados:";
            this.lblResultNewCard.Visible = false;
            // 
            // lblPointerCard
            // 
            this.lblPointerCard.AutoSize = true;
            this.lblPointerCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPointerCard.Location = new System.Drawing.Point(802, 362);
            this.lblPointerCard.Name = "lblPointerCard";
            this.lblPointerCard.Size = new System.Drawing.Size(130, 18);
            this.lblPointerCard.TabIndex = 55;
            this.lblPointerCard.Text = "Ponteiro da carta:";
            this.lblPointerCard.Visible = false;
            // 
            // txtPointerNewCard
            // 
            this.txtPointerNewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPointerNewCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPointerNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPointerNewCard.Location = new System.Drawing.Point(935, 360);
            this.txtPointerNewCard.Multiline = true;
            this.txtPointerNewCard.Name = "txtPointerNewCard";
            this.txtPointerNewCard.ReadOnly = true;
            this.txtPointerNewCard.Size = new System.Drawing.Size(83, 23);
            this.txtPointerNewCard.TabIndex = 54;
            this.txtPointerNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPointerNewCard.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(797, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 53;
            // 
            // lblOffsetNewCard
            // 
            this.lblOffsetNewCard.AutoSize = true;
            this.lblOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffsetNewCard.Location = new System.Drawing.Point(802, 334);
            this.lblOffsetNewCard.Name = "lblOffsetNewCard";
            this.lblOffsetNewCard.Size = new System.Drawing.Size(112, 18);
            this.lblOffsetNewCard.TabIndex = 52;
            this.lblOffsetNewCard.Text = "Offset da carta:";
            this.lblOffsetNewCard.Visible = false;
            // 
            // txtOffsetNewCard
            // 
            this.txtOffsetNewCard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffsetNewCard.Location = new System.Drawing.Point(935, 331);
            this.txtOffsetNewCard.Multiline = true;
            this.txtOffsetNewCard.Name = "txtOffsetNewCard";
            this.txtOffsetNewCard.ReadOnly = true;
            this.txtOffsetNewCard.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetNewCard.TabIndex = 51;
            this.txtOffsetNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetNewCard.Visible = false;
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
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SairToolStripMenuItem.Text = "&Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
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
            // FormCurrentCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 552);
            this.Controls.Add(this.lblResultNewCard);
            this.Controls.Add(this.lblPointerCard);
            this.Controls.Add(this.txtPointerNewCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOffsetNewCard);
            this.Controls.Add(this.txtOffsetNewCard);
            this.Controls.Add(this.lblTitleNewCard);
            this.Controls.Add(this.BtnSearchNewCard);
            this.Controls.Add(this.txtLastOffsetNewCard);
            this.Controls.Add(this.lblLastOffsetNewCard);
            this.Controls.Add(this.lblStartOffsetNewCard);
            this.Controls.Add(this.txtStartOffsetNewCard);
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
            this.Controls.Add(this.backBottomScroll);
            this.Controls.Add(this.lblTitleResultados);
            this.Controls.Add(this.lblTitleBuscar);
            this.Controls.Add(this.backTopScroll);
            this.Controls.Add(this.borderBottomTitleLista);
            this.Controls.Add(this.borderTopLista);
            this.Controls.Add(this.borderRightLista);
            this.Controls.Add(this.backBottomLista);
            this.Controls.Add(this.backLeftLista);
            this.Controls.Add(this.lblTitleLista);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtOffsetFinal);
            this.Controls.Add(this.lblOffsetFinal);
            this.Controls.Add(this.lblOffsetInicial);
            this.Controls.Add(this.txtOffsetInicial);
            this.Controls.Add(this.lblPonteiroCalculado);
            this.Controls.Add(this.txtPonteiroCalculado);
            this.Controls.Add(this.lblMessageInfo);
            this.Controls.Add(this.BtnAlterarPonteiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPonteiro);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.txtPonteiro);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.lListaDeCartas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.backTitleLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCurrentCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Ponteiros Yu-Gi-Oh!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.ListBox lListaDeCartas;
        public System.Windows.Forms.TextBox txtOffset;
        public System.Windows.Forms.TextBox txtPonteiro;
        public System.Windows.Forms.Label lblOffset;
        public System.Windows.Forms.Label lblPonteiro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnAlterarPonteiro;
        public System.Windows.Forms.Label lblMessageInfo;
        public System.Windows.Forms.TextBox txtPonteiroCalculado;
        public System.Windows.Forms.Label lblPonteiroCalculado;
        public System.Windows.Forms.TextBox txtOffsetInicial;
        public System.Windows.Forms.Label lblOffsetInicial;
        public System.Windows.Forms.Label lblOffsetFinal;
        public System.Windows.Forms.TextBox txtOffsetFinal;
        public System.Windows.Forms.Label lblTitleLista;
        public System.Windows.Forms.TextBox backLeftLista;
        public System.Windows.Forms.TextBox backBottomLista;
        public System.Windows.Forms.TextBox borderRightLista;
        public System.Windows.Forms.TextBox borderTopLista;
        public System.Windows.Forms.TextBox backTitleLista;
        public System.Windows.Forms.TextBox borderBottomTitleLista;
        public System.Windows.Forms.TextBox backTopScroll;
        public System.Windows.Forms.Label lblTitleBuscar;
        public System.Windows.Forms.Label lblTitleResultados;
        public System.Windows.Forms.TextBox backBottomScroll;
        public System.Windows.Forms.Button BtnBuscar;
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
        public System.Windows.Forms.Label lblTitleNewCard;
        public System.Windows.Forms.Button BtnSearchNewCard;
        public System.Windows.Forms.TextBox txtLastOffsetNewCard;
        public System.Windows.Forms.Label lblLastOffsetNewCard;
        public System.Windows.Forms.Label lblStartOffsetNewCard;
        public System.Windows.Forms.TextBox txtStartOffsetNewCard;
        public System.Windows.Forms.Label lblResultNewCard;
        public System.Windows.Forms.Label lblPointerCard;
        public System.Windows.Forms.TextBox txtPointerNewCard;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblOffsetNewCard;
        public System.Windows.Forms.TextBox txtOffsetNewCard;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

