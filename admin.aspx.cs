using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ViscardiDigitalBoardGame
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SELWYN-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)//Insert Button
        {
            conn.Open();
            cmd = new SqlCommand("Insert into mathquestions (question, answer, answerchoice, choiceone, anschoiceone, choicetwo, anschoicetwo, choicethree, anschoicethree, choicefour, anschoicefour) values ('" + txtQuestion.Text + "','" + txtAnswer.Text + "','" + DropDownList.Text + "', '" + DropDownList1.Text + "', '" + TextBox5.Text + "', '" + DropDownList2.Text + "', '" + TextBox7.Text + "', '" + DropDownList3.Text + "','" + TextBox9.Text + "', '" + DropDownList4.Text + "', '" + TextBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)//Go Back Button
        {
            Response.Redirect("gamestart.aspx");
        }
    }
}