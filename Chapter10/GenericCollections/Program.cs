using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using GenericCollections;
using System.Collections.ObjectModel;

void UseObservableGenericCollection() {
    ObservableCollection<int> myInts = new() { 1, 2, 3};

    myInts.CollectionChanged += int_collectionChanged;

    static void int_collectionChanged(object? sender, NotifyCollectionChangedEventArgs e) { 
        
    }
}

void UseGenericDictionary() {
    Dictionary<string, string> dicA = new (){
        {"first", "gold" },
        {"second", "arnold" },
    };

    Dictionary<string, string> dicB = new(){
        ["first"] = "gold",
        ["second"] = "arnold",
    };

    Console.WriteLine(dicB["first"]);
}

void UseGenericList() {
    List<Person> people = new List<Person> {
        new Person{FirstName = "Dread", LastName = "Kirpa", Age = 35 },
        new Person{FirstName = "Ns", LastName = "Kirpa", Age = 35 },
        new Person{FirstName = "Mel", LastName = "Kirpa", Age = 35 },
        new Person{FirstName = "Cake", LastName = "Kirpa", Age = 35 },
    };

    Console.WriteLine($"Items in list: {people.Count}");

    foreach (Person person in people)
    {
        // implicitly invokes ToString of the passed object
        Console.WriteLine(person);
    }

    people.RemoveAt(0);
}

void UseGenericQueue() {
    Queue<Person> people = new();

    people.Enqueue(new Person { FirstName = "Dread", LastName = "Kirpa", Age = 35 });
    people.Enqueue(new Person { FirstName = "Ns", LastName = "Kirpa", Age = 35 });

    Console.WriteLine($"First in the queue: {people.Peek()}");
    Console.WriteLine($"Removed first from the queue: {people.Dequeue()}");
}

void UserSortedSet() {
    SortedSet<Person> people = new(new SortPeopleByAge()) {
        new Person{FirstName = "Dread", LastName = "Kirpa", Age = 35 },
        new Person{FirstName = "Ns", LastName = "Kirpa", Age = 20 },
        new Person{FirstName = "Mel", LastName = "Kirpa", Age = 7 },
        new Person{FirstName = "Cake", LastName = "Kirpa", Age = 14 },
    };

    foreach(Person p in people)
        Console.WriteLine(p);

}

void UseGenericStack() {
    Stack<Person> people = new();

    people.Push(new Person { FirstName = "Dread", LastName = "Kirpa", Age = 35 });
    people.Push(new Person { FirstName = "Ns", LastName = "Kirpa", Age = 35 });

    Console.WriteLine($"Top of the stack: {people.Peek()}");
    Console.WriteLine($"Top of the stack popped: {people.Pop()}");
}

void FunWithInitializers()
{
    int[] myIntArray = {0, 1, 2, 3 };

    List<int> myGenericList = new List<int> { 1, 2, 3, 4, 5, 6};
    ArrayList myList = new ArrayList { 1, 2, 3, 4, 5, 6 };

    List<Point> points = new List<Point> { 
        new Point{ X = 5, Y = 10},
        new Point{ X = 5, Y = 2},
        new Point{ X = 3, Y = 10},
    };
}