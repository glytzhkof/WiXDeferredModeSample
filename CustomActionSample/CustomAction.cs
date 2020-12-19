using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.Windows.Forms;

namespace CustomAction2
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult TestCustomAction(Session session)
        {
            // System.Diagnostics.Debugger.Launch();
            session.Log("Begin TestCustomAction");

            string data = session["CustomActionData"];

            MessageBox.Show("We are in deferred mode custom action. We received this incoming text:\n\n" + data);

            return ActionResult.Success;
        }
    }
}
