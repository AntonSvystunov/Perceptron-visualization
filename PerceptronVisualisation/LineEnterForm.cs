using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerceptronVisualisation
{
    public partial class LineEnterForm : Form
    {
        public float a = 1;
        public float b = 0;

        public LineEnterForm()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string eq = eqTextBox.Text;
                string str_b = eq.Substring(eq.IndexOf('x') + 1);
                string str_a = eq.Substring(0, eq.IndexOf('x') - 1);
                double _a = 0;
                double _b = 0;

                if (Double.TryParse(str_a, out _a) && Double.TryParse(str_b, out _b))
                {
                    a = FloatConverter.DoubleToFloat(_a);
                    b = FloatConverter.DoubleToFloat(_b);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect equation of line! Try again!", "Error");
                    eqTextBox.Text = "";
                }
            } catch
            {
                MessageBox.Show("Incorrect equation of line! Try again!", "Error");
                eqTextBox.Text = "";
            } 
        }
    }
}
