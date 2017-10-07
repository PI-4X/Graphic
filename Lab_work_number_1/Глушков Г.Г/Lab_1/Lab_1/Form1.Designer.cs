namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MasterPanel = new System.Windows.Forms.Panel();
            this.buttonAddRotation_Z = new System.Windows.Forms.Button();
            this.buttonAddRotation_Y = new System.Windows.Forms.Button();
            this.buttonAddRotation_X = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRotation_Z = new System.Windows.Forms.Button();
            this.buttonRotation_Y = new System.Windows.Forms.Button();
            this.buttonRotation_X = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSub_Scale = new System.Windows.Forms.Button();
            this.buttonAdd_Scale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSub_Z = new System.Windows.Forms.Button();
            this.buttonAdd_Z = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSub_Y = new System.Windows.Forms.Button();
            this.buttonAdd_Y = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSub_X = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd_X = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.MasterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(647, 472);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseClick);
            this.MainPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainPanel_PreviewKeyDown);
            // 
            // MasterPanel
            // 
            this.MasterPanel.Controls.Add(this.buttonRefresh);
            this.MasterPanel.Controls.Add(this.buttonAddRotation_Z);
            this.MasterPanel.Controls.Add(this.buttonAddRotation_Y);
            this.MasterPanel.Controls.Add(this.buttonAddRotation_X);
            this.MasterPanel.Controls.Add(this.label7);
            this.MasterPanel.Controls.Add(this.label8);
            this.MasterPanel.Controls.Add(this.label9);
            this.MasterPanel.Controls.Add(this.buttonRotation_Z);
            this.MasterPanel.Controls.Add(this.buttonRotation_Y);
            this.MasterPanel.Controls.Add(this.buttonRotation_X);
            this.MasterPanel.Controls.Add(this.label6);
            this.MasterPanel.Controls.Add(this.buttonSub_Scale);
            this.MasterPanel.Controls.Add(this.buttonAdd_Scale);
            this.MasterPanel.Controls.Add(this.label5);
            this.MasterPanel.Controls.Add(this.label4);
            this.MasterPanel.Controls.Add(this.buttonSub_Z);
            this.MasterPanel.Controls.Add(this.buttonAdd_Z);
            this.MasterPanel.Controls.Add(this.label3);
            this.MasterPanel.Controls.Add(this.buttonSub_Y);
            this.MasterPanel.Controls.Add(this.buttonAdd_Y);
            this.MasterPanel.Controls.Add(this.label2);
            this.MasterPanel.Controls.Add(this.buttonSub_X);
            this.MasterPanel.Controls.Add(this.label1);
            this.MasterPanel.Controls.Add(this.buttonAdd_X);
            this.MasterPanel.Location = new System.Drawing.Point(666, 12);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(285, 470);
            this.MasterPanel.TabIndex = 1;
            // 
            // buttonAddRotation_Z
            // 
            this.buttonAddRotation_Z.Location = new System.Drawing.Point(183, 371);
            this.buttonAddRotation_Z.Name = "buttonAddRotation_Z";
            this.buttonAddRotation_Z.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRotation_Z.TabIndex = 22;
            this.buttonAddRotation_Z.Text = "+";
            this.buttonAddRotation_Z.UseVisualStyleBackColor = true;
            this.buttonAddRotation_Z.Click += new System.EventHandler(this.buttonAddRotation_Z_Click);
            // 
            // buttonAddRotation_Y
            // 
            this.buttonAddRotation_Y.Location = new System.Drawing.Point(183, 330);
            this.buttonAddRotation_Y.Name = "buttonAddRotation_Y";
            this.buttonAddRotation_Y.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRotation_Y.TabIndex = 21;
            this.buttonAddRotation_Y.Text = "+";
            this.buttonAddRotation_Y.UseVisualStyleBackColor = true;
            this.buttonAddRotation_Y.Click += new System.EventHandler(this.buttonAddRotation_Y_Click);
            // 
            // buttonAddRotation_X
            // 
            this.buttonAddRotation_X.Location = new System.Drawing.Point(183, 292);
            this.buttonAddRotation_X.Name = "buttonAddRotation_X";
            this.buttonAddRotation_X.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRotation_X.TabIndex = 20;
            this.buttonAddRotation_X.Text = "+";
            this.buttonAddRotation_X.UseVisualStyleBackColor = true;
            this.buttonAddRotation_X.Click += new System.EventHandler(this.buttonAddRotation_X_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "X";
            // 
            // buttonRotation_Z
            // 
            this.buttonRotation_Z.Location = new System.Drawing.Point(87, 371);
            this.buttonRotation_Z.Name = "buttonRotation_Z";
            this.buttonRotation_Z.Size = new System.Drawing.Size(75, 23);
            this.buttonRotation_Z.TabIndex = 16;
            this.buttonRotation_Z.Text = "-";
            this.buttonRotation_Z.UseVisualStyleBackColor = true;
            this.buttonRotation_Z.Click += new System.EventHandler(this.buttonRotation_Z_Click);
            // 
            // buttonRotation_Y
            // 
            this.buttonRotation_Y.Location = new System.Drawing.Point(87, 330);
            this.buttonRotation_Y.Name = "buttonRotation_Y";
            this.buttonRotation_Y.Size = new System.Drawing.Size(75, 23);
            this.buttonRotation_Y.TabIndex = 15;
            this.buttonRotation_Y.Text = "-";
            this.buttonRotation_Y.UseVisualStyleBackColor = true;
            this.buttonRotation_Y.Click += new System.EventHandler(this.buttonRotation_Y_Click);
            // 
            // buttonRotation_X
            // 
            this.buttonRotation_X.Location = new System.Drawing.Point(87, 292);
            this.buttonRotation_X.Name = "buttonRotation_X";
            this.buttonRotation_X.Size = new System.Drawing.Size(75, 23);
            this.buttonRotation_X.TabIndex = 14;
            this.buttonRotation_X.Text = "-";
            this.buttonRotation_X.UseVisualStyleBackColor = true;
            this.buttonRotation_X.Click += new System.EventHandler(this.buttonRotation_X_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(101, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rotation";
            // 
            // buttonSub_Scale
            // 
            this.buttonSub_Scale.Location = new System.Drawing.Point(168, 207);
            this.buttonSub_Scale.Name = "buttonSub_Scale";
            this.buttonSub_Scale.Size = new System.Drawing.Size(75, 23);
            this.buttonSub_Scale.TabIndex = 12;
            this.buttonSub_Scale.Text = "-";
            this.buttonSub_Scale.UseVisualStyleBackColor = true;
            this.buttonSub_Scale.Click += new System.EventHandler(this.buttonSub_Scale_Click);
            // 
            // buttonAdd_Scale
            // 
            this.buttonAdd_Scale.Location = new System.Drawing.Point(18, 207);
            this.buttonAdd_Scale.Name = "buttonAdd_Scale";
            this.buttonAdd_Scale.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_Scale.TabIndex = 11;
            this.buttonAdd_Scale.Text = "+";
            this.buttonAdd_Scale.UseVisualStyleBackColor = true;
            this.buttonAdd_Scale.Click += new System.EventHandler(this.buttonAdd_Scale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(119, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Z";
            // 
            // buttonSub_Z
            // 
            this.buttonSub_Z.Location = new System.Drawing.Point(168, 122);
            this.buttonSub_Z.Name = "buttonSub_Z";
            this.buttonSub_Z.Size = new System.Drawing.Size(75, 23);
            this.buttonSub_Z.TabIndex = 8;
            this.buttonSub_Z.Text = "-";
            this.buttonSub_Z.UseVisualStyleBackColor = true;
            this.buttonSub_Z.Click += new System.EventHandler(this.buttonSub_Z_Click);
            // 
            // buttonAdd_Z
            // 
            this.buttonAdd_Z.Location = new System.Drawing.Point(18, 122);
            this.buttonAdd_Z.Name = "buttonAdd_Z";
            this.buttonAdd_Z.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_Z.TabIndex = 7;
            this.buttonAdd_Z.Text = "+";
            this.buttonAdd_Z.UseVisualStyleBackColor = true;
            this.buttonAdd_Z.Click += new System.EventHandler(this.buttonAdd_Z_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(119, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y";
            // 
            // buttonSub_Y
            // 
            this.buttonSub_Y.Location = new System.Drawing.Point(168, 81);
            this.buttonSub_Y.Name = "buttonSub_Y";
            this.buttonSub_Y.Size = new System.Drawing.Size(75, 23);
            this.buttonSub_Y.TabIndex = 5;
            this.buttonSub_Y.Text = "-";
            this.buttonSub_Y.UseVisualStyleBackColor = true;
            this.buttonSub_Y.Click += new System.EventHandler(this.buttonSub_Y_Click);
            // 
            // buttonAdd_Y
            // 
            this.buttonAdd_Y.Location = new System.Drawing.Point(18, 81);
            this.buttonAdd_Y.Name = "buttonAdd_Y";
            this.buttonAdd_Y.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_Y.TabIndex = 4;
            this.buttonAdd_Y.Text = "+";
            this.buttonAdd_Y.UseVisualStyleBackColor = true;
            this.buttonAdd_Y.Click += new System.EventHandler(this.buttonAdd_Y_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // buttonSub_X
            // 
            this.buttonSub_X.Location = new System.Drawing.Point(168, 43);
            this.buttonSub_X.Name = "buttonSub_X";
            this.buttonSub_X.Size = new System.Drawing.Size(75, 23);
            this.buttonSub_X.TabIndex = 2;
            this.buttonSub_X.Text = "-";
            this.buttonSub_X.UseVisualStyleBackColor = true;
            this.buttonSub_X.Click += new System.EventHandler(this.buttonSub_X_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offset";
            // 
            // buttonAdd_X
            // 
            this.buttonAdd_X.Location = new System.Drawing.Point(18, 43);
            this.buttonAdd_X.Name = "buttonAdd_X";
            this.buttonAdd_X.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_X.TabIndex = 0;
            this.buttonAdd_X.Text = "+";
            this.buttonAdd_X.UseVisualStyleBackColor = true;
            this.buttonAdd_X.Click += new System.EventHandler(this.buttonAdd_X_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(34, 433);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(224, 23);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 496);
            this.Controls.Add(this.MasterPanel);
            this.Controls.Add(this.MainPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MasterPanel.ResumeLayout(false);
            this.MasterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MasterPanel;
        private System.Windows.Forms.Button buttonSub_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSub_Z;
        private System.Windows.Forms.Button buttonAdd_Z;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSub_Y;
        private System.Windows.Forms.Button buttonAdd_Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSub_Scale;
        private System.Windows.Forms.Button buttonAdd_Scale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRotation_Z;
        private System.Windows.Forms.Button buttonRotation_Y;
        private System.Windows.Forms.Button buttonRotation_X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddRotation_Z;
        private System.Windows.Forms.Button buttonAddRotation_Y;
        private System.Windows.Forms.Button buttonAddRotation_X;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

