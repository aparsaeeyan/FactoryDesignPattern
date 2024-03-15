using LinkedinFactoryPattern;
using LinkedinFactoryPattern.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        BuildingFactory buildingFactory = new BuildingFactory();

        // Construct an Commerical Building
        IBuilding commercialBuilding = buildingFactory.CreateBuilding("Commercial");
        commercialBuilding.Construct();

        // Construct an Office Building
        IBuilding officeBuilding = buildingFactory.CreateBuilding("Office");
        officeBuilding.Construct();

        // Construct an Residential Building
        IBuilding residentialBuilding = buildingFactory.CreateBuilding("Residential");
        residentialBuilding.Construct();
    }
}
