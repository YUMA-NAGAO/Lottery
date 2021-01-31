
namespace Lottery
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.GatyaButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nomal = new System.Windows.Forms.RadioButton();
            this.Birthday = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GatyaButton
            // 
            this.GatyaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.GatyaButton.Location = new System.Drawing.Point(454, 307);
            this.GatyaButton.Name = "GatyaButton";
            this.GatyaButton.Size = new System.Drawing.Size(334, 77);
            this.GatyaButton.TabIndex = 0;
            this.GatyaButton.Text = "抽選スタート！！！";
            this.GatyaButton.UseVisualStyleBackColor = true;
            this.GatyaButton.Click += new System.EventHandler(this.GatyaButtonClicked);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.result.Location = new System.Drawing.Point(208, 116);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(301, 76);
            this.result.TabIndex = 3;
            this.result.Text = "抽選結果";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.comboBox1.Location = new System.Drawing.Point(74, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Birthday);
            this.groupBox1.Controls.Add(this.Nomal);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(155, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Nomal
            // 
            this.Nomal.AutoSize = true;
            this.Nomal.Location = new System.Drawing.Point(0, 13);
            this.Nomal.Name = "Nomal";
            this.Nomal.Size = new System.Drawing.Size(49, 17);
            this.Nomal.TabIndex = 6;
            this.Nomal.TabStop = true;
            this.Nomal.Text = "通常";
            this.Nomal.UseVisualStyleBackColor = true;
            this.Nomal.Click += new System.EventHandler(this.NomalChecked);
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(0, 63);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(61, 17);
            this.Birthday.TabIndex = 7;
            this.Birthday.TabStop = true;
            this.Birthday.Text = "誕生日";
            this.Birthday.UseVisualStyleBackColor = true;
            this.Birthday.Click += new System.EventHandler(this.BirthdayChecked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.GatyaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GatyaButton;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Birthday;
        private System.Windows.Forms.RadioButton Nomal;
    }
}

