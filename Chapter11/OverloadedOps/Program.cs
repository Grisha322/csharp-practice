using OverloadedOps;

Square s1 = new Square(10);
Rectangle r1 = s1;

Rectangle r2 = new Rectangle(20, 10);
Square s2 = (Square)r2;
