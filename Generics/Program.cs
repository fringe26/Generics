using System.Collections.Generic;

namespace Generics;

partial class Program
{
    private static List<IComponent> _components = new List<IComponent>();

    public static void Main()
    {
        #region Generics Intro
        //Person<int> person = new Person<int>()
        //{
        //    Id = 1,
        //    Name = "Tural"
        //};
        //Person<string> person1 = new Person<string>()
        //{
        //    Id = "5WGL99Q",
        //    Name = "Orxan"
        //};
        //Person<Guid> person2 = new Person<Guid>()
        //{
        //    Id = Guid.NewGuid(),
        //    Name = "Faiq"
        //};
        //Person<Guid> person3 = new Person<Guid>()
        //{
        //    Id = Guid.NewGuid(),
        //    Name = "Faiq"
        //};
        //Person<Guid> person4 = new Person<Guid>()
        //{
        //    Id = Guid.NewGuid(),
        //    Name = "Faiq"
        //};

        //Console.WriteLine(person);
        //Console.WriteLine(person1);
        //Console.WriteLine(person2);
        //Console.WriteLine(person3);
        //Console.WriteLine(person4);

        #endregion

        #region Constraint Class

        //Device<Fax> code = new Device<Fax>();
        //Device<Printer> code2 = new Device<Printer>();
        //Device<TV> code3 = new Device<TV>();

        #endregion

        #region Generic Methods
        //Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        //_components.Add(new Rigidbody());
        //_components.Add(new Animator());
        //_components.Add(new BoxCollider());
        //_components.Add(new Transform());


        //Rigidbody rb = GetComponent<Rigidbody>();
        //Animator animator = GetComponent<Animator>();
        //Console.WriteLine(rb);
        //Console.WriteLine(animator);

        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //if(agent != null)
        //{
        //    agent.Move();
        //}
        //agent?.Move();

        //if (TryGetComponent<Rigidbody>(out Rigidbody component))
        //{
        //    component.Move();
        //}
        //else
        //{
        //    Console.WriteLine("Component not found");
        //}
        #endregion

        #region REF OUT IN

        //Person<int> person = new Person<int>()
        //{
        //    Id = 1,
        //    Name= "Orxan"
        //};
        //int[] arr = new int[15];
        //Array.Resize(ref arr, arr.Length+1);

        //ChangeVariable(out person);
        //Console.WriteLine(person);
        //int number = 5;
        //ChangeVariable(ref number);
        //Console.WriteLine(number);


        //int.TryParse("5", out int number);
        //Console.WriteLine(number);
        #endregion
    }


    public static void ChangeVariable(ref int number)
    {
        number = 45;
    }

    public static void ChangeVariable(out Person<int> person) // person = person.Link().Copy()
    {
        person = new Person<int>
        {
            Id = 15,
            Name = "tural"
        };
    }

    public static bool TryGetComponent<T>(out T component) where T : IComponent
    {
        foreach (var item in _components)
        {
            if (item.GetType() == typeof(T))
            {
                component = (T)item;
                return true;
            }
        }
        component = default;
        return false;

    }

    public static T GetComponent<T>() where T : IComponent
    {
        //Console.WriteLine(5 is 6);
        foreach (var component in _components)
        {
            if (component is T)  //
            {
                return (T)component;
            }
        }

        return default;
    }

}

class Rigidbody : IComponent
{
    public void Move()
    {
        Console.WriteLine("Move with Velocity...");
    }
}
class BoxCollider : IComponent { }

class Transform : IComponent { }

class Animator : IComponent { }
class NavMeshAgent : IComponent
{
    public void Move()
    {
        Console.WriteLine("Navmeshagent Move...");
    }
}




