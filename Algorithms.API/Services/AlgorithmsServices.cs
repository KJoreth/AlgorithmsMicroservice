namespace Algorithms.API.Services
{
    public class AlgorithmsServices : IAlgorithmsServices
    {
        public DataSetResponse BubbleSort(DataSet data)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            bool swapped = false;
            var values = data.Values;
            int n = values.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
            stopwatch.Stop();
            var result = new DataSetResponse()
            {
                SortedValues = values,
                TimeOfCalculation = (float)stopwatch.Elapsed.TotalMilliseconds
            };
            return result;
        }
    }
}
