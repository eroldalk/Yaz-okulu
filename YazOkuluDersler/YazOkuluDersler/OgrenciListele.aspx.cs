using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

public partial class OgrenciListele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> OgrenciListe = BLLOgrenci.BllListele();
        repeater1.DataSource = OgrenciListe;
        repeater1.DataBind();
    }
}