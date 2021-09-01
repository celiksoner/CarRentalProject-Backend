using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);

        IResult Delete(CarImage carImage);

        IResult Update(IFormFile file, CarImage carImage);

        IDataResult<List<CarImage>> GetAll();

        IDataResult<CarImage> GetById(int carImageId);

        IDataResult<List<CarImage>> GetImagesByCarId(int carId);
    }
}