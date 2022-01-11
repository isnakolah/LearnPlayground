using static AgeBracket;

namespace AsynchronousProgramming;

internal sealed record class Person
{
    public string FullName { get; private set; } = default!;

    public AgeBracket AgeBracket => GetAgeBracket();

    private DateOnly DateOfBirth { get; set; } = default!;


    public Person(string FirstName, string LastName, params string[] OtherNames)
    {
        var otherNames = OtherNames.Aggregate((a, b) => a.Trim() + " " + b.Trim());

        FullName = $"{FirstName.Trim()} {LastName.Trim()} {otherNames}";
    }

    public override string ToString()
    {
        return FullName;
    }

    public void AddAge(DateOnly dateOfBirth) => DateOfBirth = dateOfBirth;

    private AgeBracket GetAgeBracket()
    {
        return OverEighteen;
    }

}
