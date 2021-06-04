using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWProductViewer
{
    class ProductImage
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int ProductPhotoId { get; set; }
        public byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
    }
}
