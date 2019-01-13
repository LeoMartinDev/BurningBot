using BurningBot.Common.Manager.Map.Enum;

namespace BurningBot.Common.Manager.Map
{
    public class Cell
    {
        public int Id { get; set; } = 0;
        public int ObjectInteractiveId { get; set; } = 0;
        public TypeCell Type { get; set; } = TypeCell.NON_MARCHABLE;
        public bool IsLinearVersion { get; set; } = false;
        public bool IsCellInteractive { get; set; } = false;
        public byte LayerGroundLevel { get; set; } = 0;
        public byte LayerGroundSlope { get; set; } = 0;

        public Cell(int id)
        {
            this.Id = id;
        }
    }
}