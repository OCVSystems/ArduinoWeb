using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArduinoWeb
{
    public partial class Default : System.Web.UI.Page
    {
        Arduino arduino = new Arduino();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOFF_Click(object sender, EventArgs e)
        {
            arduino.Send(ValueToSend.sendOFF);
        }

        protected void btnGreen_Click(object sender, EventArgs e)
        {
            arduino.Send(ValueToSend.sendGreen);
        }

        protected void btnRed_Click(object sender, EventArgs e)
        {
            arduino.Send(ValueToSend.sendRed);
        }

        protected void btnBoth_Click(object sender, EventArgs e)
        {
            arduino.Send(ValueToSend.sendBoth);
        }
    }
}