<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testWeb.aspx.cs" Inherits="WebTest.testWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function cColor() {
            //color_visualizer

            $('#color_visualizer').css('background-color', 'red');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
<input type="hidden" name="rgb_r" value="">
        <input type="hidden" name="rgb_g" value="">
        <input type="hidden" name="rgb_b" value="">
        <div>
            <table border="1">
                <thead>
                    <th>
                        <td colspan="2">LAB</td>
                        <td colspan="2">RGB</td>
                    </th>
                </thead>
                <tbody>
                    <tr>
                        <td>L</td>
                        <td>
                            <asp:TextBox ID="tbxLabColorL" runat="server" OnTextChanged="tbxLabColorL_TextChanged" Text="0"></asp:TextBox>
                            <br />
                            (0 to 100)
                        </td>
                        <td>R</td>
                        <td><asp:TextBox ID="tbxRGB_R" runat="server" ReadOnly="true"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>a</td>
                        <td>
                            <asp:TextBox ID="tbxLabColorA" runat="server" OnTextChanged="tbxLabColorA_TextChanged" Text="0"></asp:TextBox>
                            <br />
                            (-128 to 128)
                        </td>
                        <td>G</td>
                        <td><asp:TextBox ID="tbxRGB_G" runat="server" ReadOnly="true"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>b</td>
                        <td>
                            <asp:TextBox ID="tbxLabColorB" runat="server" OnTextChanged="tbxLabColorB_TextChanged" Text="0"></asp:TextBox>
                            <br />
                            (-128 to 128)
                        </td>
                        <td>B</td>
                        <td><asp:TextBox ID="tbxRGB_B" runat="server" ReadOnly="true"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2"></td>
                        <td colspan="2">
                            <asp:Button ID="btnCalColor" runat="server" Text="변환" OnClick="btnCalColor_Click" Height="30" Width="100" />
                            
                            
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" id="tdColor" runat="server" Height="50"></td>
                    </tr>
                </tbody>
            </table>
            <div id="color_visualizer" style="display: inline-block; text-align:center; width: 95%; margin: 0 auto; border: 1px solid silver; height: 75px; vertical-align: top;"></div>
        </div>
</form>
</body>
</html>
