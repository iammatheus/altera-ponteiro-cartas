
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lListaDeCartas
            // 
            this.lListaDeCartas.FormattingEnabled = true;
            this.lListaDeCartas.ItemHeight = 15;
            this.lListaDeCartas.Location = new System.Drawing.Point(12, 43);
            this.lListaDeCartas.Name = "lListaDeCartas";
            this.lListaDeCartas.Size = new System.Drawing.Size(350, 379);
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
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
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
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SairToolStripMenuItem.Text = "&Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(442, 230);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.ReadOnly = true;
            this.txtOffset.Size = new System.Drawing.Size(100, 23);
            this.txtOffset.TabIndex = 2;
            this.txtOffset.Visible = false;
            // 
            // txtPonteiro
            // 
            this.txtPonteiro.Location = new System.Drawing.Point(585, 230);
            this.txtPonteiro.Name = "txtPonteiro";
            this.txtPonteiro.Size = new System.Drawing.Size(100, 23);
            this.txtPonteiro.TabIndex = 3;
            this.txtPonteiro.Visible = false;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(442, 212);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(42, 15);
            this.lblOffset.TabIndex = 4;
            this.lblOffset.Text = "Offset:";
            this.lblOffset.Visible = false;
            // 
            // lblPonteiro
            // 
            this.lblPonteiro.AutoSize = true;
            this.lblPonteiro.Location = new System.Drawing.Point(585, 209);
            this.lblPonteiro.Name = "lblPonteiro";
            this.lblPonteiro.Size = new System.Drawing.Size(55, 15);
            this.lblPonteiro.TabIndex = 5;
            this.lblPonteiro.Text = "Ponteiro:";
            this.lblPonteiro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // BtnAlterarPonteiro
            // 
            this.BtnAlterarPonteiro.Location = new System.Drawing.Point(521, 308);
            this.BtnAlterarPonteiro.Name = "BtnAlterarPonteiro";
            this.BtnAlterarPonteiro.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterarPonteiro.TabIndex = 8;
            this.BtnAlterarPonteiro.Text = "Alterar";
            this.BtnAlterarPonteiro.UseVisualStyleBackColor = true;
            this.BtnAlterarPonteiro.Visible = false;
            this.BtnAlterarPonteiro.Click += new System.EventHandler(this.BtnAlterarPonteiro_Click);
            // 
            // lblMessageInfo
            // 
            this.lblMessageInfo.AutoSize = true;
            this.lblMessageInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessageInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMessageInfo.Location = new System.Drawing.Point(368, 347);
            this.lblMessageInfo.MaximumSize = new System.Drawing.Size(373, 300);
            this.lblMessageInfo.MinimumSize = new System.Drawing.Size(370, 50);
            this.lblMessageInfo.Name = "lblMessageInfo";
            this.lblMessageInfo.Size = new System.Drawing.Size(370, 50);
            this.lblMessageInfo.TabIndex = 9;
            this.lblMessageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.lblMessageInfo);
            this.Controls.Add(this.BtnAlterarPonteiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPonteiro);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.txtPonteiro);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.lListaDeCartas);
            this.Controls.Add(this.menuStrip1);
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
    }
}

