using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.Models
{
    public class ImageCat
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public List<Breed> Breeds { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
