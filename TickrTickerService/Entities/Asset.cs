using TickrTickerService.Enums;

namespace TickrTickerService.Entities
{
    public class Asset
    {
        public string? Symbol  { get; set; }
        public string? Exchange { get; set; }

        public AssetType? AssetType { get; set; }

        public bool Valid()
        {
            return AssetType != null && Symbol != null && Exchange != null && Exchange != String.Empty;
        }
    }
}
