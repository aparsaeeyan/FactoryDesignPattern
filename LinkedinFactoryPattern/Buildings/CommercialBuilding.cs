using LinkedinFactoryPattern.Interfaces;

namespace LinkedinFactoryPattern.Buildings
{
    public class CommercialBuilding : IBuilding
    {
        public void Construct()
        {
            Console.WriteLine("Constructing Commerical Building");
            // Constructing steps for Commerical Building
        }


    }
}
