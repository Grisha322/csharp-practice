
using System.Collections;

void SimpleBoxUnboxOperation() {
    int myInt = 25;

    // We are moving copying the value from the stack into the heap
    object myObj = myInt;

    // Now the element from the heap is being copied back to the stack
    int newInt = (int)myInt;

    // This is called boxing and unboxing, on a lrage scale may causes perfomance issues
}

static void WorkWithArrayList()
{
    // Non generic array list accepts objects, and hence does the boxing and unboxing all the time
    // this is the issue of all non generic types from System.Collections, hence they are not used anymore
    // use types from System.Collections.Generic
    ArrayList mylnts = new ArrayList();
    mylnts.Add(10);
    mylnts.Add(20);
    mylnts.Add(35);

    int myInt = (int)(mylnts[0] ?? 0);

    // another problem of non generic collections is type security...
    mylnts.Add(true);
    mylnts.Add("20");
    mylnts.Add(new object());
    mylnts.Add(.3);
}