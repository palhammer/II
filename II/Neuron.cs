using System;
using System.Collections.Generic;
using System.Text;

namespace II
{
    class Neuron
    {
        public List<double> Weight { get; set; }
        public NeuronType NeuronType { get; set; }
        public double Output { get; private set; }
        public Neuron(int inputCount, NeuronType type=NeuronType.Normal)
        {
            NeuronType = type;
            Weight = new List<double>();

            for (int i=0; i<inputCount;i++)
            {
                Weight.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weight[i];
            }

            Output = Sigmoid(sum);
            return Output;

            
        }
        private double Sigmoid(double x)
            {
            var result = 1.0 / (1.0 + Math.Pow(Math.E,-x));
            return result;
            }

        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
