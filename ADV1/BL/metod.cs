using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ADV1.BL
{
    class metod
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;
        //convert byte
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }
        //Convert image
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
