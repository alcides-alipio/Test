namespace EaseStay.Features.Dashboard.Presentation
{
    partial class DashboardControl
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
            this.TblDashboardLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TblNavegatorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TblLogoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbAppName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbBtnExit = new System.Windows.Forms.Label();
            this.TblExitButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PBoxLogo = new System.Windows.Forms.PictureBox();
            this.PBoxExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TblDashboardLayout.SuspendLayout();
            this.TblNavegatorLayout.SuspendLayout();
            this.TblLogoLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TblExitButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // TblDashboardLayout
            // 
            this.TblDashboardLayout.ColumnCount = 2;
            this.TblDashboardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TblDashboardLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TblDashboardLayout.Controls.Add(this.TblNavegatorLayout, 0, 0);
            this.TblDashboardLayout.Controls.Add(this.TblExitButtonLayout, 1, 0);
            this.TblDashboardLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblDashboardLayout.Location = new System.Drawing.Point(0, 0);
            this.TblDashboardLayout.Name = "TblDashboardLayout";
            this.TblDashboardLayout.RowCount = 1;
            this.TblDashboardLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblDashboardLayout.Size = new System.Drawing.Size(768, 512);
            this.TblDashboardLayout.TabIndex = 0;
            // 
            // TblNavegatorLayout
            // 
            this.TblNavegatorLayout.ColumnCount = 3;
            this.TblNavegatorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblNavegatorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TblNavegatorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TblNavegatorLayout.Controls.Add(this.TblLogoLayout, 1, 0);
            this.TblNavegatorLayout.Controls.Add(this.panel1, 1, 1);
            this.TblNavegatorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblNavegatorLayout.Location = new System.Drawing.Point(3, 3);
            this.TblNavegatorLayout.Name = "TblNavegatorLayout";
            this.TblNavegatorLayout.RowCount = 3;
            this.TblNavegatorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblNavegatorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblNavegatorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblNavegatorLayout.Size = new System.Drawing.Size(224, 506);
            this.TblNavegatorLayout.TabIndex = 0;
            // 
            // TblLogoLayout
            // 
            this.TblLogoLayout.AutoSize = true;
            this.TblLogoLayout.ColumnCount = 2;
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblLogoLayout.Controls.Add(this.PBoxLogo, 0, 1);
            this.TblLogoLayout.Controls.Add(this.LbAppName, 1, 1);
            this.TblLogoLayout.Location = new System.Drawing.Point(25, 3);
            this.TblLogoLayout.Name = "TblLogoLayout";
            this.TblLogoLayout.RowCount = 3;
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLogoLayout.Size = new System.Drawing.Size(145, 46);
            this.TblLogoLayout.TabIndex = 0;
            // 
            // LbAppName
            // 
            this.LbAppName.AutoSize = true;
            this.LbAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LbAppName.Location = new System.Drawing.Point(49, 3);
            this.LbAppName.Margin = new System.Windows.Forms.Padding(3);
            this.LbAppName.Name = "LbAppName";
            this.LbAppName.Size = new System.Drawing.Size(93, 40);
            this.LbAppName.TabIndex = 1;
            this.LbAppName.Text = "Ease Stay";
            this.LbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 292);
            this.panel1.TabIndex = 1;
            // 
            // LbBtnExit
            // 
            this.LbBtnExit.AutoSize = true;
            this.LbBtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbBtnExit.Location = new System.Drawing.Point(33, 3);
            this.LbBtnExit.Margin = new System.Windows.Forms.Padding(3);
            this.LbBtnExit.Name = "LbBtnExit";
            this.LbBtnExit.Size = new System.Drawing.Size(25, 24);
            this.LbBtnExit.TabIndex = 0;
            this.LbBtnExit.Text = "Sair";
            this.LbBtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbBtnExit.Click += new System.EventHandler(this.LbBtnExit_Click);
            // 
            // TblExitButtonLayout
            // 
            this.TblExitButtonLayout.AutoSize = true;
            this.TblExitButtonLayout.ColumnCount = 2;
            this.TblExitButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblExitButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblExitButtonLayout.Controls.Add(this.LbBtnExit, 1, 0);
            this.TblExitButtonLayout.Controls.Add(this.PBoxExit, 0, 0);
            this.TblExitButtonLayout.Location = new System.Drawing.Point(233, 3);
            this.TblExitButtonLayout.Name = "TblExitButtonLayout";
            this.TblExitButtonLayout.RowCount = 1;
            this.TblExitButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblExitButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblExitButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblExitButtonLayout.Size = new System.Drawing.Size(61, 30);
            this.TblExitButtonLayout.TabIndex = 2;
            this.TblExitButtonLayout.Click += new System.EventHandler(this.TblExitButtonLayout_Click);
            // 
            // PBoxLogo
            // 
            this.PBoxLogo.Image = global::EaseStay.Properties.Resources.Logo_128px;
            this.PBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.PBoxLogo.Name = "PBoxLogo";
            this.PBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.PBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogo.TabIndex = 0;
            this.PBoxLogo.TabStop = false;
            // 
            // PBoxExit
            // 
            this.PBoxExit.Image = global::EaseStay.Properties.Resources.Logout;
            this.PBoxExit.Location = new System.Drawing.Point(3, 3);
            this.PBoxExit.Name = "PBoxExit";
            this.PBoxExit.Size = new System.Drawing.Size(24, 24);
            this.PBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxExit.TabIndex = 1;
            this.PBoxExit.TabStop = false;
            this.PBoxExit.Click += new System.EventHandler(this.PBoxExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblDashboardLayout);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(768, 512);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.TblDashboardLayout.ResumeLayout(false);
            this.TblDashboardLayout.PerformLayout();
            this.TblNavegatorLayout.ResumeLayout(false);
            this.TblNavegatorLayout.PerformLayout();
            this.TblLogoLayout.ResumeLayout(false);
            this.TblLogoLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TblExitButtonLayout.ResumeLayout(false);
            this.TblExitButtonLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblDashboardLayout;
        private System.Windows.Forms.TableLayoutPanel TblNavegatorLayout;
        private System.Windows.Forms.TableLayoutPanel TblLogoLayout;
        private System.Windows.Forms.PictureBox PBoxLogo;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbBtnExit;
        private System.Windows.Forms.TableLayoutPanel TblExitButtonLayout;
        private System.Windows.Forms.PictureBox PBoxExit;
        private System.Windows.Forms.Label label1;
    }
}
