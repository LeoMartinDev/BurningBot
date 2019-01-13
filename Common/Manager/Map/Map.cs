using BurningBot.Common.Manager.Map.Enum;
using BurningBot.Common.Manager.Movement;
using BurningBot.Network;
using BurningBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BurningBot.Common.Manager.Map
{
    /**
     * CREDITS: Maxoubot
     */
    class Map
    {
        public int Id { get; set; } = 0;
        public int Date { get; set; } = 0;
        public int Largeur { get; set; } = 15;
        public int Hauteur { get; set; } = 17;
        public string MapData { get; set; }
        public Cell[] Cells;
        private GameClient _client { get; set; } = null;
        private readonly XElement _mapArchive;

        public Map(GameClient client, string packet)
        {
            string[] _loc3 = packet.Split('|');
            this._client = client;
            this.Id = int.Parse(_loc3[1]);
            this.Date = int.Parse(_loc3[2]);

            this._mapArchive = XElement.Load("maps/" + this.Id + "_0" + this.Date + ".xml");
            this.Largeur = int.Parse(this._mapArchive.Element("ANCHURA").Value);
            this.Hauteur = int.Parse(this._mapArchive.Element("ALTURA").Value);
            this.MapData = this._mapArchive.Element("MAPA_DATA").Value;
            this.DecompressMap();

            this.MapData = null;
        }

        public bool MovementAction(string packet, Map map, int cellIdActuel, int cellIdDestination)
        {
            if (cellIdDestination < 0 || cellIdDestination > this.Cells.Length)
                return false;
            
            if (cellIdActuel == cellIdDestination)
                return false;

            if (this.Cells[cellIdDestination].Type == TypeCell.NON_MARCHABLE)
                return false;


            //PATHFINDING + DEPLACEMENT A FAIRE:
           



            return false;
        }

        public void DecompressMap()
        {
            this.Cells = new Cell[this.MapData.Length / 10];
            for (int i = 0; i < MapData.Length; i += 10)
            {
                var cell = MapData.Substring(i, 10);
                this.Cells[i / 10] = this.DecompressCell(cell, i / 10);
            }
        }

        public Cell DecompressCell(string cellData, int cellId)
        {
            Cell cell = new Cell(cellId);

            byte[] informacion_celda = new byte[cellData.Length];
            for (int i = 0; i < cellData.Length; i++)
            {
                informacion_celda[i] = Convert.ToByte(Hash.IndexHash(cellData[i]));
            }

            cell.Type = (TypeCell)((informacion_celda[2] & 56) >> 3);
            cell.IsLinearVersion = (informacion_celda[0] & 1) != 0;
            cell.IsCellInteractive = ((informacion_celda[7] & 2) >> 1) != 0;
            cell.ObjectInteractiveId = cell.IsCellInteractive ? ((informacion_celda[0] & 2) << 12) + ((informacion_celda[7] & 1) << 12) + (informacion_celda[8] << 6) + informacion_celda[9] : -1;
            cell.LayerGroundLevel = Convert.ToByte(informacion_celda[1] & 15);
            cell.LayerGroundSlope = Convert.ToByte((informacion_celda[4] & 60) >> 2);

            return cell;
        }


    }
}
