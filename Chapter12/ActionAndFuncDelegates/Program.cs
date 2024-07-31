Action<int, string> action = DoSomething;
Func<string, string, int> func = ReturnSomething; //last parameter is a return type

static void DoSomething(int a, string b) { 
    //doing smth
}

static int ReturnSomething(string a, string b) {
    return 1;
}
