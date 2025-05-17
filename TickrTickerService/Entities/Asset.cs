using TickrTickerService.Enums;

namespace TickrTickerService.Entities
{
    public class Asset
    {
        public string Symbol  { get; set; }
        public string Exchange { get; set; }

        public AssetType AssetType { get; set; }

        public bool Valid()
        {
            return Symbol != null && Exchange != null;
        }
    }
}
