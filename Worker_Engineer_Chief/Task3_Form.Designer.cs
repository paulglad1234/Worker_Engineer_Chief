namespace Worker_Engineer_Chief
{
    partial class Task3_Form
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.changePanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.salaryChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.patronymicChangeTextBox = new System.Windows.Forms.TextBox();
            this.nameChangeTextBox = new System.Windows.Forms.TextBox();
            this.surnameChangeTextBox = new System.Windows.Forms.TextBox();
            this.subsChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.changingsAcceptButton = new System.Windows.Forms.Button();
            this.fireButton = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsNumericUpDown)).BeginInit();
            this.changePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryChangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsChangeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.subsNumericUpDown);
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.salaryLabel);
            this.addPanel.Controls.Add(this.salaryNumericUpDown);
            this.addPanel.Controls.Add(this.patronymicLabel);
            this.addPanel.Controls.Add(this.nameLabel);
            this.addPanel.Controls.Add(this.surnameLabel);
            this.addPanel.Controls.Add(this.patronymicTextBox);
            this.addPanel.Controls.Add(this.nameTextBox);
            this.addPanel.Controls.Add(this.surnameTextBox);
            this.addPanel.Location = new System.Drawing.Point(12, 12);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(247, 157);
            this.addPanel.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(144, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.Text = "Иванов";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "Иван";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(144, 55);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicTextBox.TabIndex = 2;
            this.patronymicTextBox.Text = "Иваныч";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(3, 6);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Имя";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(3, 58);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.patronymicLabel.TabIndex = 5;
            this.patronymicLabel.Text = "Отчество";
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Location = new System.Drawing.Point(144, 81);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.salaryNumericUpDown.TabIndex = 7;
            this.salaryNumericUpDown.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(3, 83);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(22, 13);
            this.salaryLabel.TabIndex = 8;
            this.salaryLabel.Text = "ЗП";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Принять на работу";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subsNumericUpDown
            // 
            this.subsNumericUpDown.Location = new System.Drawing.Point(144, 105);
            this.subsNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.subsNumericUpDown.Name = "subsNumericUpDown";
            this.subsNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.subsNumericUpDown.TabIndex = 10;
            this.subsNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество подчиненных";
            // 
            // changePanel
            // 
            this.changePanel.Controls.Add(this.fireButton);
            this.changePanel.Controls.Add(this.changingsAcceptButton);
            this.changePanel.Controls.Add(this.subsChangeNumericUpDown);
            this.changePanel.Controls.Add(this.surnameChangeTextBox);
            this.changePanel.Controls.Add(this.nameChangeTextBox);
            this.changePanel.Controls.Add(this.patronymicChangeTextBox);
            this.changePanel.Controls.Add(this.salaryChangeNumericUpDown);
            this.changePanel.Controls.Add(this.searchButton);
            this.changePanel.Location = new System.Drawing.Point(265, 12);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(229, 157);
            this.changePanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(223, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Найти нужного работника";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // salaryChangeNumericUpDown
            // 
            this.salaryChangeNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryChangeNumericUpDown.Location = new System.Drawing.Point(124, 33);
            this.salaryChangeNumericUpDown.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.salaryChangeNumericUpDown.Name = "salaryChangeNumericUpDown";
            this.salaryChangeNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.salaryChangeNumericUpDown.TabIndex = 8;
            // 
            // patronymicChangeTextBox
            // 
            this.patronymicChangeTextBox.Location = new System.Drawing.Point(3, 80);
            this.patronymicChangeTextBox.Name = "patronymicChangeTextBox";
            this.patronymicChangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicChangeTextBox.TabIndex = 9;
            // 
            // nameChangeTextBox
            // 
            this.nameChangeTextBox.Location = new System.Drawing.Point(3, 55);
            this.nameChangeTextBox.Name = "nameChangeTextBox";
            this.nameChangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameChangeTextBox.TabIndex = 10;
            // 
            // surnameChangeTextBox
            // 
            this.surnameChangeTextBox.Location = new System.Drawing.Point(3, 32);
            this.surnameChangeTextBox.Name = "surnameChangeTextBox";
            this.surnameChangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameChangeTextBox.TabIndex = 11;
            // 
            // subsChangeNumericUpDown
            // 
            this.subsChangeNumericUpDown.Location = new System.Drawing.Point(124, 58);
            this.subsChangeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.subsChangeNumericUpDown.Name = "subsChangeNumericUpDown";
            this.subsChangeNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.subsChangeNumericUpDown.TabIndex = 12;
            // 
            // changingsAcceptButton
            // 
            this.changingsAcceptButton.Location = new System.Drawing.Point(5, 102);
            this.changingsAcceptButton.Name = "changingsAcceptButton";
            this.changingsAcceptButton.Size = new System.Drawing.Size(221, 23);
            this.changingsAcceptButton.TabIndex = 13;
            this.changingsAcceptButton.Text = "Применить изменения";
            this.changingsAcceptButton.UseVisualStyleBackColor = true;
            this.changingsAcceptButton.Click += new System.EventHandler(this.changingsAcceptButton_Click);
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(5, 131);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(221, 23);
            this.fireButton.TabIndex = 14;
            this.fireButton.Text = "Уволить";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // Task3_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 175);
            this.Controls.Add(this.changePanel);
            this.Controls.Add(this.addPanel);
            this.Name = "Task3_Form";
            this.Text = "ГосДума";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsNumericUpDown)).EndInit();
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryChangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subsChangeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown subsNumericUpDown;
        private System.Windows.Forms.Panel changePanel;
        private System.Windows.Forms.NumericUpDown salaryChangeNumericUpDown;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown subsChangeNumericUpDown;
        private System.Windows.Forms.TextBox surnameChangeTextBox;
        private System.Windows.Forms.TextBox nameChangeTextBox;
        private System.Windows.Forms.TextBox patronymicChangeTextBox;
        private System.Windows.Forms.Button changingsAcceptButton;
        private System.Windows.Forms.Button fireButton;
    }
}

