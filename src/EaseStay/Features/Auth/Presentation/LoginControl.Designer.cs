namespace EaseStay.Features.Auth.Presentation
{
    partial class LoginControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            Cleanup(disposing);
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TblImageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PBoxLogin = new System.Windows.Forms.PictureBox();
            this.TblRowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TblLogoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PBoxImageLogo = new System.Windows.Forms.PictureBox();
            this.LbTitleLogo = new System.Windows.Forms.Label();
            this.LbSubtitleLogo = new System.Windows.Forms.Label();
            this.TblLoginLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbTitleDescription = new System.Windows.Forms.Label();
            this.LbTextDescription = new System.Windows.Forms.Label();
            this.TBoxEmail = new StylizedComponents.Controls.StylizedTextBox();
            this.TBoxPassword = new StylizedComponents.Controls.StylizedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.LbBtnRecoverAccount = new System.Windows.Forms.Label();
            this.BtnLogin = new StylizedComponents.Controls.StylizedButton();
            this.TblRegisterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbRegisterText = new System.Windows.Forms.Label();
            this.LbBtnRegister = new System.Windows.Forms.Label();
            this.TblImageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).BeginInit();
            this.TblRowLayout.SuspendLayout();
            this.TblLogoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImageLogo)).BeginInit();
            this.TblLoginLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TblRegisterLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblImageLayout
            // 
            this.TblImageLayout.ColumnCount = 2;
            this.TblImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.Controls.Add(this.PBoxLogin, 0, 0);
            this.TblImageLayout.Controls.Add(this.TblRowLayout, 1, 0);
            this.TblImageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblImageLayout.Location = new System.Drawing.Point(0, 0);
            this.TblImageLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblImageLayout.Name = "TblImageLayout";
            this.TblImageLayout.RowCount = 1;
            this.TblImageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.Size = new System.Drawing.Size(768, 512);
            this.TblImageLayout.TabIndex = 0;
            // 
            // PBoxLogin
            // 
            this.PBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxLogin.Image = global::EaseStay.Properties.Resources.Auth_Image;
            this.PBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.PBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PBoxLogin.Name = "PBoxLogin";
            this.PBoxLogin.Size = new System.Drawing.Size(384, 512);
            this.PBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogin.TabIndex = 0;
            this.PBoxLogin.TabStop = false;
            // 
            // TblRowLayout
            // 
            this.TblRowLayout.ColumnCount = 1;
            this.TblRowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblRowLayout.Controls.Add(this.TblLogoLayout, 0, 1);
            this.TblRowLayout.Controls.Add(this.TblLoginLayout, 0, 3);
            this.TblRowLayout.Controls.Add(this.TblRegisterLayout, 0, 5);
            this.TblRowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRowLayout.Location = new System.Drawing.Point(387, 3);
            this.TblRowLayout.Name = "TblRowLayout";
            this.TblRowLayout.RowCount = 7;
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TblRowLayout.Size = new System.Drawing.Size(378, 506);
            this.TblRowLayout.TabIndex = 1;
            // 
            // TblLogoLayout
            // 
            this.TblLogoLayout.AutoSize = true;
            this.TblLogoLayout.ColumnCount = 3;
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblLogoLayout.Controls.Add(this.PBoxImageLogo, 1, 0);
            this.TblLogoLayout.Controls.Add(this.LbTitleLogo, 1, 1);
            this.TblLogoLayout.Controls.Add(this.LbSubtitleLogo, 1, 2);
            this.TblLogoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLogoLayout.Location = new System.Drawing.Point(3, 11);
            this.TblLogoLayout.Name = "TblLogoLayout";
            this.TblLogoLayout.RowCount = 3;
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.Size = new System.Drawing.Size(372, 159);
            this.TblLogoLayout.TabIndex = 0;
            // 
            // PBoxImageLogo
            // 
            this.PBoxImageLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxImageLogo.Image = global::EaseStay.Properties.Resources.Logo_128px;
            this.PBoxImageLogo.Location = new System.Drawing.Point(96, 3);
            this.PBoxImageLogo.Name = "PBoxImageLogo";
            this.PBoxImageLogo.Size = new System.Drawing.Size(180, 64);
            this.PBoxImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImageLogo.TabIndex = 0;
            this.PBoxImageLogo.TabStop = false;
            // 
            // LbTitleLogo
            // 
            this.LbTitleLogo.AutoSize = true;
            this.LbTitleLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitleLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LbTitleLogo.Location = new System.Drawing.Point(96, 73);
            this.LbTitleLogo.Margin = new System.Windows.Forms.Padding(3);
            this.LbTitleLogo.Name = "LbTitleLogo";
            this.LbTitleLogo.Size = new System.Drawing.Size(180, 37);
            this.LbTitleLogo.TabIndex = 1;
            this.LbTitleLogo.Text = "EaseStay";
            this.LbTitleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbSubtitleLogo
            // 
            this.LbSubtitleLogo.AutoSize = true;
            this.LbSubtitleLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbSubtitleLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbSubtitleLogo.Location = new System.Drawing.Point(96, 116);
            this.LbSubtitleLogo.Margin = new System.Windows.Forms.Padding(3);
            this.LbSubtitleLogo.Name = "LbSubtitleLogo";
            this.LbSubtitleLogo.Size = new System.Drawing.Size(180, 40);
            this.LbSubtitleLogo.TabIndex = 2;
            this.LbSubtitleLogo.Text = "Encontre um lugar para ficar!";
            this.LbSubtitleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TblLoginLayout
            // 
            this.TblLoginLayout.AutoSize = true;
            this.TblLoginLayout.ColumnCount = 3;
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TblLoginLayout.Controls.Add(this.LbTitleDescription, 1, 0);
            this.TblLoginLayout.Controls.Add(this.LbTextDescription, 1, 1);
            this.TblLoginLayout.Controls.Add(this.TBoxEmail, 1, 2);
            this.TblLoginLayout.Controls.Add(this.TBoxPassword, 1, 3);
            this.TblLoginLayout.Controls.Add(this.tableLayoutPanel1, 1, 4);
            this.TblLoginLayout.Controls.Add(this.BtnLogin, 1, 5);
            this.TblLoginLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLoginLayout.Location = new System.Drawing.Point(3, 192);
            this.TblLoginLayout.Name = "TblLoginLayout";
            this.TblLoginLayout.RowCount = 6;
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.Size = new System.Drawing.Size(372, 228);
            this.TblLoginLayout.TabIndex = 1;
            // 
            // LbTitleDescription
            // 
            this.LbTitleDescription.AutoSize = true;
            this.LbTitleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LbTitleDescription.Location = new System.Drawing.Point(56, 3);
            this.LbTitleDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTitleDescription.Name = "LbTitleDescription";
            this.LbTitleDescription.Size = new System.Drawing.Size(176, 24);
            this.LbTitleDescription.TabIndex = 2;
            this.LbTitleDescription.Text = "Bem-vindo de volta!";
            // 
            // LbTextDescription
            // 
            this.LbTextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LbTextDescription.Location = new System.Drawing.Point(56, 33);
            this.LbTextDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTextDescription.Name = "LbTextDescription";
            this.LbTextDescription.Size = new System.Drawing.Size(240, 51);
            this.LbTextDescription.TabIndex = 3;
            this.LbTextDescription.Text = "Faça login ou registre-se no nosso aplicativo para encontrar sua proxima parada!";
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TBoxEmail.BorderRadius = 6;
            this.TBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TBoxEmail.Location = new System.Drawing.Point(56, 90);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.PlaceholderText = "E-mail";
            this.TBoxEmail.Size = new System.Drawing.Size(259, 35);
            this.TBoxEmail.TabIndex = 4;
            this.TBoxEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBoxPassword
            // 
            this.TBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TBoxPassword.BorderRadius = 6;
            this.TBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TBoxPassword.Location = new System.Drawing.Point(56, 131);
            this.TBoxPassword.Name = "TBoxPassword";
            this.TBoxPassword.PlaceholderText = "Senha";
            this.TBoxPassword.Size = new System.Drawing.Size(259, 35);
            this.TBoxPassword.TabIndex = 5;
            this.TBoxPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TBoxPassword.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.CBoxRememberMe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbBtnRecoverAccount, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 169);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 23);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CBoxRememberMe
            // 
            this.CBoxRememberMe.AutoSize = true;
            this.CBoxRememberMe.Location = new System.Drawing.Point(3, 3);
            this.CBoxRememberMe.Name = "CBoxRememberMe";
            this.CBoxRememberMe.Size = new System.Drawing.Size(100, 17);
            this.CBoxRememberMe.TabIndex = 0;
            this.CBoxRememberMe.Text = "Lembrar de mim";
            this.CBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // LbBtnRecoverAccount
            // 
            this.LbBtnRecoverAccount.AutoSize = true;
            this.LbBtnRecoverAccount.Location = new System.Drawing.Point(154, 3);
            this.LbBtnRecoverAccount.Margin = new System.Windows.Forms.Padding(3);
            this.LbBtnRecoverAccount.Name = "LbBtnRecoverAccount";
            this.LbBtnRecoverAccount.Size = new System.Drawing.Size(108, 13);
            this.LbBtnRecoverAccount.TabIndex = 3;
            this.LbBtnRecoverAccount.Text = "Esqueci minha senha";
            this.LbBtnRecoverAccount.Click += new System.EventHandler(this.LbBtnRecoverAccount_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderRadius = 4;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLogin.HoverFilterStrength = 0.2F;
            this.BtnLogin.Location = new System.Drawing.Point(56, 195);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(259, 30);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TblRegisterLayout
            // 
            this.TblRegisterLayout.AutoSize = true;
            this.TblRegisterLayout.ColumnCount = 4;
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblRegisterLayout.Controls.Add(this.LbRegisterText, 1, 0);
            this.TblRegisterLayout.Controls.Add(this.LbBtnRegister, 2, 0);
            this.TblRegisterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRegisterLayout.Location = new System.Drawing.Point(3, 479);
            this.TblRegisterLayout.Name = "TblRegisterLayout";
            this.TblRegisterLayout.RowCount = 1;
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblRegisterLayout.Size = new System.Drawing.Size(372, 19);
            this.TblRegisterLayout.TabIndex = 2;
            // 
            // LbRegisterText
            // 
            this.LbRegisterText.AutoSize = true;
            this.LbRegisterText.Location = new System.Drawing.Point(90, 3);
            this.LbRegisterText.Margin = new System.Windows.Forms.Padding(3);
            this.LbRegisterText.Name = "LbRegisterText";
            this.LbRegisterText.Size = new System.Drawing.Size(106, 13);
            this.LbRegisterText.TabIndex = 0;
            this.LbRegisterText.Text = "Não tem uma conta?";
            // 
            // LbBtnRegister
            // 
            this.LbBtnRegister.AutoSize = true;
            this.LbBtnRegister.Location = new System.Drawing.Point(202, 3);
            this.LbBtnRegister.Margin = new System.Windows.Forms.Padding(3);
            this.LbBtnRegister.Name = "LbBtnRegister";
            this.LbBtnRegister.Size = new System.Drawing.Size(80, 13);
            this.LbBtnRegister.TabIndex = 3;
            this.LbBtnRegister.Text = "Registrar Agora";
            this.LbBtnRegister.Click += new System.EventHandler(this.LbBtnRegister_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblImageLayout);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(768, 512);
            this.TblImageLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).EndInit();
            this.TblRowLayout.ResumeLayout(false);
            this.TblRowLayout.PerformLayout();
            this.TblLogoLayout.ResumeLayout(false);
            this.TblLogoLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImageLogo)).EndInit();
            this.TblLoginLayout.ResumeLayout(false);
            this.TblLoginLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TblRegisterLayout.ResumeLayout(false);
            this.TblRegisterLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblImageLayout;
        private System.Windows.Forms.PictureBox PBoxLogin;
        private System.Windows.Forms.TableLayoutPanel TblRowLayout;
        private System.Windows.Forms.TableLayoutPanel TblLogoLayout;
        private System.Windows.Forms.PictureBox PBoxImageLogo;
        private System.Windows.Forms.Label LbTitleLogo;
        private System.Windows.Forms.Label LbSubtitleLogo;
        private System.Windows.Forms.TableLayoutPanel TblLoginLayout;
        private System.Windows.Forms.Label LbTitleDescription;
        private System.Windows.Forms.Label LbTextDescription;
        private StylizedComponents.Controls.StylizedTextBox TBoxEmail;
        private StylizedComponents.Controls.StylizedTextBox TBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox CBoxRememberMe;
        private System.Windows.Forms.TableLayoutPanel TblRegisterLayout;
        private System.Windows.Forms.Label LbRegisterText;
        private System.Windows.Forms.Label LbBtnRegister;
        private System.Windows.Forms.Label LbBtnRecoverAccount;
        private StylizedComponents.Controls.StylizedButton BtnLogin;
    }
}
