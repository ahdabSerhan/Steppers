using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteppersController
{
    public partial class Main : Form
    {
        Controller controller = new Controller();

        public Main()
        {
       
            InitializeComponent();
            foreach (String port in Arduino.getPorts())
                toolComboPort.Items.Add(port);

            controller.addStepper(1);
            controller.addStepper(2);
            controller.addStepper(3);
            controller.addStepper(4);
            foreach (Stepper s in controller.steppers)
            {
                StepperMotor sp = new StepperMotor(s);
                sp.Dock = DockStyle.Left;
                panelSteppers.Controls.Add(sp);
                sp.Show();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            controller.connect(toolComboPort.SelectedText, 9600);
    
            panelSteppers.Enabled = true;
        }
    }
}
