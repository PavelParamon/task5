namespace Task_4
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
            this.Add_btn = new System.Windows.Forms.Button();
            this.MainPB = new System.Windows.Forms.PictureBox();
            this.Start_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(12, 12);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(76, 23);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // MainPB
            // 
            this.MainPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPB.Location = new System.Drawing.Point(3, 41);
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(856, 497);
            this.MainPB.TabIndex = 2;
            this.MainPB.TabStop = false;
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(110, 11);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 3;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 550);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.MainPB);
            this.Controls.Add(this.Add_btn);
            this.Name = "MainForm";
            this.Text = "Троллейбус";
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.PictureBox MainPB;
        private System.Windows.Forms.Button Start_btn;
    }
}

