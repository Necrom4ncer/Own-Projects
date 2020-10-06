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
    public partial class Form1 : Form
    {
        public static UsArmyDB db = new UsArmyDB();
        Form2 Form;
        AddForm form2;
        public Form1()
        {
            InitializeComponent();
            db.OpenConnection();
        }

        private void showSoldiers_Click(object sender, EventArgs e)
        {
            Form = new Form2(db.SelectAllSoldiers(),db.SelectAllDepartments(),db.SelectAllRanks(),db.SelectAllComanders(),db.SelectAllWeapons());
            Form.Show();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            form2 = new AddForm();
            form2.Show();
        }
    }
}
