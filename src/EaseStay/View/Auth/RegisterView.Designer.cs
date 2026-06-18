namespace EaseStay.View.Auth
{
    partial class RegisterView
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
            this.PBoxRegister = new System.Windows.Forms.PictureBox();
            this.TblRowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TblLogoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PBoxImageLogo = new System.Windows.Forms.PictureBox();
            this.LbTitleLogo = new System.Windows.Forms.Label();
            this.LbSubtitleLogo = new System.Windows.Forms.Label();
            this.TblRegisterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbTitleDescription = new System.Windows.Forms.Label();
            this.LbTextDescription = new System.Windows.Forms.Label();
            this.TBoxEmail = new StylizedComponents.Controls.StylizedTextBox();
            this.TBoxPassword = new StylizedComponents.Controls.StylizedTextBox();
            this.BtnRegister = new StylizedComponents.Controls.StylizedButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TBoxFirstName = new StylizedComponents.Controls.StylizedTextBox();
            this.TBoxLastName = new StylizedComponents.Controls.StylizedTextBox();
            this.TBoxConfirmPassword = new StylizedComponents.Controls.StylizedTextBox();
            this.TblLoginLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbRegisterText = new System.Windows.Forms.Label();
            this.LkLbLogin = new StylizedComponents.Controls.StylizedLinkLabel();
            this.TblImageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegister)).BeginInit();
            this.TblRowLayout.SuspendLayout();
            this.TblLogoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImageLogo)).BeginInit();
            this.TblRegisterLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TblLoginLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblImageLayout
            // 
            this.TblImageLayout.ColumnCount = 2;
            this.TblImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.Controls.Add(this.PBoxRegister, 1, 0);
            this.TblImageLayout.Controls.Add(this.TblRowLayout, 0, 0);
            this.TblImageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblImageLayout.Location = new System.Drawing.Point(0, 0);
            this.TblImageLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblImageLayout.Name = "TblImageLayout";
            this.TblImageLayout.RowCount = 1;
            this.TblImageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.Size = new System.Drawing.Size(768, 512);
            this.TblImageLayout.TabIndex = 1;
            // 
            // PBoxRegister
            // 
            this.PBoxRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxRegister.Image = global::EaseStay.Properties.Resources.Auth;
            this.PBoxRegister.Location = new System.Drawing.Point(384, 0);
            this.PBoxRegister.Margin = new System.Windows.Forms.Padding(0);
            this.PBoxRegister.Name = "PBoxRegister";
            this.PBoxRegister.Size = new System.Drawing.Size(384, 512);
            this.PBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxRegister.TabIndex = 0;
            this.PBoxRegister.TabStop = false;
            // 
            // TblRowLayout
            // 
            this.TblRowLayout.ColumnCount = 1;
            this.TblRowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblRowLayout.Controls.Add(this.TblLogoLayout, 0, 1);
            this.TblRowLayout.Controls.Add(this.TblRegisterLayout, 0, 3);
            this.TblRowLayout.Controls.Add(this.TblLoginLayout, 0, 5);
            this.TblRowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRowLayout.Location = new System.Drawing.Point(3, 3);
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
            this.TblLogoLayout.Location = new System.Drawing.Point(3, 4);
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
            this.PBoxImageLogo.Image = global::EaseStay.Properties.Resources.AppLogo;
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
            // TblRegisterLayout
            // 
            this.TblRegisterLayout.AutoSize = true;
            this.TblRegisterLayout.ColumnCount = 3;
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.TblRegisterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TblRegisterLayout.Controls.Add(this.LbTitleDescription, 1, 0);
            this.TblRegisterLayout.Controls.Add(this.LbTextDescription, 1, 1);
            this.TblRegisterLayout.Controls.Add(this.TBoxEmail, 1, 2);
            this.TblRegisterLayout.Controls.Add(this.TBoxPassword, 1, 4);
            this.TblRegisterLayout.Controls.Add(this.BtnRegister, 1, 7);
            this.TblRegisterLayout.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.TblRegisterLayout.Controls.Add(this.TBoxConfirmPassword, 1, 5);
            this.TblRegisterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRegisterLayout.Location = new System.Drawing.Point(3, 172);
            this.TblRegisterLayout.Name = "TblRegisterLayout";
            this.TblRegisterLayout.RowCount = 8;
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.Size = new System.Drawing.Size(372, 290);
            this.TblRegisterLayout.TabIndex = 1;
            // 
            // LbTitleDescription
            // 
            this.LbTitleDescription.AutoSize = true;
            this.LbTitleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LbTitleDescription.Location = new System.Drawing.Point(56, 3);
            this.LbTitleDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTitleDescription.Name = "LbTitleDescription";
            this.LbTitleDescription.Size = new System.Drawing.Size(187, 24);
            this.LbTitleDescription.TabIndex = 2;
            this.LbTitleDescription.Text = "Efectue o seu registo";
            // 
            // LbTextDescription
            // 
            this.LbTextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LbTextDescription.Location = new System.Drawing.Point(56, 33);
            this.LbTextDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTextDescription.Name = "LbTextDescription";
            this.LbTextDescription.Size = new System.Drawing.Size(240, 51);
            this.LbTextDescription.TabIndex = 3;
            this.LbTextDescription.Text = "Registre-se para partilhar e comparar os seus imóveis favoritos e melhorar a sua " +
    "experiência de pesquisa.";
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TBoxEmail.CornerRadius = 6;
            this.TBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.TBoxPassword.CornerRadius = 6;
            this.TBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxPassword.Location = new System.Drawing.Point(56, 171);
            this.TBoxPassword.Name = "TBoxPassword";
            this.TBoxPassword.PlaceholderText = "Senha";
            this.TBoxPassword.Size = new System.Drawing.Size(259, 35);
            this.TBoxPassword.TabIndex = 5;
            this.TBoxPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TBoxPassword.UseSystemPasswordChar = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.CornerRadius = 4;
            this.BtnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegister.Location = new System.Drawing.Point(56, 252);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(259, 35);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Registrar";
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TBoxFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBoxLastName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 128);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 40);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // TBoxFirstName
            // 
            this.TBoxFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.TBoxFirstName.CornerRadius = 8;
            this.TBoxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxFirstName.Location = new System.Drawing.Point(3, 3);
            this.TBoxFirstName.Name = "TBoxFirstName";
            this.TBoxFirstName.PlaceholderText = "Primeiro Nome";
            this.TBoxFirstName.Size = new System.Drawing.Size(126, 34);
            this.TBoxFirstName.TabIndex = 0;
            this.TBoxFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBoxLastName
            // 
            this.TBoxLastName.BackColor = System.Drawing.SystemColors.Control;
            this.TBoxLastName.CornerRadius = 8;
            this.TBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxLastName.Location = new System.Drawing.Point(135, 3);
            this.TBoxLastName.Name = "TBoxLastName";
            this.TBoxLastName.PlaceholderText = "Ultimo Nome";
            this.TBoxLastName.Size = new System.Drawing.Size(127, 34);
            this.TBoxLastName.TabIndex = 1;
            this.TBoxLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBoxConfirmPassword
            // 
            this.TBoxConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TBoxConfirmPassword.CornerRadius = 8;
            this.TBoxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxConfirmPassword.Location = new System.Drawing.Point(56, 212);
            this.TBoxConfirmPassword.Name = "TBoxConfirmPassword";
            this.TBoxConfirmPassword.PlaceholderText = "Confirmar Senha";
            this.TBoxConfirmPassword.Size = new System.Drawing.Size(259, 34);
            this.TBoxConfirmPassword.TabIndex = 8;
            this.TBoxConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // TblLoginLayout
            // 
            this.TblLoginLayout.AutoSize = true;
            this.TblLoginLayout.ColumnCount = 4;
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLoginLayout.Controls.Add(this.LbRegisterText, 1, 0);
            this.TblLoginLayout.Controls.Add(this.LkLbLogin, 2, 0);
            this.TblLoginLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLoginLayout.Location = new System.Drawing.Point(3, 479);
            this.TblLoginLayout.Name = "TblLoginLayout";
            this.TblLoginLayout.RowCount = 1;
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblLoginLayout.Size = new System.Drawing.Size(372, 21);
            this.TblLoginLayout.TabIndex = 2;
            // 
            // LbRegisterText
            // 
            this.LbRegisterText.AutoSize = true;
            this.LbRegisterText.Location = new System.Drawing.Point(98, 3);
            this.LbRegisterText.Margin = new System.Windows.Forms.Padding(3);
            this.LbRegisterText.Name = "LbRegisterText";
            this.LbRegisterText.Size = new System.Drawing.Size(97, 13);
            this.LbRegisterText.TabIndex = 0;
            this.LbRegisterText.Text = "Já tem uma conta?";
            // 
            // LkLbLogin
            // 
            this.LkLbLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LkLbLogin.Location = new System.Drawing.Point(201, 3);
            this.LkLbLogin.Name = "LkLbLogin";
            this.LkLbLogin.Size = new System.Drawing.Size(73, 15);
            this.LkLbLogin.TabIndex = 1;
            this.LkLbLogin.Text = "Efetue Login";
            this.LkLbLogin.Click += new System.EventHandler(this.LkLbLogin_Click);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblImageLayout);
            this.Name = "RegisterView";
            this.Size = new System.Drawing.Size(768, 512);
            this.TblImageLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegister)).EndInit();
            this.TblRowLayout.ResumeLayout(false);
            this.TblRowLayout.PerformLayout();
            this.TblLogoLayout.ResumeLayout(false);
            this.TblLogoLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImageLogo)).EndInit();
            this.TblRegisterLayout.ResumeLayout(false);
            this.TblRegisterLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TblLoginLayout.ResumeLayout(false);
            this.TblLoginLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblImageLayout;
        private System.Windows.Forms.PictureBox PBoxRegister;
        private System.Windows.Forms.TableLayoutPanel TblRowLayout;
        private System.Windows.Forms.TableLayoutPanel TblLogoLayout;
        private System.Windows.Forms.PictureBox PBoxImageLogo;
        private System.Windows.Forms.Label LbTitleLogo;
        private System.Windows.Forms.Label LbSubtitleLogo;
        private System.Windows.Forms.TableLayoutPanel TblRegisterLayout;
        private System.Windows.Forms.Label LbTitleDescription;
        private System.Windows.Forms.Label LbTextDescription;
        private StylizedComponents.Controls.StylizedTextBox TBoxEmail;
        private StylizedComponents.Controls.StylizedTextBox TBoxPassword;
        private StylizedComponents.Controls.StylizedButton BtnRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private StylizedComponents.Controls.StylizedTextBox TBoxFirstName;
        private StylizedComponents.Controls.StylizedTextBox TBoxLastName;
        private StylizedComponents.Controls.StylizedTextBox TBoxConfirmPassword;
        private System.Windows.Forms.TableLayoutPanel TblLoginLayout;
        private System.Windows.Forms.Label LbRegisterText;
        private StylizedComponents.Controls.StylizedLinkLabel LkLbLogin;
    }
}
