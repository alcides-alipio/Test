namespace EaseStay.View.Dashboard
{
    partial class DashboardView
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
            this.TblColumnsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PnDragResize = new System.Windows.Forms.Panel();
            this.TblNavLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TblLogoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LbAppName = new System.Windows.Forms.Label();
            this.PBoxAppLogo = new System.Windows.Forms.PictureBox();
            this.LbTest = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TblColumnsLayout.SuspendLayout();
            this.TblNavLayout.SuspendLayout();
            this.TblLogoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TblColumnsLayout
            // 
            this.TblColumnsLayout.ColumnCount = 3;
            this.TblColumnsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TblColumnsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TblColumnsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblColumnsLayout.Controls.Add(this.PnDragResize, 1, 0);
            this.TblColumnsLayout.Controls.Add(this.TblNavLayout, 0, 0);
            this.TblColumnsLayout.Controls.Add(this.LbTest, 2, 0);
            this.TblColumnsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblColumnsLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblColumnsLayout.Location = new System.Drawing.Point(0, 0);
            this.TblColumnsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblColumnsLayout.Name = "TblColumnsLayout";
            this.TblColumnsLayout.RowCount = 1;
            this.TblColumnsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblColumnsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblColumnsLayout.Size = new System.Drawing.Size(768, 512);
            this.TblColumnsLayout.TabIndex = 0;
            // 
            // PnDragResize
            // 
            this.PnDragResize.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnDragResize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.PnDragResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDragResize.Location = new System.Drawing.Point(150, 0);
            this.PnDragResize.Margin = new System.Windows.Forms.Padding(0);
            this.PnDragResize.Name = "PnDragResize";
            this.PnDragResize.Size = new System.Drawing.Size(2, 512);
            this.PnDragResize.TabIndex = 0;
            this.PnDragResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnDragResize_MouseDown);
            this.PnDragResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnDragResize_MouseMove);
            this.PnDragResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnDragResize_MouseUp);
            // 
            // TblNavLayout
            // 
            this.TblNavLayout.ColumnCount = 1;
            this.TblNavLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblNavLayout.Controls.Add(this.TblLogoLayout, 0, 0);
            this.TblNavLayout.Controls.Add(this.LbUsername, 0, 1);
            this.TblNavLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblNavLayout.Location = new System.Drawing.Point(0, 0);
            this.TblNavLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblNavLayout.Name = "TblNavLayout";
            this.TblNavLayout.RowCount = 2;
            this.TblNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblNavLayout.Size = new System.Drawing.Size(150, 512);
            this.TblNavLayout.TabIndex = 2;
            // 
            // TblLogoLayout
            // 
            this.TblLogoLayout.AutoSize = true;
            this.TblLogoLayout.ColumnCount = 4;
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLogoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLogoLayout.Controls.Add(this.LbAppName, 2, 0);
            this.TblLogoLayout.Controls.Add(this.PBoxAppLogo, 1, 0);
            this.TblLogoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLogoLayout.Location = new System.Drawing.Point(3, 3);
            this.TblLogoLayout.Name = "TblLogoLayout";
            this.TblLogoLayout.RowCount = 1;
            this.TblLogoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblLogoLayout.Size = new System.Drawing.Size(144, 36);
            this.TblLogoLayout.TabIndex = 0;
            // 
            // LbAppName
            // 
            this.LbAppName.AutoSize = true;
            this.LbAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppName.Location = new System.Drawing.Point(47, 3);
            this.LbAppName.Margin = new System.Windows.Forms.Padding(3);
            this.LbAppName.Name = "LbAppName";
            this.LbAppName.Size = new System.Drawing.Size(86, 30);
            this.LbAppName.TabIndex = 0;
            this.LbAppName.Text = "EaseStay";
            this.LbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PBoxAppLogo
            // 
            this.PBoxAppLogo.Image = global::EaseStay.Properties.Resources.Logo_128px;
            this.PBoxAppLogo.Location = new System.Drawing.Point(11, 3);
            this.PBoxAppLogo.Name = "PBoxAppLogo";
            this.PBoxAppLogo.Size = new System.Drawing.Size(30, 30);
            this.PBoxAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAppLogo.TabIndex = 1;
            this.PBoxAppLogo.TabStop = false;
            // 
            // LbTest
            // 
            this.LbTest.AutoSize = true;
            this.LbTest.Location = new System.Drawing.Point(155, 0);
            this.LbTest.Name = "LbTest";
            this.LbTest.Size = new System.Drawing.Size(51, 20);
            this.LbTest.TabIndex = 4;
            this.LbTest.Text = "label1";
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(3, 42);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(51, 20);
            this.LbUsername.TabIndex = 1;
            this.LbUsername.Text = "label1";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblColumnsLayout);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(768, 512);
            this.TblColumnsLayout.ResumeLayout(false);
            this.TblColumnsLayout.PerformLayout();
            this.TblNavLayout.ResumeLayout(false);
            this.TblNavLayout.PerformLayout();
            this.TblLogoLayout.ResumeLayout(false);
            this.TblLogoLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblColumnsLayout;
        private System.Windows.Forms.Panel PnDragResize;
        private System.Windows.Forms.TableLayoutPanel TblNavLayout;
        private System.Windows.Forms.TableLayoutPanel TblLogoLayout;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.PictureBox PBoxAppLogo;
        private System.Windows.Forms.Label LbTest;
        private System.Windows.Forms.Label LbUsername;
    }
}
