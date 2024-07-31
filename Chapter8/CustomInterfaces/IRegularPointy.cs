using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIntefaces
{
    public interface IRegularPointy : IPointy
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }
        // Really think it through before usin default definition, like one bellow
        // if class implements this interface, but doesn't redefine the method, then they will
        // have to be always cast to this interface before using it, e. g. ((IRegularPointy) Square).Perimeter
        int Perimeter => SideLength * NumberOfSides;
    }
}
