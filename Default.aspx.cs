using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId");
            dt.Columns.Add("EmpName");
            dt.Columns.Add("EmpSalary");
            dt.Columns.Add("Dept");
            dt.Rows.Add(1, "JACKSON", 75000, "RESEARCH");
            dt.Rows.Add(2, "JOHNSON", 18000, "ACCOUNTING");
            dt.Rows.Add(3, "GRANT", 32000, "SALES");
            dt.Rows.Add(4, "ADAMS", 34000, "OPERATIONS");
            ViewState["dt"] = dt;
            BindGrid();
        } 
    }
    protected void BindGrid()
    {
        GridView1.DataSource = ViewState["dt"] as DataTable;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();
    }
    protected void OnUpdate(object sender, EventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        string empname = ((TextBox)row.Cells[1].Controls[0]).Text;
        int empsal = Convert.ToInt32(((TextBox)row.Cells[2].Controls[0]).Text);
        string dept = ((TextBox)row.Cells[3].Controls[0]).Text;

        DataTable dt = ViewState["dt"] as DataTable;
        dt.Rows[row.RowIndex]["EmpName"] = empname;
        dt.Rows[row.RowIndex]["EmpSalary"] = empsal;
        dt.Rows[row.RowIndex]["Dept"] = dept;
        ViewState["dt"] = dt;
        GridView1.EditIndex = -1;
        BindGrid();
    }
    protected void OnCancel(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid();
    }
    protected void OnDelete(object sender, EventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        DataTable dt = ViewState["dt"] as DataTable;
        dt.Rows.RemoveAt(row.RowIndex);
        ViewState["dt"] = dt;
        BindGrid();
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        DataTable dt = ViewState["dt"] as DataTable;
        dt.Rows.Add(txtEmpId.Text, txtEmpName.Text, txtEmpSalary.Text, txtDept.Text);
        ViewState["dt"] = dt;
        BindGrid();
        txtEmpId.Text = string.Empty;
        txtEmpName.Text = string.Empty;
        txtEmpSalary.Text = string.Empty;
        txtDept.Text = string.Empty;
    } 
}
