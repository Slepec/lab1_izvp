using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_izvp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Note[] notes = new Note[8];
        int size = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (size <= 8)
                {
                    if (tbName.Text == "" || tbPhone.Text == "") {
                        MessageBox.Show("Введіть дані");
                        return;
                    }

                    notes[size].Birthday = new int[3];
                    notes[size].Name = tbName.Text;
                    notes[size].PhoneNumber = tbPhone.Text;
                    notes[size].Birthday[0] = dateTimePicker1.Value.Day;
                    notes[size].Birthday[1] = dateTimePicker1.Value.Month;
                    notes[size].Birthday[2] = dateTimePicker1.Value.Year;

                    dataGridView1.Rows.Add(notes[size].Name, notes[size].PhoneNumber, notes[size].Birthday[0]+"."+ notes[size].Birthday[1]+"."+ notes[size].Birthday[2]);
                    size++;
                }
                else MessageBox.Show("Масив заповнений");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (size > 0)
            {
                bool exist = false;
                for (int i = 0; i < size; i++)
                {
                   
                    if (notes[i].Name.Contains(tbSearch.Text.Trim()))
                    {
                        string b = notes[i].Birthday[0] + "."+ notes[i].Birthday[1] + "."+notes[i].Birthday[2];
                       
                        exist = true;
                        MessageBox.Show("Ім'я: " + notes[i].Name + "\nТелефон: " + notes[i].PhoneNumber + "\nДата народження: " + b);
                        
                    }
                }
                if (!exist) MessageBox.Show("Запис не знайдений");
            }
        }
    }
}
