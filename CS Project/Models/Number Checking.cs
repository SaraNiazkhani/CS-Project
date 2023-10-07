using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Project.Models
{
    public partial class Number_Checking
    {
        public static void Cellphone_Checking(string text) {
            int cellphoneNumber;
            bool number = int.TryParse(text, out cellphoneNumber);
            if (text.Length < 11 || text.Length > 13 || (!text.StartsWith("09") && !text.StartsWith("989") && !text.StartsWith("+989")))
            {
                MessageBox.Show("please enter your cell number correctly ! ");
                return;
            }
            else if (text.StartsWith("989"))
            {
                text = "0" + text.Substring(2, 10);
            }
            else if (text.StartsWith("+989"))
            {
                text = "0" + text.Substring(3, 10);
            }
        }
    }

    public partial class Number_Checking
    {
        public static void Number_Replace(string text1)
        {
             text1= text1.Replace('۰', '0').Replace('۱', '1').Replace('۲', '2').Replace('۳', '3').Replace('۴', '4').Replace('۵', '5')
                                .Replace('۶', '6').Replace('۷', '7').Replace('۸', '8').Replace('۹', '9');
        }
    }
}

