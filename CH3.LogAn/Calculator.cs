namespace CH3.LogAn
{
    public class Calculator
    {
        private int _sum;

        public void Add(int number)
        {
            _sum += number;
        }

        public int Sum()
        {
            int temp = _sum;
            _sum = 0;
            return temp;
        }
    }
}
