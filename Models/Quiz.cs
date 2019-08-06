namespace QuizApplication.Models {
    public class Quiz {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public string[] Options = new string[4];
        public string correctOption { get; set; }
    }
}