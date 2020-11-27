<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Etiquetas.aspx.cs" Inherits="ProyectoAplicacionFotos.WEBForms.Etiquetas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 252px;
        }
        .auto-style9 {
            margin-left: 140px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        .auto-style12 {
            margin-left: 27px;
            margin-top: 2px;
        }
        .auto-style16 {
            width: 485px;
            height: 16px;
        }
        .auto-style18 {
            height: 16px;
        }
        .auto-style22 {
            margin-left: 126px;
        }
        .auto-style23 {
            width: 660px;
            height: 16px;
        }
        .auto-style26 {
            margin-left: 317px;
        }
        .auto-style30 {
            width: 485px;
            height: 101px;
        }
        .auto-style31 {
            width: 660px;
            height: 101px;
        }
        .auto-style32 {
            height: 101px;
        }
        .auto-style33 {
            width: 485px;
            height: 137px;
        }
        .auto-style34 {
            width: 660px;
            height: 137px;
        }
        .auto-style35 {
            height: 137px;
        }
        .auto-style36 {
            width: 485px;
            height: 114px;
        }
        .auto-style37 {
            width: 660px;
            height: 114px;
        }
        .auto-style38 {
            height: 114px;
        }
        .auto-style39 {
            margin-left: 562px;
        }
        .auto-style40 {
            width: 485px;
            height: 39px;
        }
        .auto-style41 {
            width: 660px;
            height: 39px;
        }
        .auto-style42 {
            height: 39px;
        }
        .auto-style43 {
            margin-left: 209px;
        }
        .auto-style46 {
            height: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" BorderColor="#FF0066" BorderStyle="Inset" Height="820px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style40" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID</td>
                    <td class="auto-style41" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF66FF;">
                        <asp:TextBox ID="TextBox6" runat="server" BorderColor="#FF3399" BorderStyle="Double" CssClass="auto-style9" Width="167px"></asp:TextBox>
                    </td>
                    <td class="auto-style42" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;"> </td>
                </tr>
                <tr>
                    <td class="auto-style40" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">Codigo Etiqueta</td>
                    <td class="auto-style41" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF66FF;">
                        <asp:TextBox ID="TXTCodigoEtiqueta" runat="server" BorderColor="#FF3399" BorderStyle="Double" CssClass="auto-style9" Width="167px"></asp:TextBox>
                    </td>
                    <td class="auto-style42" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp; Nombre Etiquetas</td>
                    <td class="auto-style23" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cantidad de Fotos</td>
                    <td class="auto-style18" style="font-family: 'Arial Narrow'; font-size: 16px; font-style: oblique; background-color: #FF99FF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuarios / Sistema<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style36">
                        <asp:TextBox ID="TextBox4" runat="server" BorderColor="#FF3399" BorderStyle="Double" CssClass="auto-style10" Width="207px"></asp:TextBox>
                    </td>
                    <td class="auto-style37">
                        <asp:TextBox ID="TextBox2" runat="server" BorderColor="#FF3399" BorderStyle="Double" CssClass="auto-style9" Width="167px"></asp:TextBox>
                    </td>
                    <td class="auto-style38">
                        <asp:TextBox ID="TextBox5" runat="server" BorderColor="#FF3399" BorderStyle="Double" CssClass="auto-style22" Width="167px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        <asp:Button ID="BTNSugerencias" runat="server" BackColor="#CC99FF" BorderColor="#FF0066" BorderStyle="Dotted" OnClick="BTNSugerencias_Click" Text="Mostrar Sugerencias" Width="136px" />
                        <br />
                    </td>
                    <td class="auto-style34">
                        <asp:Label ID="LabelEtiquetas" runat="server" BackColor="#CC99FF" BorderColor="#FF0066" BorderStyle="Dashed" Text="Arbol, Paisajes , Flores, Casas, Objetos, animales, personas" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style35">
                        <asp:Image ID="Image1" runat="server" CssClass="auto-style12" Height="33px" ImageUrl="~/Imagenes/flecha.gif" Visible="False" Width="79px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Button ID="Button1" runat="server" BorderColor="#FF0066" BorderStyle="Inset" Text="Registrar" Width="119px" />
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="Button3" runat="server" BorderColor="#FF0066" BorderStyle="Double" CssClass="auto-style43" Text="Eliminar" Width="140px" />
                    </td>
                    <td class="auto-style32">
                        <asp:Button ID="Button2" runat="server" BorderColor="#FF0066" BorderStyle="Inset" CssClass="auto-style26" Text="Actualizar" Width="118px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style46" colspan="3">
                        <asp:GridView ID="GridView1" runat="server" BorderColor="#FF0066" BorderStyle="Double" Height="131px" Width="1088px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Image ID="Image2" runat="server" CssClass="auto-style39" Height="147px" ImageUrl="~/Imagenes/etiqueta.png" Width="170px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
