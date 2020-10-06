using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Army_App
{
    public partial class Form2 : Form
    {
        List<Soldier> soldiers;
        List<Department> deps;
        List<Rank> ranks;
        List<Comander> coms;
        List<Weapon> weps;

        public Form2(List<Soldier> s,List<Department> d,List<Rank> r,List<Comander> c,List<Weapon> w)
        {
            InitializeComponent();
            soldiers = s;
            deps = d;
            ranks = r;
            coms = c;
            weps = w;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = soldiers;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "Info";
            textBox1.Text = "Soldiers";
        }

        private void deps_btn_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = deps;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "Info";
            textBox1.Text = "Departments";
        }

        private void ranks_btn_Click(object sender, EventArgs e)
        {

            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = ranks;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "Info";
            textBox1.Text = "Ranks";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = coms;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "Info";
            textBox1.Text = "Comanders";
        }

        private void weapons_btn_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = weps;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "Info";
            textBox1.Text = "Weapons";
        }
    }
}
