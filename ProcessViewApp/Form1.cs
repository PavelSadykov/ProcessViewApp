using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessViewApp
{
    public partial class Form1 : Form
    {
        private System.Threading.Timer timer;
        private int interval = 10000; // Интервал обновления по умолчанию (в миллисекундах)
        public Form1()
        {
            InitializeComponent();
            LoadProcesses();
            dataGridViewDetails.Columns.Add("Property", "Property");
            dataGridViewDetails.Columns.Add("Value", "Value");
            listBoxProcesses.SelectedIndexChanged += listBoxProcesses_SelectedIndexChanged;
            //Запускаем таймер для обновления процессов с указанным интервалом
            timer = new System.Threading.Timer(UpdateProcesses, null, interval, interval);
        }
        private int GetProcessCount(string processName)
        {

            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length;
        }
        private void LoadProcesses()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                listBoxProcesses.Items.Add($"{process.ProcessName} (ID: {process.Id})");
            }
        }

        private void UpdateProcesses(object state)
        {
            //Очищаем список процессов и обновляем его
            listBoxProcesses.Invoke((MethodInvoker)delegate
            {
                listBoxProcesses.Items.Clear();
                LoadProcesses();
            });
        }

        private void listBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex != -1)
            {
                Process selectedProcess = Process.GetProcesses()[listBoxProcesses.SelectedIndex];
                ShowProcessDetails(selectedProcess);
            }
        }

        private void ShowProcessDetails(Process process)
        {
            dataGridViewDetails.Rows.Clear();

            dataGridViewDetails.Rows.Add("Идентификатор процесса", process.Id);
            dataGridViewDetails.Rows.Add("Время старта", process.StartTime.ToString());
            dataGridViewDetails.Rows.Add("Общее время CPU", process.TotalProcessorTime.ToString());
            dataGridViewDetails.Rows.Add("Количество потоков", process.Threads.Count);
            int count = GetProcessCount(process.ProcessName);
            dataGridViewDetails.Rows.Add("Количество копий проесса", count);

            // Отображаем информацию о процессе в DataGridView
            dataGridViewDetails.AutoResizeColumns();
        }
        private void btnSetInterval_Click_1(object sender, EventArgs e)
        {
            // Устанавливаем новый интервал обновления из текстового поля
            if (int.TryParse(textBoxInterval.Text, out int newInterval) && newInterval > 0)
            {
                interval = newInterval;
                timer.Change(0, interval); // Изменяем интервал таймера
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный интервал в миллисекундах.");
            }
        }
        private void btnEndProcess_Click_1(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex != -1)
            {
                Process[] processes = Process.GetProcesses();
                Process selectedProcess = processes[listBoxProcesses.SelectedIndex];

                if (!selectedProcess.HasExited)
                {
                    try
                    {
                      //  selectedProcess.Kill(); // Завершение выбранного процесса
                        MessageBox.Show("Процесс успешно завершен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при завершении процесса: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Выбранный процесс уже завершен.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите процесс для завершения.");
            }
        }
        //обработчик события для кнопки запуска блокнота
        private void btnRunNotepad_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске блокнота: {ex.Message}");
            }
        }

        //обработчик события для кнопки запуска калькулятора
        private void btnRunCalculator_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске калькулятора: {ex.Message}");
            }
        }

        //обработчик события для кнопки запуска Paint
        private void btnRunPaint_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mspaint.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске Paint: {ex.Message}");
            }
        }

        //обработчик события для кнопки запуска пользовательского приложения
        private void btnRunCustomApp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.Title = "Выберите исполняемый файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedApp = openFileDialog.FileName;
                try
                {
                    Process.Start(selectedApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при запуске выбранного приложения: {ex.Message}");
                }
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
