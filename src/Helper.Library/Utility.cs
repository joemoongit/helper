using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public abstract class Utility
    {
        public int IndexOf_old(int gridcellIndex)
        {
            if (gridcellIndex >= 10)
            {
                return IndexOf_old(gridcellIndex - 10);
            }
            return gridcellIndex;
        }

        public int IndexOfGrid(int gridcellIndex, int numberOfColumnsInGrid)
        {
            if(gridcellIndex >= numberOfColumnsInGrid)
            {
                return IndexOfGrid(gridcellIndex - numberOfColumnsInGrid, numberOfColumnsInGrid);
            }
            return gridcellIndex;
        }

    }
}
