namespace PerceptronVisualisation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CurrentStatusLabel = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 600);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 13);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(35, 13);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "label1";
            // 
            // CurrentStatusLabel
            // 
            this.CurrentStatusLabel.AutoSize = true;
            this.CurrentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentStatusLabel.Location = new System.Drawing.Point(607, 13);
            this.CurrentStatusLabel.Name = "CurrentStatusLabel";
            this.CurrentStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.CurrentStatusLabel.TabIndex = 2;
            this.CurrentStatusLabel.Text = "label1";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(12, 539);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(35, 13);
            this.ModeLabel.TabIndex = 3;
            this.ModeLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(671, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 104);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.CurrentStatusLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Perceptron Visualization";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label CurrentStatusLabel;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label label1;
    }
}

