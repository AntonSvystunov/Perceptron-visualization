using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronVisualisation
{
    class Point
    {
        public float x { get; }
        public float y { get; }
        public float bias { get; }

        public int label { get; }

        public Point(Func<float, float> f)
        {
            bias = 1;
            Random rand = new Random(unchecked((int)DateTime.Now.Ticks));
            x = rand.Next(-3000, 3000)/10;
            y = rand.Next(-3000, 3000)/10;

            label = y > f(x) ? 1 : -1;
        }
    }
}
