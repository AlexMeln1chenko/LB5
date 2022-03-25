using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (Control k in groupBox1.Controls)
                    groupBox1.Controls.Remove(k);
            }
            Random r1 = new Random();
            for (int j = 0; j <= 2; j++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    int x = r1.Next(20, 50);
                    int k = r1.Next(1, 6);
                    switch (k)
                    {
                        case 1:
                            Button a = new Button();
                            a.Parent = groupBox1;
                            a.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            a.Size = new Size(x, 20); break;
                        case 2:
                            ListBox b = new ListBox();
                            b.Parent = groupBox1;
                            b.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            b.Size = new Size(x, 20);
                            b.BackColor = Color.BlueViolet; break;
                        case 3:
                            TextBox c = new TextBox();
                            c.Parent = groupBox1;
                            c.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            c.Size = new Size(x, 20); break;
                        case 4:
                            GroupBox d = new GroupBox();
                            d.Parent = groupBox1;
                            d.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            d.Size = new Size(x, 20);
                            d.BackColor = Color.RoyalBlue; break;
                        case 5:
                            DataGridView f = new DataGridView();
                            f.Parent = groupBox1;
                            f.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            f.Size = new Size(x, 20); break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0, f = 0;
            foreach (Control k in groupBox1.Controls)
            {
                if (k is Button)
                    a++;
                if (k is ListBox)
                    b++;
                if (k is TextBox)
                    c++;
                if (k is GroupBox)
                    d++;
                if (k is DataGridView)
                    f++;
            }
            textBox1.Text = " Button: " + a.ToString() + Environment.NewLine + " ListBox: " + b.ToString() + Environment.NewLine + " TextBox: " + c.ToString()
                + Environment.NewLine + " GroupBox: " + d.ToString() + Environment.NewLine + " DataGridView: " + f.ToString();
        }
    }
}
