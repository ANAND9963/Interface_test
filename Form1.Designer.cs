namespace Interface
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
            txtHoursWorked = new TextBox();
            txtPayRate = new TextBox();
            txtDepartment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtYearsWorked = new TextBox();
            btnComputePayBenifts = new Button();
            txtOverTimeRate = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(193, 77);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(125, 27);
            txtHoursWorked.TabIndex = 0;
            // 
            // txtPayRate
            // 
            txtPayRate.Location = new Point(193, 132);
            txtPayRate.Name = "txtPayRate";
            txtPayRate.Size = new Size(125, 27);
            txtPayRate.TabIndex = 1;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(193, 201);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(125, 27);
            txtDepartment.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 80);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Hours Worked";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 139);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Pay Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 208);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 287);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 6;
            label4.Text = "Years Worked";
            // 
            // txtYearsWorked
            // 
            txtYearsWorked.Location = new Point(193, 280);
            txtYearsWorked.Name = "txtYearsWorked";
            txtYearsWorked.Size = new Size(125, 27);
            txtYearsWorked.TabIndex = 7;
            // 
            // btnComputePayBenifts
            // 
            btnComputePayBenifts.Location = new Point(171, 385);
            btnComputePayBenifts.Name = "btnComputePayBenifts";
            btnComputePayBenifts.Size = new Size(208, 29);
            btnComputePayBenifts.TabIndex = 8;
            btnComputePayBenifts.Text = "Compute Pay Benifts";
            btnComputePayBenifts.UseVisualStyleBackColor = true;
            btnComputePayBenifts.Click += btnComputePayBenifts_Click;
            // 
            // txtOverTimeRate
            // 
            txtOverTimeRate.Location = new Point(193, 339);
            txtOverTimeRate.Name = "txtOverTimeRate";
            txtOverTimeRate.Size = new Size(125, 27);
            txtOverTimeRate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 346);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 10;
            label5.Text = "Over Time Rate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtOverTimeRate);
            Controls.Add(btnComputePayBenifts);
            Controls.Add(txtYearsWorked);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartment);
            Controls.Add(txtPayRate);
            Controls.Add(txtHoursWorked);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoursWorked;
        private TextBox txtPayRate;
        private TextBox txtDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtYearsWorked;
        private Button btnComputePayBenifts;
        private TextBox txtOverTimeRate;
        private Label label5;
    }
}
