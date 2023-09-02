using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Switch_case_uygulamasi
{
    public partial class Switch1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_hesapla_Click(object sender, EventArgs e)
        {
            byte not_degeri = Convert.ToByte(not_txt.Text);
            switch(not_degeri)
            {
                case 5:
                    Response.Write("pekiyi");
                    break;
                case 3:
                    Response.Write("orta");
                    break;
                case 4:
                    Response.Write("iyi");
                    break;
                case 2:
                    Response.Write("geçer");
                    break;
          
                default:
                    if (not_degeri == 0 || not_degeri == 1)
                        Response.Write("kaldın eylülde gel..");
                    else
                    Response.Write("Not Değeri 0 ile 5 arasında olmalı");
                    break;
            }//switch
        }

      
    }
}