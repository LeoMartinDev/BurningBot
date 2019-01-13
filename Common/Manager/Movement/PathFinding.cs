using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Manager.Movement
{
    class PathFinding
    {
        private int _startCell { get; set; }
        private int _destinationCell { get; set; }
        private readonly Map.Map _map;

        public PathFinding(Map.Map map, int startCell, int destinationCell)
        {
            this._startCell = startCell;
            this._destinationCell = destinationCell;
            this._map = map;
        }
        
    }
}
