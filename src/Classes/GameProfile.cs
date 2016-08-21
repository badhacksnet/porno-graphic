using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Porno_Graphic.Classes
{
    [Serializable()]
    [XmlRoot(ElementName = "profile", Namespace = "http://baddesthacks.net/porno-graphic/profile")]
    public class GameProfile
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlArray(ElementName = "layouts", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem(ElementName = "layout", Form = XmlSchemaForm.Unqualified)]
        public CharLayout[] CharLayouts { get; set; }

        [XmlArray(ElementName = "regions", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem(ElementName = "region", Form = XmlSchemaForm.Unqualified)]
        public LoadRegion[] LoadRegions { get; set; }
    }
}
