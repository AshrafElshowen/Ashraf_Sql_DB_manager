using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashraf_DB_manager
{
    public partial class ViewTableData : Form
    {
        public DataTable Table = new DataTable();
        public ViewTableData()
        {
            InitializeComponent();            
        }

        private void ViewTableData_Load(object sender, EventArgs e)
        {
            textBoxTable.Text = Table.TableName;
            dataGridView1.DataSource = Table;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }
    }
}
