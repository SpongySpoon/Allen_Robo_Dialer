// See https://aka.ms/new-console-template for more information
namespace Allen_Robo_Dialer;

class Program
{
    static void Main(string[] args)
    {
        Phone[] call = new Phone[10];
        call[0] = new HomePhone("Computest ", "(303) 985-5060 ", 1);
        call[1] = new CellPhone("Curtis Manufacturing ", "(603) 532-4123", 2);
        call[2] = new HomePhone("Data Functions ", "(800) 876-2524", 1);
        call[3] = new HomePhone("Donney Repair ", "(708) 397-3330", 1);
        call[4] = new HomePhone("Ergonomic Inc ", "(360) 434-3894", 1);
        call[5] = new HomePhone("ErgoSource ", "(800) 969-4374", 1);
        call[6] = new CellPhone("Fox Bay Industries ", "(800) 874-8527", 2);
        call[7] = new CellPhone("Glare-Guard ", "(800) 545-6254", 2);
        call[8] = new CellPhone("Hazard Comm Specialists ", "(407) 783-6641", 2);
        call[9] = new CellPhone("Komfort Support ", "(714) 472-4409", 2);

        numOfCallers(call);
    }

    public static void numOfCallers(Phone[] call)
    {
        for (int i = 0; i < call.Length; i++)
        {
            Console.WriteLine(call[i]._Dial());
        }
    }
}
