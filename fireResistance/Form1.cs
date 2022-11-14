using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fireResistance
{
    public partial class LableFireResistanceForm : Form
    {
        public LableFireResistanceForm()
        {
            InitializeComponent();
        }

        private void comboBoxFireResistanceLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFireResistanceLimit.Text);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHeightElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LableMetr_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxConcreteClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxStrength_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonСalculation_Click(object sender, EventArgs e)
        {
            Controller run = new Controller();
            run.RunFireResistanceColumn(comboBoxFireResistanceLimit.Text, Convert.ToDouble(textBoxLenthElement.Text), Convert.ToInt32(textBoxHeightElement.Text), Convert.ToInt32(textBoxWidthElement.Text),
                Convert.ToDouble(textBoxLenthFromArmatureToEdge.Text), comboBoxFixationElement.Text, comboBoxArmatureClass.Text, comboBoxConcreteType.Text,
                comboBoxConcreteClass.Text, Convert.ToInt32(comboBoxArmatureDiameter.Text), Convert.ToInt32(comboBoxArmatureAmount.Text), Convert.ToDouble(textBoxMoment.Text), Convert.ToDouble(textBoxStrength.Text));
        }

        private void comboBoxFixationElement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLenthElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWidthElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLenthFromArmatureToEdge_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxArmatureClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxConcreteType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxArmatureDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxArmatureAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMoment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
