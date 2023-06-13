namespace TestPostConnect.Model
{
    public class Answer
    {
        public string? Version { get; set; }
        public AnswerResult? Result { get; set; }
        public Answer(Request req)
        {
            Version = "1.1";
            if (req == null) return;
            if (req.Method == "approve_card") Result = new AnswerResultCheck(req);
            if (req.Method == "get_info") Result = new AnswerResultInfo(req);
            if (req.Method == "activate") Result = new AnswerResultActivate(req);
            if (req.Method == "deactivate") Result = new AnswerResultDeactive(req);
            if (req.Method == "payment") Result = new AnswerResultPlayment(req);
        }

    }
}
