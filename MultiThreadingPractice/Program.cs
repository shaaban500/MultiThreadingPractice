Thread x = new Thread(WriteY); 
x.Start();

Thread y = new Thread(WriteX);
y.Start();

Thread z = new Thread(WriteZ);
z.Start();

for (int i = 0; i < 1000; i++)
{
    Console.Write("a");
}

static void WriteY()
{
    for (int i = 0; i < 1000; i++) Console.Write("b");
}

static void WriteX()
{
    for (int i = 0; i < 1000; i++) Console.Write("c");
}

static void WriteZ()
{
    for (int i = 0; i < 1000; i++) Console.Write("d");
}
