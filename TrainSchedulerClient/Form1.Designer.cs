using System;
using System.Drawing;
using WcfServiceLibrary1;

namespace TrainSchedulerClient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startCityTextBox = new System.Windows.Forms.TextBox();
            this.endCityTextBox = new System.Windows.Forms.TextBox();
            this.timeIntervalLabel = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.citiesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.directTextArea = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.indirectTextArea = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start city:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "End city:";
            // 
            // startCityTextBox
            // 
            this.startCityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.startCityTextBox.Location = new System.Drawing.Point(99, 58);
            this.startCityTextBox.Name = "startCityTextBox";
            this.startCityTextBox.Size = new System.Drawing.Size(172, 26);
            this.startCityTextBox.TabIndex = 2;
            // 
            // endCityTextBox
            // 
            this.endCityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.endCityTextBox.Location = new System.Drawing.Point(99, 101);
            this.endCityTextBox.Name = "endCityTextBox";
            this.endCityTextBox.Size = new System.Drawing.Size(172, 26);
            this.endCityTextBox.TabIndex = 3;
            // 
            // timeIntervalLabel
            // 
            this.timeIntervalLabel.AutoSize = true;
            this.timeIntervalLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.timeIntervalLabel.Location = new System.Drawing.Point(417, 23);
            this.timeIntervalLabel.Name = "timeIntervalLabel";
            this.timeIntervalLabel.Size = new System.Drawing.Size(116, 22);
            this.timeIntervalLabel.TabIndex = 4;
            this.timeIntervalLabel.Text = "Time Interval";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(393, 59);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(155, 20);
            this.fromDatePicker.TabIndex = 5;
            this.fromDatePicker.Value = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(342, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "From:";
            // 
            // citiesLabel
            // 
            this.citiesLabel.AutoSize = true;
            this.citiesLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.citiesLabel.Location = new System.Drawing.Point(134, 23);
            this.citiesLabel.Name = "citiesLabel";
            this.citiesLabel.Size = new System.Drawing.Size(57, 22);
            this.citiesLabel.TabIndex = 7;
            this.citiesLabel.Text = "Cities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(342, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(393, 101);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(155, 20);
            this.toDatePicker.TabIndex = 8;
            this.toDatePicker.Value = new System.DateTime(2017, 6, 20, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.Location = new System.Drawing.Point(134, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direct";
            // 
            // directTextArea
            // 
            this.directTextArea.Location = new System.Drawing.Point(27, 241);
            this.directTextArea.Name = "directTextArea";
            this.directTextArea.Size = new System.Drawing.Size(275, 126);
            this.directTextArea.TabIndex = 11;
            this.directTextArea.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.Location = new System.Drawing.Point(443, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Indirect";
            // 
            // indirectTextArea
            // 
            this.indirectTextArea.Location = new System.Drawing.Point(336, 242);
            this.indirectTextArea.Name = "indirectTextArea";
            this.indirectTextArea.Size = new System.Drawing.Size(280, 125);
            this.indirectTextArea.TabIndex = 13;
            this.indirectTextArea.Text = "";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(201, 152);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(239, 30);
            this.submit.TabIndex = 14;
            this.submit.Text = "Show train schedule";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fromTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fromTimePicker.Location = new System.Drawing.Point(554, 58);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.ShowUpDown = true;
            this.fromTimePicker.Size = new System.Drawing.Size(62, 20);
            this.fromTimePicker.TabIndex = 15;
            // 
            // toTimePicker
            // 
            this.toTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.toTimePicker.Location = new System.Drawing.Point(554, 101);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.ShowUpDown = true;
            this.toTimePicker.Size = new System.Drawing.Size(62, 20);
            this.toTimePicker.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 396);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.indirectTextArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.directTextArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.citiesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.timeIntervalLabel);
            this.Controls.Add(this.endCityTextBox);
            this.Controls.Add(this.startCityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Indirect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startCityTextBox;
        private System.Windows.Forms.TextBox endCityTextBox;
        private System.Windows.Forms.Label timeIntervalLabel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label citiesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox directTextArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox indirectTextArea;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
    }
}

