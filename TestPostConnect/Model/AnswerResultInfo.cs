namespace TestPostConnect.Model
{
    public class AnswerResultInfo : AnswerResult
    {
        public string Card_num { get; set; }
        public double Restsum { get; set; }
        public Datetime? Activatedt { get; set; }
        public Datetime? Createdt { get; set; }
        public Datetime? Closedt { get; set; }
        public Datetime? Discarddt { get; set; }
        public string? Status { get; set; }
        public double Nominal { get; set; }
        public int Days_expire { get; set; }
        public Datetime? Expiredt { get; set; }
        public Datetime? Lastdate { get; set; }
        public double Paysum { get; set; }
        public string? Pay_kind { get; set; }
        public int Trans_num { get; set; }
        public string? Slip { get; set; }
        public AnswerResultInfo(Request req)
        {
            Result = false;
            Card_num = "";
            if (req != null && req.Params != null && req.Params.Card_num != null)
            {
                Card_num = req.Params.Card_num;
                var searc_CN = cards_num.Find(x => x == req.Params.Card_num);
                if (searc_CN != null) 
                {
                    Result = true;
                    Restsum = 500.0;
                    Activatedt = new Datetime() { __datetime = "20230303T105110" };
                    Createdt = new Datetime() { __datetime = "20211222T131309" };
                    Closedt = null;
                    Discarddt = null;
                    Status = "Активирован";
                    Nominal = 500.0;
                    Days_expire = 1098;
                    Expiredt = new Datetime() { __datetime = "20260305T105110" }; 
                    Lastdate = new Datetime() { __datetime = "20230303T105110" }; 
                    Paysum = 500.0;
                    Pay_kind = "ОТМЕНА АКТИВАЦИИ";
                    Trans_num = 25591599;
                    Slip = "=============================================\nНОМИНАЛ:                               500.00\n\n                ПЕЧАТЬ ОСТАТКА               \n            ПОДАРОЧНЫЙ СЕРТИФИКАТ            \n=============================================\nОСТАТОК:                               500.00\nАКТИВИРОВАН:                       03.03.2023\nДЕЙСТВУЕТ ДО:                      05.03.2026\nОПЕРАЦИЯ ВЫПОЛНЕНА";
                }   
            }
        }

        private List<string> cards_num = new()
        {
            "01DC0050045E",
            "01DC0100045E",
            "01DC0200045E",
            "01DC1000045E"
        };
    }
}
