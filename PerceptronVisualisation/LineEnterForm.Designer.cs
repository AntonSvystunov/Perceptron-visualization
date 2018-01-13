namespace PerceptronVisualisation
{
    partial class LineEnterForm
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
            this.OKbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eqTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(102, 106);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 0;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter equation in style ( float *x + float)";
            // 
            // eqTextBox
            // 
            this.eqTextBox.Location = new System.Drawing.Point(10, 65);
            this.eqTextBox.Name = "eqTextBox";
            this.eqTextBox.Size = new System.Drawing.Size(265, 20);
            this.eqTextBox.TabIndex = 3;
            // 
            // LineEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.eqTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LineEnterForm";
            this.Text = "LineEnterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eqTextBox;
    }
}