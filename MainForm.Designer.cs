namespace Guide
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.Label();
            this.MinimizeWindowButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ArticlesStoragePanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox.Location = new System.Drawing.Point(4, 25);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(542, 721);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(542, 16);
            this.Title.TabIndex = 1;
            this.Title.Text = "Guide";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // MinimizeWindowButton
            // 
            this.MinimizeWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.MinimizeWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeWindowButton.FlatAppearance.BorderSize = 0;
            this.MinimizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.MinimizeWindowButton.Location = new System.Drawing.Point(518, 7);
            this.MinimizeWindowButton.Name = "MinimizeWindowButton";
            this.MinimizeWindowButton.Size = new System.Drawing.Size(10, 10);
            this.MinimizeWindowButton.TabIndex = 2;
            this.MinimizeWindowButton.UseVisualStyleBackColor = false;
            this.MinimizeWindowButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeWindowButton_MouseClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExitButton.Location = new System.Drawing.Point(533, 7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(10, 10);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // ArticlesStoragePanel
            // 
            this.ArticlesStoragePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ArticlesStoragePanel.Location = new System.Drawing.Point(3, 24);
            this.ArticlesStoragePanel.Name = "ArticlesStoragePanel";
            this.ArticlesStoragePanel.Size = new System.Drawing.Size(544, 722);
            this.ArticlesStoragePanel.TabIndex = 6;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReturnButton.Location = new System.Drawing.Point(7, 7);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(22, 10);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "←";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReturnButton_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Guide.Properties.Resources.MainForm;
            this.ClientSize = new System.Drawing.Size(550, 750);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ArticlesStoragePanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MinimizeWindowButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.Text = "Guide";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MinimizeWindowButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel ArticlesStoragePanel;
        private System.Windows.Forms.Button ReturnButton;
    }
}

