namespace _003_Combobox_1
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
            this.District_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCountItems = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.btnSortItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // District_Combobox
            // 
            this.District_Combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.District_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.District_Combobox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.District_Combobox.FormattingEnabled = true;
            this.District_Combobox.Items.AddRange(new object[] {
            "Dhaka",
            "Khulna",
            "Rajshahi"});
            this.District_Combobox.Location = new System.Drawing.Point(250, 106);
            this.District_Combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.District_Combobox.Name = "District_Combobox";
            this.District_Combobox.Size = new System.Drawing.Size(255, 40);
            this.District_Combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Items";
            // 
            // txtAddItem
            // 
            this.txtAddItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAddItem.Location = new System.Drawing.Point(250, 49);
            this.txtAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(255, 39);
            this.txtAddItem.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(536, 49);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCountItems
            // 
            this.btnCountItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCountItems.Location = new System.Drawing.Point(250, 166);
            this.btnCountItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCountItems.Name = "btnCountItems";
            this.btnCountItems.Size = new System.Drawing.Size(255, 36);
            this.btnCountItems.TabIndex = 4;
            this.btnCountItems.Text = "Count Items";
            this.btnCountItems.UseVisualStyleBackColor = true;
            this.btnCountItems.Click += new System.EventHandler(this.btnCountItems_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.Location = new System.Drawing.Point(250, 280);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(255, 36);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearItems.Location = new System.Drawing.Point(250, 341);
            this.btnClearItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(255, 36);
            this.btnClearItems.TabIndex = 6;
            this.btnClearItems.Text = "Clear Items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // btnSortItems
            // 
            this.btnSortItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortItems.Location = new System.Drawing.Point(250, 220);
            this.btnSortItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortItems.Name = "btnSortItems";
            this.btnSortItems.Size = new System.Drawing.Size(255, 36);
            this.btnSortItems.TabIndex = 7;
            this.btnSortItems.Text = "Sort Items";
            this.btnSortItems.UseVisualStyleBackColor = true;
            this.btnSortItems.Click += new System.EventHandler(this.btnSortItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 482);
            this.Controls.Add(this.btnSortItems);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCountItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.District_Combobox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "District Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox District_Combobox;
        private Label label1;
        private TextBox txtAddItem;
        private Button btnAdd;
        private Button btnCountItems;
        private Button btnRemoveItem;
        private Button btnClearItems;
        private Button btnSortItems;
    }
}