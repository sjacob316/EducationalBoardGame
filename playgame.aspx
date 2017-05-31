<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="playgame.aspx.cs" Inherits="ViscardiDigitalBoardGame.playgame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Board Game</title>
    <link rel ="stylesheet" type="text/css" href="StyleSheet.css" />
    <!--<script src="JavaScript.js"></script>-->
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
    </head>
    <body>
    <form id="form1" runat="server">
        
            
    <!--<img src="cheetahtrnsparnet.png" id='i1' style="position:absolute; left: 95px; top: 600px; height: 107px; width: 75px;">-->
        <asp:Button ID="Button1" runat="server" Text="End Game" OnClick="Button1_Click" style="z-index:1; position:absolute; top: 205px; left: 1050px;" Visible="False"/>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Start Game" style="z-index:1; position:absolute; top: 200px; left: 385px;" Visible="False" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Roll Dice" OnClick="Button3_Click" style="z-index:1; position:absolute; top: 203px; left: 734px;" Visible="False"/>
                    <asp:Image ID="i1" runat="server" ImageUrl="~/cowanimation.gif" style="z-index: 1; position: absolute; top: 630px; left: 85px; height: 110px; width: 94px;" CssClass="original" Visible="False" />
                    <asp:ImageButton ID="ImageButton1" runat="server" style="z-index: 1; position: absolute; top: 221px; left: 8px; height: 354px; width: 285px;" CssClass="original" ImageUrl="~/cownew.png" OnClick="ImageButton1_Click"/>
        <asp:ImageButton ID="ImageButton2" runat="server" style="z-index: 1; position: absolute; top: 210px; left: 259px; height: 362px; width: 255px;" CssClass="original" ImageUrl="~/cheetahnew.png" OnClick="ImageButton2_Click"/>
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/cubbynew.png" style="z-index: 1; position: absolute; top: 217px; left: 477px; height: 362px; width: 282px;" CssClass="original" OnClick="ImageButton3_Click"/>
        <asp:ImageButton ID="ImageButton4" runat="server" style="z-index: 1; position: absolute; top: 212px; left: 751px; height: 362px; width: 321px;" CssClass="original" ImageUrl="~/dognew.png" OnClick="ImageButton4_Click" />
        <asp:ImageButton ID="ImageButton5" runat="server" style="z-index: 1; position: absolute; top: 213px; left: 1028px; height: 362px; width: 282px;" CssClass="original" ImageUrl="~/zebranew.png" OnClick="ImageButton5_Click" />
        <asp:ImageButton ID="ImageButton6" runat="server" style="z-index: 1; position: absolute; top: 219px; left: 1284px; height: 362px; width: 282px;" CssClass="original" ImageUrl="~/catnew.png" OnClick="ImageButton6_Click" />
                    <asp:Image ID="Image1" runat="server" Height="732px" ImageUrl="~/characterselectionbackground.jpg" Width="1585px" />



        <asp:Image ID="Dice" runat="server" ImageUrl="~/DicerollGIF3.gif" Height="202px" Width="200px" style="z-index:1; position:absolute; top: 252px; left: 675px;" Visible="False"/>
   
        
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View Question" style="z-index:1; position:absolute; top: 424px; left: 417px;" Visible="False"/>

        <asp:Label ID="Label1" runat="server" Font-Size="100px" style="z-index:1; position:absolute; top: 557px; left: 533px;" Visible="False">Welcome!</asp:Label>

      


        <asp:Button ID="ans1" runat="server" Text="A" OnClick="ans1_Click" style="z-index:1; position:absolute; top: 697px; left: 628px;" Visible="False" />
        <asp:Button ID="ans2" runat="server" Text="B" OnClick="ans2_Click" style="z-index:1; position:absolute; top: 697px; left: 710px;" Visible="False"/>
        <asp:Button ID="ans3" runat="server" Text="C" OnClick="ans3_Click" style="z-index:1; position:absolute; top: 696px; left: 800px;" Visible="False"/>
        <asp:Button ID="ans4" runat="server" Text="D" OnClick="ans4_Click1" style="z-index:1; position:absolute; top: 695px; left: 894px;" Visible="False"/>
        <script>
    function timer() {
        document.getElementById('i1').style.left = "<%=prevx%>px";
        document.getElementById('i1').style.top = "<%=prevy%>px";
        $('#i1').animate({ top: "-=<%=ycord%>" }, 2000);
        $("#i1").animate({left: "+=<%=xcord%>"}, 2000);
    }
    function timer12(){
        document.getElementById('i1').style.left = "<%=prevx%>px";
        document.getElementById('i1').style.top = "<%=prevy%>px"
        $('#i1').animate({left: "+=<%=xcord%>" }, 2000);
        $("#i1").animate({top: "+=<%=ycord%>"}, 2000);
    }
    function setstyle(){
        setTimeout(function(){
            document.getElementById('i1').style.left = "<%=xtemp%>px";
            document.getElementById('i1').style.top = "<%=ytemp%>px";
        },5000);
    }
    function immset(){
        document.getElementById('i1').style.left = "<%=xtemp%>px";
        document.getElementById('i1').style.top = "<%=ytemp%>px";
    }
</script>
    </form>

<!--
        <script>
        function reset1(){
clearTimeout(my_time);
document.getElementById('i1').style.left= "500px";
document.getElementById('i1').style.top= "100px";
document.getElementById("msg").innerHTML="";

}



function move_img(str) {

var x=document.getElementById('i1').offsetTop;
x= x +100;
document.getElementById('i1').style.top= x + "px";

}
function disp(){
    var step=1; // Change this step value
    document.getElementById('i1').style.left= 95;
        document.getElementById('i1').style.top= 410;
var y=document.getElementById('i1').offsetTop;
var x=document.getElementById('i1').offsetLeft;

if(y > <%=ytemp%> ){y= y -step;
document.getElementById('i1').style.top= y + "px"; // vertical movment
}else{
if(x < <%=xtemp%>){x= x +step;
document.getElementById('i1').style.left= x + "px"; // horizontal movment
}
            
}
//////////////////////
           
}
            $(document).ready(function(){
            $.post()})
function timer(){
    disp();
    //doTheThing();
var y=document.getElementById('i1').offsetTop;
var x=document.getElementById('i1').offsetLeft;
document.getElementById("msg").innerHTML="X: " + x + " Y : " + y
my_time=setTimeout('timer()',10);
}
function doTheThing(){
    setTimeout(function(){
        document.getElementById('i1').style.left= <%=xtemp%>;
        document.getElementById('i1').style.top= <%=ytemp%>;
    },5000);
}

        </script>
    -->
    </body>
</html>
