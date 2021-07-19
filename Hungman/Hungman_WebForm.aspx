<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hungman_WebForm.aspx.cs" Inherits="Hungman_Game__HW2.Hungman_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">

</script>
    <link rel="Stylesheet" href="Hungman_Style.css" />
</head>&nbsp;<body style="height: 335px"><form id="form1" runat="server">
  <p><b> <asp:Label ID="label6" runat="server" CssClass="word" Text="HUNGMAN GAME"></asp:Label></b></p>
  <p>
       
    <asp:Button CssClass="btn" ID="A" runat="server" onclick="LetterGuessed" Text="A" />
    <asp:Button CssClass="btn" ID="B" runat="server" onclick="LetterGuessed" Text="B" />
    <asp:Button CssClass="btn" ID="C" runat="server" onclick="LetterGuessed" Text="C" />
    <asp:Button CssClass="btn" ID="D" runat="server" onclick="LetterGuessed" Text="D" />
    <asp:Button CssClass="btn" ID="E" runat="server" onclick="LetterGuessed" Text="E" />
    <asp:Button CssClass="btn" ID="F" runat="server" onclick="LetterGuessed" Text="F" />
    <asp:Button CssClass="btn" ID="G" runat="server" onclick="LetterGuessed" Text="G" />
    <asp:Button CssClass="btn" ID="H" runat="server" onclick="LetterGuessed" Text="H" />
    <asp:Button CssClass="btn" ID="I" runat="server" onclick="LetterGuessed" Text="I" />
    <asp:Button CssClass="btn" ID="J" runat="server" onclick="LetterGuessed" Text="J" />
    <asp:Button CssClass="btn" ID="K" runat="server" onclick="LetterGuessed" Text="K" />
    <asp:Button CssClass="btn" ID="L" runat="server" onclick="LetterGuessed" Text="L" />
    <asp:Button CssClass="btn" ID="M" runat="server" onclick="LetterGuessed" Text="M" />
    <asp:Button CssClass="btn" ID="N" runat="server" onclick="LetterGuessed" Text="N" />
    <asp:Button CssClass="btn" ID="O" runat="server" onclick="LetterGuessed" Text="O" />
    <asp:Button CssClass="btn" ID="P" runat="server" onclick="LetterGuessed" Text="P" />
    <asp:Button CssClass="btn" ID="Q" runat="server" onclick="LetterGuessed" Text="Q" />
    <asp:Button CssClass="btn" ID="R" runat="server" onclick="LetterGuessed" Text="R" />
    <asp:Button CssClass="btn" ID="S" runat="server" onclick="LetterGuessed" Text="S" />
    <asp:Button CssClass="btn" ID="T" runat="server" onclick="LetterGuessed" Text="T" />
    <asp:Button CssClass="btn" ID="U" runat="server" onclick="LetterGuessed" Text="U" />
    <asp:Button CssClass="btn" ID="V" runat="server" onclick="LetterGuessed" Text="V" />
    <asp:Button CssClass="btn" ID="W" runat="server" onclick="LetterGuessed" Text="W" />
    <asp:Button CssClass="btn" ID="X" runat="server" onclick="LetterGuessed" Text="X" />
    <asp:Button CssClass="btn" ID="Y" runat="server" onclick="LetterGuessed" Text="Y" />
    <asp:Button CssClass="btn" ID="Z" runat="server" onclick="LetterGuessed" Text="Z" />
  </p>

    <asp:Button CssClass="button" ID="btnPlay" runat="server" Text="PLAY" onclick="btnPlay_Click" Height="30px" Width="60px" />
 
    <div style="float: right;height: 300px; width:auto">
        <p >
            <asp:Image ID="image1" runat="server" ImageUrl="~/images/0.jpg" Style="height: 200px; width:200px"/>
          
        </p>
        </div>

        <br />
        <br />
        <asp:Label ID="lblHint" runat="server" Text="Label5" CssClass="hint" ForeColor="#FF3300" Width="200px"></asp:Label>
        <br />
 

        
    <asp:Label ID="lblWord" runat="server" Text="Label" CssClass="word"></asp:Label>
     
     
    
    <br />

        
    <asp:Label ID="lblMessage" runat="server" CssClass="attempts" Text="Lives left:" BorderStyle="Solid"></asp:Label>
    <asp:Label ID="lblAttemps" runat="server" CssClass="word"></asp:Label>
    <p>
    <asp:Label ID="lblResult" runat="server" CssClass="word"></asp:Label>
    
   <br />
    <div>
        <asp:Label ID="lblNewWord" runat="server" ForeColor="#3333CC">Add New Word</asp:Label>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        <asp:TextBox ID="txtName" runat="server" Width="92px" ></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:Label ID="lblNewHint" runat="server" Text="Add New Hint" ForeColor="#3333CC"></asp:Label>
        <br />
        <asp:TextBox ID="txtHint" runat="server" Width="156px" ></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" Height="30px" Text="Add New Word" Width="116px" OnClick="btnAdd_Click" />

        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRemove" runat="server" Height="26px" OnClick="btnRemove_Click" Text="Remove Word" Width="109px" />

        <br />
        <br />
        <br />

    </div>
   
</form>
    </body>
</html>

