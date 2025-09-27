using System;
using System.Collections.Generic;
using System.Linq;
using WixToolset.Dtf.WindowsInstaller;
using System.Windows.Forms;

namespace CustomAction1
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult MyCustomAction(Session session)
        {
            // System.Diagnostics.Debugger.Launch();
            session.Log("Begin MyCustomAction");

            string data = session["CustomActionData"];

            MessageBox.Show("We are in deferred mode custom action. We received this incoming text:\n\n" + data);

            return ActionResult.Success;

            //session.Log("Begin CustomAction1");
            //return ActionResult.Success;
        }
    }
}
