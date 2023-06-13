namespace TestPostConnect.Model
{
    public class AnswerResultCheck : AnswerResult
    {
        public string Reason { get; set; }
        public AnswerResultCheck()
        {
            Result = false;
            Reason = "";
        }
        public AnswerResultCheck(Request req)
        {
            Result = false;
            Reason = "";
            if (req.Params != null && req.Params.Art_barcode != null && req.Params.Barcode != null && req.Params.Wscode != null)
            {
                Result = IsWsCode(req.Params.Wscode)
                    && IsArt_BarCode(req.Params.Art_barcode) 
                    && IsBarCode(req.Params.Barcode);
                Reason = Result ? "Данный ПС принят на Аптеку Асклепий." : "Товарный штрих-код не соответствует номиналу.";
            };
        }
    }
}
