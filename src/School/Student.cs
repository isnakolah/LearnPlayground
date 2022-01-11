namespace School;

public sealed record class Student
{
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Student(string firstName, string lastName, string middleName) : this(firstName, lastName)
    {
        MiddleName = middleName;
    }

    public Guid ID { get; init; } = Guid.NewGuid();
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string? MiddleName { get; init; }
    public ICollection<Subject> Subjects { get; private set; } = default!;

    public void AddClass(Subject subject)
    {
        Subjects.Add(subject);

        if (subject is { Name.Length: > 0 })
            return;

        subject.AddStudent(this);
    }

    public IEnumerable<Student> FindStudentsWithSimilarNamesInClass()
    {
        if (Subjects is null)
            throw new Exception($"There's no class associated with student");

        var nameOccurences = new List<Student>();

        foreach (var subject in Subjects.Where(x => x is not null))
            nameOccurences.AddRange(subject.SearchNameOccurrence(FirstName, LastName, MiddleName));

        return nameOccurences.Distinct();
    }

    public override string ToString()
    {
        return $"Student with id {ID} named {FirstName} {LastName} {MiddleName} with {Subjects?.Count.ToString() ?? "no"} class(s)";
    }
}
