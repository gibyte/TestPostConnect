namespace TestPostConnect.Model
{
    public class AnswerResultActivate : AnswerResult
    {
        public string Reason { get; set; }
        public AnswerResultActivate(Request req) 
        {
            Result = false;
            if (req != null && req.Params != null && req.Params.Card_num != null 
                && req.Params.Wscode != null && req.Params.Artcode != null)
            {
                Result = IsWsCode(req.Params.Wscode) && IsCardNum(req.Params.Card_num) && IsArtCode(req.Params.Artcode);
            }
            Reason = Result ? "" : "Сертификат не был принят или не прошел проверку.\nПродажа запрещена.";
        }

    }
}
