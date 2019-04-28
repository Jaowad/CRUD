<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div align="center">    
    <table>    
        <tr>    
            <td>EmpId</td>    
            <td>    
                <asp:TextBox ID="txtEmpId" runat="server" />    
            </td>    
        </tr>    
        <tr>    
            <td>EmpName</td>    
            <td>    
                <asp:TextBox ID="txtEmpName" runat="server" />    
            </td>    
        </tr>    
        <tr>    
            <td>EmpSalary</td>    
            <td>    
                <asp:TextBox ID="txtEmpSalary" runat="server" />    
            </td>    
        </tr>    
        <tr>    
            <td>Department</td>    
            <td>    
                <asp:TextBox ID="txtDept" runat="server" />    
            </td>    
        </tr>    
    </table>    
    <br />    
    <asp:Button ID="btnInsert" runat="server" Text="Insert" Height="30" Width="70" OnClick="btnInsert_Click" OnClientClick="return validate();" />    
    <br /><br />    
    <asp:GridView ID="GridView1" HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White" runat="server" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing">    
        <Columns>    
            <asp:BoundField DataField="EmpId" HeaderText="EmpId" ReadOnly="true" />    
            <asp:BoundField DataField="EmpName" HeaderText="EmpName" />    
            <asp:BoundField DataField="EmpSalary" HeaderText="EmpSalary" />    
            <asp:BoundField DataField="Dept" HeaderText="Department" />    
            <asp:TemplateField>    
                <ItemTemplate>    
                    <asp:LinkButton ID="LinkButton1" Text="Edit" runat="server" CommandName="Edit" />    
                    <asp:LinkButton ID="LinkButton2" Text="Delete" runat="server" OnClick="OnDelete" />    
                </ItemTemplate>    
                <EditItemTemplate>    
                    <asp:LinkButton ID="LinkButton3" Text="Update" runat="server" OnClick="OnUpdate" />    
                    <asp:LinkButton ID="LinkButton4" Text="Cancel" runat="server" OnClick="OnCancel" />    
                </EditItemTemplate>    
            </asp:TemplateField>    
        </Columns>    
    </asp:GridView>    
</div>
    </div>
    </form>
</body>
</html>
