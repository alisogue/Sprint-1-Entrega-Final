<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WAnalisis.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 569px;
            width: 447px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="text-align: match-parent" class="auto-style1">
                <asp:Image ID="Image1" runat="server" Height="221px" Width="430px" ImageUrl="http://agriperfiles.agri-d.net/file/n26023/logo_ulacit.jpg" BorderColor="#6600CC" BorderStyle="Groove" />
                <br />
                <br />
               
               
             ULACIT <br />
        <br />
        Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_Usuario" runat="server"></asp:TextBox>
        <br />
        <br />
                Contraseña&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_Contrasena" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DrpDw_listUsarios" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True" Value="Otr_Usua">Otro Usuario</asp:ListItem>
                    <asp:ListItem Value="Admin">Administrador</asp:ListItem>
                </asp:DropDownList>
                <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_mensaje" runat="server" Visible="False"></asp:Label>
&nbsp;<br />
        <br />
        <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_ingresar" runat="server" OnClick="btn_ingresar_Click" Text="Ingresar" BackColor="Silver" Font-Bold="True" ForeColor="#CC33FF" style="height: 29px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_salir" runat="server" OnClick="btn_salir_Click" Text="Salir" BackColor="Silver" Font-Bold="True" ForeColor="#CC33FF" Height="30px" Width="79px" />
            </div>
        </div>
    </form>
</body>
</html>
