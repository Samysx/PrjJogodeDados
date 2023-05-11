using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjJogosdeDados
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSortear_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int valor = rdn.Next(1, 7);
            int valor2 = rdn.Next(1, 7);

            int empate = int.Parse(lblempate.Text);

            if (valor == 1)
            {
                Image1.ImageUrl = "~/CSS/Image/image1.jpg";

            }
            if (valor == 2)
            {
                Image1.ImageUrl = "~/CSS/Image/image2.jpg";

            }
            if (valor == 3)
            {
                Image1.ImageUrl = "~/CSS/Image/image3.jpg";

            }
            if (valor == 4)
            {
                Image1.ImageUrl = "~/CSS/Image/image4.jpg";

            }
            if (valor == 5)
            {
                Image1.ImageUrl = "~/CSS/Image/image5.jpg";

            }
            if (valor == 6)
            {
                Image1.ImageUrl = "~/CSS/Image/image6.jpg";

            }
    //--------------------------------------------------------------------------------------------------------------------------------
            if (valor2 == 1)
            {
                Image2.ImageUrl = "~/CSS/Image/image1.jpg";

            }
            if (valor2 == 2)
            {
                Image2.ImageUrl = "~/CSS/Image/image2.jpg";

            }
            if (valor2 == 3)
            {
                Image2.ImageUrl = "~/CSS/Image/image3.jpg";

            }
            if (valor2 == 4)
            {
                Image2.ImageUrl = "~/CSS/Image/image4.jpg";

            }
            if (valor2 == 5)
            {
                Image2.ImageUrl = "~/CSS/Image/image5.jpg";

            }
            if (valor2 == 6)
            {
                Image2.ImageUrl = "~/CSS/Image/image6.jpg";

            }

            if (valor == valor2)
            {
                empate = empate + 1;
                lblempate.Text = empate.ToString();
            }
        }
    }
}