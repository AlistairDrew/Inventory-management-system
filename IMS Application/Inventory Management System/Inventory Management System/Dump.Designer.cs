namespace Inventory_Management_System
{
    partial class Dump
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
            this.button_DumpSubmit = new System.Windows.Forms.Button();
            this.listBox_SI = new System.Windows.Forms.ListBox();
            this.label_CV = new System.Windows.Forms.Label();
            this.label_BV = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label_Weight = new System.Windows.Forms.Label();
            this.label_Size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ItemType = new System.Windows.Forms.Label();
            this.label_DumpTitle = new System.Windows.Forms.Label();
            this.textBox_CV = new System.Windows.Forms.TextBox();
            this.textBox_BaseV = new System.Windows.Forms.TextBox();
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.comboBox_ItemType = new System.Windows.Forms.ComboBox();
            this.button_DumpCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_DumpSubmit
            // 
            this.button_DumpSubmit.Location = new System.Drawing.Point(541, 441);
            this.button_DumpSubmit.Name = "button_DumpSubmit";
            this.button_DumpSubmit.Size = new System.Drawing.Size(110, 39);
            this.button_DumpSubmit.TabIndex = 29;
            this.button_DumpSubmit.Text = "Submit";
            this.button_DumpSubmit.UseVisualStyleBackColor = true;
            this.button_DumpSubmit.Click += new System.EventHandler(this.button_DumpSubmit_Click);
            // 
            // listBox_SI
            // 
            this.listBox_SI.FormattingEnabled = true;
            this.listBox_SI.ItemHeight = 16;
            this.listBox_SI.Location = new System.Drawing.Point(83, 309);
            this.listBox_SI.Name = "listBox_SI";
            this.listBox_SI.Size = new System.Drawing.Size(538, 116);
            this.listBox_SI.TabIndex = 28;
            // 
            // label_CV
            // 
            this.label_CV.AutoSize = true;
            this.label_CV.Location = new System.Drawing.Point(359, 101);
            this.label_CV.Name = "label_CV";
            this.label_CV.Size = new System.Drawing.Size(147, 17);
            this.label_CV.TabIndex = 27;
            this.label_CV.Text = "Current value of item: ";
            // 
            // label_BV
            // 
            this.label_BV.AutoSize = true;
            this.label_BV.Location = new System.Drawing.Point(374, 76);
            this.label_BV.Name = "label_BV";
            this.label_BV.Size = new System.Drawing.Size(132, 17);
            this.label_BV.TabIndex = 26;
            this.label_BV.Text = "Base value of item: ";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(188, 232);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(121, 22);
            this.textBox_Weight.TabIndex = 25;
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(71, 232);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(102, 17);
            this.label_Weight.TabIndex = 24;
            this.label_Weight.Text = "Weight of item:";
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Location = new System.Drawing.Point(71, 181);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(81, 17);
            this.label_Size.TabIndex = 23;
            this.label_Size.Text = "Size of item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Number of item:";
            // 
            // label_ItemType
            // 
            this.label_ItemType.AutoSize = true;
            this.label_ItemType.Location = new System.Drawing.Point(71, 82);
            this.label_ItemType.Name = "label_ItemType";
            this.label_ItemType.Size = new System.Drawing.Size(94, 17);
            this.label_ItemType.TabIndex = 21;
            this.label_ItemType.Text = "Type of item: ";
            // 
            // label_DumpTitle
            // 
            this.label_DumpTitle.AutoSize = true;
            this.label_DumpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DumpTitle.Location = new System.Drawing.Point(282, 22);
            this.label_DumpTitle.Name = "label_DumpTitle";
            this.label_DumpTitle.Size = new System.Drawing.Size(141, 29);
            this.label_DumpTitle.TabIndex = 20;
            this.label_DumpTitle.Text = "Dump Items";
            // 
            // textBox_CV
            // 
            this.textBox_CV.Location = new System.Drawing.Point(512, 101);
            this.textBox_CV.Name = "textBox_CV";
            this.textBox_CV.Size = new System.Drawing.Size(121, 22);
            this.textBox_CV.TabIndex = 19;
            // 
            // textBox_BaseV
            // 
            this.textBox_BaseV.Location = new System.Drawing.Point(512, 71);
            this.textBox_BaseV.Name = "textBox_BaseV";
            this.textBox_BaseV.Size = new System.Drawing.Size(121, 22);
            this.textBox_BaseV.TabIndex = 18;
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(188, 181);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(121, 22);
            this.textBox_Size.TabIndex = 17;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(188, 130);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(121, 22);
            this.textBoxNo.TabIndex = 16;
            // 
            // comboBox_ItemType
            // 
            this.comboBox_ItemType.FormattingEnabled = true;
            this.comboBox_ItemType.Location = new System.Drawing.Point(188, 82);
            this.comboBox_ItemType.Name = "comboBox_ItemType";
            this.comboBox_ItemType.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ItemType.TabIndex = 15;
            // 
            // button_DumpCancel
            // 
            this.button_DumpCancel.Location = new System.Drawing.Point(425, 441);
            this.button_DumpCancel.Name = "button_DumpCancel";
            this.button_DumpCancel.Size = new System.Drawing.Size(110, 39);
            this.button_DumpCancel.TabIndex = 32;
            this.button_DumpCancel.Text = "Cancel";
            this.button_DumpCancel.UseVisualStyleBackColor = true;
            this.button_DumpCancel.Click += new System.EventHandler(this.button_DumpCancel_Click);
            // 
            // Dump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 495);
            this.Controls.Add(this.button_DumpCancel);
            this.Controls.Add(this.button_DumpSubmit);
            this.Controls.Add(this.listBox_SI);
            this.Controls.Add(this.label_CV);
            this.Controls.Add(this.label_BV);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ItemType);
            this.Controls.Add(this.label_DumpTitle);
            this.Controls.Add(this.textBox_CV);
            this.Controls.Add(this.textBox_BaseV);
            this.Controls.Add(this.textBox_Size);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.comboBox_ItemType);
            this.Name = "Dump";
            this.Text = "Dump";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DumpSubmit;
        private System.Windows.Forms.ListBox listBox_SI;
        private System.Windows.Forms.Label label_CV;
        private System.Windows.Forms.Label label_BV;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ItemType;
        private System.Windows.Forms.Label label_DumpTitle;
        private System.Windows.Forms.TextBox textBox_CV;
        private System.Windows.Forms.TextBox textBox_BaseV;
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.ComboBox comboBox_ItemType;
        private System.Windows.Forms.Button button_DumpCancel;
    }
}