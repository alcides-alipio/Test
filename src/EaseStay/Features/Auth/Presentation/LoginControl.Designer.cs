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
            this.TBoxEmail = new EaseStay.Core.Elements.TextBoxStylized();
            this.textBoxStylized1 = new EaseStay.Core.Elements.TextBoxStylized();
            this.TblImageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).BeginInit();
            this.TblRowLayout.SuspendLayout();
            this.TblLogoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImageLogo)).BeginInit();
            this.TblLoginLayout.SuspendLayout();
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
            this.TblImageLayout.Size = new System.Drawing.Size(1179, 614);
            this.TblImageLayout.TabIndex = 0;
            // 
            // PBoxLogin
            // 
            this.PBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxLogin.Image = global::EaseStay.Properties.Resources.Auth_Image;
            this.PBoxLogin.Location = new System.Drawing.Point(0, 0);
            this.PBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PBoxLogin.Name = "PBoxLogin";
            this.PBoxLogin.Size = new System.Drawing.Size(589, 614);
            this.PBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogin.TabIndex = 0;
            this.PBoxLogin.TabStop = false;
            // 
            // TblRowLayout
            // 
            this.TblRowLayout.ColumnCount = 1;
            this.TblRowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblRowLayout.Controls.Add(this.TblLogoLayout, 0, 0);
            this.TblRowLayout.Controls.Add(this.TblLoginLayout, 0, 1);
            this.TblRowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRowLayout.Location = new System.Drawing.Point(592, 3);
            this.TblRowLayout.Name = "TblRowLayout";
            this.TblRowLayout.RowCount = 3;
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblRowLayout.Size = new System.Drawing.Size(584, 608);
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
            this.TblLogoLayout.Location = new System.Drawing.Point(3, 3);
            this.TblLogoLayout.Name = "TblLogoLayout";
            this.TblLogoLayout.RowCount = 3;
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.Size = new System.Drawing.Size(578, 139);
            this.TblLogoLayout.TabIndex = 0;
            // 
            // PBoxImageLogo
            // 
            this.PBoxImageLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxImageLogo.Image = global::EaseStay.Properties.Resources.Logo_128px;
            this.PBoxImageLogo.Location = new System.Drawing.Point(147, 3);
            this.PBoxImageLogo.Name = "PBoxImageLogo";
            this.PBoxImageLogo.Size = new System.Drawing.Size(283, 64);
            this.PBoxImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImageLogo.TabIndex = 0;
            this.PBoxImageLogo.TabStop = false;
            // 
            // LbTitleLogo
            // 
            this.LbTitleLogo.AutoSize = true;
            this.LbTitleLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitleLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LbTitleLogo.Location = new System.Drawing.Point(147, 73);
            this.LbTitleLogo.Margin = new System.Windows.Forms.Padding(3);
            this.LbTitleLogo.Name = "LbTitleLogo";
            this.LbTitleLogo.Size = new System.Drawing.Size(283, 37);
            this.LbTitleLogo.TabIndex = 1;
            this.LbTitleLogo.Text = "EaseStay";
            this.LbTitleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbSubtitleLogo
            // 
            this.LbSubtitleLogo.AutoSize = true;
            this.LbSubtitleLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbSubtitleLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbSubtitleLogo.Location = new System.Drawing.Point(147, 116);
            this.LbSubtitleLogo.Margin = new System.Windows.Forms.Padding(3);
            this.LbSubtitleLogo.Name = "LbSubtitleLogo";
            this.LbSubtitleLogo.Size = new System.Drawing.Size(283, 20);
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
            this.TblLoginLayout.Controls.Add(this.textBoxStylized1, 1, 3);
            this.TblLoginLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLoginLayout.Location = new System.Drawing.Point(3, 148);
            this.TblLoginLayout.Name = "TblLoginLayout";
            this.TblLoginLayout.RowCount = 4;
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLoginLayout.Size = new System.Drawing.Size(578, 169);
            this.TblLoginLayout.TabIndex = 1;
            // 
            // LbTitleDescription
            // 
            this.LbTitleDescription.AutoSize = true;
            this.LbTitleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LbTitleDescription.Location = new System.Drawing.Point(85, 3);
            this.LbTitleDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTitleDescription.Name = "LbTitleDescription";
            this.LbTitleDescription.Size = new System.Drawing.Size(176, 24);
            this.LbTitleDescription.TabIndex = 2;
            this.LbTitleDescription.Text = "Bem-vindo de volta!";
            // 
            // LbTextDescription
            // 
            this.LbTextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LbTextDescription.Location = new System.Drawing.Point(85, 33);
            this.LbTextDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTextDescription.Name = "LbTextDescription";
            this.LbTextDescription.Size = new System.Drawing.Size(240, 51);
            this.LbTextDescription.TabIndex = 3;
            this.LbTextDescription.Text = "Faça login ou registre-se no nosso aplicativo para encontrar sua proxima parada!";
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TBoxEmail.BorderRadius = 6;
            this.TBoxEmail.BorderWidth = 2F;
            this.TBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TBoxEmail.Location = new System.Drawing.Point(85, 90);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Placeholder = "E-mail";
            this.TBoxEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBoxEmail.Size = new System.Drawing.Size(406, 35);
            this.TBoxEmail.TabIndex = 4;
            // 
            // textBoxStylized1
            // 
            this.textBoxStylized1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStylized1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.textBoxStylized1.BorderRadius = 6;
            this.textBoxStylized1.BorderWidth = 2F;
            this.textBoxStylized1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStylized1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxStylized1.Location = new System.Drawing.Point(85, 131);
            this.textBoxStylized1.Name = "textBoxStylized1";
            this.textBoxStylized1.Placeholder = "Senha";
            this.textBoxStylized1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.textBoxStylized1.Size = new System.Drawing.Size(271, 35);
            this.textBoxStylized1.TabIndex = 5;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblImageLayout);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1179, 614);
            this.TblImageLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).EndInit();
            this.TblRowLayout.ResumeLayout(false);
            this.TblRowLayout.PerformLayout();
            this.TblLogoLayout.ResumeLayout(false);
            this.TblLogoLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImageLogo)).EndInit();
            this.TblLoginLayout.ResumeLayout(false);
            this.TblLoginLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblImageLayout;
        private System.Windows.Forms.PictureBox PBoxLogin;
        private System.Windows.Forms.TableLayoutPanel TblRowLayout;
        private System.Windows.Forms.TableLayoutPanel TblLogoLayout;
        private System.Windows.Forms.TableLayoutPanel TblLoginLayout;
        private System.Windows.Forms.PictureBox PBoxImageLogo;
        private System.Windows.Forms.Label LbTitleLogo;
        private System.Windows.Forms.Label LbSubtitleLogo;
        private System.Windows.Forms.Label LbTitleDescription;
        private System.Windows.Forms.Label LbTextDescription;
        private Core.Elements.TextBoxStylized TBoxEmail;
        private Core.Elements.TextBoxStylized textBoxStylized1;
    }
}
