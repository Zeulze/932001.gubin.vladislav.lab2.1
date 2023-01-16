namespace Lab21.Models {
    public class CalcModel 
    {
        public readonly int X;
        public readonly int Y;
        public readonly string Sum;
        public readonly string Min;
        public readonly string Mult;
        public readonly string Div;
        public CalcModel(int x, int y, string sum, string min, string mult, string div) {
            X = x;
            Y = y;
            Sum = sum;
            Min = min;
            Mult = mult;
            Div = div;
        }
    }
}
