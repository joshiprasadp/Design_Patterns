namespace Abstract_Factory.Main
{
    public interface ICarSales
    {
        FamilyCar GetFamilyCar(string Company);
        SportsCar GetSportsCar(string Company);
    }
}