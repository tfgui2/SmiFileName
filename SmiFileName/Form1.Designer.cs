namespace SmiFileName
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
            this.listBoxSmi = new System.Windows.Forms.ListBox();
            this.listBoxAvi = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTrans = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSmi
            // 
            this.listBoxSmi.AllowDrop = true;
            this.listBoxSmi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSmi.FormattingEnabled = true;
            this.listBoxSmi.ItemHeight = 24;
            this.listBoxSmi.Location = new System.Drawing.Point(0, 0);
            this.listBoxSmi.Name = "listBoxSmi";
            this.listBoxSmi.Size = new System.Drawing.Size(503, 712);
            this.listBoxSmi.TabIndex = 0;
            this.listBoxSmi.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxSmi_DragDrop);
            this.listBoxSmi.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxSmi_DragEnter);
            // 
            // listBoxAvi
            // 
            this.listBoxAvi.AllowDrop = true;
            this.listBoxAvi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAvi.FormattingEnabled = true;
            this.listBoxAvi.ItemHeight = 24;
            this.listBoxAvi.Location = new System.Drawing.Point(0, 0);
            this.listBoxAvi.Name = "listBoxAvi";
            this.listBoxAvi.Size = new System.Drawing.Size(509, 712);
            this.listBoxAvi.TabIndex = 1;
            this.listBoxAvi.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxAvi_DragDrop);
            this.listBoxAvi.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxAvi_DragEnter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(90, 85);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxSmi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxAvi);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 712);
            this.splitContainer1.SplitterDistance = 503;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Smi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avi";
            // 
            // buttonTrans
            // 
            this.buttonTrans.Location = new System.Drawing.Point(1124, 85);
            this.buttonTrans.Name = "buttonTrans";
            this.buttonTrans.Size = new System.Drawing.Size(158, 103);
            this.buttonTrans.TabIndex = 5;
            this.buttonTrans.Text = "Trans";
            this.buttonTrans.UseVisualStyleBackColor = true;
            this.buttonTrans.Click += new System.EventHandler(this.buttonTrans_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1124, 206);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(158, 103);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 868);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "SmiFileName";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSmi;
        private System.Windows.Forms.ListBox listBoxAvi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTrans;
        private System.Windows.Forms.Button buttonClear;
    }
}

