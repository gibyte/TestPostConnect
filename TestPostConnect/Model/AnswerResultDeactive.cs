namespace TestPostConnect.Model
{
    public class AnswerResultDeactive : AnswerResult
    {
        public string Reason { get; set; }
        public AnswerResultDeactive(Request req)
        {
            Result = false;
            if (req != null && req.Params != null && req.Params.Card_num != null
                && req.Params.Wscode != null && req.Params.Artcode != null)
            {
                Result = IsWsCode(req.Params.Wscode) && IsCardNum(req.Params.Card_num) && IsArtCode(req.Params.Artcode);
            }
            Reason = Result ? "" : "Текст ошибки";
        }
    }
}
