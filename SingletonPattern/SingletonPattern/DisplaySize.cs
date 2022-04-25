using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class DisplaySize
    {
        public int Width { get; set; } = 1366;

        public int Height { get; set; } = 768;

        public void Maximazed()
        {
            Width = 1366;
            Height = 768;
        }
    }
}
