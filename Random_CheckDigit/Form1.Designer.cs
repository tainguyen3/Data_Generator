namespace Random_CheckDigit
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bt_C128 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // bt_C128
            // 
            this.bt_C128.Location = new System.Drawing.Point(15, 58);
            this.bt_C128.Name = "bt_C128";
            this.bt_C128.Size = new System.Drawing.Size(193, 50);
            this.bt_C128.TabIndex = 0;
            this.bt_C128.Text = "C128";
            this.bt_C128.UseVisualStyleBackColor = true;
            this.bt_C128.Click += new System.EventHandler(this.Bt_Generator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length (2,4,6,8)";
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(108, 12);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(100, 20);
            this.tb_Data.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(619, 394);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_C128);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bt_C128;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Data;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

