namespace DO;

/// <summary>
/// מייצג תלמיד (נבחן) במערכת, כולל תעודת זהות, שמו, מזהה הבחינה שלו והציון שקיבל.
/// </summary>
public record Student(
    int Id,                  // תעודת זהות (מספר מזהה)
    string? Name,             // שם התלמיד
    int ExamId,              // מזהה בחינה
    int Grade                // ציון
)
{
    //בנאי ריק 
public Student() : this(0, "", 0, 0) { }
}