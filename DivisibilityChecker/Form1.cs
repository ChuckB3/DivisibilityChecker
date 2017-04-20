using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DivisibilityChecker
{
    public partial class DivisibilityChecker : Form
    {
        public List<String> results = new List<String>();        
        public int divBy;

        public DivisibilityChecker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            results.Clear();
            divBy = Int32.Parse(divByBox.Text);

            for(int i = 1; i <= 100; i++)
            {
                if (i%divBy==0)
                {
                    results.Add(i.ToString());
                }
            }
            var message = string.Join(Environment.NewLine, results.ToArray());
            MessageBox.Show(message, "Results");

        }
    }
}
