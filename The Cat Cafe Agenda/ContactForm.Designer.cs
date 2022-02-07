namespace The_Cat_Cafe_Agenda
{
    partial class ContactForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.BntGetXML = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DateofBirthPicker = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(37, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(37, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(37, 109);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 21);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(37, 180);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // BntGetXML
            // 
            this.BntGetXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BntGetXML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BntGetXML.Location = new System.Drawing.Point(533, 495);
            this.BntGetXML.Name = "BntGetXML";
            this.BntGetXML.Size = new System.Drawing.Size(157, 40);
            this.BntGetXML.TabIndex = 18;
            this.BntGetXML.Text = "Get Customer List";
            this.BntGetXML.UseVisualStyleBackColor = false;
            this.BntGetXML.Click += new System.EventHandler(this.BntGetXML_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(37, 352);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 40);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add Customer";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(199, 352);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(148, 40);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove Customer";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DateofBirthPicker
            // 
            this.DateofBirthPicker.AutoSize = true;
            this.DateofBirthPicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateofBirthPicker.Location = new System.Drawing.Point(37, 256);
            this.DateofBirthPicker.Name = "DateofBirthPicker";
            this.DateofBirthPicker.Size = new System.Drawing.Size(97, 21);
            this.DateofBirthPicker.TabIndex = 6;
            this.DateofBirthPicker.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 5, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.DateOfBirth});
            this.dataGridView1.DataSource = this.customerModelBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(442, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(344, 466);
            this.dataGridView1.TabIndex = 17;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // customerModelBindingSource2
            // 
            this.customerModelBindingSource2.DataSource = typeof(CustomerModel);
            // 
            // customerModelBindingSource3
            // 
            this.customerModelBindingSource3.DataSource = typeof(CustomerModel);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReturn.Location = new System.Drawing.Point(12, 510);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(109, 40);
            this.BtnReturn.TabIndex = 19;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 562);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BntGetXML);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateofBirthPicker);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Form";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label NameLabel;
        private Label LastNameLabel;
        private TextBox textBox2;
        private Label DateofBirthPicker;
        private Button AddButton;
        private Button RemoveButton;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private BindingSource customersBindingSource;
        private DataGridViewTextBoxColumn a1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn a2DataGridViewTextBoxColumn;
        private BindingSource customerModelBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource customerModelBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource customerModelBindingSource2;
        private BindingSource customerModelBindingSource3;
        private Button BntGetXML;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn DateOfBirth;
        private Button BtnReturn;
    }
}