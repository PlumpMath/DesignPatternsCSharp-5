using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson13.Gui
{
    public partial class Form1 : Form
    {
        private Television _television;
        public Form1()
        {
            InitializeComponent();

            _television = new Television("127.0.0.1", 8080);
        }

        private void ExecuteCommand(AquosCommand command)
        {
            command.Television = _television;

            command.Execute();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(textBox1.Text);

            ExecuteCommand(AquosCommand.Volume(value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteCommand(AquosCommand.Power(PowerSetting.On));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteCommand(AquosCommand.Power(PowerSetting.Off));

        }
    }
}
