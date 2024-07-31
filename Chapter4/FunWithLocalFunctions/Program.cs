// See https://aka.ms/new-console-template for more information

static int AddWrapperWithSideEffects(int x, int y) {
    // Some validation
    return Add();

    // Add has access to local parameters of the function, might be a problem
    int Add() {
        x++;
        return x + y;
    }
}

static int AddWrapper(int x, int y) {
    // Some validation
    return Add(x, y);

    // If you add static, then add stops having access to local variables of the parent function, same logic as with classes and methods.
    static int Add(int x, int y) {
        return x + y;
    }
}
