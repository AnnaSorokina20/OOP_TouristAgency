namespace TourAgency
{
    partial class AddEditTourForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            textBoxDepCity = new TextBox();
            textBoxDesCountry = new TextBox();
            textBoxDescription = new TextBox();
            textBoxPrice = new TextBox();
            dateTimePickerDepDate = new DateTimePicker();
            dateTimePickerRetDate = new DateTimePicker();
            comboBoxTourType = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            comboBoxStatus = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(299, 11);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 1;
            label1.Text = "Додати тур";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(113, 101);
            label2.Name = "label2";
            label2.Size = new Size(244, 29);
            label2.TabIndex = 2;
            label2.Text = "Місто відправлення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(113, 214);
            label3.Name = "label3";
            label3.Size = new Size(203, 29);
            label3.TabIndex = 3;
            label3.Text = "Країна прибуття";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(113, 324);
            label4.Name = "label4";
            label4.Size = new Size(234, 29);
            label4.TabIndex = 4;
            label4.Text = "Дата відправлення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(406, 324);
            label5.Name = "label5";
            label5.Size = new Size(216, 29);
            label5.TabIndex = 5;
            label5.Text = "Дата повернення";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(119, 429);
            label6.Name = "label6";
            label6.Size = new Size(64, 29);
            label6.TabIndex = 6;
            label6.Text = "Ціна";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(119, 531);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 7;
            label7.Text = "Опис";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(124, 798);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(137, 55);
            button2.TabIndex = 8;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxDepCity
            // 
            textBoxDepCity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDepCity.Location = new Point(124, 141);
            textBoxDepCity.Margin = new Padding(3, 4, 3, 4);
            textBoxDepCity.Name = "textBoxDepCity";
            textBoxDepCity.Size = new Size(398, 35);
            textBoxDepCity.TabIndex = 9;
            // 
            // textBoxDesCountry
            // 
            textBoxDesCountry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDesCountry.Location = new Point(124, 254);
            textBoxDesCountry.Margin = new Padding(3, 4, 3, 4);
            textBoxDesCountry.Name = "textBoxDesCountry";
            textBoxDesCountry.Size = new Size(398, 35);
            textBoxDesCountry.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDescription.Location = new Point(124, 571);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(508, 118);
            textBoxDescription.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(124, 469);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(151, 35);
            textBoxPrice.TabIndex = 14;
            // 
            // dateTimePickerDepDate
            // 
            dateTimePickerDepDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerDepDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDepDate.Location = new Point(119, 364);
            dateTimePickerDepDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDepDate.Name = "dateTimePickerDepDate";
            dateTimePickerDepDate.Size = new Size(235, 35);
            dateTimePickerDepDate.TabIndex = 15;
            // 
            // dateTimePickerRetDate
            // 
            dateTimePickerRetDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerRetDate.Format = DateTimePickerFormat.Short;
            dateTimePickerRetDate.Location = new Point(411, 364);
            dateTimePickerRetDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerRetDate.Name = "dateTimePickerRetDate";
            dateTimePickerRetDate.Size = new Size(222, 35);
            dateTimePickerRetDate.TabIndex = 16;
            // 
            // comboBoxTourType
            // 
            comboBoxTourType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTourType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTourType.FormattingEnabled = true;
            comboBoxTourType.Location = new Point(124, 64);
            comboBoxTourType.Margin = new Padding(3, 4, 3, 4);
            comboBoxTourType.Name = "comboBoxTourType";
            comboBoxTourType.Size = new Size(398, 37);
            comboBoxTourType.TabIndex = 17;
            comboBoxTourType.SelectedIndexChanged += comboBoxTourType_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(113, 31);
            label8.Name = "label8";
            label8.Size = new Size(113, 29);
            label8.TabIndex = 18;
            label8.Text = "Тип туру";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(119, 700);
            label9.Name = "label9";
            label9.Size = new Size(90, 29);
            label9.TabIndex = 19;
            label9.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(124, 733);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(398, 37);
            comboBoxStatus.TabIndex = 20;
            // 
            // AddEditTourForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 866);
            Controls.Add(comboBoxStatus);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBoxTourType);
            Controls.Add(dateTimePickerRetDate);
            Controls.Add(dateTimePickerDepDate);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxDesCountry);
            Controls.Add(textBoxDepCity);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddEditTourForm";
            Text = "AddEditTourForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDepCity;
        private System.Windows.Forms.TextBox textBoxDesCountry;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetDate;
        private System.Windows.Forms.ComboBox comboBoxTourType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}
