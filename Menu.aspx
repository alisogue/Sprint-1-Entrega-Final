<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WAnalisis.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title> 
    <style type="text/css">
        .auto-style1 {
            height: 558px;
            width: 745px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style1">
                <asp:Image ID="Image1" runat="server" Height="178px" ImageUrl="http://agriperfiles.agri-d.net/file/n26023/logo_ulacit.jpg" Width="373px" />
                <br />
                <asp:Button ID="PlanBtn" runat="server" BorderColor="Black" BorderStyle="Groove" BorderWidth="10px" Font-Bold="True" ForeColor="#CC3399" Text="Plan De Estudios" ViewStateMode="Disabled" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="infoBtn" runat="server" BorderColor="Black" BorderStyle="Groove" BorderWidth="10px" Font-Bold="True" ForeColor="#FF33CC" Text="Informacion del Estudiante" />
                <br />
                <br />
                <br />
                <asp:Button ID="MatricularBtn" runat="server" BorderColor="Black" BorderStyle="Groove" BorderWidth="10px" Font-Bold="True" ForeColor="#FF33CC" Text="Matricular" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="listaCbtn" runat="server" BorderColor="Black" BorderStyle="Groove" BorderWidth="10px" Font-Bold="True" ForeColor="#CC0099" Text="Lista de Cursos" />
                <br />
                <br />
                <br />
                <asp:Button ID="cursonbtn" runat="server" BorderColor="Black" BorderStyle="Groove" BorderWidth="10px" Font-Bold="True" ForeColor="#FF33CC" Text="Mis Cursos" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salir" />
            </div>
        </div>
    </form>
</body>
</html>

