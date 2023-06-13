namespace TestPostConnect.Model
{
    public class AnswerResultPlayment : AnswerResult
    {
        public string Reason { get; set; }
        public AnswerResultPlayment(Request req) 
        {
            Result = false;
            Reason = "Недостаточно средств для проведения платежа.\nТекущий остаток: 0 руб.";
        }
    }
}
