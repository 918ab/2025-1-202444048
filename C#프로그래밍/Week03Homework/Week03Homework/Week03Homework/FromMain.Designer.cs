namespace Week03Homework
{
    partial class FormMain
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
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExpression
            // 
            this.lblExpression.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblExpression.Location = new System.Drawing.Point(12, 9);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(309, 52);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblNumbers
            // 
            this.lblNumbers.BackColor = System.Drawing.Color.White;
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNumbers.Location = new System.Drawing.Point(14, 79);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(307, 50);
            this.lblNumbers.TabIndex = 0;
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.White;
            this.btnNum7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum7.Location = new System.Drawing.Point(14, 158);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum7.Size = new System.Drawing.Size(64, 51);
            this.btnNum7.TabIndex = 1;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.White;
            this.btnNum8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum8.Location = new System.Drawing.Point(95, 158);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum8.Size = new System.Drawing.Size(64, 51);
            this.btnNum8.TabIndex = 1;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.White;
            this.btnNum9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum9.Location = new System.Drawing.Point(176, 158);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum9.Size = new System.Drawing.Size(64, 51);
            this.btnNum9.TabIndex = 1;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDiv.Location = new System.Drawing.Point(257, 158);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDiv.Size = new System.Drawing.Size(64, 51);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.White;
            this.btnNum4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum4.Location = new System.Drawing.Point(14, 223);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum4.Size = new System.Drawing.Size(64, 51);
            this.btnNum4.TabIndex = 1;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.White;
            this.btnNum5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum5.Location = new System.Drawing.Point(95, 223);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum5.Size = new System.Drawing.Size(64, 51);
            this.btnNum5.TabIndex = 1;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.White;
            this.btnNum6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum6.Location = new System.Drawing.Point(176, 223);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum6.Size = new System.Drawing.Size(64, 51);
            this.btnNum6.TabIndex = 1;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.White;
            this.btnMul.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMul.Location = new System.Drawing.Point(257, 223);
            this.btnMul.Name = "btnMul";
            this.btnMul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMul.Size = new System.Drawing.Size(64, 51);
            this.btnMul.TabIndex = 1;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.White;
            this.btnNum1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum1.Location = new System.Drawing.Point(14, 288);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum1.Size = new System.Drawing.Size(64, 51);
            this.btnNum1.TabIndex = 1;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.White;
            this.btnNum2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum2.Location = new System.Drawing.Point(95, 288);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum2.Size = new System.Drawing.Size(64, 51);
            this.btnNum2.TabIndex = 1;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.White;
            this.btnNum3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum3.Location = new System.Drawing.Point(176, 288);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum3.Size = new System.Drawing.Size(64, 51);
            this.btnNum3.TabIndex = 1;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.White;
            this.btnSub.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSub.Location = new System.Drawing.Point(257, 288);
            this.btnSub.Name = "btnSub";
            this.btnSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSub.Size = new System.Drawing.Size(64, 51);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.White;
            this.btnNum0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNum0.Location = new System.Drawing.Point(14, 353);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNum0.Size = new System.Drawing.Size(64, 51);
            this.btnNum0.TabIndex = 1;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.White;
            this.btnCal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCal.Location = new System.Drawing.Point(95, 353);
            this.btnCal.Name = "btnCal";
            this.btnCal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCal.Size = new System.Drawing.Size(145, 51);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(257, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(64, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(340, 429);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblExpression);
            this.Name = "FormMain";
            this.Text = "계산기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAdd;
    }
}

