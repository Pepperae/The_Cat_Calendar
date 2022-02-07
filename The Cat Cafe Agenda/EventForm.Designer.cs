namespace The_Cat_Cafe_Agenda
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eventModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.DatePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePickerStart = new System.Windows.Forms.DateTimePicker();
            this.BntGetXML = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.catCafeDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LabelEvent = new System.Windows.Forms.Label();
            this.LabelContact = new System.Windows.Forms.Label();
            this.TextCustomer = new System.Windows.Forms.TextBox();
            this.TextEvent = new System.Windows.Forms.TextBox();
            this.BtnMove = new System.Windows.Forms.Button();
            this.BtnFetch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catCafeDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(CustomerModel);
            // 
            // eventModelBindingSource1
            // 
            this.eventModelBindingSource1.DataSource = typeof(EventModel);
            // 
            // eventModelBindingSource2
            // 
            this.eventModelBindingSource2.DataSource = typeof(EventModel);
            // 
            // eventModelBindingSource3
            // 
            this.eventModelBindingSource3.DataSource = typeof(EventModel);
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.EventName,
            this.DateStart,
            this.DateEnd});
            this.dataGridViewEvent.Location = new System.Drawing.Point(401, 33);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.RowTemplate.Height = 25;
            this.dataGridViewEvent.Size = new System.Drawing.Size(696, 475);
            this.dataGridViewEvent.TabIndex = 34;
            //this.dataGridViewEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvent_CellContentClick_1);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer";
            this.CustomerName.Name = "CustomerName";
            // 
            // EventName
            // 
            this.EventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "Event";
            this.EventName.Name = "EventName";
            // 
            // DateStart
            // 
            this.DateStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "E.Start";
            this.DateStart.Name = "DateStart";
            // 
            // DateEnd
            // 
            this.DateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "E.End";
            this.DateEnd.Name = "DateEnd";
            // 
            // eventModelBindingSource
            // 
            this.eventModelBindingSource.DataSource = typeof(EventModel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "End Date";
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.CustomFormat = "MMM/dd/yyyy-hh:mm";
            this.DatePickerEnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerEnd.Location = new System.Drawing.Point(58, 257);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.ShowUpDown = true;
            this.DatePickerEnd.Size = new System.Drawing.Size(197, 33);
            this.DatePickerEnd.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Start Date";
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.CustomFormat = "MMM/dd/yyyy-hh:mm";
            this.DatePickerStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerStart.Location = new System.Drawing.Point(61, 176);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.ShowUpDown = true;
            this.DatePickerStart.Size = new System.Drawing.Size(194, 33);
            this.DatePickerStart.TabIndex = 30;
            // 
            // BntGetXML
            // 
            this.BntGetXML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BntGetXML.Location = new System.Drawing.Point(286, 470);
            this.BntGetXML.Name = "BntGetXML";
            this.BntGetXML.Size = new System.Drawing.Size(109, 38);
            this.BntGetXML.TabIndex = 25;
            this.BntGetXML.Text = "Get Events";
            this.BntGetXML.UseVisualStyleBackColor = true;
            this.BntGetXML.Click += new System.EventHandler(this.BntGetXML_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(199, 314);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(95, 38);
            this.RemoveButton.TabIndex = 24;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(58, 314);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 38);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "Add Event";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReturn.Location = new System.Drawing.Point(12, 468);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(109, 40);
            this.BtnReturn.TabIndex = 20;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LabelEvent
            // 
            this.LabelEvent.AutoSize = true;
            this.LabelEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEvent.Location = new System.Drawing.Point(58, 9);
            this.LabelEvent.Name = "LabelEvent";
            this.LabelEvent.Size = new System.Drawing.Size(48, 21);
            this.LabelEvent.TabIndex = 3;
            this.LabelEvent.Text = "Event";
            // 
            // LabelContact
            // 
            this.LabelContact.AutoSize = true;
            this.LabelContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelContact.Location = new System.Drawing.Point(58, 77);
            this.LabelContact.Name = "LabelContact";
            this.LabelContact.Size = new System.Drawing.Size(78, 21);
            this.LabelContact.TabIndex = 2;
            this.LabelContact.Text = "Customer";
            // 
            // TextCustomer
            // 
            this.TextCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextCustomer.Location = new System.Drawing.Point(58, 101);
            this.TextCustomer.Name = "TextCustomer";
            this.TextCustomer.Size = new System.Drawing.Size(318, 29);
            this.TextCustomer.TabIndex = 1;
            this.TextCustomer.Text = "Atari";
            // 
            // TextEvent
            // 
            this.TextEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEvent.Location = new System.Drawing.Point(58, 33);
            this.TextEvent.Name = "TextEvent";
            this.TextEvent.Size = new System.Drawing.Size(318, 29);
            this.TextEvent.TabIndex = 0;
            this.TextEvent.Text = "Konami";
            // 
            // BtnMove
            // 
            this.BtnMove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMove.Location = new System.Drawing.Point(199, 374);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(95, 38);
            this.BtnMove.TabIndex = 35;
            this.BtnMove.Text = "Move";
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // BtnFetch
            // 
            this.BtnFetch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFetch.Location = new System.Drawing.Point(58, 374);
            this.BtnFetch.Name = "BtnFetch";
            this.BtnFetch.Size = new System.Drawing.Size(95, 38);
            this.BtnFetch.TabIndex = 36;
            this.BtnFetch.Text = "Fetch";
            this.BtnFetch.UseVisualStyleBackColor = true;
            this.BtnFetch.Click += new System.EventHandler(this.BtnFetch_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 516);
            this.Controls.Add(this.BtnFetch);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatePickerEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatePickerStart);
            this.Controls.Add(this.BntGetXML);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LabelEvent);
            this.Controls.Add(this.LabelContact);
            this.Controls.Add(this.TextCustomer);
            this.Controls.Add(this.TextEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catCafeDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource customerModelBindingSource;
        private BindingSource eventModelBindingSource1;
        private BindingSource eventModelBindingSource2;
        private BindingSource eventModelBindingSource3;
        private DataGridView dataGridViewEvent;
        private BindingSource eventModelBindingSource;
        private Label label3;
        private DateTimePicker DatePickerEnd;
        private Label label2;
        private DateTimePicker DatePickerStart;
        private Button BntGetXML;
        private Button RemoveButton;
        private BindingSource catCafeDatabaseBindingSource;
        private Button BtnAdd;
        private Button BtnReturn;
        private Label LabelEvent;
        private Label LabelContact;
        private TextBox TextCustomer;
        private TextBox TextEvent;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn DateStart;
        private DataGridViewTextBoxColumn DateEnd;
        private Button BtnMove;
        private Button BtnFetch;
    }
}