using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Porno_Graphic.Classes
{
    public abstract class SolidPalette : IPalette
    {
        private class Node
        {
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public uint Pen { get; set; }
            public Brush Brush { get; set; }

            public Node(uint pen, Color color)
            {
                Next = null;
                Previous = null;
                Pen = pen;
                Brush = new SolidBrush(color);
            }
        };

        private readonly Dictionary<uint, Node> mEntries = new Dictionary<uint, Node>();
        private readonly int mCapacity = 256;
        private Node mHead = null;
        private Node mTail = null;

        public Brush GetBrush(uint pen)
        {
            pen = GetEffectivePen(pen);
            Node entry;
            if (!mEntries.TryGetValue(pen, out entry))
            {
                while (mEntries.Count >= mCapacity)
                {
                    mEntries.Remove(mTail.Pen);
                    mTail = mTail.Previous;
                    if (mTail != null)
                        mTail.Next = null;
                }
                entry = new Node(pen, GetColor(pen));
                mEntries.Add(pen, entry);
            }
            MakeHead(entry);
            return entry.Brush;
        }

        public abstract Color GetColor(uint pen);

        protected abstract uint GetEffectivePen(uint pen);

        protected void ClearCache()
        {
            mEntries.Clear();
            mHead = null;
            mTail = null;
        }

        protected void ClearCache(uint pen)
        {
            Node entry;
            if (mEntries.TryGetValue(pen, out entry))
            {
                mEntries.Remove(pen);
                Node next = entry.Next;
                Node previous = entry.Previous;
                if (next != null)
                    next.Previous = previous;
                else if (mTail == entry)
                    mTail = previous;
                if (previous != null)
                    previous.Next = next;
                else if (mHead == entry)
                    mHead = next;
            }
        }

        private void MakeHead(Node entry)
        {
            if (mHead != entry)
            {
                Node next = entry.Next;
                Node previous = entry.Previous;
                if (next != null)
                    next.Previous = previous;
                else if (mTail == entry)
                    mTail = previous;
                if (previous != null)
                    previous.Next = next;
                if (mHead != null)
                    mHead.Previous = entry;
                entry.Next = mHead;
                mHead = entry;
                entry.Previous = null;
            }
        }
    }
}
