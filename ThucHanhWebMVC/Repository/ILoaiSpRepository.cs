using ThucHanhWebMVC.Models;
namespace ThucHanhWebMVC.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(string maloaiSp);

        TLoaiSp GetLoaiSp(String maloaiSp);
        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
