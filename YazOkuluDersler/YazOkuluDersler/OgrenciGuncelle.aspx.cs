using BusinessLayer;
using EntityLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int x =Convert.ToInt32(Request.QueryString["OGRID"].ToString());

        txtId.Text = x.ToString();
        txtId.Enabled = false;
        EntityOgrenci ent =new EntityOgrenci();
        List<EntityOgrenci> Ogrlist = BLLOgrenci.Ogrencidetay(x);
        txtAd.Text = Ogrlist[0].AD.ToString();
        txtSoyad.Text = Ogrlist[0].SOYAD.ToString();
        txtNumara.Text = Ogrlist[0].NUMARA.ToString();
        txtSifre.Text = Ogrlist[0].SIFRE.ToString();
        txtFoto.Text = Ogrlist[0].FOTOGRAF.ToString();










        //int x = int.Parse(Request.QueryString["OGRID"]);

        //var ogrenci = BLLOgrenci.OgrenciBul(x);
        //txtId.Enabled = false;
        //if (Page.IsPostBack==false)
        //{
        //    txtId.Text = x.ToString();
        //    txtAd.Text = ogrenci[0].AD;
        //    txtSoyad.Text = ogrenci[0].SOYAD;
        //    txtNumara.Text = ogrenci[0].NUMARA.ToString();
        //    txtSifre.Text = ogrenci[0].SIFRE;
        //    txtFoto.Text = ogrenci[0].FOTOGRAF;

        //}



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //int id = int.Parse(Request.QueryString["Id"]);
        //var ogrenci = BLLOgrenci.OgrenciBul(id);
        //ogrenci[0].AD = txtAd.Text;
        //ogrenci[0].SOYAD = txtSoyad.Text;
        //ogrenci[0].NUMARA = txtNumara.Text;
        //ogrenci[0].SIFRE = txtSifre.Text;
        //ogrenci[0].FOTOGRAF = txtFoto.Text;
        //BLLOgrenci.Ogrencidetay(ogrenci[0]);
        //Response.Redirect("OgrenciListele.aspx");

    }
}