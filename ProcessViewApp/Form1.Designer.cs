namespace ProcessViewApp
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
            this.listBoxProcesses = new System.Windows.Forms.ListBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.btnSetInterval = new System.Windows.Forms.Button();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunNotepad = new System.Windows.Forms.Button();
            this.btnRunCalculator = new System.Windows.Forms.Button();
            this.btnRunPaint = new System.Windows.Forms.Button();
            this.btnRunCustomApp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.Location = new System.Drawing.Point(12, 29);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(274, 342);
            this.listBoxProcesses.TabIndex = 0;
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(685, 41);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(75, 20);
            this.textBoxInterval.TabIndex = 1;
            // 
            // btnSetInterval
            // 
            this.btnSetInterval.Location = new System.Drawing.Point(685, 67);
            this.btnSetInterval.Name = "btnSetInterval";
            this.btnSetInterval.Size = new System.Drawing.Size(75, 23);
            this.btnSetInterval.TabIndex = 2;
            this.btnSetInterval.Text = "Enter";
            this.btnSetInterval.UseVisualStyleBackColor = true;
            this.btnSetInterval.Click += new System.EventHandler(this.btnSetInterval_Click_1);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(316, 29);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(360, 179);
            this.dataGridViewDetails.TabIndex = 3;
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Location = new System.Drawing.Point(688, 146);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(75, 23);
            this.btnEndProcess.TabIndex = 4;
            this.btnEndProcess.Text = "Enter";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Установить интервал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Завершить процесс";
            // 
            // btnRunNotepad
            // 
            this.btnRunNotepad.Location = new System.Drawing.Point(316, 251);
            this.btnRunNotepad.Name = "btnRunNotepad";
            this.btnRunNotepad.Size = new System.Drawing.Size(116, 49);
            this.btnRunNotepad.TabIndex = 7;
            this.btnRunNotepad.Text = "Блокнот";
            this.btnRunNotepad.UseVisualStyleBackColor = true;
            this.btnRunNotepad.Click += new System.EventHandler(this.btnRunNotepad_Click_1);
            // 
            // btnRunCalculator
            // 
            this.btnRunCalculator.Location = new System.Drawing.Point(438, 251);
            this.btnRunCalculator.Name = "btnRunCalculator";
            this.btnRunCalculator.Size = new System.Drawing.Size(116, 49);
            this.btnRunCalculator.TabIndex = 8;
            this.btnRunCalculator.Text = "Калькулятор";
            this.btnRunCalculator.UseVisualStyleBackColor = true;
            this.btnRunCalculator.Click += new System.EventHandler(this.btnRunCalculator_Click_1);
            // 
            // btnRunPaint
            // 
            this.btnRunPaint.Location = new System.Drawing.Point(560, 251);
            this.btnRunPaint.Name = "btnRunPaint";
            this.btnRunPaint.Size = new System.Drawing.Size(116, 49);
            this.btnRunPaint.TabIndex = 9;
            this.btnRunPaint.Text = "Paint";
            this.btnRunPaint.UseVisualStyleBackColor = true;
            // 
            // btnRunCustomApp
            // 
            this.btnRunCustomApp.Location = new System.Drawing.Point(438, 306);
            this.btnRunCustomApp.Name = "btnRunCustomApp";
            this.btnRunCustomApp.Size = new System.Drawing.Size(116, 49);
            this.btnRunCustomApp.TabIndex = 10;
            this.btnRunCustomApp.Text = "Пользовательское приложение";
            this.btnRunCustomApp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ЗАПУСК ПРИЛОЖЕНИЙ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRunCustomApp);
            this.Controls.Add(this.btnRunPaint);
            this.Controls.Add(this.btnRunCalculator);
            this.Controls.Add(this.btnRunNotepad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndProcess);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.btnSetInterval);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.listBoxProcesses);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcesses;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Button btnSetInterval;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunNotepad;
        private System.Windows.Forms.Button btnRunCalculator;
        private System.Windows.Forms.Button btnRunPaint;
        private System.Windows.Forms.Button btnRunCustomApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

