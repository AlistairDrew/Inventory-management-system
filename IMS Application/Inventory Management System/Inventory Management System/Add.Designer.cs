namespace Inventory_Management_System
{
    partial class Add
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
            this.comboBox_ItemType = new System.Windows.Forms.ComboBox();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.textBox_BaseV = new System.Windows.Forms.TextBox();
            this.textBox_CV = new System.Windows.Forms.TextBox();
            this.label_AddTitle = new System.Windows.Forms.Label();
            this.label_ItemType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_Weight = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label_BV = new System.Windows.Forms.Label();
            this.label_CV = new System.Windows.Forms.Label();
            this.listBox_SI = new System.Windows.Forms.ListBox();
            this.button_AddSubmit = new System.Windows.Forms.Button();
            this.button_AddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_ItemType
            // 
            this.comboBox_ItemType.FormattingEnabled = true;
            this.comboBox_ItemType.Location = new System.Drawing.Point(129, 69);
            this.comboBox_ItemType.Name = "comboBox_ItemType";
            this.comboBox_ItemType.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ItemType.TabIndex = 0;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(129, 117);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(121, 22);
            this.textBoxNo.TabIndex = 1;
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(129, 168);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(121, 22);
            this.textBox_Size.TabIndex = 2;
            // 
            // textBox_BaseV
            // 
            this.textBox_BaseV.Location = new System.Drawing.Point(453, 58);
            this.textBox_BaseV.Name = "textBox_BaseV";
            this.textBox_BaseV.Size = new System.Drawing.Size(121, 22);
            this.textBox_BaseV.TabIndex = 3;
            // 
            // textBox_CV
            // 
            this.textBox_CV.Location = new System.Drawing.Point(453, 88);
            this.textBox_CV.Name = "textBox_CV";
            this.textBox_CV.Size = new System.Drawing.Size(121, 22);
            this.textBox_CV.TabIndex = 4;
            this.textBox_CV.TextChanged += new System.EventHandler(this.textBox_CV_TextChanged);
            // 
            // label_AddTitle
            // 
            this.label_AddTitle.AutoSize = true;
            this.label_AddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddTitle.Location = new System.Drawing.Point(223, 9);
            this.label_AddTitle.Name = "label_AddTitle";
            this.label_AddTitle.Size = new System.Drawing.Size(153, 29);
            this.label_AddTitle.TabIndex = 5;
            this.label_AddTitle.Text = "Adding Items";
            // 
            // label_ItemType
            // 
            this.label_ItemType.AutoSize = true;
            this.label_ItemType.Location = new System.Drawing.Point(12, 69);
            this.label_ItemType.Name = "label_ItemType";
            this.label_ItemType.Size = new System.Drawing.Size(94, 17);
            this.label_ItemType.TabIndex = 6;
            this.label_ItemType.Text = "Type of item: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Location = new System.Drawing.Point(12, 168);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(81, 17);
            this.label_Size.TabIndex = 8;
            this.label_Size.Text = "Size of item";
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(12, 219);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(102, 17);
            this.label_Weight.TabIndex = 9;
            this.label_Weight.Text = "Weight of item:";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(129, 219);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(121, 22);
            this.textBox_Weight.TabIndex = 10;
            // 
            // label_BV
            // 
            this.label_BV.AutoSize = true;
            this.label_BV.Location = new System.Drawing.Point(315, 63);
            this.label_BV.Name = "label_BV";
            this.label_BV.Size = new System.Drawing.Size(132, 17);
            this.label_BV.TabIndex = 11;
            this.label_BV.Text = "Base value of item: ";
            // 
            // label_CV
            // 
            this.label_CV.AutoSize = true;
            this.label_CV.Location = new System.Drawing.Point(300, 88);
            this.label_CV.Name = "label_CV";
            this.label_CV.Size = new System.Drawing.Size(147, 17);
            this.label_CV.TabIndex = 12;
            this.label_CV.Text = "Current value of item: ";
            // 
            // listBox_SI
            // 
            this.listBox_SI.FormattingEnabled = true;
            this.listBox_SI.ItemHeight = 16;
            this.listBox_SI.Location = new System.Drawing.Point(24, 296);
            this.listBox_SI.Name = "listBox_SI";
            this.listBox_SI.Size = new System.Drawing.Size(538, 116);
            this.listBox_SI.TabIndex = 13;
            // 
            // button_AddSubmit
            // 
            this.button_AddSubmit.Location = new System.Drawing.Point(551, 444);
            this.button_AddSubmit.Name = "button_AddSubmit";
            this.button_AddSubmit.Size = new System.Drawing.Size(110, 39);
            this.button_AddSubmit.TabIndex = 30;
            this.button_AddSubmit.Text = "Submit";
            this.button_AddSubmit.UseVisualStyleBackColor = true;
            this.button_AddSubmit.Click += new System.EventHandler(this.button_AddSubmit_Click_1);
            // 
            // button_AddCancel
            // 
            this.button_AddCancel.Location = new System.Drawing.Point(425, 444);
            this.button_AddCancel.Name = "button_AddCancel";
            this.button_AddCancel.Size = new System.Drawing.Size(110, 39);
            this.button_AddCancel.TabIndex = 31;
            this.button_AddCancel.Text = "Cancel";
            this.button_AddCancel.UseVisualStyleBackColor = true;
            this.button_AddCancel.Click += new System.EventHandler(this.button_AddCancel_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 495);
            this.Controls.Add(this.button_AddCancel);
            this.Controls.Add(this.button_AddSubmit);
            this.Controls.Add(this.listBox_SI);
            this.Controls.Add(this.label_CV);
            this.Controls.Add(this.label_BV);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ItemType);
            this.Controls.Add(this.label_AddTitle);
            this.Controls.Add(this.textBox_CV);
            this.Controls.Add(this.textBox_BaseV);
            this.Controls.Add(this.textBox_Size);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.comboBox_ItemType);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ItemType;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.TextBox textBox_BaseV;
        private System.Windows.Forms.TextBox textBox_CV;
        private System.Windows.Forms.Label label_AddTitle;
        private System.Windows.Forms.Label label_ItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label_BV;
        private System.Windows.Forms.Label label_CV;
        private System.Windows.Forms.ListBox listBox_SI;
        private System.Windows.Forms.Button button_AddSubmit;
        private System.Windows.Forms.Button button_AddCancel;
    }
}