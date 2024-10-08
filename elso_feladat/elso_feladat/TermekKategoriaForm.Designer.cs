namespace elso_feladat
{
    partial class TermekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóriaToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.ContextMenuStrip = contextMenuStripKategoria;
            treeViewKategoriak.LabelEdit = true;
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(247, 426);
            treeViewKategoriak.TabIndex = 0;
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { átnevezésToolStripMenuItem, újFőkategóriaToolStripMenuItem, újAlkategóriaToolStripMenuItem, törlésToolStripMenuItem, frissítésToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStripKategoria";
            contextMenuStripKategoria.Size = new Size(149, 114);
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(148, 22);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            átnevezésToolStripMenuItem.Click += átnevezésToolStripMenuItem_Click;
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            újFőkategóriaToolStripMenuItem.Click += újFőkategóriaToolStripMenuItem_Click;
            // 
            // újAlkategóriaToolStripMenuItem
            // 
            újAlkategóriaToolStripMenuItem.Name = "újAlkategóriaToolStripMenuItem";
            újAlkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újAlkategóriaToolStripMenuItem.Text = "Új alkategória";
            újAlkategóriaToolStripMenuItem.Click += újAlkategóriaToolStripMenuItem_Click;
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(148, 22);
            törlésToolStripMenuItem.Text = "Törlés";
            törlésToolStripMenuItem.Click += törlésToolStripMenuItem_Click;
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(148, 22);
            frissítésToolStripMenuItem.Text = "Frissítés";
            frissítésToolStripMenuItem.Click += frissítésToolStripMenuItem_Click;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(265, 12);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(355, 23);
            txtNev.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(265, 41);
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(355, 23);
            txtLeiras.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(265, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(346, 70);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Új testvér";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(427, 70);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Új gyermek";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(508, 70);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Törlés";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(265, 113);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóriaToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
        private Button button5;
    }
}