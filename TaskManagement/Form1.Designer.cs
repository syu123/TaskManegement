namespace TaskManagement
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskPlannedTime = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taskType = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.taskDetail = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "タスク一覧";
            // 
            // taskName
            // 
            this.taskName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Name", true));
            this.taskName.Location = new System.Drawing.Point(408, 81);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(306, 34);
            this.taskName.TabIndex = 4;
            this.taskName.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "タスク名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "予定時間";
            // 
            // taskPlannedTime
            // 
            this.taskPlannedTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "PlannedTime", true));
            this.taskPlannedTime.Location = new System.Drawing.Point(408, 138);
            this.taskPlannedTime.Name = "taskPlannedTime";
            this.taskPlannedTime.Size = new System.Drawing.Size(306, 34);
            this.taskPlannedTime.TabIndex = 6;
            this.taskPlannedTime.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "作業分類";
            // 
            // taskType
            // 
            this.taskType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Type", true));
            this.taskType.Location = new System.Drawing.Point(408, 195);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(306, 34);
            this.taskType.TabIndex = 8;
            this.taskType.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "詳細";
            // 
            // taskDetail
            // 
            this.taskDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Details", true));
            this.taskDetail.Location = new System.Drawing.Point(408, 252);
            this.taskDetail.Name = "taskDetail";
            this.taskDetail.Size = new System.Drawing.Size(306, 233);
            this.taskDetail.TabIndex = 10;
            this.taskDetail.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "作成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(24, 97);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(265, 394);
            this.listBox.TabIndex = 14;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(TaskManagement.Task);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taskDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskPlannedTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox taskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox taskPlannedTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox taskType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox taskDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.ListBox listBox;
    }
}

