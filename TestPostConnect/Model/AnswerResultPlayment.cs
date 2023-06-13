namespace TestPostConnect.Model
{
    public class AnswerResultPlayment : AnswerResult
    {
        public string Reason { get; set; }
        public AnswerResultPlayment(Request req) 
        {
            if (req.Params != null && req.Params.Wscode != null && req.Params.Card_num != null)
            {
                Result = IsWsCode(req.Params.Wscode) && IsCardNum(req.Params.Card_num);
            }
            Reason = Result ? "" : "Недостаточно средств для проведения платежа.\nТекущий остаток: 0 руб.";
        }
    }
}
