<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroFotos.aspx.cs" Inherits="ProyectoAplicacionFotos.WEBForms.RegistroFotos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 529px;
        }
        .auto-style5 {
            margin-left: 32px;
        }
        .auto-style6 {
            margin-left: 114px;
        }
        .auto-style7 {
            margin-left: 51px;
        }
        .auto-style8 {
            margin-left: 116px;
        }
        .auto-style9 {
            margin-left: 44px;
        }
        .auto-style11 {
            width: 419px;
            height: 34px;
        }
        .auto-style12 {
            width: 596px;
            height: 34px;
        }
        .auto-style13 {
            margin-left: 21px;
        }
        .auto-style24 {
            height: 34px;
        }
        .auto-style25 {
            width: 419px;
            height: 33px;
        }
        .auto-style26 {
            width: 596px;
            height: 33px;
        }
        .auto-style27 {
            height: 33px;
        }
        .auto-style33 {
            height: 29px;
        }
        .auto-style34 {
            margin-left: 79px;
        }
        .auto-style35 {
            margin-left: 139px;
        }
        .auto-style36 {
            margin-left: 65px;
        }
        .auto-style38 {
            margin-left: 96px;
        }
        .auto-style39 {
            margin-left: 70px;
        }
        .auto-style40 {
            width: 419px;
            height: 84px;
        }
        .auto-style41 {
            width: 596px;
            height: 84px;
        }
        .auto-style42 {
            height: 84px;
        }
        .auto-style43 {
            width: 419px;
            height: 76px;
        }
        .auto-style44 {
            width: 596px;
            height: 76px;
        }
        .auto-style45 {
            height: 76px;
        }
        .auto-style46 {
            width: 419px;
            height: 63px;
        }
        .auto-style47 {
            width: 596px;
            height: 63px;
        }
        .auto-style48 {
            height: 63px;
        }
        .auto-style49 {
            height: 69px;
            width: 220px;
        }
        .auto-style50 {
            height: 54px;
        }
        .auto-style51 {
            height: 69px;
        }
        .auto-style52 {
            margin-left: 550px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: 30px; background-image: url('../Imagenes/password.png'); background-color: #FF00FF">
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" Height="837px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11" colspan="2" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; URL</td>
                    <td class="auto-style12" colspan="2" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre del Archivo</td>
                    <td class="auto-style24" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tipo</td>
                </tr>
                <tr>
                    <td class="auto-style25" colspan="2">
                        <asp:TextBox ID="TextBox2" runat="server" BorderColor="#FF0066" BorderStyle="Double" CssClass="auto-style13" Width="241px"></asp:TextBox>
                    </td>
                    <td class="auto-style26" colspan="2">
                        <asp:TextBox ID="TextBox1" runat="server" BorderColor="#FF0066" BorderStyle="Double" CssClass="auto-style6" Width="174px"></asp:TextBox>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox3" runat="server" BorderColor="#FF0066" BorderStyle="Double" CssClass="auto-style5" Width="187px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style46" colspan="2" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tamaño </td>
                    <td class="auto-style47" colspan="2" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Resolución</td>
                    <td class="auto-style48" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tipo de Foto</td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="2">
                        <asp:TextBox ID="TextBox4" runat="server" BorderColor="#FF0066" BorderStyle="Double" CssClass="auto-style9" Width="156px"></asp:TextBox>
                    </td>
                    <td class="auto-style44" colspan="2">
                        <asp:TextBox ID="TextBox5" runat="server" BorderColor="#FF0066" BorderStyle="Double" CssClass="auto-style8" Width="178px"></asp:TextBox>
                    </td>
                    <td class="auto-style45">
                        <asp:TextBox ID="TextBox6" runat="server" BorderColor="#FF0066" CssClass="auto-style7" Width="151px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style40" colspan="2">
                        <asp:Button ID="Button2" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style36" Text="Agregar" Width="115px" />
                    </td>
                    <td class="auto-style41" colspan="2">
                        <asp:Button ID="Button3" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style35" Text="Actualizar" Width="135px" />
                    </td>
                    <td class="auto-style42">
                        <asp:Button ID="Button4" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style34" Text="Eliminar" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style50" colspan="5">
                        <asp:GridView ID="GridView1" runat="server" Width="977px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style51">
                        <asp:Button ID="Button5" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style39" Text="Mostrar" Width="100px" />
                    </td>
                    <td class="auto-style49" colspan="2"></td>
                    <td class="auto-style51"></td>
                    <td class="auto-style51">
                        <asp:Button ID="Button6" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style38" OnClick="Button6_Click" Text="Siguiente" Width="78px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33" colspan="5">
                        <asp:Image ID="Image1" runat="server" CssClass="auto-style52" Height="179px" ImageUrl="~/Imagenes/photo.png" Width="215px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
