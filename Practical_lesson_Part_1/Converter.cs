using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_lesson_Part_1
{
    public partial class ConverterFrom : Form
    {
        public ConverterFrom()
        {
            InitializeComponent();
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim().ToUpper();
            string result = "";
            string fromSystem = comboFrom.SelectedItem.ToString();
            string toSystem = comboTo.SelectedItem.ToString();

            if (fromSystem == null || toSystem == null)
            {
                MessageBox.Show("Оберіть системи числення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int fromBase = int.Parse(fromSystem);
                int toBase = int.Parse(toSystem);

                int decimalValue = Convert.ToInt32(input, fromBase);

                if (toBase == 2)
                    result = Convert.ToString(decimalValue, 2);
                else if (toBase == 8)
                    result = Convert.ToString(decimalValue, 8);
                else if (toBase == 16)
                    result = Convert.ToString(decimalValue, 16).ToUpper();
                else
                    result = "Невідома система";
            }
            catch
            {
                MessageBox.Show("Некоректне число для обраної системи!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtResult.Text = result;
        }
    }
}
