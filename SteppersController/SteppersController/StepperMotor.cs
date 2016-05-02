using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteppersController
{
    public partial class StepperMotor : UserControl
    {
        Stepper stepper;
        public StepperMotor(Stepper stepper)
        {
            InitializeComponent();

            this.stepper = stepper;
            lblId.Text = "Pin:" +stepper.id.ToString();
            lblTag.Text = stepper.tag;
            txtPosition.Text = stepper.position.ToString();
        }
        public StepperMotor()
        {
            InitializeComponent();

        }
    }
}
