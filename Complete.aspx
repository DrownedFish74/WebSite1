<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Complete.aspx.cs" Inherits="Complete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		画面遷移しました。<br/>
		<br/>
		VALUE1:<asp:Label id="lRedirect1" runat="server"></asp:Label><br/>
		VALUE2:<asp:Label id="lRedirect2" runat="server"></asp:Label><br/>
		<br/>
		<br/>
		<a href="./Default.aspx">もどる</a>
    </div>
    </form>
</body>
</html>
