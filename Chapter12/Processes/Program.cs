using System.Diagnostics;
using System.Reflection;
using System.Linq;

ListAssemblies();
static void UseApplicationVerbs() {
    int i = 0;
    ProcessStartInfo s1 = new(@"test_file.docx");

    foreach (var verb in s1.Verbs) {
        Console.WriteLine($"{i++}. {verb}");
    }

    s1.WindowStyle = ProcessWindowStyle.Maximized;
    s1.Verb = "Edit";
    s1.UseShellExecute = true;
    Process.Start(s1);
}

static void DisplayDADStats()
{
    // Получить доступ к домену приложения для текущего потока.
    AppDomain defaultAD = AppDomain.CurrentDomain;
    // Вывести разнообразные статистические данные об этом домене.
    Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
    // Дружественное имя этого домена
    Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
    // Идентификатор этого процесса
    Console.WriteLine("Is this the default domain?: {0}",
    defaultAD.IsDefaultAppDomain());
    // Является ли этот домен стандартным
    Console.WriteLine("Base directory of this domain: {0}",
    defaultAD.BaseDirectory);
    // Базовый каталог этого домена
    Console.WriteLine("Setup Information for this domain:");
    // Информация о настройке этого домена
    Console.WriteLine("\tApplication Base: {0}",
    defaultAD.SetupInformation.ApplicationBase);
    // Базовый каталог приложения
    Console.WriteLine("\tTarget Framework: {0}",
    defaultAD.SetupInformation.TargetFrameworkName);
    // Целевая платформа
}

static void ListAssemblies (){
    AppDomain defaultAD = AppDomain.CurrentDomain;

    Assembly[] assemblies = defaultAD.GetAssemblies();

    foreach (Assembly a in assemblies) {
        var name = a.GetName();
        int[] someInts = { 1, 2, 3, 4, 5 };
        // this is to include linq in assemblies
        var value = (from i in someInts select i).First();
        Console.WriteLine($"Name = {name.Name}, Version = {name.Version}");
    }
}