namespace FileAppender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.labelAppend = new System.Windows.Forms.Label();
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnInputBrowser = new System.Windows.Forms.Button();
            this.btnAppendBrowser = new System.Windows.Forms.Button();
            this.btnOutputBrowser = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(55, 60);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(53, 12);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "輸入檔案";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(135, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(250, 22);
            this.txtInput.TabIndex = 2;
            // 
            // labelAppend
            // 
            this.labelAppend.AutoSize = true;
            this.labelAppend.Location = new System.Drawing.Point(55, 105);
            this.labelAppend.Name = "labelAppend";
            this.labelAppend.Size = new System.Drawing.Size(53, 12);
            this.labelAppend.TabIndex = 4;
            this.labelAppend.Text = "加入檔案";
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(135, 102);
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.ReadOnly = true;
            this.txtAppend.Size = new System.Drawing.Size(250, 22);
            this.txtAppend.TabIndex = 5;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(55, 150);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(53, 12);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "輸出檔案";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(135, 147);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(250, 22);
            this.txtOutput.TabIndex = 8;
            // 
            // btnInputBrowser
            // 
            this.btnInputBrowser.Location = new System.Drawing.Point(405, 55);
            this.btnInputBrowser.Name = "btnInputBrowser";
            this.btnInputBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnInputBrowser.TabIndex = 3;
            this.btnInputBrowser.Text = "瀏覽";
            this.btnInputBrowser.UseVisualStyleBackColor = true;
            this.btnInputBrowser.Click += new System.EventHandler(this.btnInputBrowser_Click);
            // 
            // btnAppendBrowser
            // 
            this.btnAppendBrowser.Location = new System.Drawing.Point(405, 100);
            this.btnAppendBrowser.Name = "btnAppendBrowser";
            this.btnAppendBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnAppendBrowser.TabIndex = 6;
            this.btnAppendBrowser.Text = "瀏覽";
            this.btnAppendBrowser.UseVisualStyleBackColor = true;
            this.btnAppendBrowser.Click += new System.EventHandler(this.btnAppendBrowser_Click);
            // 
            // btnOutputBrowser
            // 
            this.btnOutputBrowser.Location = new System.Drawing.Point(405, 145);
            this.btnOutputBrowser.Name = "btnOutputBrowser";
            this.btnOutputBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnOutputBrowser.TabIndex = 9;
            this.btnOutputBrowser.Text = "瀏覽";
            this.btnOutputBrowser.UseVisualStyleBackColor = true;
            this.btnOutputBrowser.Click += new System.EventHandler(this.btnOutputBrowser_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(230, 200);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "套用";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "檔案合併工具";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(544, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnOutputBrowser);
            this.Controls.Add(this.btnAppendBrowser);
            this.Controls.Add(this.btnInputBrowser);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.txtAppend);
            this.Controls.Add(this.labelAppend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "檔案合併工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label labelAppend;
        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInputBrowser;
        private System.Windows.Forms.Button btnAppendBrowser;
        private System.Windows.Forms.Button btnOutputBrowser;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label1;
    }
}

