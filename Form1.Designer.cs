namespace HW_TabControl
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
            this.SHOW = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPtext = new System.Windows.Forms.TabPage();
            this.TPcolor = new System.Windows.Forms.TabPage();
            this.TPsize = new System.Windows.Forms.TabPage();
            this.RBtext1 = new System.Windows.Forms.RadioButton();
            this.RBtext2 = new System.Windows.Forms.RadioButton();
            this.RBred = new System.Windows.Forms.RadioButton();
            this.RByellow = new System.Windows.Forms.RadioButton();
            this.RBblue = new System.Windows.Forms.RadioButton();
            this.TxtSize = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.TPtext.SuspendLayout();
            this.TPcolor.SuspendLayout();
            this.TPsize.SuspendLayout();
            this.SuspendLayout();
            // 
            // SHOW
            // 
            this.SHOW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SHOW.Location = new System.Drawing.Point(0, 192);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(288, 81);
            this.SHOW.TabIndex = 1;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPtext);
            this.tabControl1.Controls.Add(this.TPcolor);
            this.tabControl1.Controls.Add(this.TPsize);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 189);
            this.tabControl1.TabIndex = 2;
            // 
            // TPtext
            // 
            this.TPtext.Controls.Add(this.RBtext2);
            this.TPtext.Controls.Add(this.RBtext1);
            this.TPtext.Location = new System.Drawing.Point(4, 22);
            this.TPtext.Name = "TPtext";
            this.TPtext.Padding = new System.Windows.Forms.Padding(3);
            this.TPtext.Size = new System.Drawing.Size(280, 163);
            this.TPtext.TabIndex = 0;
            this.TPtext.Text = "Текст";
            this.TPtext.UseVisualStyleBackColor = true;
            // 
            // TPcolor
            // 
            this.TPcolor.Controls.Add(this.RBblue);
            this.TPcolor.Controls.Add(this.RByellow);
            this.TPcolor.Controls.Add(this.RBred);
            this.TPcolor.Location = new System.Drawing.Point(4, 22);
            this.TPcolor.Name = "TPcolor";
            this.TPcolor.Padding = new System.Windows.Forms.Padding(3);
            this.TPcolor.Size = new System.Drawing.Size(280, 163);
            this.TPcolor.TabIndex = 1;
            this.TPcolor.Text = "Цвет";
            this.TPcolor.UseVisualStyleBackColor = true;
            // 
            // TPsize
            // 
            this.TPsize.Controls.Add(this.TxtSize);
            this.TPsize.Location = new System.Drawing.Point(4, 22);
            this.TPsize.Name = "TPsize";
            this.TPsize.Size = new System.Drawing.Size(280, 163);
            this.TPsize.TabIndex = 2;
            this.TPsize.Text = "Размер";
            this.TPsize.UseVisualStyleBackColor = true;
            // 
            // RBtext1
            // 
            this.RBtext1.Location = new System.Drawing.Point(3, 6);
            this.RBtext1.Name = "RBtext1";
            this.RBtext1.Size = new System.Drawing.Size(252, 44);
            this.RBtext1.TabIndex = 0;
            this.RBtext1.TabStop = true;
            this.RBtext1.Text = "Восхищенная, сочувственная,  скромно-смущенная";
            this.RBtext1.UseVisualStyleBackColor = true;
            this.RBtext1.CheckedChanged += new System.EventHandler(this.RBtext1_CheckedChanged);
            // 
            // RBtext2
            // 
            this.RBtext2.Location = new System.Drawing.Point(3, 56);
            this.RBtext2.Name = "RBtext2";
            this.RBtext2.Size = new System.Drawing.Size(252, 44);
            this.RBtext2.TabIndex = 1;
            this.RBtext2.TabStop = true;
            this.RBtext2.Text = "Нежняя улыбка,ехидная, бесстыжая, подленькая, снисходительная";
            this.RBtext2.UseVisualStyleBackColor = true;
            this.RBtext2.CheckedChanged += new System.EventHandler(this.RBtext2_CheckedChanged);
            // 
            // RBred
            // 
            this.RBred.AutoSize = true;
            this.RBred.Location = new System.Drawing.Point(9, 21);
            this.RBred.Name = "RBred";
            this.RBred.Size = new System.Drawing.Size(70, 17);
            this.RBred.TabIndex = 0;
            this.RBred.TabStop = true;
            this.RBred.Text = "Красный";
            this.RBred.UseVisualStyleBackColor = true;
            this.RBred.CheckedChanged += new System.EventHandler(this.RBred_CheckedChanged);
            // 
            // RByellow
            // 
            this.RByellow.AutoSize = true;
            this.RByellow.Location = new System.Drawing.Point(9, 44);
            this.RByellow.Name = "RByellow";
            this.RByellow.Size = new System.Drawing.Size(67, 17);
            this.RByellow.TabIndex = 1;
            this.RByellow.TabStop = true;
            this.RByellow.Text = "Желтый";
            this.RByellow.UseVisualStyleBackColor = true;
            this.RByellow.CheckedChanged += new System.EventHandler(this.RByellow_CheckedChanged);
            // 
            // RBblue
            // 
            this.RBblue.AutoSize = true;
            this.RBblue.Location = new System.Drawing.Point(9, 67);
            this.RBblue.Name = "RBblue";
            this.RBblue.Size = new System.Drawing.Size(56, 17);
            this.RBblue.TabIndex = 2;
            this.RBblue.TabStop = true;
            this.RBblue.Text = "Синий";
            this.RBblue.UseVisualStyleBackColor = true;
            this.RBblue.CheckedChanged += new System.EventHandler(this.RBblue_CheckedChanged);
            // 
            // TxtSize
            // 
            this.TxtSize.FormattingEnabled = true;
            this.TxtSize.Location = new System.Drawing.Point(8, 18);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(248, 21);
            this.TxtSize.TabIndex = 0;
            this.TxtSize.SelectedIndexChanged += new System.EventHandler(this.TxtSize_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 273);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SHOW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TPtext.ResumeLayout(false);
            this.TPcolor.ResumeLayout(false);
            this.TPcolor.PerformLayout();
            this.TPsize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SHOW;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPtext;
        private System.Windows.Forms.RadioButton RBtext2;
        private System.Windows.Forms.RadioButton RBtext1;
        private System.Windows.Forms.TabPage TPcolor;
        private System.Windows.Forms.RadioButton RBblue;
        private System.Windows.Forms.RadioButton RByellow;
        private System.Windows.Forms.RadioButton RBred;
        private System.Windows.Forms.TabPage TPsize;
        private System.Windows.Forms.ComboBox TxtSize;
    }
}

