using LinkedinFactoryPattern.Buildings;
using LinkedinFactoryPattern.Interfaces;

namespace LinkedinFactoryPattern
{
    public class BuildingFactory
    {
        public IBuilding CreateBuilding(string type)
        {
            switch (type.ToLower())
            {
                case "commercial":
                    return new CommercialBuilding();
                case "office":
                    return new ResidentialBuilding();
                case "residential":
                    return new OfficeBuilding();
                default:
                    throw new ArgumentException("Invalid building type");
            }
        }
    }

}
