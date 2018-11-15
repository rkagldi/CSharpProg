namespace HelloCShartWin
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new Infragistics.Win.Misc.UltraLabel();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.sumNumbers = new Infragistics.Win.Misc.UltraButton();
            this.sumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Location = new System.Drawing.Point(62, 68);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(111, 15);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "여기를 클릭하세요";
            this.HelloLabel.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(62, 102);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(100, 21);
            this.sum1.TabIndex = 1;
            // 
            // sum2
            // 
            this.sum2.Location = new System.Drawing.Point(192, 102);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(100, 21);
            this.sum2.TabIndex = 2;
            // 
            // sumNumbers
            // 
            this.sumNumbers.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Borderless;
            this.sumNumbers.Location = new System.Drawing.Point(326, 102);
            this.sumNumbers.Name = "sumNumbers";
            this.sumNumbers.Size = new System.Drawing.Size(75, 23);
            this.sumNumbers.TabIndex = 3;
            this.sumNumbers.Text = "=";
            this.sumNumbers.Click += new System.EventHandler(this.sumNumbers_Click);
            // 
            // sumResult
            // 
            this.sumResult.Location = new System.Drawing.Point(442, 102);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(100, 21);
            this.sumResult.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.sumNumbers);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel HelloLabel;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.TextBox sum2;
        private Infragistics.Win.Misc.UltraButton sumNumbers;
        private System.Windows.Forms.TextBox sumResult;
    }
}

