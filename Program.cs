using System.Runtime.InteropServices.Marshalling;
using Microsoft.Win32.SafeHandles;

User s1 = new RegularUser("Ali");
User s2 = new Infulaser ("Eraj");

s1.Viewactivity();
s2.Viewactivity();



  Photo p1 = new Photo("sunset.jpg");
 Photo p2 = new ProcessedPhoto("beach.jpg", "GNJ");

        p1.Display();
        Console.WriteLine();
        p2.Display();




