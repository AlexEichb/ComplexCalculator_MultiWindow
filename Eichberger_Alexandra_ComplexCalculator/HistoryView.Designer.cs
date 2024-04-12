namespace Eichberger_Alexandra_ComplexCalculator
{
    partial class HistoryView
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
            this.tbx_historyList = new System.Windows.Forms.TextBox();
            this.txb_Index = new System.Windows.Forms.TextBox();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_historyList
            // 
            this.tbx_historyList.Location = new System.Drawing.Point(12, 44);
            this.tbx_historyList.Multiline = true;
            this.tbx_historyList.Name = "tbx_historyList";
            this.tbx_historyList.ReadOnly = true;
            this.tbx_historyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_historyList.Size = new System.Drawing.Size(280, 234);
            this.tbx_historyList.TabIndex = 0;
            // 
            // txb_Index
            // 
            this.txb_Index.Location = new System.Drawing.Point(322, 100);
            this.txb_Index.Name = "txb_Index";
            this.txb_Index.Size = new System.Drawing.Size(146, 27);
            this.txb_Index.TabIndex = 1;
            this.txb_Index.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(322, 182);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(104, 37);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.Text = "Restore";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index";
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.txb_Index);
            this.Controls.Add(this.tbx_historyList);
            this.Name = "HistoryView";
            this.Text = "HistoryView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_historyList;
        private TextBox txb_Index;
        private Button btn_Restore;
        private Label label1;
    }
}