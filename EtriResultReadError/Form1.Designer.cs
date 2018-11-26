namespace EtriResultReadError
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.comboBoxFileList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResultSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxResult.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxResult.Location = new System.Drawing.Point(102, 80);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(460, 140);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TabStop = false;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(102, 282);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(192, 51);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "파일 읽기";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInputWord.Location = new System.Drawing.Point(102, 236);
            this.textBoxInputWord.Multiline = true;
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(460, 40);
            this.textBoxInputWord.TabIndex = 2;
            this.textBoxInputWord.TabStop = false;
            // 
            // comboBoxFileList
            // 
            this.comboBoxFileList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxFileList.FormattingEnabled = true;
            this.comboBoxFileList.Location = new System.Drawing.Point(102, 36);
            this.comboBoxFileList.Name = "comboBoxFileList";
            this.comboBoxFileList.Size = new System.Drawing.Size(460, 28);
            this.comboBoxFileList.TabIndex = 3;
            this.comboBoxFileList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "단어 입력";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "파일 목록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "개수";
            // 
            // btnResultSum
            // 
            this.btnResultSum.Location = new System.Drawing.Point(436, 283);
            this.btnResultSum.Name = "btnResultSum";
            this.btnResultSum.Size = new System.Drawing.Size(126, 50);
            this.btnResultSum.TabIndex = 8;
            this.btnResultSum.Text = "Sum";
            this.btnResultSum.UseVisualStyleBackColor = true;
            this.btnResultSum.Click += new System.EventHandler(this.btnResultSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 345);
            this.Controls.Add(this.btnResultSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFileList);
            this.Controls.Add(this.textBoxInputWord);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox textBoxInputWord;
        private System.Windows.Forms.ComboBox comboBoxFileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResultSum;
    }
}

