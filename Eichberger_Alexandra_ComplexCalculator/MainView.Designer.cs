namespace Eichberger_Alexandra_ComplexCalculator
{
    partial class MainView
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
            this.txb_Number1 = new System.Windows.Forms.TextBox();
            this.lbl_Number1 = new System.Windows.Forms.Label();
            this.lbl_Number2 = new System.Windows.Forms.Label();
            this.txb_Number2 = new System.Windows.Forms.TextBox();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txb_Result = new System.Windows.Forms.TextBox();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_ShowHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Number1
            // 
            this.txb_Number1.Location = new System.Drawing.Point(92, 67);
            this.txb_Number1.Name = "txb_Number1";
            this.txb_Number1.Size = new System.Drawing.Size(172, 27);
            this.txb_Number1.TabIndex = 0;
            // 
            // lbl_Number1
            // 
            this.lbl_Number1.AutoSize = true;
            this.lbl_Number1.Location = new System.Drawing.Point(12, 70);
            this.lbl_Number1.Name = "lbl_Number1";
            this.lbl_Number1.Size = new System.Drawing.Size(78, 20);
            this.lbl_Number1.TabIndex = 1;
            this.lbl_Number1.Text = "Number 1:";
            // 
            // lbl_Number2
            // 
            this.lbl_Number2.AutoSize = true;
            this.lbl_Number2.Location = new System.Drawing.Point(12, 110);
            this.lbl_Number2.Name = "lbl_Number2";
            this.lbl_Number2.Size = new System.Drawing.Size(78, 20);
            this.lbl_Number2.TabIndex = 2;
            this.lbl_Number2.Text = "Number 2:";
            // 
            // txb_Number2
            // 
            this.txb_Number2.Location = new System.Drawing.Point(92, 107);
            this.txb_Number2.Name = "txb_Number2";
            this.txb_Number2.Size = new System.Drawing.Size(172, 27);
            this.txb_Number2.TabIndex = 3;
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Location = new System.Drawing.Point(12, 28);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(380, 20);
            this.lbl_Instruction.TabIndex = 4;
            this.lbl_Instruction.Text = "First enter 2 complex numbers, then choose an operator.";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(388, 70);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(52, 20);
            this.lbl_Result.TabIndex = 5;
            this.lbl_Result.Text = "Result:";
            // 
            // txb_Result
            // 
            this.txb_Result.Location = new System.Drawing.Point(446, 67);
            this.txb_Result.Name = "txb_Result";
            this.txb_Result.ReadOnly = true;
            this.txb_Result.Size = new System.Drawing.Size(177, 27);
            this.txb_Result.TabIndex = 6;
            // 
            // btn_addition
            // 
            this.btn_addition.Location = new System.Drawing.Point(12, 172);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(140, 30);
            this.btn_addition.TabIndex = 7;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Location = new System.Drawing.Point(169, 172);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(140, 30);
            this.btn_subtraction.TabIndex = 8;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Location = new System.Drawing.Point(328, 172);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(140, 30);
            this.btn_multiplication.TabIndex = 9;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(483, 172);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(140, 30);
            this.btn_division.TabIndex = 10;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_ShowHistory
            // 
            this.btn_ShowHistory.Location = new System.Drawing.Point(483, 244);
            this.btn_ShowHistory.Name = "btn_ShowHistory";
            this.btn_ShowHistory.Size = new System.Drawing.Size(140, 32);
            this.btn_ShowHistory.TabIndex = 11;
            this.btn_ShowHistory.Text = "Show History";
            this.btn_ShowHistory.UseVisualStyleBackColor = true;
            this.btn_ShowHistory.Click += new System.EventHandler(this.btn_ShowHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 310);
            this.Controls.Add(this.btn_ShowHistory);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.txb_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Instruction);
            this.Controls.Add(this.txb_Number2);
            this.Controls.Add(this.lbl_Number2);
            this.Controls.Add(this.lbl_Number1);
            this.Controls.Add(this.txb_Number1);
            this.Name = "Form1";
            this.Text = "ComplexCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_Number1;
        private Label lbl_Number1;
        private Label lbl_Number2;
        private TextBox txb_Number2;
        private Label lbl_Instruction;
        private Label lbl_Result;
        private TextBox txb_Result;
        private Button btn_addition;
        private Button btn_subtraction;
        private Button btn_multiplication;
        private Button btn_division;
        private Button btn_ShowHistory;
    }
}