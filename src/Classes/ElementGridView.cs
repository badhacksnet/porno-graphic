using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic.Classes
{
    public partial class ElementGridView : ScrollableControl
    {
        private uint mElementWidth = 8U;
        private uint mElementHeight = 8U;
        private uint mElementPadding = 1U;

        private uint mScaleX = 1U;
        private uint mScaleY = 1U;
        private bool mFlipX = false;
        private bool mFlipY = false;

        private Color mGridColor = Color.FromArgb(255, 0, 0, 0);
        private Color mHighlightColor = Color.FromArgb(255, 255, 255, 0);

        private GfxElement[] mElements = new GfxElement[0];
        private IPalette mPalette;

        [DefaultValue(typeof(uint), "8")]
        public uint ElementWidth
        {
            get
            {
                return mElementWidth;
            }
            set
            {
                if (value != mElementWidth)
                {
                    mElementWidth = value;
                    RecomputeLayout();
                    Invalidate();
                }
            }
        }
        [DefaultValue(typeof(uint), "8")]
        public uint ElementHeight
        {
            get
            {
                return mElementHeight;
            }
            set
            {
                if (value != mElementHeight)
                {
                    mElementHeight = value;
                    RecomputeLayout();
                    Invalidate();
                }
            }
        }
        [DefaultValue(typeof(uint), "1")]
        public uint ElementPadding
        {
            get
            {
                return mElementPadding;
            }
            set
            {
                if (value != mElementPadding)
                {
                    mElementPadding = value;
                    RecomputeLayout();
                    Invalidate();
                }
            }
        }

        [DefaultValue(typeof(uint), "1")]
        public uint ScaleX
        {
            get
            {
                return mScaleX;
            }
            set
            {
                if (value != mScaleX)
                {
                    mScaleX = value;
                    RecomputeLayout();
                    Invalidate();
                }
            }
        }
        [DefaultValue(typeof(uint), "1")]
        public uint ScaleY
        {
            get
            {
                return mScaleY;
            }
            set
            {
                if (value != mScaleY)
                {
                    mScaleY = value;
                    RecomputeLayout();
                    Invalidate();
                }
            }
        }
        [DefaultValue(false)]
        public bool FlipX
        {
            get
            {
                return mFlipX;
            }
            set
            {
                mFlipX = value;
                Invalidate();
            }
        }
        [DefaultValue(false)]
        public bool FlipY
        {
            get
            {
                return mFlipY;
            }
            set
            {
                mFlipY = value;
                Invalidate();
            }
        }

        public Color GridColor { get { return mGridColor; } set { mGridColor = value; Invalidate(); } }
        public Color HighlightColor { get { return mHighlightColor; } set { mHighlightColor = value; Invalidate(); } }

        public GfxElement[] Elements
        {
            get
            {
                return mElements;
            }
            set
            {
                mElements = value;
                RecomputeLayout();
                Invalidate();
            }
        }
        public IPalette Palette
        {
            get
            {
                return mPalette;
            }
            set
            {
                mPalette = value;
                Invalidate();
            }
        }

        private uint ItemWidth { get { return (ScaleX * ElementWidth) + (2 * ElementPadding); } }
        private uint ItemHeight { get { return (ScaleY * ElementHeight) + (2 * ElementPadding); } }

        public ElementGridView()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);
            Rectangle clip = e.ClipRectangle;
            clip.Offset(-AutoScrollPosition.X, -AutoScrollPosition.Y);
            e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            int columns = (int)((AutoScrollMinSize.Width - (2 * ElementPadding)) / ItemWidth);
            int rows = (Elements.Length + columns - 1) / columns;
            int firstRow = (int)Math.Max(clip.Top / ItemHeight, 0);
            int lastRow = (int)Math.Min((clip.Bottom - 1 - (2 * ElementPadding)) / ItemHeight, rows - 1);
            int firstColumn = (int)Math.Max(clip.Left / ItemWidth, 0);
            int lastColumn = (int)Math.Min((clip.Right - 1 - (2 * ElementPadding)) / ItemWidth, columns - 1);
            if (Palette != null)
            {
                int[,] transform = new int[,] { { FlipX ? -(int)ScaleX : (int)ScaleX, 0, 0 }, { 0, FlipY ? -(int)ScaleY : (int)ScaleY, 0 }, { 0, 0, 1 } };
                transform[1, 2] = (int)((ItemHeight * firstRow) + (2 * ElementPadding) + (FlipY ? ((ElementHeight * ScaleY) - 1) : 0));
                for (int row = firstRow; row <= lastRow; row++, transform[1, 2] += (int)ItemHeight)
                {
                    transform[0, 2] = (int)((ItemWidth * firstColumn) + (2 * ElementPadding) + (FlipX ? ((ElementWidth * ScaleX) - 1) : 0));
                    for (int column = firstColumn; (column <= lastColumn) && (((row * columns) + column) < Elements.Length); column++, transform[0, 2] += (int)ItemWidth)
                    {
                        GfxElement element = Elements[(row * columns) + column];
                        if (element != null)
                            element.Draw(e.Graphics, Palette, transform);
                    }
                }
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            bool needRedraw = RecomputeLayout();
            base.OnSizeChanged(e);
            if (needRedraw)
                Invalidate();
        }

        private bool RecomputeLayout()
        {
            int columns = (int)Math.Max(1, (Size.Width - (2 * ElementPadding)) / ItemWidth);
            int rows = (((Elements != null) ? Elements.Length : 0) + columns - 1) / columns;
            if (((ItemHeight * rows) + (2 * ElementPadding)) > Size.Height)
            {
                columns = (int)Math.Max(1, (Size.Width - SystemInformation.VerticalScrollBarWidth - (2 * ElementPadding)) / ItemWidth);
                rows = (((Elements != null) ? Elements.Length : 0) + columns - 1) / columns;
            }
            int desiredWidth = (int)((columns * ItemWidth) + (2 * ElementPadding));
            int desiredHeight = (int)((rows * ItemHeight) + (2 * ElementPadding));
            if ((desiredWidth != AutoScrollMinSize.Width) || (desiredHeight != AutoScrollMinSize.Height))
            {
                AutoScrollMinSize = new Size(desiredWidth, desiredHeight);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
