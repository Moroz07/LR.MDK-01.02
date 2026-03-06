namespace MovieShow
{
    partial class MainForm
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
            this.ListBoxGenre = new System.Windows.Forms.ListBox();
            this.ComboBoxMovie = new System.Windows.Forms.ComboBox();
            this.PictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.ButtonShowMovie = new System.Windows.Forms.Button();
            this.RichTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.totalShowsMovie = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalShowsMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGenre
            // 
            this.ListBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxGenre.FormattingEnabled = true;
            this.ListBoxGenre.ItemHeight = 20;
            this.ListBoxGenre.Location = new System.Drawing.Point(-2, 13);
            this.ListBoxGenre.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxGenre.Name = "ListBoxGenre";
            this.ListBoxGenre.Size = new System.Drawing.Size(166, 544);
            this.ListBoxGenre.TabIndex = 0;
            this.ListBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenre_SelectedIndexChanged);
            // 
            // ComboBoxMovie
            // 
            this.ComboBoxMovie.FormattingEnabled = true;
            this.ComboBoxMovie.Location = new System.Drawing.Point(453, 82);
            this.ComboBoxMovie.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxMovie.Name = "ComboBoxMovie";
            this.ComboBoxMovie.Size = new System.Drawing.Size(149, 24);
            this.ComboBoxMovie.TabIndex = 1;
            this.ComboBoxMovie.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMovie_SelectedIndexChanged);
            // 
            // PictureBoxMovie
            // 
            this.PictureBoxMovie.Location = new System.Drawing.Point(610, 0);
            this.PictureBoxMovie.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxMovie.Name = "PictureBoxMovie";
            this.PictureBoxMovie.Size = new System.Drawing.Size(609, 403);
            this.PictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMovie.TabIndex = 2;
            this.PictureBoxMovie.TabStop = false;
            // 
            // ButtonShowMovie
            // 
            this.ButtonShowMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowMovie.Location = new System.Drawing.Point(246, 248);
            this.ButtonShowMovie.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonShowMovie.Name = "ButtonShowMovie";
            this.ButtonShowMovie.Size = new System.Drawing.Size(204, 79);
            this.ButtonShowMovie.TabIndex = 3;
            this.ButtonShowMovie.Text = "Отчёт";
            this.ButtonShowMovie.UseVisualStyleBackColor = true;
            this.ButtonShowMovie.Click += new System.EventHandler(this.ButtonShowMovie_Click);
            // 
            // RichTextBoxInfo
            // 
            this.RichTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxInfo.Location = new System.Drawing.Point(610, 437);
            this.RichTextBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxInfo.Name = "RichTextBoxInfo";
            this.RichTextBoxInfo.Size = new System.Drawing.Size(609, 153);
            this.RichTextBoxInfo.TabIndex = 4;
            this.RichTextBoxInfo.Text = "";
            // 
            // totalShowsMovie
            // 
            this.totalShowsMovie.Location = new System.Drawing.Point(453, 162);
            this.totalShowsMovie.Name = "totalShowsMovie";
            this.totalShowsMovie.Size = new System.Drawing.Size(150, 22);
            this.totalShowsMovie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(241, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите фильм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выбериете кол-во показов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalShowsMovie);
            this.Controls.Add(this.RichTextBoxInfo);
            this.Controls.Add(this.ButtonShowMovie);
            this.Controls.Add(this.PictureBoxMovie);
            this.Controls.Add(this.ComboBoxMovie);
            this.Controls.Add(this.ListBoxGenre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1250, 650);
            this.Name = "MainForm";
            this.Text = "Прокат фильмов";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalShowsMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGenre;
        private System.Windows.Forms.ComboBox ComboBoxMovie;
        private System.Windows.Forms.PictureBox PictureBoxMovie;
        private System.Windows.Forms.Button ButtonShowMovie;
        private System.Windows.Forms.RichTextBox RichTextBoxInfo;
        private System.Windows.Forms.NumericUpDown totalShowsMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

