
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
            this.Birthday = new System.Windows.Forms.CheckBox();
            this.Nomal = new System.Windows.Forms.CheckBox();
            this.result = new System.Windows.Forms.Label();
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
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Birthday.Location = new System.Drawing.Point(314, 349);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(114, 35);
            this.Birthday.TabIndex = 1;
            this.Birthday.Text = "誕生日";
            this.Birthday.UseVisualStyleBackColor = true;
            this.Birthday.CheckedChanged += new System.EventHandler(this.BirthdayChecked);
            // 
            // Nomal
            // 
            this.Nomal.AutoSize = true;
            this.Nomal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Nomal.Location = new System.Drawing.Point(314, 308);
            this.Nomal.Name = "Nomal";
            this.Nomal.Size = new System.Drawing.Size(87, 35);
            this.Nomal.TabIndex = 2;
            this.Nomal.Text = "通常";
            this.Nomal.UseVisualStyleBackColor = true;
            this.Nomal.CheckedChanged += new System.EventHandler(this.NomalChecked);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Nomal);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.GatyaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GatyaButton;
        private System.Windows.Forms.CheckBox Birthday;
        private System.Windows.Forms.CheckBox Nomal;
        private System.Windows.Forms.Label result;
    }
}

