using Pronia.BL.Services.Concretes;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions
{
    public interface ISliderItemService
    {

        SliderItem GetSliderItemById(int id);
        Task<List<SliderItem>> GetAllSliderItemsAsync();

        Task CreateSliderItemAsync(SliderItem sliderItem);
        void UpdateSliderItem(int id, SliderItem sliderItem);
        Task HardDeleteSliderItemAsync(int id);
        Task SoftDeleteSliderItemAsync(int id);
        List<SliderItem> GetSliderItems();
    }
}