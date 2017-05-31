using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ViscardiDigitalBoardGame
{
    public partial class playgame : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SELWYN-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public int xtemp;
        public int ytemp;
        public int prevx;
        public int prevy;
        public int moves;
        public int i;
        public int position;
        public String xcord;
        public String ycord;
        protected void Page_Load(object sender, EventArgs e)
        {
            position = Convert.ToInt16(Session["mypos"]);
            moves = Convert.ToInt16(Session["move"]);
            ycord = Convert.ToString(Session["ycor"]);
            xcord = Convert.ToString(Session["xcor"]);
            ytemp = Convert.ToInt16(Session["thepos"]);
            xtemp = Convert.ToInt16(Session["opos"]);
            prevx = Convert.ToInt16(Session["xprev"]);
            prevy = Convert.ToInt16(Session["yprev"]);
            i = Convert.ToInt16(Session["dbcount"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("gameover.aspx");
           
        }

        protected void Button3_Click(object sender, EventArgs e)//DICE ROLL BUTTON
        {

            //i1.Visible = false;
            //Image1.Visible = false;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            //Button3.Visible = false;

            ClientScript.RegisterStartupScript(GetType(), "blah", "immset();", true);
            Random rnd = new Random();

            int dice = rnd.Next(1, 7);
            if (dice == 1){
                Dice.ImageUrl = ("~/dice1 (1).jpg");
                moves = 1;
                Session["move"] = moves;
            }
            else if(dice == 2){
                Dice.ImageUrl = ("~/dice2 (1).jpg");
                moves = 2;
                Session["move"] = moves;
            }
            else if(dice == 3)
            {
                Dice.ImageUrl = ("~/dice3 (1).jpg");
                moves = 3;
                Session["move"] = moves;
            }
            else if(dice == 4)
            {
                Dice.ImageUrl = ("~/dice4 (1).jpg");
                moves = 4;
                Session["move"] = moves;
            }
            else if(dice == 5)
            {
                Dice.ImageUrl = ("~/dice5 (1).jpg");
                moves = 5;
                Session["move"] = moves;
            }
            else if(dice == 6)
            {
                Dice.ImageUrl = ("~/dice6 (1).jpg");
                moves = 6;
                Session["move"] = moves;
            }
        }

        
        protected void Button4_Click(object sender, EventArgs e)//View Questions Button
        {
            ClientScript.RegisterStartupScript(GetType(), "blah1", "immset();", true);
            //ClientScript.RegisterStartupScript(GetType(), "hwa3", "doTheThing();", true);
            //ClientScript.RegisterStartupScript(GetType(), "hwasel124", "savextemp();", true);
            //ClientScript.RegisterStartupScript(GetType(), "hwasel123", "saveytemp();", true);
            i++;
            Session["dbcount"] = i;
            //Response.Write(i);
            System.Diagnostics.Debug.Write(xtemp);
            SqlCommand scmdquestion = new SqlCommand("select question, anschoiceone, anschoicetwo, anschoicethree, anschoicefour from mathquestions where questionid = '" + i + "'", connection);
            connection.Open();
                SqlDataReader readerJ = scmdquestion.ExecuteReader();
            
                while (readerJ.Read())
                {
                    
                    Label1.Text = (String.Format("{0}", readerJ[0]));
                    String X = (String.Format("{0}", readerJ[0]));
                    ans1.Text = (String.Format("{0}", readerJ[1]));
                    ans2.Text = (String.Format("{0}", readerJ[2]));
                    ans3.Text = (String.Format("{0}", readerJ[3]));
                    ans4.Text = (String.Format("{0}", readerJ[4]));
                
            }
                connection.Close();

        }

        protected void ans3_Click(object sender, EventArgs e)//3rd choice Button
        {
            SqlCommand scmdans = new SqlCommand("select answer from mathquestions where questionid = '"+ i +"'", connection);
            connection.Open();
            SqlDataReader readerJ = scmdans.ExecuteReader();
            while(readerJ.Read())
            {
                if (ans3.Text == (String.Format("{0}", readerJ[0])))
                {
                    position = moves + position;
                    Session["mypos"] = position;

                    //ytemp = 630;
                    //xtemp = 85;
                    Session["thepos"] = ytemp;
                    Session["opos"] = xtemp;
                    Dice.ImageUrl = ("~/DicerollGIF3.gif");
                    if (position >= 19 && i1.CssClass == "eighteen")
                    {
                        position = 19;
                        Label1.Text = "Game Over!";
                        ans1.Visible = false;
                        ans2.Visible = false;
                        ans3.Visible = false;
                        ans4.Visible = false;
                        Button4.Visible = false;
                        Dice.Visible = false;
                        Button3.Visible = false;
                    }
                    else if(position >= 19 && i1.CssClass == "seventeen")
                    {
                        position = 19;
                        Label1.Text = "Game Over!";
                        ans1.Visible = false;
                        ans2.Visible = false;
                        ans3.Visible = false;
                        ans4.Visible = false;
                        Button4.Visible = false;
                        Dice.Visible = false;
                        Button3.Visible = false;
                    }
                    else if(position >= 19 && i1.CssClass == "sixteen")
                    {
                        position = 19;
                        Label1.Text = "Game Over!";
                        ans1.Visible = false;
                        ans2.Visible = false;
                        ans3.Visible = false;
                        ans4.Visible = false;
                        Button4.Visible = false;
                        Dice.Visible = false;
                        Button3.Visible = false;
                    }
                    else if(position >= 19 && i1.CssClass == "fifteen")
                    {
                        position = 19;
                        Label1.Text = "Game Over!";
                        ans1.Visible = false;
                        ans2.Visible = false;
                        ans3.Visible = false;
                        ans4.Visible = false;
                        Button4.Visible = false;
                        Dice.Visible = false;
                        Button3.Visible = false;
                    }
                    else if(position >= 19 && i1.CssClass == "fourteen")
                    {
                        position = 19;
                        Label1.Text = "Game Over!";
                        ans1.Visible = false;
                        ans2.Visible = false;
                        ans3.Visible = false;
                        ans4.Visible = false;
                        Button4.Visible = false;
                        Dice.Visible = false;
                        Button3.Visible = false;
                    }
                    else if(position >= 19 && i1.CssClass == "thirteen")
                    {
                        position = 19;
                        Label1.Text = "Game Over!";
                        ans1.Visible = false;
                        ans2.Visible = false;
                        ans3.Visible = false;
                        ans4.Visible = false;
                        Button4.Visible = false;
                        Dice.Visible = false;
                        Button3.Visible = false;
                    }
                    if (position == 1 && i1.CssClass == "original")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "140";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 490;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "one";
                    }
                    else if (position == 2 && i1.CssClass == "original")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "245";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "two";
                    }
                    else if (position == 3 && i1.CssClass == "original")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "360";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 270;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "three";
                    }
                    else if (position == 4 && i1.CssClass == "original")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "475";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 155;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "four";
                    }
                    else if (position == 5 && i1.CssClass == "original")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "590";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "five";
                    }
                    else if (position == 6 && i1.CssClass == "original")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "590";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 220;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "six";
                    }
                    else if (position == 2 && i1.CssClass == "one")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "105";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "two";
                    }
                    else if (position == 3 && i1.CssClass == "one")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "220";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 270;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "three";
                    }
                    else if (position == 4 && i1.CssClass == "one")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "335";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 155;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "four";
                    }
                    else if (position == 5 && i1.CssClass == "one")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "450";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "five";
                    }
                    else if (position == 6 && i1.CssClass == "one")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "450";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 220;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "six";
                    }
                    else if (position == 7 && i1.CssClass == "one")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "450";
                        xcord = "260";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 370;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seven";
                    }
                    else if (position == 3 && i1.CssClass == "two")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 270;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "three";
                    }
                    else if (position == 4 && i1.CssClass == "two")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "230";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 155;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "four";
                    }
                    else if (position == 5 && i1.CssClass == "two")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "five";
                    }
                    else if (position == 6 && i1.CssClass == "two")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 220;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "six";
                    }
                    else if (position == 7 && i1.CssClass == "two")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 370;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seven";
                    }
                    else if (position == 8 && i1.CssClass == "two")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "435";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 520;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eight";
                    }
                    else if (position == 4 && i1.CssClass == "three")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 155;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "four";
                    }
                    else if (position == 5 && i1.CssClass == "three")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "230";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "five";
                    }
                    else if (position == 6 && i1.CssClass == "three")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "230";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 220;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "six";
                    }
                    else if (position == 7 && i1.CssClass == "three")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "230";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 370;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seven";
                    }
                    else if (position == 8 && i1.CssClass == "three")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "230";
                        xcord = "435";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 520;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eight";
                    }
                    else if (position == 9 && i1.CssClass == "three")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "230";
                        xcord = "595";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 680;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nine";
                    }
                    else if (position == 5 && i1.CssClass == "four")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 85;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "five";
                    }
                    else if (position == 6 && i1.CssClass == "four")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 220;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "six";
                    }
                    else if (position == 7 && i1.CssClass == "four")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 370;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seven";
                    }
                    else if (position == 8 && i1.CssClass == "four")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "435";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 520;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eight";
                    }
                    else if (position == 9 && i1.CssClass == "four")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "595";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 680;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nine";
                    }
                    else if (position == 10 && i1.CssClass == "four")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "740";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 825;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "ten";
                    }
                    else if (position == 6 && i1.CssClass == "five")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 220;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "six";
                    }
                    else if (position == 7 && i1.CssClass == "five")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 370;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seven";
                    }
                    else if (position == 8 && i1.CssClass == "five")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "435";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 520;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eight";
                    }
                    else if (position == 9 && i1.CssClass == "five")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "595";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 680;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nine";
                    }
                    else if (position == 10 && i1.CssClass == "five")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "740";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 825;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "ten";
                    }
                    else if (position == 11 && i1.CssClass == "five")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "900";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 985;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eleven";
                    }
                    else if (position == 7 && i1.CssClass == "six")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "150";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 370;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seven";
                    }
                    else if (position == 8 && i1.CssClass == "six")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "300";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 520;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eight";
                    }
                    else if (position == 9 && i1.CssClass == "six")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "460";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 680;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nine";

                    }
                    else if (position == 10 && i1.CssClass == "six")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "605";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 825;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "ten";

                    }
                    else if (position == 11 && i1.CssClass == "six")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "760";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 980;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eleven";

                    }
                    else if (position == 12 && i1.CssClass == "six")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "920";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1140;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "twelve";
                    }
                    else if (position == 8 && i1.CssClass == "seven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "150";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 520;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eight";
                    }
                    else if (position == 9 && i1.CssClass == "seven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "310";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 680;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nine";
                    }
                    else if (position == 10 && i1.CssClass == "seven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "455";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 825;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "ten";
                    }
                    else if (position == 11 && i1.CssClass == "seven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "615";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 985;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eleven";
                    }
                    else if (position == 12 && i1.CssClass == "seven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "770";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1140;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "twelve";
                    }
                    else if (position == 13 && i1.CssClass == "seven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "920";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1290;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "thirteen";
                    }
                    else if (position == 9 && i1.CssClass == "eight")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "160";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 680;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nine";
                    }
                    else if (position == 10 && i1.CssClass == "eight")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "305";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 825;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "ten";
                    }
                    else if (position == 11 && i1.CssClass == "eight")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "465";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 985;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eleven";
                    }
                    else if (position == 12 && i1.CssClass == "eight")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "620";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1140;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "twelve";
                    }
                    else if (position == 13 && i1.CssClass == "eight")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "770";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1290;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "thirteen";
                    }
                    else if (position == 14 && i1.CssClass == "eight")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "905";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fourteen";
                    }
                    else if (position == 10 && i1.CssClass == "nine")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "145";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 825;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "ten";
                    }
                    else if (position == 11 && i1.CssClass == "nine")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "305";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 985;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eleven";
                    }
                    else if (position == 12 && i1.CssClass == "nine")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "460";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1140;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "twelve";
                    }
                    else if (position == 13 && i1.CssClass == "nine")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "610";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1290;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "thirteen";
                    }
                    else if (position == 14 && i1.CssClass == "nine")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "745";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fourteen";
                    }
                    else if (position == 15 && i1.CssClass == "nine")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "120";
                        xcord = "745";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 160;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fifteen";
                    }
                    else if (position == 11 && i1.CssClass == "ten")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "160";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 985;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eleven";
                    }
                    else if (position == 12 && i1.CssClass == "ten")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "315";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1140;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "twelve";
                    }
                    else if (position == 13 && i1.CssClass == "ten")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "465";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1290;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "thirteen";
                    }
                    else if (position == 14 && i1.CssClass == "ten")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "600";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fourteen";
                    }
                    else if (position == 15 && i1.CssClass == "ten")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "120";
                        xcord = "600";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 160;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fifteen";
                    }
                    else if (position == 16 && i1.CssClass == "ten")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "235";
                        xcord = "600";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 275;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "sixteen";
                    }
                    else if (position == 12 && i1.CssClass == "eleven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "160";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1140;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "twelve";
                    }
                    else if (position == 13 && i1.CssClass == "eleven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "310";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1290;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "thirteen";
                    }
                    else if (position == 14 && i1.CssClass == "eleven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "445";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fourteen";
                    }
                    else if (position == 15 && i1.CssClass == "eleven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "120";
                        xcord = "445";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 160;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fifteen";
                    }
                    else if (position == 16 && i1.CssClass == "eleven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "235";
                        xcord = "445";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 275;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "sixteen";
                    }
                    else if (position == 17 && i1.CssClass == "eleven")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "445";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seventeen";
                    }
                    else if (position == 13 && i1.CssClass == "twelve")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "150";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1290;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "thirteen";
                    }
                    else if (position == 14 && i1.CssClass == "twelve")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fourteen";
                    }
                    else if (position == 15 && i1.CssClass == "twelve")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "120";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 160;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fifteen";
                    }
                    else if (position == 16 && i1.CssClass == "twelve")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "235";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 275;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "sixteen";
                    }
                    else if (position == 17 && i1.CssClass == "twelve")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seventeen";
                    }
                    else if (position == 18 && i1.CssClass == "twelve")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "460";
                        xcord = "285";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 500;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eighteen";
                    }
                    else if (position == 14 && i1.CssClass == "thirteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "0";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 40;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fourteen";
                    }
                    else if (position == 15 && i1.CssClass == "thirteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "120";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 160;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fifteen";
                    }
                    else if (position == 16 && i1.CssClass == "thirteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "235";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 275;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "sixteen";
                    }
                    else if (position == 17 && i1.CssClass == "thirteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seventeen";
                    }
                    else if (position == 18 && i1.CssClass == "thirteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "460";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 500;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eighteen";
                    }
                    else if (position == 19 && i1.CssClass == "thirteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "590";
                        xcord = "135";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 630;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nineteen";
                    }
                    else if (position == 15 && i1.CssClass == "fourteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "120";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 160;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "fifteen";
                    }
                    else if (position == 16 && i1.CssClass == "fourteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "235";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 275;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "sixteen";
                    }
                    else if (position == 17 && i1.CssClass == "fourteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "345";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seventeen";
                    }
                    else if (position == 18 && i1.CssClass == "fourteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "460";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 500;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eighteen";
                    }
                    else if (position == 19 && i1.CssClass == "fourteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "590";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 630;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nineteen";
                    }
                    ///bruhh
                    else if (position == 16 && i1.CssClass == "fifteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 275;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "sixteen";
                    }
                    else if (position == 17 && i1.CssClass == "fifteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "225";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seventeen";
                    }
                    else if (position == 18 && i1.CssClass == "fifteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "340";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 500;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eighteen";
                    }
                    else if (position == 19 && i1.CssClass == "fifteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "470";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 630;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nineteen";
                    }
                    else if (position == 17 && i1.CssClass == "sixteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "110";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 385;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "seventeen";
                    }
                    else if (position == 18 && i1.CssClass == "sixteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "225";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 500;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eighteen";
                    }
                    else if (position == 19 && i1.CssClass == "sixteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "355";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 630;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nineteen";
                    }
                    else if (position == 18 && i1.CssClass == "seventeen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "115";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 500;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "eighteen";
                    }
                    else if (position == 19 && i1.CssClass == "seventeen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "245";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 630;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "nineteen";
                    }
                    else if(position == 19 && i1.CssClass == "eighteen")
                    {
                        prevx = xtemp;
                        prevy = ytemp;
                        ycord = "130";
                        xcord = "0";
                        Session["xcor"] = xcord;
                        Session["ycor"] = ycord;
                        ytemp = 630;
                        xtemp = 1425;
                        Session["thepos"] = ytemp;
                        Session["opos"] = xtemp;
                        ClientScript.RegisterStartupScript(GetType(), "blah", "setstyle();", true);
                        i1.CssClass = "end";
                    }
                   

                    if (position <= 14)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "hwa", "timer();", true);
                    }
                    else if (position >= 15)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "hwa231", "timer12();", true);
                    }
                   
                }
                else
                {
                    prevx = xtemp;
                    prevy = ytemp;
                    ClientScript.RegisterStartupScript(GetType(), "blah", "immset();", true);
                }
            }
            
        }


        protected void Button5_Click(object sender, EventArgs e)
        {
            i1.Visible = false;
            
            Button4.Visible = false;
            ans1.Visible = false;
            ans2.Visible = false;
            ans3.Visible = false;
            ans4.Visible = false;
            Button5.Visible = false;
        }//start game

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Image1.ImageUrl = "~/level1qc2.jpg";
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
            ImageButton6.Visible = false;
            i1.ImageUrl = "~/cowanimation.gif";
            //i1.Visible = true;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            Button5.Visible = true;
            Button3.Visible = true;
            Label1.Visible = true;
            Dice.Visible = true;

        }//cow

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Image1.ImageUrl = "~/level1qc2.jpg";
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
            ImageButton6.Visible = false;
            i1.ImageUrl = "~/cheetahanimation.gif";
            i1.Visible = true;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            Button5.Visible = true;
            Button3.Visible = true;
            Label1.Visible = true;
            Dice.Visible = true;
        }//cheetah

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Image1.ImageUrl = "~/level1qc2.jpg";
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
            ImageButton6.Visible = false;
            i1.ImageUrl = "~/cub.gif";
            i1.Visible = true;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            Button5.Visible = true;
            Button3.Visible = true;
            Label1.Visible = true;
            Dice.Visible = true;
        }//cub

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Image1.ImageUrl = "~/level1qc2.jpg";
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
            ImageButton6.Visible = false;
            i1.ImageUrl = "~/dog.gif";
            i1.Visible = true;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            Button5.Visible = true;
            Button3.Visible = true;
            Label1.Visible = true;
            Dice.Visible = true;
        }//dog

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Image1.ImageUrl = "~/level1qc2.jpg";
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
            ImageButton6.Visible = false;
            i1.ImageUrl = "~/zebra.gif";
            i1.Visible = true;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            Button5.Visible = true;
            Button3.Visible = true;
            Label1.Visible = true;
            Dice.Visible = true;
        }//zebra

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Image1.ImageUrl = "~/level1qc2.jpg";
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
            ImageButton6.Visible = false;
            i1.ImageUrl = "~/cat.gif";
            i1.Visible = true;
            Button4.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
            Button5.Visible = true;
            Button3.Visible = true;
            Label1.Visible = true;
            Dice.Visible = true;
        }//cat
    }
}
