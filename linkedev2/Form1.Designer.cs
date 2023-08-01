namespace linkedev2
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFRO = new FontAwesome.Sharp.IconButton();
            this.btnMO = new FontAwesome.Sharp.IconButton();
            this.btnDE = new FontAwesome.Sharp.IconButton();
            this.btnPRO = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.panelMenu.Controls.Add(this.btnFRO);
            this.panelMenu.Controls.Add(this.btnMO);
            this.panelMenu.Controls.Add(this.btnDE);
            this.panelMenu.Controls.Add(this.btnPRO);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 424);
            this.panelMenu.TabIndex = 0;
            // 
            // btnFRO
            // 
            this.btnFRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFRO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFRO.FlatAppearance.BorderSize = 0;
            this.btnFRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFRO.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnFRO.IconColor = System.Drawing.Color.Black;
            this.btnFRO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFRO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFRO.Location = new System.Drawing.Point(0, 244);
            this.btnFRO.Name = "btnFRO";
            this.btnFRO.Size = new System.Drawing.Size(220, 60);
            this.btnFRO.TabIndex = 5;
            this.btnFRO.Text = "Front";
            this.btnFRO.UseVisualStyleBackColor = true;
            this.btnFRO.Click += new System.EventHandler(this.btnFRO_Click);
            // 
            // btnMO
            // 
            this.btnMO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMO.FlatAppearance.BorderSize = 0;
            this.btnMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMO.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.btnMO.IconColor = System.Drawing.Color.Black;
            this.btnMO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMO.Location = new System.Drawing.Point(0, 192);
            this.btnMO.Name = "btnMO";
            this.btnMO.Size = new System.Drawing.Size(220, 60);
            this.btnMO.TabIndex = 4;
            this.btnMO.Text = "Mobile";
            this.btnMO.UseVisualStyleBackColor = true;
            this.btnMO.Click += new System.EventHandler(this.btnMO_Click);
            // 
            // btnDE
            // 
            this.btnDE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDE.FlatAppearance.BorderSize = 0;
            this.btnDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDE.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            this.btnDE.IconColor = System.Drawing.Color.Black;
            this.btnDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDE.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDE.Location = new System.Drawing.Point(-3, 136);
            this.btnDE.Name = "btnDE";
            this.btnDE.Size = new System.Drawing.Size(220, 60);
            this.btnDE.TabIndex = 3;
            this.btnDE.Text = "Designers";
            this.btnDE.UseVisualStyleBackColor = true;
            this.btnDE.Click += new System.EventHandler(this.btnDE_Click);
            // 
            // btnPRO
            // 
            this.btnPRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPRO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPRO.FlatAppearance.BorderSize = 0;
            this.btnPRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRO.IconChar = FontAwesome.Sharp.IconChar.Robot;
            this.btnPRO.IconColor = System.Drawing.Color.Black;
            this.btnPRO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPRO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPRO.Location = new System.Drawing.Point(-1, 79);
            this.btnPRO.Name = "btnPRO";
            this.btnPRO.Size = new System.Drawing.Size(220, 60);
            this.btnPRO.TabIndex = 2;
            this.btnPRO.Text = "Progamadores";
            this.btnPRO.UseVisualStyleBackColor = true;
            this.btnPRO.Click += new System.EventHandler(this.btnPRO_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(581, 80);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "LINKEDEV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "LINKEDEV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "LINKEDEV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "LINKEDEV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton btnMO;
        private FontAwesome.Sharp.IconButton btnDE;
        private FontAwesome.Sharp.IconButton btnPRO;
        private FontAwesome.Sharp.IconButton btnFRO;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

