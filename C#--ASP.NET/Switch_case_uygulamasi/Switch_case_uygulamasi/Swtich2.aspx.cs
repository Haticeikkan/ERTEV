using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Switch_case_uygulamasi
{
    public partial class Swtich2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sehir_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce_listesi.Items.Clear();
           byte secim=Convert.ToByte(Sehir_listesi.SelectedItem.Value);
            switch(secim)
            {
                case 16:
                    ilce_listesi.Items.Add("Kestel");
                    ilce_listesi.Items.Add("Yıldırım");
                    ilce_listesi.Items.Add("gürsu");
                    break;
                case 6:
                    ilce_listesi.Items.Add("çankaya");
                    ilce_listesi.Items.Add("ulus");
                    ilce_listesi.Items.Add("cebeci");
                    break;
                case 35:
                    ilce_listesi.Items.Add("bornova");
                    ilce_listesi.Items.Add("çeşme");
                    ilce_listesi.Items.Add("narlıdere");
                    break;
            }
        }
    }
}