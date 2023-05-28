using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2
{
    public partial class Form1 : Form
    {
        private List<string> array = File.ReadAllLines("text.txt").ToList();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonText_Click(object sender, EventArgs e)
        {

            listBoxArray.DataSource = array;
        }

        private void buttonZad1_Click(object sender, EventArgs e)
        {
            if (listBoxArray.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала считайте информацию из файла", "Ошибка");
            }
            else
            {
                labelCountDigit.Visible = true;
                listBoxZad1_2.Visible = true;
                var digits = array.SelectMany(s => s.Where(char.IsDigit)).ToList();
                listBoxZad1_2.DataSource = digits;
                labelCountDigit.Text = "Количество цифр в файле: " + digits.Count.ToString();
            }
        }

        private void buttonZad2_Click(object sender, EventArgs e)
        {
            if (listBoxArray.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала считайте информацию из файла", "Ошибка");
            }
            else
            {
                labelCountDigit.Visible = false;
                listBoxZad1_2.Visible = true;

                //var elements = new List<string>();
                //foreach (var item in array)
                //{
                //    if (item.Contains("/"))
                //    {
                //        var index = item.IndexOf("/");
                //        elements.Add(item.Substring(0, index));
                //        break;
                //    }
                //    elements.Add(item);
                //}
                //listBoxZad1_2.DataSource = elements;

                var elements = array.TakeWhile(s => !s.Contains("/")).ToList();
              
                listBoxZad1_2.DataSource = elements;
            }
        }

        private void buttonZad3_Click(object sender, EventArgs e)
        {
            
            var afterLastSlash = array.SkipWhile(str => !str.Contains("/")).Skip(2);
            var replacedElements = afterLastSlash.Select(str => str.ToUpper()).ToList();
            File.WriteAllLines("output.txt", replacedElements);

        }
    }
}
