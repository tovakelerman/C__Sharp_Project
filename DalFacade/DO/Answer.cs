

namespace DO;

/// <summary>
/// מייצג תשובה לשאלה במערכת, כולל מזהה, מזהה השאלה שאליה שייכת ותוכן התשובה.
/// </summary>
public record Answer(
    int Id,                  // מספר מזהה ייחודי
    int QuestionId,          // מזהה שאלה
    string Text              // תוכן התשובה
)
{
    //בנאי ריק
    public Answer() : this(0, 0, "") { }
}