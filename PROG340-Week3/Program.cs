namespace PROG340_Week3
{
    internal static class Program
    {
        /*Worth 10 points. Create a game Menu with the following components:

1- Rectangle

2- Ellipses /

3-Square /

4- Circle 

5- Pie /

6- Arc /

7- Triangle /

8- Hexagon /

9- All text must be a drawn string

10- Mix the use of Pen and Brush*/

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}