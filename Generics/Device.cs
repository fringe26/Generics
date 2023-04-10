namespace Generics;

partial class Program
{
    class Device<T> where T : class,IOutput, new()
    {
        public T Output { get; set; }

        public Device()
        {
            Output = new T();
        }

    }




}

