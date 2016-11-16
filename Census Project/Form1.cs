using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Census_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myTownDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myTownDBDataSet.PersonAddressView' table. You can move, or remove it, as needed.
            this.personAddressViewTableAdapter.Fill(this.myTownDBDataSet.PersonAddressView);
            // TODO: This line of code loads data into the 'myTownDBDataSet.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.myTownDBDataSet.Address);

        }
    }
}
