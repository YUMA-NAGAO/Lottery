
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
            this.Birthday = new System.Windows.Forms.RadioButton();
            this.Nomal = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GatyaButton
            // 
            this.GatyaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.GatyaButton.Location = new System.Drawing.Point(749, 377);
            this.GatyaButton.Margin = new System.Windows.Forms.Padding(4);
            this.GatyaButton.Name = "GatyaButton";
            this.GatyaButton.Size = new System.Drawing.Size(445, 95);
            this.GatyaButton.TabIndex = 0;
            this.GatyaButton.Text = "抽選スタート！！！";
            this.GatyaButton.UseVisualStyleBackColor = true;
            this.GatyaButton.Click += new System.EventHandler(this.GatyaButtonClicked);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.result.Location = new System.Drawing.Point(13, 63);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(601, 153);
            this.result.TabIndex = 3;
            this.result.Text = "抽選結果";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboBox1.Location = new System.Drawing.Point(363, 115);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Birthday);
            this.groupBox1.Controls.Add(this.Nomal);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(113, 333);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(576, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Birthday.Location = new System.Drawing.Point(0, 93);
            this.Birthday.Margin = new System.Windows.Forms.Padding(4);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(196, 62);
            this.Birthday.TabIndex = 7;
            this.Birthday.Text = "誕生月";
            this.Birthday.UseVisualStyleBackColor = true;
            this.Birthday.Click += new System.EventHandler(this.BirthdayChecked);
            // 
            // Nomal
            // 
            this.Nomal.AutoSize = true;
            this.Nomal.Checked = true;
            this.Nomal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Nomal.Location = new System.Drawing.Point(0, 16);
            this.Nomal.Margin = new System.Windows.Forms.Padding(4);
            this.Nomal.Name = "Nomal";
            this.Nomal.Size = new System.Drawing.Size(146, 62);
            this.Nomal.TabIndex = 6;
            this.Nomal.TabStop = true;
            this.Nomal.Text = "通常";
            this.Nomal.UseVisualStyleBackColor = true;
            this.Nomal.Click += new System.EventHandler(this.NomalChecked);
            // 
            // comboBox2
            // 
            //AddCombo DicData = new AddCombo();
            //string[] DictionaryData = { };
            //DictionaryData = DicData.DirectroyData();
            string[] testdata = { "a", "b" };
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(testdata);
            this.comboBox2.Location = new System.Drawing.Point(782, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 553);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.GatyaButton);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

