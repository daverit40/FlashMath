namespace FlashMath.Classes
{
    public class Answer
    {
        public  Factors factors { get;}
        public int answer { get; }
        public Answer(Factors Factors, int Answer)
        {
            this.factors = Factors;
            this.answer = Answer;
        }
    }
}