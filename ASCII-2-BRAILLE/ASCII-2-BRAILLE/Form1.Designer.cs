namespace ASCII_2_BRAILLE
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
            this.BtnConverter = new System.Windows.Forms.Button();
            this.G11_1 = new System.Windows.Forms.CheckBox();
            this.G11_2 = new System.Windows.Forms.CheckBox();
            this.G11_3 = new System.Windows.Forms.CheckBox();
            this.G11_6 = new System.Windows.Forms.CheckBox();
            this.G11_5 = new System.Windows.Forms.CheckBox();
            this.G11_4 = new System.Windows.Forms.CheckBox();
            this.G11 = new System.Windows.Forms.GroupBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFDFile = new System.Windows.Forms.OpenFileDialog();
            this.G11.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConverter
            // 
            this.BtnConverter.Location = new System.Drawing.Point(184, 441);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(90, 42);
            this.BtnConverter.TabIndex = 8;
            this.BtnConverter.Text = "Convertir";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // G11_1
            // 
            this.G11_1.AutoCheck = false;
            this.G11_1.AutoSize = true;
            this.G11_1.Enabled = false;
            this.G11_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G11_1.Location = new System.Drawing.Point(11, 16);
            this.G11_1.Name = "G11_1";
            this.G11_1.Size = new System.Drawing.Size(13, 12);
            this.G11_1.TabIndex = 9;
            this.G11_1.UseVisualStyleBackColor = true;
            // 
            // G11_2
            // 
            this.G11_2.AutoCheck = false;
            this.G11_2.AutoSize = true;
            this.G11_2.Enabled = false;
            this.G11_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G11_2.Location = new System.Drawing.Point(11, 34);
            this.G11_2.Name = "G11_2";
            this.G11_2.Size = new System.Drawing.Size(13, 12);
            this.G11_2.TabIndex = 10;
            this.G11_2.UseVisualStyleBackColor = true;
            // 
            // G11_3
            // 
            this.G11_3.AutoCheck = false;
            this.G11_3.AutoSize = true;
            this.G11_3.Enabled = false;
            this.G11_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G11_3.Location = new System.Drawing.Point(11, 52);
            this.G11_3.Name = "G11_3";
            this.G11_3.Size = new System.Drawing.Size(13, 12);
            this.G11_3.TabIndex = 11;
            this.G11_3.UseVisualStyleBackColor = true;
            // 
            // G11_6
            // 
            this.G11_6.AutoCheck = false;
            this.G11_6.AutoSize = true;
            this.G11_6.Enabled = false;
            this.G11_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G11_6.Location = new System.Drawing.Point(33, 52);
            this.G11_6.Name = "G11_6";
            this.G11_6.Size = new System.Drawing.Size(13, 12);
            this.G11_6.TabIndex = 14;
            this.G11_6.UseVisualStyleBackColor = true;
            // 
            // G11_5
            // 
            this.G11_5.AutoCheck = false;
            this.G11_5.AutoSize = true;
            this.G11_5.Enabled = false;
            this.G11_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G11_5.Location = new System.Drawing.Point(33, 34);
            this.G11_5.Name = "G11_5";
            this.G11_5.Size = new System.Drawing.Size(13, 12);
            this.G11_5.TabIndex = 13;
            this.G11_5.UseVisualStyleBackColor = true;
            // 
            // G11_4
            // 
            this.G11_4.AutoCheck = false;
            this.G11_4.AutoSize = true;
            this.G11_4.Enabled = false;
            this.G11_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G11_4.Location = new System.Drawing.Point(33, 16);
            this.G11_4.Name = "G11_4";
            this.G11_4.Size = new System.Drawing.Size(13, 12);
            this.G11_4.TabIndex = 12;
            this.G11_4.UseVisualStyleBackColor = true;
            // 
            // G11
            // 
            this.G11.Controls.Add(this.G11_6);
            this.G11.Controls.Add(this.G11_5);
            this.G11.Controls.Add(this.G11_4);
            this.G11.Controls.Add(this.G11_3);
            this.G11.Controls.Add(this.G11_2);
            this.G11.Controls.Add(this.G11_1);
            this.G11.Location = new System.Drawing.Point(12, 44);
            this.G11.Name = "G11";
            this.G11.Size = new System.Drawing.Size(56, 71);
            this.G11.TabIndex = 15;
            this.G11.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(459, 24);
            this.Menu.TabIndex = 16;
            this.Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // OFDFile
            // 
            this.OFDFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 517);
            this.Controls.Add(this.G11);
            this.Controls.Add(this.BtnConverter);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Braill-E";
            this.G11.ResumeLayout(false);
            this.G11.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnConverter;
        private CheckBox G11_1;
        private CheckBox G11_2;
        private CheckBox G11_3;
        private CheckBox G11_6;
        private CheckBox G11_5;
        private CheckBox G11_4;
        private GroupBox G11;
        private MenuStrip Menu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private OpenFileDialog OFDFile;
    }
}