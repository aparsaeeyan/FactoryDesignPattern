using LinkedinFactoryPattern.Interfaces;

namespace LinkedinFactoryPattern.Buildings
{
    public class OfficeBuilding : IBuilding
    {
        public void Construct()
        {
            Console.WriteLine("Constructing Office Building");
            // Constructing steps for Office Building
        }
    }
}
