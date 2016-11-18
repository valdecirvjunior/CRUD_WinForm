using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tB_alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crudDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crudDataSet.TB_alunos' table. You can move, or remove it, as needed.
            this.tB_alunosTableAdapter.Fill(this.crudDataSet.TB_alunos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tB_alunosBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_alunosBindingSource.EndEdit();
            this.tableAdapterManager.TB_alunosTableAdapter.Update(this.crudDataSet);
            this.tableAdapterManager.UpdateAll(this.crudDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tB_alunosBindingSource.RemoveCurrent();
        }
    }
}
