namespace PBAuth
{
    partial class PBAuth
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.logintb = new System.Windows.Forms.MaskedTextBox();
            this.passwordtb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(390, 194);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // logintb
            // 
            this.logintb.Location = new System.Drawing.Point(312, 124);
            this.logintb.Name = "logintb";
            this.logintb.Size = new System.Drawing.Size(100, 20);
            this.logintb.TabIndex = 1;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(312, 150);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(100, 20);
            this.passwordtb.TabIndex = 2;
            // 
            // PBAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBAuth.Properties.Resources.PointBlank_nesia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(477, 238);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.logintb);
            this.Controls.Add(this.enter);
            this.Name = "PBAuth";
            this.Text = "Point Blank Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.MaskedTextBox logintb;
        private System.Windows.Forms.MaskedTextBox passwordtb;
    }
}

