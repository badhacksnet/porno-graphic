using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Porno_Graphic.Classes
{
    [Serializable()]
    [XmlRoot(ElementName = "region", Namespace = "http://baddesthacks.net/porno-graphic/profile")]
    public class LoadRegion
    {
        public class Instruction
        {
            [XmlIgnore]
            public uint Offset { get; set; }

            [XmlIgnore]
            public uint Size { get; set; }

            [XmlAttribute("offset")]
            public string SerializedOffset
            {
                get { return Offset.ToString("x"); }
                set { Offset = uint.Parse(value, NumberStyles.HexNumber); }
            }

            [XmlAttribute("size")]
            public string SerializedSize
            {
                get { return Size.ToString("x"); }
                set { Size = uint.Parse(value, NumberStyles.HexNumber); }
            }
        };

        public class File
        {
            public enum Lanes
            {
                [XmlEnum("8/byte")]
                ByteByte,
                [XmlEnum("16/byte")]
                WordByte,
                [XmlEnum("16/word")]
                WordWord,
                [XmlEnum("32/byte")]
                DWordByte,
                [XmlEnum("32/word")]
                DWordWord,
                [XmlEnum("32/dword")]
                DWordDWord,
                [XmlEnum("64/byte")]
                QWordByte,
                [XmlEnum("64/word")]
                QWordWord,
                [XmlEnum("64/dword")]
                QWordDWord,
                [XmlEnum("64/qword")]
                QWordQWord
            }

            [XmlAttribute("name")]
            public String Name { get; set; }

            [XmlIgnore]
            public uint Group { get; private set; }

            [XmlIgnore]
            public uint Skip { get; private set; }

            [XmlAttribute("byteswap")]
            public bool ByteSwap { get; set; }

            [XmlElement(ElementName = "load", Form = XmlSchemaForm.Unqualified)]
            public Instruction[] Instructions { get; set; }

            public uint SwapMask { get { return ByteSwap ? (Group - 1U) : 0U; } }

            [XmlAttribute("lanes")]
            public Lanes SerializedLanes
            {
                set
                {
                    switch (value)
                    {
                        case Lanes.ByteByte:
                            Group = 1U;
                            Skip = 0U;
                            break;
                        case Lanes.WordByte:
                            Group = 1U;
                            Skip = 1U;
                            break;
                        case Lanes.WordWord:
                            Group = 2U;
                            Skip = 0U;
                            break;
                        case Lanes.DWordByte:
                            Group = 1U;
                            Skip = 3U;
                            break;
                        case Lanes.DWordWord:
                            Group = 2U;
                            Skip = 2U;
                            break;
                        case Lanes.DWordDWord:
                            Group = 4U;
                            Skip = 0U;
                            break;
                        case Lanes.QWordByte:
                            Group = 1U;
                            Skip = 7U;
                            break;
                        case Lanes.QWordWord:
                            Group = 2U;
                            Skip = 6U;
                            break;
                        case Lanes.QWordDWord:
                            Group = 4U;
                            Skip = 4U;
                            break;
                        case Lanes.QWordQWord:
                            Group = 8U;
                            Skip = 0U;
                            break;
                    }
                }
                get
                {
                    switch (Group)
                    {
                        case 1U:
                            switch (Skip)
                            {
                                case 0U:
                                    return Lanes.ByteByte;
                                case 1U:
                                    return Lanes.WordByte;
                                case 3U:
                                    return Lanes.DWordByte;
                                case 7U:
                                    return Lanes.QWordByte;
                            }
                            break;
                        case 2U:
                            switch (Skip)
                            {
                                case 0U:
                                    return Lanes.WordWord;
                                case 2U:
                                    return Lanes.DWordWord;
                                case 6U:
                                    return Lanes.QWordWord;
                            }
                            break;
                        case 4U:
                            switch (Skip)
                            {
                                case 0U:
                                    return Lanes.DWordDWord;
                                case 4U:
                                    return Lanes.QWordDWord;
                            }
                            break;
                        case 8U:
                            switch (Skip)
                            {
                                case 0U:
                                    return Lanes.QWordQWord;
                            }
                            break;
                    }
                    throw new ArgumentOutOfRangeException();
                }
            }

            public File()
            {
                Group = 1U;
                Skip = 0U;
                ByteSwap = false;
            }
        };

        public class Fill
        {
            [XmlIgnore]
            public uint Offset { get; set; }

            [XmlIgnore]
            public uint Size { get; set; }

            [XmlIgnore]
            public byte Value { get; set; }

            [XmlAttribute("offset")]
            public string SerializedOffset
            {
                get { return Offset.ToString("x"); }
                set { Offset = uint.Parse(value, NumberStyles.HexNumber); }
            }

            [XmlAttribute("size")]
            public string SerializedSize
            {
                get { return Size.ToString("x"); }
                set { Size = uint.Parse(value, NumberStyles.HexNumber); }
            }

            [XmlAttribute("value")]
            public string SerializedValue
            {
                get { return Value.ToString("x"); }
                set { Size = byte.Parse(value, NumberStyles.HexNumber); }
            }
        };

        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlIgnore]
        public uint Length { get; set; }

        [XmlElement(ElementName = "file", Form = XmlSchemaForm.Unqualified)]
        public File[] Files { get; set; }

        [XmlElement(ElementName = "fill", Form = XmlSchemaForm.Unqualified)]
        public Fill[] Fills { get; set; }

        [XmlAttribute("length")]
        public string SerializedLength
        {
            get { return Length.ToString("x"); }
            set { Length = uint.Parse(value, NumberStyles.HexNumber); }
        }

        public byte[] LoadFiles(string[] paths)
        {
            byte[] result = new byte[Length];
            for (int i = 0; i < Files.Length; i++)
            {
                File file = Files[i];
                FileStream stream = new FileStream(paths[i], FileMode.Open, FileAccess.Read);
                uint maxSize = 0;
                foreach (Instruction instruction in file.Instructions)
                    maxSize = Math.Max(maxSize, instruction.Size);
                byte[] buffer = new byte[maxSize];
                foreach (Instruction instruction in file.Instructions)
                {
                    stream.Read(buffer, 0, (int)instruction.Size);
                    uint destination = instruction.Offset;
                    for (uint source = 0; source < instruction.Size; source++)
                    {
                        result[destination ^ file.SwapMask] = buffer[source];
                        destination++;
                        if ((source % file.Group) == (file.Group - 1))
                            destination += file.Skip;
                    }
                }
            }
            if (Fills != null)
            {
                foreach (Fill fill in Fills)
                {
                    for (uint i = 0; i < fill.Size; i++)
                        result[fill.Offset + i] = fill.Value;
                }
            }
            return result;
        }
    }
}
