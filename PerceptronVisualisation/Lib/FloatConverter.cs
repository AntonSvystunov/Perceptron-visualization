using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronVisualisation
{
    class FloatConverter
    {
        public static float DoubleToFloat(double dValue)
        {
            if (float.IsPositiveInfinity(Convert.ToSingle(dValue)))
            {
                return float.MaxValue;
            }
            if (float.IsNegativeInfinity(Convert.ToSingle(dValue)))
            {
                return float.MinValue;
            }
            return Convert.ToSingle(dValue);
        }
    }
}
