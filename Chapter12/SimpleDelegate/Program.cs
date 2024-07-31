using SimpleDelegate;

/*BinaryOp op = new BinaryOp(SimpleMath.Add);
op += SimpleMath.Subtract;

DisplayDelegateInfo(op);*/

Car car = new("some name", 90);
car.RegisterWithCarEngine(DisplayMessage);
car.RegisterWithCarEngine(DisplayMessage);
car.Acelerate(5);
car.Acelerate(10);

static void DisplayMessage(string msg) {
    Console.WriteLine(msg);
}

static void DisplayDelegateInfo(Delegate delObj)
{
    foreach (Delegate d in delObj.GetInvocationList()) {
        Console.WriteLine($"Method name: {d.Method}");
        Console.WriteLine($"Type name: {d.Target}");
    }
}

public delegate int BinaryOp(int x, int y);
