namespace Inventory_Management_System
{
    partial class IMS
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
            this.button_ADD = new System.Windows.Forms.Button();
            this.button_DUMP = new System.Windows.Forms.Button();
            this.button_SELL = new System.Windows.Forms.Button();
            this.button_CUSTOM = new System.Windows.Forms.Button();
            this.InventoryDisplay = new System.Windows.Forms.ListBox();
            this.label_IMStitle = new System.Windows.Forms.Label();
            this.ShipWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(631, 74);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(116, 77);
            this.button_ADD.TabIndex = 0;
            this.button_ADD.Text = "ADD";
            this.button_ADD.UseVisualStyleBackColor = true;
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // button_DUMP
            // 
            this.button_DUMP.Location = new System.Drawing.Point(631, 157);
            this.button_DUMP.Name = "button_DUMP";
            this.button_DUMP.Size = new System.Drawing.Size(116, 77);
            this.button_DUMP.TabIndex = 1;
            this.button_DUMP.Text = "DUMP";
            this.button_DUMP.UseVisualStyleBackColor = true;
            this.button_DUMP.Click += new System.EventHandler(this.button_DUMP_Click);
            // 
            // button_SELL
            // 
            this.button_SELL.Location = new System.Drawing.Point(631, 240);
            this.button_SELL.Name = "button_SELL";
            this.button_SELL.Size = new System.Drawing.Size(116, 77);
            this.button_SELL.TabIndex = 2;
            this.button_SELL.Text = "SELL";
            this.button_SELL.UseVisualStyleBackColor = true;
            this.button_SELL.Click += new System.EventHandler(this.button_SELL_Click);
            // 
            // button_CUSTOM
            // 
            this.button_CUSTOM.Location = new System.Drawing.Point(631, 323);
            this.button_CUSTOM.Name = "button_CUSTOM";
            this.button_CUSTOM.Size = new System.Drawing.Size(116, 77);
            this.button_CUSTOM.TabIndex = 3;
            this.button_CUSTOM.Text = "CUSTOM";
            this.button_CUSTOM.UseVisualStyleBackColor = true;
            this.button_CUSTOM.Click += new System.EventHandler(this.button_CUSTOM_Click);
            // 
            // InventoryDisplay
            // 
            this.InventoryDisplay.FormattingEnabled = true;
            this.InventoryDisplay.ItemHeight = 16;
            this.InventoryDisplay.Location = new System.Drawing.Point(12, 74);
            this.InventoryDisplay.Name = "InventoryDisplay";
            this.InventoryDisplay.Size = new System.Drawing.Size(594, 324);
            this.InventoryDisplay.TabIndex = 4;
            this.InventoryDisplay.SelectedIndexChanged += new System.EventHandler(this.InventoryDisplay_SelectedIndexChanged);
            // 
            // label_IMStitle
            // 
            this.label_IMStitle.AutoSize = true;
            this.label_IMStitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IMStitle.Location = new System.Drawing.Point(329, 21);
            this.label_IMStitle.Name = "label_IMStitle";
            this.label_IMStitle.Size = new System.Drawing.Size(109, 29);
            this.label_IMStitle.TabIndex = 5;
            this.label_IMStitle.Text = "Inventory";
            this.label_IMStitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShipWeight
            // 
            this.ShipWeight.Location = new System.Drawing.Point(12, 12);
            this.ShipWeight.Multiline = true;
            this.ShipWeight.Name = "ShipWeight";
            this.ShipWeight.Size = new System.Drawing.Size(160, 38);
            this.ShipWeight.TabIndex = 6;
            this.ShipWeight.TextChanged += new System.EventHandler(this.ShipWeight_TextChanged);
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 449);
            this.Controls.Add(this.ShipWeight);
            this.Controls.Add(this.label_IMStitle);
            this.Controls.Add(this.InventoryDisplay);
            this.Controls.Add(this.button_CUSTOM);
            this.Controls.Add(this.button_SELL);
            this.Controls.Add(this.button_DUMP);
            this.Controls.Add(this.button_ADD);
            this.Name = "IMS";
            this.Text = "IMS";
            this.Load += new System.EventHandler(this.IMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Button button_DUMP;
        private System.Windows.Forms.Button button_SELL;
        private System.Windows.Forms.Button button_CUSTOM;
        private System.Windows.Forms.ListBox InventoryDisplay;
        private System.Windows.Forms.Label label_IMStitle;
        private System.Windows.Forms.TextBox ShipWeight;
    }
}