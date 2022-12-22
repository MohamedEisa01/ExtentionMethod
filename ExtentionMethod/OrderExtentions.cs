namespace ExtentionMethod
{
    public static class OrderExtentions
    {
        public static Order OrderItem1( this Order value)
        {
            value.summery += "\n Order Item1      10$";
            value.total += 10;
            return value;
        }
        public static Order OrderItem2(this Order value)
        {
            value.summery += "\n Order Item2      5$";
            value.total += 5;
            return value;
        }
        public static Order OrderItem3(this Order value)
        {
            value.summery += "\n Order Item3      20$";
            value.total += 20;
            return value;
        }
        public static Order OrderItem4(this Order value)
        {
            value.summery += "\n Order Item4      12$";
            value.total += 12;
            return value;
        }

    }
}
