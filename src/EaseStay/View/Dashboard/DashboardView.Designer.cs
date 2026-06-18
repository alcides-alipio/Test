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
            this.BtnExit = new StylizedComponents.Controls.StylizedButton();
            this.FwPnNavButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnProfile = new StylizedComponents.Controls.StylizedButton();
            this.BtnHome = new StylizedComponents.Controls.StylizedButton();
            this.TblColumnsLayout.SuspendLayout();
            this.TblNavLayout.SuspendLayout();
            this.TblLogoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAppLogo)).BeginInit();
            this.FwPnNavButtonsLayout.SuspendLayout();
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
            this.TblColumnsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblColumnsLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblColumnsLayout.Location = new System.Drawing.Point(0, 0);
            this.TblColumnsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblColumnsLayout.Name = "TblColumnsLayout";
            this.TblColumnsLayout.RowCount = 1;
            this.TblColumnsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblColumnsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 512F));
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
            this.TblNavLayout.Controls.Add(this.BtnExit, 0, 2);
            this.TblNavLayout.Controls.Add(this.FwPnNavButtonsLayout, 0, 1);
            this.TblNavLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblNavLayout.Location = new System.Drawing.Point(0, 0);
            this.TblNavLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblNavLayout.Name = "TblNavLayout";
            this.TblNavLayout.RowCount = 3;
            this.TblNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.PBoxAppLogo.Image = global::EaseStay.Properties.Resources.AppLogo;
            this.PBoxAppLogo.Location = new System.Drawing.Point(11, 3);
            this.PBoxAppLogo.Name = "PBoxAppLogo";
            this.PBoxAppLogo.Size = new System.Drawing.Size(30, 30);
            this.PBoxAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAppLogo.TabIndex = 1;
            this.PBoxAppLogo.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FillColor = System.Drawing.SystemColors.Control;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Icon = global::EaseStay.Properties.Resources.Logout_Black;
            this.BtnExit.IconAlign = StylizedComponents.Core.models.IconAlignment.Left;
            this.BtnExit.IconSize = new System.Drawing.Size(25, 25);
            this.BtnExit.Location = new System.Drawing.Point(0, 467);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 45);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Sair";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FwPnNavButtonsLayout
            // 
            this.FwPnNavButtonsLayout.ColumnCount = 1;
            this.FwPnNavButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FwPnNavButtonsLayout.Controls.Add(this.BtnHome, 0, 0);
            this.FwPnNavButtonsLayout.Controls.Add(this.label2, 0, 1);
            this.FwPnNavButtonsLayout.Controls.Add(this.BtnProfile, 0, 2);
            this.FwPnNavButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FwPnNavButtonsLayout.Location = new System.Drawing.Point(6, 48);
            this.FwPnNavButtonsLayout.Margin = new System.Windows.Forms.Padding(6);
            this.FwPnNavButtonsLayout.Name = "FwPnNavButtonsLayout";
            this.FwPnNavButtonsLayout.RowCount = 4;
            this.FwPnNavButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FwPnNavButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FwPnNavButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FwPnNavButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FwPnNavButtonsLayout.Size = new System.Drawing.Size(138, 413);
            this.FwPnNavButtonsLayout.TabIndex = 4;
            this.FwPnNavButtonsLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.FwPnNavButtonsLayout_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conta";
            // 
            // BtnProfile
            // 
            this.BtnProfile.CornerRadius = 4;
            this.BtnProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProfile.FillColor = System.Drawing.SystemColors.Control;
            this.BtnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnProfile.ForeColor = System.Drawing.Color.Black;
            this.BtnProfile.HoverFilterStrength = 0.1F;
            this.BtnProfile.Icon = global::EaseStay.Properties.Resources.Person_Black;
            this.BtnProfile.IconAlign = StylizedComponents.Core.models.IconAlignment.Left;
            this.BtnProfile.IconSize = new System.Drawing.Size(25, 25);
            this.BtnProfile.Location = new System.Drawing.Point(3, 70);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(132, 35);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.Tag = "IconName=Person;";
            this.BtnProfile.Text = "Perfil";
            this.BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnHome
            // 
            this.BtnHome.CornerRadius = 4;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHome.FillColor = System.Drawing.SystemColors.Control;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.HoverFilterStrength = 0.1F;
            this.BtnHome.Icon = global::EaseStay.Properties.Resources.Home_Black;
            this.BtnHome.IconAlign = StylizedComponents.Core.models.IconAlignment.Left;
            this.BtnHome.IconSize = new System.Drawing.Size(25, 25);
            this.BtnHome.Location = new System.Drawing.Point(3, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(132, 35);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Tag = "IconName=Home;";
            this.BtnHome.Text = "Inicio";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblColumnsLayout);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(768, 512);
            this.TblColumnsLayout.ResumeLayout(false);
            this.TblNavLayout.ResumeLayout(false);
            this.TblNavLayout.PerformLayout();
            this.TblLogoLayout.ResumeLayout(false);
            this.TblLogoLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAppLogo)).EndInit();
            this.FwPnNavButtonsLayout.ResumeLayout(false);
            this.FwPnNavButtonsLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblColumnsLayout;
        private System.Windows.Forms.Panel PnDragResize;
        private System.Windows.Forms.TableLayoutPanel TblNavLayout;
        private System.Windows.Forms.TableLayoutPanel TblLogoLayout;
        private System.Windows.Forms.Label LbAppName;
        private System.Windows.Forms.PictureBox PBoxAppLogo;
        private StylizedComponents.Controls.StylizedButton BtnExit;
        private System.Windows.Forms.TableLayoutPanel FwPnNavButtonsLayout;
        private System.Windows.Forms.Label label2;
        private StylizedComponents.Controls.StylizedButton BtnProfile;
        private StylizedComponents.Controls.StylizedButton BtnHome;
    }
}
