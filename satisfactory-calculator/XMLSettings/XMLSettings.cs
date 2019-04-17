using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
    class XMLSettings
    {
        public static List<Material> Components = _ReadMaterials("Components.xml","Config/Materials");
        private static List<Material> _ReadMaterials(string xmlFile, string xmlPath)
        {
            if (!System.IO.Directory.Exists(xmlPath)) { System.IO.Directory.CreateDirectory(xmlPath); }
            return Functions.ReadFromXmlFile<List<Material>>(string.Format("{0}\\{1}", xmlPath, xmlFile));
        }
    }
}
