using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Concretes
{
    public class SliderItemService : ISliderItemService
    {
        public readonly ProniaDbContext _context;

        public SliderItemService(ProniaDbContext context)
        {
            _context = context;
        }

        public Task CreateSliderItemAsync(SliderItem sliderItem)
        {
            throw new NotImplementedException();
        }

        public async Task SoftDeleteSliderItemAsync(int id)
        {
            

            SliderItem? baseSliderItem = await _context.SliderItems.SingleOrDefaultAsync(s => s.Id == id && !s.IdDeleted);
            if (baseSliderItem is null)
            {
                throw new Exception($"Slider Item not found with this id({id})");
            }

            baseSliderItem.IdDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task HardDeleteSliderItemAsync(int id)
        {
            SliderItem? baseSliderItem = await _context.SliderItems.FindAsync(id);
            if (baseSliderItem is null)
            {
                throw new Exception($"Slider Item not found with this id({id})");
            }

            if (!baseSliderItem.IdDeleted)
            {

                throw new Exception($"Slide Item with this id{id} not Soft deleted before. ");
            }

            _context.SliderItems.Remove(baseSliderItem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SliderItem>> GetAllSliderItemsAsync()
        {
            List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
            return sliderItems;
        }

        public SliderItem GetSliderItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSliderItem(int id, SliderItem sliderItem)
        {
            throw new NotImplementedException();
        }

        public List<SliderItem> GetSliderItems()
        {
            throw new NotImplementedException();
        }
    }
}
