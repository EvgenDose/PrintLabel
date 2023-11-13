namespace PrintLabel
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Diagnostics;
    using System.Management;
    using System.Threading;
    using System.Collections.Generic;

    public partial class Form1 : Form
    {
        //���������� ����������
        String k;
        String line;
        List<string> alllines = new List<string>();
        string[] tuple;
        object Name_print;
        object Name_sys;

        public Form1()
        {
            //���������� ��������� � �����
            InitializeComponent();
            var preparat = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\PrintLabel\\pr.txt").ToList();
            for (int i = 0; i < preparat.Count; i++)
            {
                string[] tuple = preparat[i].Split(',');
                comboBox1.Items.Add(tuple[1].Trim('\''));
            }
        }

        //�������� ����� � ������ � ���������� �� � ������ List
        private void b1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files|*.txt|All Files|*.*";
            dlg.ShowDialog();
            string path = dlg.FileName;
            textBox1.Text = path;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                alllines.Add(line);
                label8.Text = line;
                label8.ForeColor = Color.Green;
            }
        }

        //��������� ���������� ������ � �����
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                var preparat = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\PrintLabel\\pr.txt").ToList();
                foreach (var tupleString in preparat)
                {
                    string[] tuple = tupleString.Split(',');
                    if (tuple[1].Trim('\'') == selectedItem)
                    {
                        string firstElement = tuple[0].Trim('(', '\'');
                        string thirdElement = tuple[2].Trim('\'', ')');
                        label12.Text = firstElement;
                        label12.ForeColor = Color.Green;
                        label9.Text = thirdElement;
                        label9.ForeColor = Color.Green;
                        label4.Text = tuple[1].Trim('\'');
                        label4.ForeColor = Color.Green;
                        break;
                    }
                }
            }
        }

        //���� ����
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label14.Text = maskedTextBox1.Text;
            label14.ForeColor = Color.Green;
        }

        //���� �����
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label11.Text = maskedTextBox2.Text;
            label11.ForeColor = Color.Green;
        }

        //������ zpl ������� �� �������������
        private void b2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            // ���������� ���������� ���� ������ ��������
            DialogResult result = printDialog.ShowDialog();

            // ���������, ���� �� ������� �� ������ "��" � ���� ������ ��������
            if (result == DialogResult.OK)
            {
                // �������� ��������� ������� �� PrintDialog � �������� ��� ����������� ��� � ��� �����
                var print_NAME = printDialog.PrinterSettings.PrinterName;
                string printerName = print_NAME;
                string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName);
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                using (ManagementObjectCollection coll = searcher.Get())
                {
                    foreach (ManagementObject printer in coll)
                    {
                        foreach (PropertyData property in printer.Properties)
                        {
                            string print_property = property.Name;
                            object property_value = property.Value;
                            if (print_property == "ShareName")
                            {
                                Name_print = property.Value;
                            }
                            if (print_property == "SystemName")
                            {
                                Name_sys = property.Value;
                            }
                        }
                    }
                }
                // ���� ������������ zpl ������� � ������� ������
                foreach (string l in alllines)
                {
                    var zpl = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\PrintLabel\\zpl.txt").ToList();
                    var modifiedZpl = new List<string>();
                    for (int i = 0; i < zpl.Count; i++)
                    {
                        if (l.Length < 20)
                        {
                            modifiedZpl.Add(zpl[i]);
                            if (i == 0)
                            {
                                modifiedZpl.Add(label4.Text);
                            }
                            if (i == 1)
                            {
                                modifiedZpl.Add(label14.Text);
                            }
                            if (i == 2)
                            {
                                modifiedZpl.Add(label9.Text);
                            }
                            if (i == 3)
                            {
                                modifiedZpl.Add(label11.Text);
                            }
                            if (i == 4)
                            {
                                modifiedZpl.Add(label12.Text);
                            }
                            if (i == 5)
                            {
                                modifiedZpl.Add(l);
                            }
                        }
                        else
                        {
                            k = l.Substring(2);
                            modifiedZpl.Add(zpl[i]);
                            if (i == 0)
                            {
                                modifiedZpl.Add(label4.Text);
                            }
                            if (i == 1)
                            {
                                modifiedZpl.Add(label14.Text);
                            }
                            if (i == 2)
                            {
                                modifiedZpl.Add(label9.Text);
                            }
                            if (i == 3)
                            {
                                modifiedZpl.Add(label11.Text);
                            }
                            if (i == 4)
                            {
                                modifiedZpl.Add(label12.Text);
                            }
                            if (i == 5)
                            {
                                modifiedZpl.Add(k);
                            }
                        }

                    }

                    File.WriteAllLines("box.zpl", modifiedZpl);


                    // ������� ������ ������ ProcessStartInfo ��� ������� ������� ������
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = "CMD.exe";
                    info.RedirectStandardInput = true;
                    info.UseShellExecute = false;

                    // ��������� ������� ������
                    Process process = new Process();
                    process.StartInfo = info;
                    process.Start();

                    // �������� ���� � ������� ������� "print"
                    process.StandardInput.WriteLine($"print /d:\\\\{Name_sys}\\{Name_print} box.zpl\r\n");
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}