namespace Training
{
    public  class Testarrays
    {
        public static string basics(int a)
        {
            /*string[] fraudulantOrderIds = new string[3];
            fraudulantOrderIds[0] = "A123";
            fraudulantOrderIds[1] = "B456";
            fraudulantOrderIds[2] = "C789";
            //fraudulantOrderIds[3] = "E1011";
            fraudulantOrderIds[1] = "D1213";*/

            string[] fraudulantOrderIds = {"A123", "B456", "C789", "D1011", "E1213", "F1415" };

            return fraudulantOrderIds[a];
        }

        public void boolean()
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            //Random coin = new Random();
            //Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
            
        }
    }
}
