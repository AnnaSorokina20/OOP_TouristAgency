namespace TourAgency
{
    partial class SearchToursForm
    {
        private TextBox departureCityTextBox;
        private TextBox destinationCountryTextBox;
        private NumericUpDown minPriceNumericUpDown;
        private NumericUpDown maxPriceNumericUpDown;
        private Button searchButton;
        private DataGridView resultsDataGridView;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownMinPrice = new NumericUpDown();
            numericUpDownMaxPrice = new NumericUpDown();
            textBoxDepartureCity = new TextBox();
            textBoxDestinationCountry = new TextBox();
            dataGridView1 = new DataGridView();
            buttonSearch = new Button();
            buttonMyBooking = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 271F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownMinPrice, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownMaxPrice, 3, 1);
            tableLayoutPanel1.Controls.Add(textBoxDepartureCity, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxDestinationCountry, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonSearch, 4, 1);
            tableLayoutPanel1.Controls.Add(buttonMyBooking, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 494F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(1122, 605);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 26);
            label1.TabIndex = 0;
            label1.Text = "Місто відправлення";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(284, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 26);
            label2.TabIndex = 1;
            label2.Text = "Країна прибуття";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(565, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 26);
            label3.TabIndex = 2;
            label3.Text = "Мін. ціна";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(709, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 3;
            label4.Text = "Макс. ціна";
            // 
            // numericUpDownMinPrice
            // 
            numericUpDownMinPrice.Dock = DockStyle.Fill;
            numericUpDownMinPrice.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownMinPrice.Location = new Point(565, 44);
            numericUpDownMinPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMinPrice.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownMinPrice.Name = "numericUpDownMinPrice";
            numericUpDownMinPrice.Size = new Size(138, 32);
            numericUpDownMinPrice.TabIndex = 4;
            numericUpDownMinPrice.ValueChanged += numericUpDownMinPrice_ValueChanged;
            // 
            // numericUpDownMaxPrice
            // 
            numericUpDownMaxPrice.Dock = DockStyle.Fill;
            numericUpDownMaxPrice.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownMaxPrice.Location = new Point(709, 44);
            numericUpDownMaxPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMaxPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownMaxPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMaxPrice.Name = "numericUpDownMaxPrice";
            numericUpDownMaxPrice.Size = new Size(138, 32);
            numericUpDownMaxPrice.TabIndex = 5;
            numericUpDownMaxPrice.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownMaxPrice.ValueChanged += numericUpDownMaxPrice_ValueChanged;
            // 
            // textBoxDepartureCity
            // 
            textBoxDepartureCity.Dock = DockStyle.Fill;
            textBoxDepartureCity.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDepartureCity.Location = new Point(3, 44);
            textBoxDepartureCity.Margin = new Padding(3, 4, 3, 4);
            textBoxDepartureCity.Name = "textBoxDepartureCity";
            textBoxDepartureCity.Size = new Size(275, 32);
            textBoxDepartureCity.TabIndex = 6;
            textBoxDepartureCity.TextChanged += textBoxDepartureCity_TextChanged;
            // 
            // textBoxDestinationCountry
            // 
            textBoxDestinationCountry.Dock = DockStyle.Fill;
            textBoxDestinationCountry.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDestinationCountry.Location = new Point(284, 44);
            textBoxDestinationCountry.Margin = new Padding(3, 4, 3, 4);
            textBoxDestinationCountry.Name = "textBoxDestinationCountry";
            textBoxDestinationCountry.Size = new Size(275, 32);
            textBoxDestinationCountry.TabIndex = 7;
            textBoxDestinationCountry.TextChanged += textBoxDestinationCountry_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 5);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 92);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1116, 509);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Fill;
            buttonSearch.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.Location = new Point(853, 44);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(266, 40);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonMyBooking
            // 
            buttonMyBooking.Dock = DockStyle.Fill;
            buttonMyBooking.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMyBooking.Location = new Point(853, 3);
            buttonMyBooking.Name = "buttonMyBooking";
            buttonMyBooking.Size = new Size(266, 34);
            buttonMyBooking.TabIndex = 10;
            buttonMyBooking.Text = "Мої бронювання";
            buttonMyBooking.UseVisualStyleBackColor = true;
            buttonMyBooking.Click += buttonMyBooking_Click;
            // 
            // SearchToursForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 605);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchToursForm";
            Text = "SearchToursForm";
            Load += SearchToursForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownMinPrice;
        private NumericUpDown numericUpDownMaxPrice;
        private TextBox textBoxDepartureCity;
        private TextBox textBoxDestinationCountry;
        private DataGridView dataGridView1;
        private Button buttonSearch;
        private Button buttonMyBooking;
    }
}