using Backend.Models;

namespace Backend.Repositories
{
    public class OutfitCalendarRepository: IOutfitCalendarRepository
    {
        private readonly WardrobeDBContext _dbContext;

        public OutfitCalendarRepository(WardrobeDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveOutfitCalendarEntry(OutfitCalendarEntry entry)
        {
            _dbContext.OutfitCalendarEntries.Add(entry);
            _dbContext.SaveChangesAsync();
        }
        public OutfitCalendarEntry GetOutfitCalendarEntry(int id)
        {
            return _dbContext.OutfitCalendarEntries.FirstOrDefault(entry => entry.Id == id);
        }

        public List<OutfitCalendarEntry> GetOutfitCalendarEntries()
        {
            return _dbContext.OutfitCalendarEntries.ToList();
        }
    }

    public interface IOutfitCalendarRepository
    {
        void SaveOutfitCalendarEntry(OutfitCalendarEntry entry);
        List<OutfitCalendarEntry> GetOutfitCalendarEntries();
        OutfitCalendarEntry GetOutfitCalendarEntry(int id);
    }
}
