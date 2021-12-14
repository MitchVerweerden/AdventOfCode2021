namespace app
{
    public class DepthIncreaseCounter
    {
        private int counter;
        private int[] data;

        public void LoadData()
        {
            using (StreamReader r = new StreamReader("input.json"))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<int[]>(json);
            }
        }
    }
}