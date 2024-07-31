using System;

Console.WriteLine("***** Fun With enums *****");
Console.WriteLine("EmpTypesEnum uses {0} for storage", Enum.GetUnderlyingType(EmpTypesEnum.Grunt.GetType()));
Console.WriteLine("EmpTypesEnum uses {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypesEnum))); // type of is simpler in this context
EmpTypesEnum emp = EmpTypesEnum.Constructor;
// Выводит строку "Contractor = 100".
Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp); // Note: Enum.Format provides more control of string formatting with enum

EmpTypesEnum e2 = EmpTypesEnum.Constructor;
// Эти типы являются перечислениями из пространства имен System.
DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;
EvaluateEnum(e2);
EvaluateEnum(day);
EvaluateEnum(cc);
Console.ReadLine();

static void EvaluateEnum(Enum e)
{
    Console.WriteLine("=> Information about {0}", e.GetType().Name);
    // Вывести лежащий в основе тип хранилища.
    Console.WriteLine("Underlying storage type: {0}",
    Enum.GetUnderlyingType(e.GetType()));
    // Получить все пары "имя-значение" для входного параметра.
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members.", enumData.Length);
    // Вывести строковое имя и ассоциированное значение,
    // используя флаг формата D (см. главу 3).
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}",
        enumData.GetValue(i));
    }
    Console.WriteLine();
}

enum EmpTypesEnum : byte{ // by typing : byte, we changed the underlying type of the enum,
                          // now every value stored, should be within byte range
                          // which saves memory
    VicePresident = 102,
    Manager,    // 103
    Grunt,      // 104
    Constructor // 105
}

