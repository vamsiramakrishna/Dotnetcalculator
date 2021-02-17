<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CalculatorApp</title>
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <div class="form-group">
            <h2 class ="headings">Calculator</h2>
        </div>
        <div class="alignment">
        <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Number 1:"></asp:Label>
        <asp:TextBox ID="txtNum1" runat="server" Height="30px"></asp:TextBox> <br/>
        <asp:RequiredFieldValidator ID="Num1" runat="server" ControlToValidate="txtNum1" ErrorMessage="Please enter a value" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="Number 2:"></asp:Label>
        <asp:TextBox ID="txtNum2" runat="server" Height="30px"></asp:TextBox> <br/>
        <asp:RequiredFieldValidator ID="Num2" runat="server" ControlToValidate="txtNum2" ErrorMessage="Please enter a value" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
        <asp:Label ID="Label3" runat="server" Text="Result:"></asp:Label>
        <asp:TextBox ID="txtResult" runat="server" Height="30px" ReadOnly="True"></asp:TextBox>
        </div>
       
        <div class="form-group">
        <asp:Button ID="btnSum" CssClass="btn btn-primary" runat="server" Height="30px" OnClick="btnSum_Click" Text="+" Width="50px" />
        <asp:Button ID="btnMinus"  CssClass="btn btn-primary" runat="server" Height="30px" OnClick="btnMinus_Click" Text="-" Width="50px" />
        <asp:Button ID="btnMultiply" CssClass="btn btn-primary" runat="server" Height="30px" OnClick="btnMultiply_Click" Text="*" Width="50px" />
        <asp:Button ID="btnDivide" CssClass="btn btn-primary" runat="server" Height="30px" OnClick="btnDivide_Click" Text="/" Width="50px" />
        <asp:Button ID="Clear" CssClass="btn btn-danger" runat="server" Height="30px" OnClick="Clear_Click" Text="Clear" Width="70px" />
        </div>
        </div>
        </div>
       
    </form>
</body>
</html>
