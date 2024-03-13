using AutomobileLibrary.DataAccess;


namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
      

        public Car GetCarByID(int carId) => CarDAO.Instance.getCarByID(carId);
        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarList();
        public void InSertCar(Car car) => CarDAO.Instance.AddNew(car);
        public void DeleteCar(int carId) => CarDAO.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);

        public Car GetCarById(int carId)
        {
            throw new NotImplementedException();
        }

        public void InsertCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
