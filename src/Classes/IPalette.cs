using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Porno_Graphic.Classes
{
    public interface IPalette
    {
        Color GetColor(uint pen);
        Brush GetBrush(uint pen);
    }
}
