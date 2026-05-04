namespace EaseStay.Features.Auth.Presentation
{
    partial class RecoverAccount_FindAccount
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
            this.PBoxAuth = new System.Windows.Forms.PictureBox();
            this.TblRowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TblRegisterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbTitleDescription = new System.Windows.Forms.Label();
            this.LbTextDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TBoxEmail = new EaseStay.Core.Elements.TextBoxStylized();
            this.BtnFindAccount = new System.Windows.Forms.Button();
            this.TblImageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAuth)).BeginInit();
            this.TblRowLayout.SuspendLayout();
            this.TblRegisterLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblImageLayout
            // 
            this.TblImageLayout.ColumnCount = 2;
            this.TblImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.Controls.Add(this.PBoxAuth, 1, 0);
            this.TblImageLayout.Controls.Add(this.TblRowLayout, 0, 0);
            this.TblImageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblImageLayout.Location = new System.Drawing.Point(0, 0);
            this.TblImageLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblImageLayout.Name = "TblImageLayout";
            this.TblImageLayout.RowCount = 1;
            this.TblImageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblImageLayout.Size = new System.Drawing.Size(768, 512);
            this.TblImageLayout.TabIndex = 0;
            // 
            // PBoxAuth
            // 
            this.PBoxAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxAuth.Image = global::EaseStay.Properties.Resources.Auth_Image;
            this.PBoxAuth.Location = new System.Drawing.Point(384, 0);
            this.PBoxAuth.Margin = new System.Windows.Forms.Padding(0);
            this.PBoxAuth.Name = "PBoxAuth";
            this.PBoxAuth.Size = new System.Drawing.Size(384, 512);
            this.PBoxAuth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAuth.TabIndex = 0;
            this.PBoxAuth.TabStop = false;
            // 
            // TblRowLayout
            // 
            this.TblRowLayout.ColumnCount = 1;
            this.TblRowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblRowLayout.Controls.Add(this.TblRegisterLayout, 0, 1);
            this.TblRowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRowLayout.Location = new System.Drawing.Point(3, 3);
            this.TblRowLayout.Name = "TblRowLayout";
            this.TblRowLayout.RowCount = 3;
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblRowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblRowLayout.Size = new System.Drawing.Size(378, 506);
            this.TblRowLayout.TabIndex = 1;
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
            this.TblRegisterLayout.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.TblRegisterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRegisterLayout.Location = new System.Drawing.Point(3, 183);
            this.TblRegisterLayout.Name = "TblRegisterLayout";
            this.TblRegisterLayout.RowCount = 4;
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblRegisterLayout.Size = new System.Drawing.Size(372, 139);
            this.TblRegisterLayout.TabIndex = 1;
            // 
            // LbTitleDescription
            // 
            this.LbTitleDescription.AutoSize = true;
            this.LbTitleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LbTitleDescription.Location = new System.Drawing.Point(56, 3);
            this.LbTitleDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTitleDescription.Name = "LbTitleDescription";
            this.LbTitleDescription.Size = new System.Drawing.Size(255, 24);
            this.LbTitleDescription.TabIndex = 2;
            this.LbTitleDescription.Text = "Vamos encontrar a sua conta";
            // 
            // LbTextDescription
            // 
            this.LbTextDescription.AutoSize = true;
            this.LbTextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LbTextDescription.Location = new System.Drawing.Point(56, 33);
            this.LbTextDescription.Margin = new System.Windows.Forms.Padding(3);
            this.LbTextDescription.Name = "LbTextDescription";
            this.LbTextDescription.Size = new System.Drawing.Size(250, 16);
            this.LbTextDescription.TabIndex = 3;
            this.LbTextDescription.Text = "Introduza o email associado à sua conta.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnFindAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 93);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 46);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(3, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(126, 40);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.TBoxEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TBoxEmail.Location = new System.Drawing.Point(56, 55);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Placeholder = "E-mail";
            this.TBoxEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TBoxEmail.Size = new System.Drawing.Size(259, 35);
            this.TBoxEmail.TabIndex = 4;
            // 
            // BtnFindAccount
            // 
            this.BtnFindAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFindAccount.Location = new System.Drawing.Point(135, 3);
            this.BtnFindAccount.Name = "BtnFindAccount";
            this.BtnFindAccount.Size = new System.Drawing.Size(127, 40);
            this.BtnFindAccount.TabIndex = 1;
            this.BtnFindAccount.Text = "Encontrar conta";
            this.BtnFindAccount.UseVisualStyleBackColor = true;
            this.BtnFindAccount.Click += new System.EventHandler(this.BtnFindAccount_Click);
            // 
            // RecoverAccount_FindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblImageLayout);
            this.Name = "RecoverAccount_FindAccount";
            this.Size = new System.Drawing.Size(768, 512);
            this.TblImageLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAuth)).EndInit();
            this.TblRowLayout.ResumeLayout(false);
            this.TblRowLayout.PerformLayout();
            this.TblRegisterLayout.ResumeLayout(false);
            this.TblRegisterLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblImageLayout;
        private System.Windows.Forms.PictureBox PBoxAuth;
        private System.Windows.Forms.TableLayoutPanel TblRowLayout;
        private System.Windows.Forms.TableLayoutPanel TblRegisterLayout;
        private System.Windows.Forms.Label LbTitleDescription;
        private System.Windows.Forms.Label LbTextDescription;
        private Core.Elements.TextBoxStylized TBoxEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnFindAccount;
    }
}
