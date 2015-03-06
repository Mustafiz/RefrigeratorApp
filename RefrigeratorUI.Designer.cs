namespace RefrigeratorApp
{
    partial class RefrigeratorUI
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
            this.saveButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.numberOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(369, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(427, 68);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 15;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(314, 119);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingWeightTextBox.TabIndex = 14;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(314, 69);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 10;
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(90, 119);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(107, 20);
            this.currentWeightTextBox.TabIndex = 11;
            // 
            // numberOfItemsTextBox
            // 
            this.numberOfItemsTextBox.Location = new System.Drawing.Point(90, 69);
            this.numberOfItemsTextBox.Name = "numberOfItemsTextBox";
            this.numberOfItemsTextBox.Size = new System.Drawing.Size(107, 20);
            this.numberOfItemsTextBox.TabIndex = 12;
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(175, 23);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(172, 20);
            this.maxWeightTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remaining Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current (weight)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight (kg)/Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "No of items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Maximum weight it can take";
            // 
            // RefrigeratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 174);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.numberOfItemsTextBox);
            this.Controls.Add(this.maxWeightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RefrigeratorUI";
            this.Text = "Refrigerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.TextBox numberOfItemsTextBox;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

