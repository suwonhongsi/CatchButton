namespace CatchButton
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Target = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Target
            // 
            this.Target.BackColor = System.Drawing.Color.Yellow;
            this.Target.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Target.Location = new System.Drawing.Point(503, 336);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(432, 130);
            this.Target.TabIndex = 0;
            this.Target.Text = "버튼을 잡으세요";
            this.Target.UseVisualStyleBackColor = false;
            this.Target.Click += new System.EventHandler(this.button1_Click);
            this.Target.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 801);
            this.Controls.Add(this.Target);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Target;
    }
}

