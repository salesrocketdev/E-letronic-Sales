﻿namespace E_Sales
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkLembrar = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblAdmin = new MaterialSkin.Controls.MaterialLabel();
            this.lblGuest = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSelecionado = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgGuest = new System.Windows.Forms.PictureBox();
            this.imgAdmin = new System.Windows.Forms.PictureBox();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(69, 290);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(267, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TabStop = false;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // chkLembrar
            // 
            this.chkLembrar.AutoSize = true;
            this.chkLembrar.BackColor = System.Drawing.Color.Transparent;
            this.chkLembrar.Depth = 0;
            this.chkLembrar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkLembrar.ForeColor = System.Drawing.Color.Transparent;
            this.chkLembrar.Location = new System.Drawing.Point(66, 320);
            this.chkLembrar.Margin = new System.Windows.Forms.Padding(0);
            this.chkLembrar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkLembrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkLembrar.Name = "chkLembrar";
            this.chkLembrar.Ripple = true;
            this.chkLembrar.Size = new System.Drawing.Size(105, 30);
            this.chkLembrar.TabIndex = 3;
            this.chkLembrar.TabStop = false;
            this.chkLembrar.Text = "Lembrar-me";
            this.chkLembrar.UseVisualStyleBackColor = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(66, 356);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(267, 2);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.TabStop = false;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdmin.Depth = 0;
            this.lblAdmin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdmin.Location = new System.Drawing.Point(81, 210);
            this.lblAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(104, 19);
            this.lblAdmin.TabIndex = 9;
            this.lblAdmin.Text = "Administrador";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.BackColor = System.Drawing.Color.Transparent;
            this.lblGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGuest.Depth = 0;
            this.lblGuest.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuest.Location = new System.Drawing.Point(234, 210);
            this.lblGuest.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(80, 19);
            this.lblGuest.TabIndex = 10;
            this.lblGuest.Text = "Convidado";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(260, 316);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(73, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecionado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSelecionado.Depth = 0;
            this.lblSelecionado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelecionado.Location = new System.Drawing.Point(83, 10);
            this.lblSelecionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(156, 19);
            this.lblSelecionado.TabIndex = 13;
            this.lblSelecionado.Text = "Usuário Selecionado: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgGuest
            // 
            this.imgGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGuest.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgGuest.ErrorImage")));
            this.imgGuest.Image = ((System.Drawing.Image)(resources.GetObject("imgGuest.Image")));
            this.imgGuest.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgGuest.InitialImage")));
            this.imgGuest.Location = new System.Drawing.Point(210, 87);
            this.imgGuest.Name = "imgGuest";
            this.imgGuest.Size = new System.Drawing.Size(126, 120);
            this.imgGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGuest.TabIndex = 8;
            this.imgGuest.TabStop = false;
            this.imgGuest.Click += new System.EventHandler(this.imgGuest_Click);
            // 
            // imgAdmin
            // 
            this.imgAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAdmin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgAdmin.ErrorImage")));
            this.imgAdmin.Image = ((System.Drawing.Image)(resources.GetObject("imgAdmin.Image")));
            this.imgAdmin.Location = new System.Drawing.Point(69, 87);
            this.imgAdmin.Name = "imgAdmin";
            this.imgAdmin.Size = new System.Drawing.Size(126, 120);
            this.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAdmin.TabIndex = 7;
            this.imgAdmin.TabStop = false;
            this.imgAdmin.Click += new System.EventHandler(this.imgAdmin_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Depth = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnSair.Icon = null;
            this.btnSair.Location = new System.Drawing.Point(203, 316);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(51, 36);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(34)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSelecionado);
            this.panel1.Location = new System.Drawing.Point(-9, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 42);
            this.panel1.TabIndex = 15;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 244);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.imgGuest);
            this.Controls.Add(this.imgAdmin);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.chkLembrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 432);
            this.MinimumSize = new System.Drawing.Size(400, 244);
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialCheckBox chkLembrar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox imgAdmin;
        private System.Windows.Forms.PictureBox imgGuest;
        private MaterialSkin.Controls.MaterialLabel lblAdmin;
        private MaterialSkin.Controls.MaterialLabel lblGuest;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel lblSelecionado;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
        private System.Windows.Forms.Panel panel1;


    }
}

