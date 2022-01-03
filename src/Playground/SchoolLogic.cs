using School;

namespace Playground;

internal sealed class SchoolLogic
{
    public static void Run()
    {
        var daniel = new Student("Daniel", "Nakolah", "Oladidi");
        var david = new Student("David", "Mkuu");
        var faith = new Student("Faith", "Daniels");
        var anna = new Student("Anna", "Nadupa", "Nakolahs");

        var biology = new Subject("Biology");
        var physics = new Subject("Physics");

        biology.AddStudents(daniel, daniel, faith, anna);
        physics.AddStudents(daniel, david, daniel, daniel, anna, faith);

        var danielSimilarNames = daniel.FindStudentsWithSimilarNamesInClass();

        foreach (var student in danielSimilarNames)
            Console.WriteLine(student);
    }
}