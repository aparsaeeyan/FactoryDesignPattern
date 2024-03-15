using LinkedinFactoryPattern.Interfaces;

namespace LinkedinFactoryPattern.Buildings
{
    public class ResidentialBuilding : IBuilding
    {
        public void Construct()
        {
            Console.WriteLine("Constructing Residential Building");
            // Constructing steps for Residential Building

        }
    }
}
