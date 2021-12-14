using System;
using System.IO;
using Newtonsoft.Json;

namespace app
{
    class DepthIncreaseCounter
    {
        private int counter;
        private int[] data;

        public DepthIncreaseCounter()
        {
            LoadData();
            CountDepthIncrease(data);
        }

        public void LoadData()
        {
            using (StreamReader r = new StreamReader("input.json"))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<int[]>(json);
            }
        }

        public void CountDepthIncrease(int[] data)
        {
            counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (i > 0)
                {
                    if (data[i] > data[i - 1])
                    {
                        counter++;
                    }
                }
            }
            Console.Write(counter);
        }

    }
}