
namespace DO;

/// <summary>
/// מייצג שאלה במערכת, כולל מזהה, נושא השאלה, תוכן ומזהה התשובה הנכונה.
/// </summary>
public record Question(
    int Id,                  // מספר מזהה ייחודי
    SubjectType Subject,     // נושא השאלה (Enum)
    string Text,             // תוכן השאלה
    int CorrectAnswerId      // מזהה תשובה נכונה
)
{
    //בנאי ריק
    public Question() : this(0, default, "", 0) { }
}