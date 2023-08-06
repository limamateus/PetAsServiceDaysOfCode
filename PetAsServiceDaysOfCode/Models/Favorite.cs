using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public string Image_Id { get; set; }
        public string Sub_Id { get; set; }
        public DateTime Created_At { get; set; }
        public ImageCat Image { get; set; }
    }
}
