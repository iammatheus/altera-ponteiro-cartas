
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitleLista = new System.Windows.Forms.Label();
            this.backLeftLista = new System.Windows.Forms.TextBox();
            this.backBottomLista = new System.Windows.Forms.TextBox();
            this.borderRightLista = new System.Windows.Forms.TextBox();
            this.borderTopLista = new System.Windows.Forms.TextBox();
            this.backTitleLista = new System.Windows.Forms.TextBox();
            this.borderBottomTitleLista = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblTitleBuscar = new System.Windows.Forms.Label();
            this.lblTitleResultados = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lListaDeCartas
            // 
            this.lListaDeCartas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lListaDeCartas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lListaDeCartas.FormattingEnabled = true;
            this.lListaDeCartas.ItemHeight = 18;
            this.lListaDeCartas.Location = new System.Drawing.Point(11, 97);
            this.lListaDeCartas.Name = "lListaDeCartas";
            this.lListaDeCartas.Size = new System.Drawing.Size(337, 396);
            this.lListaDeCartas.TabIndex = 0;
            this.lListaDeCartas.Visible = false;
            this.lListaDeCartas.SelectedIndexChanged += new System.EventHandler(this.ListaDeCartas_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
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
            // txtOffset
            // 
            this.txtOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOffset.Location = new System.Drawing.Point(516, 251);
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
            this.txtPonteiro.Location = new System.Drawing.Point(516, 309);
            this.txtPonteiro.Multiline = true;
            this.txtPonteiro.Name = "txtPonteiro";
            this.txtPonteiro.Size = new System.Drawing.Size(83, 23);
            this.txtPonteiro.TabIndex = 3;
            this.txtPonteiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPonteiro.Visible = false;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOffset.Location = new System.Drawing.Point(383, 254);
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
            this.lblPonteiro.Location = new System.Drawing.Point(383, 312);
            this.lblPonteiro.Name = "lblPonteiro";
            this.lblPonteiro.Size = new System.Drawing.Size(109, 18);
            this.lblPonteiro.TabIndex = 5;
            this.lblPonteiro.Text = "Ponteiro atual:";
            this.lblPonteiro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 279);
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
            this.BtnAlterarPonteiro.Location = new System.Drawing.Point(494, 349);
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
            this.lblMessageInfo.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessageInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMessageInfo.Location = new System.Drawing.Point(358, 400);
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
            this.txtPonteiroCalculado.Location = new System.Drawing.Point(516, 280);
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
            this.lblPonteiroCalculado.Location = new System.Drawing.Point(383, 282);
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
            this.txtOffsetInicial.Multiline = true;
            this.txtOffsetInicial.Name = "txtOffsetInicial";
            this.txtOffsetInicial.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetInicial.TabIndex = 12;
            this.txtOffsetInicial.Text = "1CA190";
            this.txtOffsetInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetInicial.Visible = false;
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
            this.txtOffsetFinal.Multiline = true;
            this.txtOffsetFinal.Name = "txtOffsetFinal";
            this.txtOffsetFinal.Size = new System.Drawing.Size(83, 23);
            this.txtOffsetFinal.TabIndex = 15;
            this.txtOffsetFinal.Text = "1CA737";
            this.txtOffsetFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetFinal.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(460, 145);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 29);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Ok";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.backLeftLista.Size = new System.Drawing.Size(10, 415);
            this.backLeftLista.TabIndex = 19;
            this.backLeftLista.Visible = false;
            // 
            // backBottomLista
            // 
            this.backBottomLista.BackColor = System.Drawing.Color.White;
            this.backBottomLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backBottomLista.Enabled = false;
            this.backBottomLista.Location = new System.Drawing.Point(11, 493);
            this.backBottomLista.Multiline = true;
            this.backBottomLista.Name = "backBottomLista";
            this.backBottomLista.Size = new System.Drawing.Size(321, 8);
            this.backBottomLista.TabIndex = 21;
            this.backBottomLista.Visible = false;
            // 
            // borderRightLista
            // 
            this.borderRightLista.BackColor = System.Drawing.Color.Black;
            this.borderRightLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borderRightLista.Enabled = false;
            this.borderRightLista.Location = new System.Drawing.Point(346, 37);
            this.borderRightLista.Multiline = true;
            this.borderRightLista.Name = "borderRightLista";
            this.borderRightLista.Size = new System.Drawing.Size(1, 464);
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
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(332, 86);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(14, 12);
            this.textBox7.TabIndex = 26;
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
            this.lblTitleResultados.Location = new System.Drawing.Point(378, 211);
            this.lblTitleResultados.Name = "lblTitleResultados";
            this.lblTitleResultados.Size = new System.Drawing.Size(135, 29);
            this.lblTitleResultados.TabIndex = 28;
            this.lblTitleResultados.Text = "Resultados:";
            this.lblTitleResultados.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 500);
            this.Controls.Add(this.lblTitleResultados);
            this.Controls.Add(this.lblTitleBuscar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.borderBottomTitleLista);
            this.Controls.Add(this.borderTopLista);
            this.Controls.Add(this.borderRightLista);
            this.Controls.Add(this.backBottomLista);
            this.Controls.Add(this.backLeftLista);
            this.Controls.Add(this.lblTitleLista);
            this.Controls.Add(this.btnBuscar);
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
            this.Text = " Alterar Ponteiro de Carta";
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitleLista;
        private System.Windows.Forms.TextBox backLeftLista;
        private System.Windows.Forms.TextBox backBottomLista;
        private System.Windows.Forms.TextBox borderRightLista;
        private System.Windows.Forms.TextBox borderTopLista;
        private System.Windows.Forms.TextBox backTitleLista;
        private System.Windows.Forms.TextBox borderBottomTitleLista;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblTitleBuscar;
        private System.Windows.Forms.Label lblTitleResultados;
    }
}

