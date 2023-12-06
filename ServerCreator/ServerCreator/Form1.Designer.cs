namespace ServerCreator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form1Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragSpace = new System.Windows.Forms.Panel();
            this.DragForm1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CloseBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1Elipse
            // 
            this.Form1Elipse.TargetControl = this;
            // 
            // DragSpace
            // 
            this.DragSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DragSpace.Controls.Add(this.MinimizeBox);
            this.DragSpace.Controls.Add(this.CloseBox);
            this.DragSpace.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DragSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragSpace.Location = new System.Drawing.Point(0, 0);
            this.DragSpace.Name = "DragSpace";
            this.DragSpace.Size = new System.Drawing.Size(898, 47);
            this.DragSpace.TabIndex = 0;
            // 
            // DragForm1
            // 
            this.DragForm1.DockIndicatorTransparencyValue = 0.6D;
            this.DragForm1.DragStartTransparencyValue = 0.8D;
            this.DragForm1.TargetControl = this.DragSpace;
            this.DragForm1.UseTransparentDrag = true;
            // 
            // CloseBox
            // 
            this.CloseBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.FillColor = System.Drawing.Color.Transparent;
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(843, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(55, 47);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.MinimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBox.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeBox.IconColor = System.Drawing.Color.White;
            this.MinimizeBox.Location = new System.Drawing.Point(788, 0);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(55, 47);
            this.MinimizeBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 510);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(898, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragSpace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form1Elipse;
        private System.Windows.Forms.Panel DragSpace;
        private Guna.UI2.WinForms.Guna2DragControl DragForm1;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBox;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBox;
        private System.Windows.Forms.Panel panel1;
    }
}

