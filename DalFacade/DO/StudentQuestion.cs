namespace DO;

/// <summary>
/// מייצג את הקשר בין תלמיד, בחינה, שאלה והתשובה שהנבחן בחר בפועל.
/// </summary>
public record StudentQuestion(
    int StudentId,           // מזהה תלמיד
    int ExamId,              // מזהה בחינה
    int QuestionId,          // מזהה שאלה
    int? SelectedAnswerId     // מזהה תשובה שנבחרה
)
{
    //בנאי ריק
    public StudentQuestion() : this(0, 0, 0, 0) { }
}
