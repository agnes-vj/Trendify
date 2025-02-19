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

        public List<OutfitCalendarEntry> GetOutfitCalendarEntries()
        {
            return _dbContext.OutfitCalendarEntries.ToList();
        }
    }

    public interface IOutfitCalendarRepository
    {
        void SaveOutfitCalendarEntry(OutfitCalendarEntry entry);
        List<OutfitCalendarEntry> GetOutfitCalendarEntries();
    }
}
