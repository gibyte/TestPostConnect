namespace TestPostConnect.Model
{
    public class AnswerResultDeactive : AnswerResult
    {
        public string Reason { get; set; }
        public AnswerResultDeactive(Request req)
        {
            Result = false;
            Reason = "Текст ошибки";
        }
    }
}
