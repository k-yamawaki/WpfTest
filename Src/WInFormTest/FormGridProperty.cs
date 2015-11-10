using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class FormGridProperty : Form
    {
        private PropertyGridSample _sample = new PropertyGridSample();

        public FormGridProperty()
        {
            InitializeComponent();
        }

        private void FormGridProperty_Load(object sender, EventArgs e)
        {
            this.xPropertyGrid.SelectedObject = _sample;
        }
    }
}
