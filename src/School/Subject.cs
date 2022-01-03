namespace School;

public sealed record class Subject
{
    public Subject(string name)
    {
        Name = name;
    }

    public Guid ID { get; init; } = Guid.NewGuid();
    public string Name { get; init; }
    public ICollection<Student> Students { get; init; } = new List<Student>();

    /// <summary>
    /// Searches any occurence of first anme
    /// </summary>
    /// <param name="firstName"></param>
    /// <returns>IEnumerable of Stude</returns>
    public IEnumerable<Student> SearchNameOccurrence(string name)
    {
        var foundStudents = Students
            .Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name) || (x?.MiddleName?.Contains(name) ?? false));

        return foundStudents;
    }

    /// <summary>
    /// Searches for name occurence in the provided names
    /// </summary>
    /// <param name="names">Names that can be nullable</param>
    /// <returns>iEnumerable of Students</returns>
    public IEnumerable<Student> SearchNameOccurrence(params string?[] names)
    {
        var foundStudents = new List<Student>();

        foreach (var name in names.Where(name => name is not null))
            foundStudents.AddRange(SearchNameOccurrence(name!));

        return foundStudents.Distinct();
    }

    public void AddStudent(Student student)
    {
        if (student.Subjects.Where(x => x.Students.Contains(student)).Any())
            return;

        student.AddClass(this);
        Students.Add(student);
    }

    public void AddStudents(params Student[] students)
    {
        foreach (var student in students.Where(x => x is not null))
            AddStudent(student);
    }
}

internal sealed class StudentNotFoundException : Exception
{
    public StudentNotFoundException(string name) : base($"Student with name {name} was not found")
    {
    }
}