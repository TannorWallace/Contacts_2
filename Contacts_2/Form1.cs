using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Connection Secure:\n How Can This One Serve?");
            //testing connection to GITHUB
        }

        private void legionContactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.legionContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDBDataSet.LegionContacts' table. You can move, or remove it, as needed.
            this.legionContactsTableAdapter.Fill(this.contactsDBDataSet.LegionContacts);

        }
    }
}
