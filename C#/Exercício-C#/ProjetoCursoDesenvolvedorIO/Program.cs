namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShapeCircle();
        }

        private static void ShapeCircle()
        {
            var circle = new ExercicioCsharp.Circle();
            // circle.SaveToFile("shapes.txt");
            circle.ReadFile("shapes.txt");
        }


    }
}
