

namespace DO;

/// <summary>
/// מייצג מבחן במערכת, כולל מזהה, נושא, תאריך וכמות שאלות.
/// </summary>
public record Exam( 
    int Id,                  // מספר מזהה ייחודי
    SubjectType Subject,     // נושא המבחן (Enum)
    DateTime ExamDate,       // תאריך בחינה
    int QuestionsCount       // מספר השאלות

)
{
    //בנאי ריק
    public Exam() : this(0, default, default, 0) { }
}


