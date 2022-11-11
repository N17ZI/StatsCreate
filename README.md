# StatsCreate
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ResultMatch
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    filePath = openFileDialog.FileName;
                    foreach (var line in File.ReadLines(filePath))
                    {
                        var array = line.Split(',');
                        dataGridView1.Rows.Add(array);
                    }
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            updateData();
        }

        private void bSort_Click(object sender, EventArgs e)
        {
            try
            {
                double war = Convert.ToDouble(comboSec.Text);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(comboName.Text) &&
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) <= war)
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;

                            }

                }

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    int index = dataGridView2.Rows.Add(r.Clone() as DataGridViewRow);

                    foreach (DataGridViewCell o in r.Cells)
                    {
                        dataGridView2.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void updateData()
        {
            string[] names = new string[dataGridView1.RowCount];
            comboName.Items.Clear();
            for(int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                names[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
            string[] distinct = names.Distinct().ToArray();
            for(int i = 0; i < distinct.Length-1; i++)
            {
                comboName.Items.Add(distinct[i].ToString());
            }            
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter streamWriter = new StreamWriter(myStream);

                    try
                    {
                        for (int j = 0; j < dataGridView2.Rows.Count; j++)
                        {
                            for (int i = 0; i < dataGridView2.Rows[j].Cells.Count; i++)
                            {
                                streamWriter.Write(dataGridView2.Rows[j].Cells[i].Value + ",");
                            }

                            streamWriter.WriteLine();
                        }

                        streamWriter.Close();
                        myStream.Close();

                        MessageBox.Show("Файл успешно сохранен");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении файла!");
                    }
                    myStream.Close();
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
///
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalcMicro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sum, days,pereplata, EffPercent1;

        private void SumLoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDL.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (SaveDL.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = SaveDL.FileName;
                    File.WriteAllText(filename, $"{SumLoan.Text} {DaysLoan.Text} {TotalSum.Text} {TotalSumPer.Text} {EffPercent.Text}");
                }
                catch
                {
                    MessageBox.Show("Something wrong with your save file");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDL.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (OpenDL.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = OpenDL.FileName;
                    string fileText = File.ReadAllText(filename);
                    var use = fileText.Split(' ');
                    SumLoan.Text = use[0];
                    DaysLoan.Text = use[1];
                    TotalSum.Text = use[2];
                    TotalSumPer.Text = use[3];
                    EffPercent.Text = use[4];
                    bRun_Click(bRun, null);           
                }

                catch
                {
                    MessageBox.Show("Something wrong with your open file");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDL.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (OpenDL.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = OpenDL.FileName;
                    string fileText = File.ReadAllText(filename);
                    var use = fileText.Split(' ');
                    SumLoan.Text = use[0];
                    DaysLoan.Text = use[1];
                }

                catch
                {
                    MessageBox.Show("Something wrong with your open file");
                }
            }
        }

        private void DaysLoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalSum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bRun_Click(object sender, EventArgs e)
        {
            sum = Convert.ToDouble(SumLoan.Text); //Сумма займа
            days = Convert.ToDouble(DaysLoan.Text);// Сумма займа в днях
            EffPercent.Clear();

            if (days<=5)
            {
                pereplata = sum * 0.9 / 100 * days;
                TotalSumPer.Text = pereplata.ToString();
                TotalSum.Text = Convert.ToString(pereplata + sum);
                EffPercent.Text = ($"0.9");
                
            }
            if (days > 5 && days<=10)
            {
                pereplata = sum * 0.7 / 100 * (days - 5) + sum * 0.9 / 100 *5;
                TotalSumPer.Text = pereplata.ToString();
                TotalSum.Text = Convert.ToString(pereplata + sum);
                EffPercent1 = Convert.ToDouble((0.7 * (days - 5) + 0.7 * 5) / days);
                EffPercent.Text = Convert.ToString(EffPercent1);
            }
            if (days > 10)
            {
                pereplata = sum * 0.6 / 100 * (days - 10) + sum * 0.7 / 100 * 5 + sum * 0.9 / 100 * 5;
                TotalSumPer.Text = pereplata.ToString();
                TotalSum.Text = Convert.ToString(pereplata + sum);
                EffPercent1 = Convert.ToDouble((0.6 * (days - 10) + 0.9 * 5 + 0.7 * 5) / days);
                EffPercent.Text = Convert.ToString(EffPercent1);
            }
            if(days >=366 || sum >500000)
            {
                MessageBox.Show("Превышен срок/сумма");
            }
        }
    }
}
