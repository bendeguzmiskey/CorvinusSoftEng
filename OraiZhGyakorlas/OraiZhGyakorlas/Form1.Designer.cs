namespace OraiZhGyakorlas
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
            nyersanyagIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyisegiEgysegIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            mennyisegiEgysegekBindingSource = new BindingSource(components);
            egysegarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyisegiEgysegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receptekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagokBindingSource = new BindingSource(components);
            saveButton = new Button();
            AddViaContext = new Button();
            AddViaBL = new Button();
            AddViaBindingSource = new Button();
            DeleteButton = new Button();
            dataGridView2 = new DataGridView();
            UjNyersAnyagButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mennyisegiEgysegekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nyersanyagIdDataGridViewTextBoxColumn, nyersanyagNevDataGridViewTextBoxColumn, mennyisegiEgysegIdDataGridViewTextBoxColumn, egysegarDataGridViewTextBoxColumn, mennyisegiEgysegDataGridViewTextBoxColumn, receptekDataGridViewTextBoxColumn });
            dataGridView1.DataSource = nyersanyagokBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(595, 349);
            dataGridView1.TabIndex = 0;
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegIdDataGridViewTextBoxColumn
            // 
            mennyisegiEgysegIdDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgysegId";
            mennyisegiEgysegIdDataGridViewTextBoxColumn.DataSource = mennyisegiEgysegekBindingSource;
            mennyisegiEgysegIdDataGridViewTextBoxColumn.DisplayMember = "EgysegNev";
            mennyisegiEgysegIdDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgysegId";
            mennyisegiEgysegIdDataGridViewTextBoxColumn.Name = "mennyisegiEgysegIdDataGridViewTextBoxColumn";
            mennyisegiEgysegIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            mennyisegiEgysegIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            mennyisegiEgysegIdDataGridViewTextBoxColumn.ValueMember = "MennyisegiEgysegId";
            // 
            // mennyisegiEgysegekBindingSource
            // 
            mennyisegiEgysegekBindingSource.DataSource = typeof(Models.MennyisegiEgysegek);
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            egysegarDataGridViewTextBoxColumn.HeaderText = "Egysegar";
            egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegDataGridViewTextBoxColumn
            // 
            mennyisegiEgysegDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgyseg";
            mennyisegiEgysegDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgyseg";
            mennyisegiEgysegDataGridViewTextBoxColumn.Name = "mennyisegiEgysegDataGridViewTextBoxColumn";
            // 
            // receptekDataGridViewTextBoxColumn
            // 
            receptekDataGridViewTextBoxColumn.DataPropertyName = "Receptek";
            receptekDataGridViewTextBoxColumn.HeaderText = "Receptek";
            receptekDataGridViewTextBoxColumn.Name = "receptekDataGridViewTextBoxColumn";
            // 
            // nyersanyagokBindingSource
            // 
            nyersanyagokBindingSource.DataSource = typeof(Models.Nyersanyagok);
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 367);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // AddViaContext
            // 
            AddViaContext.Location = new Point(93, 367);
            AddViaContext.Name = "AddViaContext";
            AddViaContext.Size = new Size(113, 23);
            AddViaContext.TabIndex = 2;
            AddViaContext.Text = "AddViaContext";
            AddViaContext.UseVisualStyleBackColor = true;
            AddViaContext.Click += AddViaContext_Click;
            // 
            // AddViaBL
            // 
            AddViaBL.Location = new Point(212, 367);
            AddViaBL.Name = "AddViaBL";
            AddViaBL.Size = new Size(121, 23);
            AddViaBL.TabIndex = 3;
            AddViaBL.Text = "AdddViaBindingList";
            AddViaBL.UseVisualStyleBackColor = true;
            AddViaBL.Click += AddViaBL_Click;
            // 
            // AddViaBindingSource
            // 
            AddViaBindingSource.Location = new Point(339, 367);
            AddViaBindingSource.Name = "AddViaBindingSource";
            AddViaBindingSource.Size = new Size(137, 23);
            AddViaBindingSource.TabIndex = 4;
            AddViaBindingSource.Text = "AddViaBindingSource";
            AddViaBindingSource.UseVisualStyleBackColor = true;
            AddViaBindingSource.Click += AddViaBindingSource_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(482, 367);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(613, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(399, 349);
            dataGridView2.TabIndex = 6;
            // 
            // UjNyersAnyagButton
            // 
            UjNyersAnyagButton.Location = new Point(563, 367);
            UjNyersAnyagButton.Name = "UjNyersAnyagButton";
            UjNyersAnyagButton.Size = new Size(138, 23);
            UjNyersAnyagButton.TabIndex = 7;
            UjNyersAnyagButton.Text = "Új Nyersanyag";
            UjNyersAnyagButton.UseVisualStyleBackColor = true;
            UjNyersAnyagButton.Click += UjNyersAnyagButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 450);
            Controls.Add(UjNyersAnyagButton);
            Controls.Add(dataGridView2);
            Controls.Add(DeleteButton);
            Controls.Add(AddViaBindingSource);
            Controls.Add(AddViaBL);
            Controls.Add(AddViaContext);
            Controls.Add(saveButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mennyisegiEgysegekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource nyersanyagokBindingSource;
        private DataGridViewTextBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn mennyisegiEgysegIdDataGridViewTextBoxColumn;
        private BindingSource mennyisegiEgysegekBindingSource;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receptekDataGridViewTextBoxColumn;
        private Button saveButton;
        private Button AddViaContext;
        private Button AddViaBL;
        private Button AddViaBindingSource;
        private Button DeleteButton;
        private DataGridView dataGridView2;
        private Button UjNyersAnyagButton;
    }
}
