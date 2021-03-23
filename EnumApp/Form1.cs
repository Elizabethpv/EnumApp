using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumApp
{
    public partial class enumSwitch : Form
    {
        public enumSwitch()
        {
            InitializeComponent();
        }
        public SwitchResult Tossing(Switch switchs)
        {
            int temp;
            Random random= new Random();
            temp = random.Next(0, 2);

            if (temp == (int)switchs)
            {
                return SwitchResult.Light;
            }
            else
            {
                return SwitchResult.Dark;
            }
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            SwitchResult result;

            if (cmbSwitchBox.Text == "ON")
            {
                result = Tossing(Switch.ON);
                this.Text = result.ToString();
               
               
            }
            else if (cmbSwitchBox.Text == "OFF")
            {
                result = Tossing(Switch.OFF);
                this.Text = result.ToString();
               
            }
            else
            {
                MessageBox.Show("Please On Switch");
            }

            if(this.Text=="Light")
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Black;

            }
        }
    }
}
