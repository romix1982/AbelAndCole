using AbelAndColeCore.Entities;
using AbelAndColeCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static AbelAndColeCore.Utils.EnumsSurveycs;

namespace AbelAndColeSurveyTest
{
    public partial class _Default : Page
    {
        List<Value> lv;
        protected void Page_Load(object sender, EventArgs e)
        {
            TypeDomain.GenerateTypes();
            var lt = TypeDomain.ListTypes;

            ValueDomain.GenerateTypesValues();
            lv = ValueDomain.ListSurveyTypes;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string strName = Request.Form["fname"];
            string strEMail = Request.Form["mail"];

            Person oPerson = new Person(strName, strEMail);

            oPerson.Preferences = PersonDomain.AddPreferences(Request.Form.AllKeys.ToList(), Request.Form["selector"]);

            MsgBox(Message(oPerson), this.Page, this);

        }

        

        private void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            System.Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        private string Message(Person pPerson)
        {
            string message;
            string preferences = PersonDomain.PrintPreferences(pPerson);
            message = "Hi " + pPerson.Name + "! \\n" + preferences;
            return message;
        }

    }
}