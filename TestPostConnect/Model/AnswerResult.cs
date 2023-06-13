namespace TestPostConnect.Model
{
    public class AnswerResult
    {
        public bool Result { get; set; }
        public AnswerResult() 
        {
            Result = false;
        }

        protected bool IsArtCode(String artcode) 
        {
            var searc = artcodes.Find(x => x == artcode);
            return searc != null;
        }

        protected List<string> artcodes = new()
        {
            "77700500",
            "77701000",
            "77702000",
            "77710000",
        };

        protected bool IsCardNum(String cardNum)
        {
            var searc = cards_num.Find(x => x == cardNum);
            return searc != null;
        }

        protected List<string> cards_num = new()
        {
            "01DC0050045E",
            "01DC0100045E",
            "01DC0200045E",
            "01DC1000045E"
        };
        protected bool IsArt_BarCode(String art_barcode)
        {
            var searc = art_barcodes.Find(x => x == art_barcode);
            return searc != null;
        }

        protected List<string> art_barcodes = new()
        {
            "2000018472224",
            "2000018472231",
            "2000018472248",
            "2000018472255",
        };
        protected bool IsBarCode(string barcode)
        {
            var searc = barcodes.Find(x => x == barcode);
            return searc != null;
        }

        protected List<string> barcodes = new()
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

        protected bool IsWsCode(string wscode)
        {
            var searc = wscodes.Find(x => x == wscode);
            return searc != null;
        }

        protected List<string> wscodes = new()
        {
            "900001",
            "900003",
        };


    }
}