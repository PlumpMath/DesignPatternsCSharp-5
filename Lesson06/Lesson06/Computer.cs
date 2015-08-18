using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    public class Computer : ICloneable
    {
        public int AmountOfCores { get; set; }
        public decimal CpuFrequency { get; set; }
        public int AmountOfRam { get; set; }
        public string DriveType { get; set; }
        public GraphicsCard Gpu { get; set; }

        public object Clone()
        {
            var clone = (Computer) MemberwiseClone();

            clone.Gpu = (GraphicsCard)Gpu.Clone();

            //clone.Gpu = new GraphicsCard
            //{
            //    AmountOfRam = Gpu.AmountOfRam,
            //    GpuFrequency = Gpu.GpuFrequency
            //};

            return clone;
        }
    }
}
