using BenchmarkDotNet.Attributes;

namespace TestBenchmarkDotNet
{
    [MemoryDiagnoser(false)]
    public class BenchClass
    {
        readonly int[] _array = { 425, 458, 795, 798, 125, 645 };

        [Benchmark]
        public int Test_WithParams_Inline()
        {
            return Sum_WithParams(425, 458, 795, 798, 125, 645);
        }

        [Benchmark]
        public int Test_WithParams_Array()
        {
            return Sum_WithParams(_array);
        }

        [Benchmark]
        public int Test_WithoutParams_Array()
        {
            return Sum_WithoutParams(_array);
        }

        private int Sum_WithParams(params int[] numbers)
        {
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private int Sum_WithoutParams(int[] numbers)
        {
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
