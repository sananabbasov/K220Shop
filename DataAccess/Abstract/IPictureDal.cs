using Core.DataAccess;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IPictureDal : IRepositoryBase<Picture>
    {
        Picture AddPictures(Picture picture);
    }
}
