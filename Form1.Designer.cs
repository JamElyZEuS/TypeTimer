namespace TypeTimer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.setButton = new System.Windows.Forms.Button();
            this.typingField = new System.Windows.Forms.TextBox();
            this.setText = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 1;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableContainer.Controls.Add(this.setButton, 0, 4);
            this.tableContainer.Controls.Add(this.typingField, 0, 3);
            this.tableContainer.Controls.Add(this.setText, 0, 2);
            this.tableContainer.Controls.Add(this.timeLabel, 0, 1);
            this.tableContainer.Controls.Add(this.titleLabel, 0, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 5;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableContainer.Size = new System.Drawing.Size(751, 481);
            this.tableContainer.TabIndex = 0;
            // 
            // setButton
            // 
            this.setButton.AutoSize = true;
            this.setButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setButton.Location = new System.Drawing.Point(646, 440);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(102, 38);
            this.setButton.TabIndex = 1;
            this.setButton.Text = "Set Text";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // typingField
            // 
            this.typingField.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.typingField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typingField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typingField.Location = new System.Drawing.Point(10, 313);
            this.typingField.Margin = new System.Windows.Forms.Padding(10);
            this.typingField.Multiline = true;
            this.typingField.Name = "typingField";
            this.typingField.Size = new System.Drawing.Size(731, 114);
            this.typingField.TabIndex = 0;
            this.typingField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typingField.TextChanged += new System.EventHandler(this.typingField_TextChanged);
            this.typingField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typingField_KeyDown);
            // 
            // setText
            // 
            this.setText.AutoEllipsis = true;
            this.setText.AutoSize = true;
            this.setText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setText.Location = new System.Drawing.Point(3, 278);
            this.setText.Name = "setText";
            this.setText.Size = new System.Drawing.Size(745, 25);
            this.setText.TabIndex = 2;
            this.setText.Text = "Enter text to compare";
            this.setText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(587, 139);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(161, 139);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "00:00.000";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(745, 139);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Test your typing speed!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 481);
            this.Controls.Add(this.tableContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TypeTimer";
            this.tableContainer.ResumeLayout(false);
            this.tableContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private System.Windows.Forms.TextBox typingField;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label setText;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

