namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<PieListViewModel> Pies { get; }
        public string? CurrentCategory { get; }

        public PieListViewModel(IEnumerable<PieListViewModel> pies, string? currentCatetgory)
        {
            Pies = pies;
            CurrentCategory = currentCatetgory;
        }
    }
}
