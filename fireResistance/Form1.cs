using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            buttonСalculation.Enabled = false;
            Controller run = new Controller();
            run.RunFireResistanceColumn(comboBoxFireResistanceLimit.Text, Convert.ToDouble(textBoxLenthElement.Text), Convert.ToInt32(textBoxHeightElement.Text), Convert.ToInt32(textBoxWidthElement.Text),
                Convert.ToDouble(textBoxLenthFromArmatureToEdge.Text), comboBoxFixationElement.Text, comboBoxArmatureClass.Text, comboBoxConcreteType.Text,
                comboBoxConcreteClass.Text, Convert.ToInt32(comboBoxArmatureDiameter.Text), Convert.ToInt32(comboBoxArmatureAmount.Text), Convert.ToDouble(textBoxMoment.Text), Convert.ToDouble(textBoxStrength.Text));
            buttonСalculation.Enabled = true;
        }

        //private void textBoxLenthElement_TextChanged(object sender, EventArgs e)
        //{
        //    char number = e.KeyChar;
        //    MessageBox.Show(text.);
        //}

        private void textBoxWidthElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLenthFromArmatureToEdge_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxMoment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLenthElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (number == 8)
            {
                e.Handled = false;
            }

        }

        private void textBoxHeightElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (number == 8)
            {
                e.Handled = false;
            }
        }

        private void textBoxWidthElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (number == 8)
            {
                e.Handled = false;
            }
        }

        private void textBoxLenthFromArmatureToEdge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (number == 8)
            {
                e.Handled = false;
            }
        }

        private void comboBoxConcreteType_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxConcreteType.DroppedDown = true;
            e.Handled = true;

        }

        private void comboBoxFixationElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxFixationElement.DroppedDown = true;
            e.Handled = true;
        }

        private void comboBoxArmatureClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxArmatureClass.DroppedDown = true;
            e.Handled = true;
        }

        private void comboBoxConcreteClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxConcreteClass.DroppedDown = true;
            e.Handled = true;
        }

        private void comboBoxArmatureDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxArmatureDiameter.DroppedDown = true;
            e.Handled = true;
        }

        private void comboBoxArmatureAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxArmatureAmount.DroppedDown = true;
            e.Handled = true;
        }

        private void textBoxMoment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (number == 8)
            {
                e.Handled = false;
            }
            if (number == ',')
            {
                e.Handled = false;
            }
            if (number == '.')
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }

        private void textBoxStrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (number == 8)
            {
                e.Handled = false;
            }
            if (number == ',')
            {
                e.Handled = false;
            }
            if (number == '.')
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }

        private void comboBoxFireResistanceLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxFireResistanceLimit.DroppedDown = true;
            e.Handled = true;
        }

        private void comboBoxFireResistanceLimit_Click(object sender, EventArgs e)
        {
            comboBoxFireResistanceLimit.DroppedDown = true;
        }

        private void comboBoxFixationElement_Click(object sender, EventArgs e)
        {
            comboBoxFixationElement.DroppedDown = true;
        }

        private void comboBoxArmatureClass_Click(object sender, EventArgs e)
        {
            comboBoxArmatureClass.DroppedDown = true;
        }

        private void comboBoxConcreteType_Click(object sender, EventArgs e)
        {
            comboBoxConcreteType.DroppedDown = true;
        }

        private void comboBoxConcreteClass_Click(object sender, EventArgs e)
        {
            comboBoxConcreteClass.DroppedDown = true;
        }

        private void comboBoxArmatureDiameter_Click(object sender, EventArgs e)
        {
            comboBoxArmatureDiameter.DroppedDown = true;
        }

        private void comboBoxArmatureAmount_Click(object sender, EventArgs e)
        {
            comboBoxArmatureAmount.DroppedDown = true;
        }
    }
}
