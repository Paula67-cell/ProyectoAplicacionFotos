<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyectoAplicacionFotos.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 383px;
        }
        .auto-style4 {
            margin-top: 0px;
        }
        .auto-style7 {
            margin-left: 19px;
        }
        .auto-style9 {
            margin-left: 69px;
        }
        .auto-style10 {
            margin-left: 54px;
        }
        .auto-style11 {
            width: 339px;
        }
        .auto-style12 {
            width: 401px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4" style="background-image: url('../Imagenes/password.png'); font-size: 30px; background-color: #FF00FF;">
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" Height="675px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11" style="font-family: 'Arial Narrow'; font-size: 16px; background-color: #FF99FF;">Digite un Nombre de Usuario</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TxtUsuario" runat="server" Width="214px" BorderColor="#FF0066" BorderStyle="Double"></asp:TextBox>
                    </td>
                    <td rowspan="4" style="font-size: 30px; font-family: Corbel; font-style: oblique">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registrar<br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image1" runat="server" CssClass="auto-style7" Height="290px" ImageUrl="~/Imagenes/Registro2.jpg" Width="265px" />
                        <br />
                        <br />
                        &nbsp;<asp:Button ID="BTNSiguiente" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style9" OnClick="Button2_Click" Text="Siguiente" Width="148px" />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" style="font-family: 'Arial Narrow'; font-size: 16px; background-color: #FF99FF;">Digite un Correo Electrónico</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TxtCorreo" runat="server" Width="215px" BorderColor="#FF0066" BorderStyle="Double"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" style="font-family: 'Arial Narrow'; font-size: 16px; background-color: #FF99FF;">Digite una Contraseña</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TXTContraseña" runat="server" Width="218px" BorderColor="#FF0066" BorderStyle="Double"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" style="font-family: 'Arial Narrow'; font-size: 16px">
                        <asp:Button ID="BTNRegistrar" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style10" Text="Registrar" Width="115px" />
                    </td>
                    <td class="auto-style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
