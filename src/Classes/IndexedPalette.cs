using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class IndexedPalette : SolidPalette
    {
        public static IPalette RGB;
        public static IPalette RGBI;

        static IndexedPalette()
        {
            IndexedPalette pal;

            pal = new IndexedPalette();
            pal.Colors = new Color[8];
            for (uint i = 0; i < pal.Colors.Length; i++)
                pal.Colors[i] = Color.FromArgb(((i & 0x01) != 0) ? 0xff : 0x00, ((i & 0x02) != 0) ? 0xff : 0x00, ((i & 0x04) != 0) ? 0xff : 0x00);
            RGB = pal;

            pal = new IndexedPalette();
            pal.Colors = new Color[16];
            for (uint i = 0; i < pal.Colors.Length; i++)
            {
                int intensity = ((i & 0x08) != 0) ? 0x80 : 0;
                int red = intensity | (((i & 0x01) != 0) ? 0x7f : 0x00);
                int green = intensity | (((i & 0x02) != 0) ? 0x7f : 0x00);
                int blue = intensity | (((i & 0x04) != 0) ? 0x7f : 0x00);
                pal.Colors[i] = Color.FromArgb(red, green, blue);
            }
            RGBI = pal;
        }

        private Color[] mColors;

        public Color[] Colors
        {
            get
            {
                return mColors;
            }
            set
            {
                mColors = value;
                ClearCache();
            }
        }

        public override Color GetColor(uint pen)
        {
            return mColors[pen % Colors.Length];
        }

        protected override uint GetEffectivePen(uint pen)
        {
            return (uint)(pen % Colors.Length);
        }
    }
}
