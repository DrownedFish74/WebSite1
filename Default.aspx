<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
	    <hr/>
	    ■１．データベースから値を取得＆表示<br/>
		ID:<asp:TextBox id="tbDispId" runat="server" Width="76px"></asp:TextBox>
   		<asp:Button id="btnDisp" Text="取得＆表示" runat="server" OnClick="btnDisp_Click" />
		<asp:Literal id="lDispText" runat="server"></asp:Literal>
		<br/>
		<br/>
		
		<br/>
	    <hr/>
	    ■２．データベースへ値を更新<br/>
		ID:<asp:TextBox id="tbUpdateId" runat="server" Width="77px"></asp:TextBox>
		VALUE:<asp:TextBox id="tbUpdateText" runat="server"></asp:TextBox>
   		<asp:Button id="btnUpdate" Text="更新" runat="server" OnClick="btnUpdate_Click" />
		<br/>
		<asp:Literal id="lUpdateResult" runat="server"></asp:Literal>
		<br/>
		<br/>

		<br/>
	    <hr/>
	    ■３．値を取得して画面遷移位<br/>
		VALUE1:<asp:TextBox id="tbRedirect1" runat="server"></asp:TextBox><br/>
		VALUE2:<asp:TextBox id="tbRedirect2" runat="server"></asp:TextBox><br/>
		<asp:Button ID="btnRedirect" Text="画面遷移" runat="server" OnClick="btnRedirect_Click"/>
    </div>
    </form>
</body>
</html>
