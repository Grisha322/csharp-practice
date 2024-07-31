using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    internal interface IAdvancedDraw: IDrawable
    {
        void DrowInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
        new int TimeToDraw() => 15;
    }
}
