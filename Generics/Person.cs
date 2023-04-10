namespace Generics;

public class Person<TId>
{
    public TId Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        Console.WriteLine(new String('-',100));
        return $"User Id: {Id} - {Id.GetType()}\n" +
            $"Name: {Name}";
    }

    public TId GetInfo(Person<TId> person)
    {
        return person.Id;
    }
}

