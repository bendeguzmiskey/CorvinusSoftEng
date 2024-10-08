namespace elso_feladat
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            ujButton = new Button();
            torlesButton = new Button();
            mentesButton = new Button();
            frissitesButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(622, 417);
            dataGridView1.TabIndex = 0;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // ujButton
            // 
            ujButton.Location = new Point(640, 12);
            ujButton.Name = "ujButton";
            ujButton.Size = new Size(75, 23);
            ujButton.TabIndex = 1;
            ujButton.Text = "Új";
            ujButton.UseVisualStyleBackColor = true;
            ujButton.Click += ujButton_Click;
            // 
            // torlesButton
            // 
            torlesButton.Location = new Point(640, 41);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(75, 23);
            torlesButton.TabIndex = 2;
            torlesButton.Text = "Törlés";
            torlesButton.UseVisualStyleBackColor = true;
            torlesButton.Click += torlesButton_Click;
            // 
            // mentesButton
            // 
            mentesButton.Location = new Point(640, 70);
            mentesButton.Name = "mentesButton";
            mentesButton.Size = new Size(75, 23);
            mentesButton.TabIndex = 3;
            mentesButton.Text = "Mentés";
            mentesButton.UseVisualStyleBackColor = true;
            mentesButton.Click += mentesButton_Click;
            // 
            // frissitesButton
            // 
            frissitesButton.Location = new Point(640, 99);
            frissitesButton.Name = "frissitesButton";
            frissitesButton.Size = new Size(75, 23);
            frissitesButton.TabIndex = 4;
            frissitesButton.Text = "Frissítés";
            frissitesButton.UseVisualStyleBackColor = true;
            frissitesButton.Click += frissitesButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(640, 128);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 5;
            button1.Text = "Termékkategóriák kezelése";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(frissitesButton);
            Controls.Add(mentesButton);
            Controls.Add(torlesButton);
            Controls.Add(ujButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ujButton;
        private Button torlesButton;
        private Button mentesButton;
        private Button frissitesButton;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private BindingSource ugyfelBindingSource;
        private Button button1;
    }
}
