using ThucHanhWebMVC.Models;
namespace ThucHanhWebMVC.ViewModels
{
    public class HomeProductDetailViewModel
    {
        public TDanhMucSp _danhMucSp { get; set; }
        public List<TAnhSp> _anhSps { get; set; }
        public HomeProductDetailViewModel(TDanhMucSp danhMucSp,List<TAnhSp> anhSps) 
        {
            _danhMucSp = danhMucSp;
            _anhSps = anhSps;
        }
    }
}
