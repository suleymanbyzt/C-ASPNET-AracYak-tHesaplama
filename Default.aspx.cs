using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            RadioButton1.GroupName = "araç";
            RadioButton2.GroupName = "araç";
            RadioButton3.GroupName = "vites";
            RadioButton4.GroupName = "vites";
            RadioButton1.Checked = true;
            RadioButton3.Checked = true;
            TextBox1.Focus();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double km=Convert.ToDouble(TextBox1.Text);
        double litre=0,tutar=0;
        if (RadioButton1.Checked && RadioButton3.Checked)
        {
            litre=km*7/100;
            tutar=litre*7;
        }
            else if (RadioButton1.Checked && RadioButton4.Checked)
            {
                litre=km*7/100*1.05;
                tutar=litre*7;
            }
                else if (RadioButton2.Checked && RadioButton3.Checked)
                 {
                    litre=km*5/100;
                    tutar=litre*6;
                 }
                     else if (RadioButton2.Checked && RadioButton4.Checked)
                         {
                            litre = km * 7 / 100 * 1.05;
                            tutar = litre * 6;
                         }
        Label1.Text = "Gereken yakıt tutarı" + litre.ToString()+"Litre";
        Label1.Text = "<br>Faturatutar" + tutar+"TL";
    }
}