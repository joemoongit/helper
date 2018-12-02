using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Library
{
    public static class Utility
    {
        public static int IndexOfGrid(int gridcellIndex, int numberOfColumnsInGrid)
        {
            if(gridcellIndex >= numberOfColumnsInGrid)
            {
                return IndexOfGrid(gridcellIndex - numberOfColumnsInGrid, numberOfColumnsInGrid);
            }
            return gridcellIndex;
        }
    }
}
