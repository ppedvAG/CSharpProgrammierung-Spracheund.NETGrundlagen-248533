namespace FahrzeugGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbx_Fahrzeuge = new ListBox();
            label1 = new Label();
            Btn_Löschen = new Button();
            Btn_Neu = new Button();
            Lbl_Info = new Label();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            MeI_Beenden = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbx_Fahrzeuge
            // 
            Lbx_Fahrzeuge.FormattingEnabled = true;
            Lbx_Fahrzeuge.Location = new Point(20, 130);
            Lbx_Fahrzeuge.Margin = new Padding(5);
            Lbx_Fahrzeuge.Name = "Lbx_Fahrzeuge";
            Lbx_Fahrzeuge.Size = new Size(422, 292);
            Lbx_Fahrzeuge.TabIndex = 1;
            Lbx_Fahrzeuge.SelectedIndexChanged += Lbx_Fahrzeuge_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 93);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 2;
            label1.Text = "Vorhandene Fahrzeuge:";
            // 
            // Btn_Löschen
            // 
            Btn_Löschen.Location = new Point(738, 130);
            Btn_Löschen.Margin = new Padding(5);
            Btn_Löschen.Name = "Btn_Löschen";
            Btn_Löschen.Size = new Size(255, 61);
            Btn_Löschen.TabIndex = 6;
            Btn_Löschen.Text = "Lösche Fahrzeug";
            Btn_Löschen.UseVisualStyleBackColor = true;
            Btn_Löschen.Click += Btn_Löschen_Click;
            // 
            // Btn_Neu
            // 
            Btn_Neu.Location = new Point(473, 130);
            Btn_Neu.Margin = new Padding(5);
            Btn_Neu.Name = "Btn_Neu";
            Btn_Neu.Size = new Size(255, 61);
            Btn_Neu.TabIndex = 5;
            Btn_Neu.Text = "Neues Fahrzeug";
            Btn_Neu.UseVisualStyleBackColor = true;
            Btn_Neu.Click += Btn_Neu_Click;
            // 
            // Lbl_Info
            // 
            Lbl_Info.AutoSize = true;
            Lbl_Info.Location = new Point(20, 451);
            Lbl_Info.Margin = new Padding(5, 0, 5, 0);
            Lbl_Info.Name = "Lbl_Info";
            Lbl_Info.Size = new Size(0, 32);
            Lbl_Info.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1014, 42);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MeI_Beenden });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(90, 36);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // MeI_Beenden
            // 
            MeI_Beenden.Name = "MeI_Beenden";
            MeI_Beenden.Size = new Size(242, 44);
            MeI_Beenden.Text = "Beenden";
            MeI_Beenden.Click += MeI_Beenden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 504);
            Controls.Add(menuStrip1);
            Controls.Add(Lbl_Info);
            Controls.Add(Btn_Löschen);
            Controls.Add(Btn_Neu);
            Controls.Add(label1);
            Controls.Add(Lbx_Fahrzeuge);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Fahrzeug-Verwaltung";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox Lbx_Fahrzeuge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Löschen;
        private System.Windows.Forms.Button Btn_Neu;
        private System.Windows.Forms.Label Lbl_Info;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MeI_Beenden;
    }
}
