namespace ExtentionMethod
{
    public class Order
    {
        public int total { get; set; } = 0;
        public string summery { get; set; }

        public override string ToString()
        {
            return $"{summery} \n -------------------- \n total:           {total.ToString().PadLeft(2)}$";
        }

    }
}
