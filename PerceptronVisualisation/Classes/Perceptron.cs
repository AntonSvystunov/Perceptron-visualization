using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronVisualisation
{
    class Perceptron
    {
        const float LEARNING_RATE = 0.01f;
        const float BIAS_RATE = 3f;

        float[] weights = new float[3];

        public Perceptron()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for(int i = 0; i<weights.Length; i++)
            {
                weights[i] = FloatConverter.DoubleToFloat(rand.NextDouble()*2-1);
            }
        }

        public int Guess(float[] inputs)
        {
            double sum = 0;
            for(int i = 0; i < weights.Length; i++)
            {
                sum += weights[i] * inputs[i];
            }

            return sum < 0 ? -1 : 1;
        }

        public void Train(float[] inputs, int target)
        {
            int guess = Guess(inputs);
            int error = target - guess;

            for(int i = 0; i<weights.Length; i++)
            {
                weights[i] += error * inputs[i] *( i ==2 ? BIAS_RATE : LEARNING_RATE);
            }
        }

        public void ReInit()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = FloatConverter.DoubleToFloat(rand.NextDouble() * 2 - 1);
            }
        }

        public string getWeights()
        {
            var sb = new StringBuilder();
            for(int i = 0; i < weights.Length; i++)
            {
                sb.AppendFormat("w{0}: {1}   ", i, weights[i]);
            }
            return sb.ToString();
        }

        public Func<float, float> GetPrediction()
        {
            for(int i = 0; i<weights.Length; i++)
            {
                if(weights[i] == 0)
                {
                    weights[i] += 0.0001f;
                }
            }
            
            return new Func<float, float>(x => -(weights[2] / weights[1]) - (weights[0] / weights[1]) * x);
        }

        public void GetPredictedValues(out float a, out float b)
        {
            for (int i = 0; i < weights.Length; i++)
            {
                if (weights[i] == 0)
                {
                    weights[i] += 0.0001f;
                }
            }
            a = -(weights[0] / weights[1]);
            b = -(weights[2] / weights[1]);
        }
    }
}
