
namespace AlteraPonteiro
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
            this.lListaDeCartas = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.BtnBuscar = new System.Windows.Forms.Button();
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
            this.txtOffsetFinalPonteiro = new System.Windows.Forms.TextBox();
            this.txtOffsetInicialPonteiro = new System.Windows.Forms.TextBox();
            this.lblTitleBuscarPonteiro = new System.Windows.Forms.Label();
            this.lblOffsetInicialPonteiro = new System.Windows.Forms.Label();
            this.lblOffsetFinalPonteiro = new System.Windows.Forms.Label();
            this.backBottomScroll = new System.Windows.Forms.TextBox();
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.txtOffsetFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetFinal.Visible = false;
            this.txtOffsetFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCamposHexadecimal);
            this.txtOffsetFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaBotaoOk);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Enabled = false;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Location = new System.Drawing.Point(460, 246);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(105, 29);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Ok";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Visible = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblTitleLista
            // 
            this.lblTitleLista.AutoSize = true;
            this.lblTitleLista.BackColor = System.Drawing.Color.White;
            this.lblTitleLista.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleLista.Location = new System.Drawing.Point(78, 45);
            this.lblTitleLista.Name = "lblTitleLista";
            this.lblTitleLista.Size = new System.Drawing.Size(197, 33);
            this.lblTitleLista.TabIndex = 17;
            this.lblTitleLista.Text = "Lista de Cartas";
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
            // txtOffsetFinalPonteiro
            // 
            this.txtOffsetFinalPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffsetFinalPonteiro.Location = new System.Drawing.Point(482, 209);
            this.txtOffsetFinalPonteiro.MaxLength = 6;
            this.txtOffsetFinalPonteiro.Multiline = true;
            this.txtOffsetFinalPonteiro.Name = "txtOffsetFinalPonteiro";
            this.txtOffsetFinalPonteiro.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetFinalPonteiro.TabIndex = 29;
            this.txtOffsetFinalPonteiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetFinalPonteiro.Visible = false;
            this.txtOffsetFinalPonteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCamposHexadecimal);
            this.txtOffsetFinalPonteiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaBotaoOk);
            // 
            // txtOffsetInicialPonteiro
            // 
            this.txtOffsetInicialPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffsetInicialPonteiro.Location = new System.Drawing.Point(482, 180);
            this.txtOffsetInicialPonteiro.MaxLength = 6;
            this.txtOffsetInicialPonteiro.Multiline = true;
            this.txtOffsetInicialPonteiro.Name = "txtOffsetInicialPonteiro";
            this.txtOffsetInicialPonteiro.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetInicialPonteiro.TabIndex = 30;
            this.txtOffsetInicialPonteiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetInicialPonteiro.Visible = false;
            this.txtOffsetInicialPonteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCamposHexadecimal);
            this.txtOffsetInicialPonteiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidaBotaoOk);
            // 
            // lblTitleBuscarPonteiro
            // 
            this.lblTitleBuscarPonteiro.AutoSize = true;
            this.lblTitleBuscarPonteiro.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBuscarPonteiro.Location = new System.Drawing.Point(378, 140);
            this.lblTitleBuscarPonteiro.Name = "lblTitleBuscarPonteiro";
            this.lblTitleBuscarPonteiro.Size = new System.Drawing.Size(177, 29);
            this.lblTitleBuscarPonteiro.TabIndex = 31;
            this.lblTitleBuscarPonteiro.Text = "Buscar ponteiro";
            this.lblTitleBuscarPonteiro.Visible = false;
            // 
            // lblOffsetInicialPonteiro
            // 
            this.lblOffsetInicialPonteiro.AutoSize = true;
            this.lblOffsetInicialPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffsetInicialPonteiro.Location = new System.Drawing.Point(383, 183);
            this.lblOffsetInicialPonteiro.Name = "lblOffsetInicialPonteiro";
            this.lblOffsetInicialPonteiro.Size = new System.Drawing.Size(98, 18);
            this.lblOffsetInicialPonteiro.TabIndex = 32;
            this.lblOffsetInicialPonteiro.Text = "Offset inicial:";
            this.lblOffsetInicialPonteiro.Visible = false;
            // 
            // lblOffsetFinalPonteiro
            // 
            this.lblOffsetFinalPonteiro.AutoSize = true;
            this.lblOffsetFinalPonteiro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffsetFinalPonteiro.Location = new System.Drawing.Point(383, 211);
            this.lblOffsetFinalPonteiro.Name = "lblOffsetFinalPonteiro";
            this.lblOffsetFinalPonteiro.Size = new System.Drawing.Size(87, 18);
            this.lblOffsetFinalPonteiro.TabIndex = 33;
            this.lblOffsetFinalPonteiro.Text = "Offset final:";
            this.lblOffsetFinalPonteiro.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 552);
            this.Controls.Add(this.backBottomScroll);
            this.Controls.Add(this.lblOffsetFinalPonteiro);
            this.Controls.Add(this.lblOffsetInicialPonteiro);
            this.Controls.Add(this.lblTitleBuscarPonteiro);
            this.Controls.Add(this.txtOffsetInicialPonteiro);
            this.Controls.Add(this.txtOffsetFinalPonteiro);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Ponteiros Yu-Gi-Oh!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lListaDeCartas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.TextBox txtPonteiro;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Label lblPonteiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAlterarPonteiro;
        private System.Windows.Forms.Label lblMessageInfo;
        private System.Windows.Forms.TextBox txtPonteiroCalculado;
        private System.Windows.Forms.Label lblPonteiroCalculado;
        private System.Windows.Forms.TextBox txtOffsetInicial;
        private System.Windows.Forms.Label lblOffsetInicial;
        private System.Windows.Forms.Label lblOffsetFinal;
        private System.Windows.Forms.TextBox txtOffsetFinal;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label lblTitleLista;
        private System.Windows.Forms.TextBox backLeftLista;
        private System.Windows.Forms.TextBox backBottomLista;
        private System.Windows.Forms.TextBox borderRightLista;
        private System.Windows.Forms.TextBox borderTopLista;
        private System.Windows.Forms.TextBox backTitleLista;
        private System.Windows.Forms.TextBox borderBottomTitleLista;
        private System.Windows.Forms.TextBox backTopScroll;
        private System.Windows.Forms.Label lblTitleBuscar;
        private System.Windows.Forms.Label lblTitleResultados;
        private System.Windows.Forms.TextBox txtOffsetFinalPonteiro;
        private System.Windows.Forms.TextBox txtOffsetInicialPonteiro;
        private System.Windows.Forms.Label lblTitleBuscarPonteiro;
        private System.Windows.Forms.Label lblOffsetInicialPonteiro;
        private System.Windows.Forms.Label lblOffsetFinalPonteiro;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox backBottomScroll;
    }
}

