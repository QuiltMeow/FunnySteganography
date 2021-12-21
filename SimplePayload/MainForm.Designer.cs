namespace SimplePayload
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMeow = new System.Windows.Forms.Label();
            this.btnMeow = new SimplePayload.RoundButton();
            this.SuspendLayout();
            // 
            // labelMeow
            // 
            this.labelMeow.AutoSize = true;
            this.labelMeow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMeow.Location = new System.Drawing.Point(110, 35);
            this.labelMeow.Name = "labelMeow";
            this.labelMeow.Size = new System.Drawing.Size(41, 20);
            this.labelMeow.TabIndex = 0;
            this.labelMeow.Text = "喵嗚";
            // 
            // btnMeow
            // 
            this.btnMeow.BackColor = System.Drawing.Color.Azure;
            this.btnMeow.Location = new System.Drawing.Point(95, 80);
            this.btnMeow.Name = "btnMeow";
            this.btnMeow.Size = new System.Drawing.Size(75, 23);
            this.btnMeow.TabIndex = 1;
            this.btnMeow.Text = "喵";
            this.btnMeow.UseVisualStyleBackColor = false;
            this.btnMeow.Click += new System.EventHandler(this.btnMeow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(264, 131);
            this.Controls.Add(this.btnMeow);
            this.Controls.Add(this.labelMeow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "喵喵";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMeow;
        private RoundButton btnMeow;
    }
}

