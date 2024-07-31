static void TraditionalDelegateSyntax() {
    List<int> list = new();

    list.AddRange(new int[] { 1, 2, 3, 4, 5});

    Predicate<int> callback = new Predicate<int>(IsEven); // or delegate (int num) { return true; }; or IsEven

    List<int> evenNumbers = list.FindAll(callback); // or IsEven or delegate (int num) { return true; };
}

static void LambdaExpressionDelegates() {
    List<int> list = new();

    list.AddRange(new int[] { 1, 2, 3, 4, 5 });

    List<int> evenNumbers = list.FindAll(i => i % 2 == 0); // (i) => { do something }
}

static bool IsEven(int num) { 
    return (num % 2) == 0;
}