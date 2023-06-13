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
            bool res = false;
            if (req.Params != null && req.Params.Art_barcode != null)
            {
                var sear_artbc = art_barcode.Find(x => x == req.Params.Art_barcode);
                res = sear_artbc != null;
                if (res)
                {
                    var sear_bc = barcode.Find(x => x == req.Params.Barcode);
                    Result = sear_bc != null;
                }
            };
        }

        private List<string> art_barcode = new()
        {
            "2000018472224",
            "2000018472231",
            "2000018472248",
            "2000018472255",
        };

        private List<string> barcode = new()
        {
            "CT01DC0050045E81",
            "CT01DC0050045E82",
            "CT01DC0100045E83",
            "CT01DC0100045E84",
            "CT01DC0200045E85",
            "CT01DC0200045E86",
            "CT01DC1000045E87",
            "CT01DC1000045E88",
        };


    }
}
