using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace satisfactory_calculator
{
    /// <summary>
    /// Adds xml read and write features along with housing the lists of types
    /// 
    /// </summary>
    class XMLSettings
    {
        public static List<Material> AllMaterials
        {
            get
            {
                if (_AllMaterials == null) _AllMaterials = _AllMaterials_ReadFromFile();
                return _AllMaterials;
            }
        }
        private static List<Material> _AllMaterials = null;
        private static List<Material> _AllMaterials_ReadFromFile(string xmlPath = "Config")
        {
            List<Material> materials = new List<Material>();
            string category;
            try
            {
                foreach (string file in System.IO.Directory.GetFiles(xmlPath))
                {
                    if (file.Contains("Materials."))
                    {
                        category = file.Replace(xmlPath + "\\Materials.", "").Replace(".xml", "");
                        foreach(Material material in ReadFromXmlFile<List<Material>>(file))
                        {
                            material.Category = category;
                            materials.Add(material);
                        }
                        Functions.myLog("Loaded xml file:\n - " + file);
                    }
                }
                return materials;
            }
            catch (Exception ex)
            {
                Functions.myLog(string.Format("XMLSettings.AllMaterials_ReadFromFile:\n - {0}", ex.Message));
                return materials;
            }
        }

        public static List<Machine> AllMachines
        {
            get
            {
                if (_AllMachines == null) _AllMachines = _AllMachines_ReadFromFile();
                return _AllMachines;
            }
        }
        private static List<Machine> _AllMachines = null;
        private static List<Machine> _AllMachines_ReadFromFile(string xmlPath = "Config")
        {
            List<Machine> machines = new List<Machine>();
            try
            {
                foreach (string file in System.IO.Directory.GetFiles(xmlPath))
                {
                    if (file.ToUpper().Contains("MACHINES."))
                    {
                        machines.AddRange(ReadFromXmlFile<List<Machine>>(file));
                        Functions.myLog("Loaded xml file:\n - " + file);
                    }
                }
                return machines;
            }
            catch (Exception ex)
            {
                Functions.myLog(string.Format("XMLSettings.AllMachines_ReadFromFile:\n - {0}", ex.Message));
                return machines;
            }
        }

        public static List<Recipe> AllRecipes
        {
            get
            {
                if (_AllRecipes == null) _AllRecipes = _AllRecipes_ReadFromFile();
                return _AllRecipes;
            }
        }
        private static List<Recipe> _AllRecipes = null;
        private static List<Recipe> _AllRecipes_ReadFromFile(string xmlPath = "Config")
        {
            List<Recipe> recipes = new List<Recipe>();
            string parent;
            try
            {
                foreach (string file in System.IO.Directory.GetFiles(xmlPath))
                {
                    if (file.Contains("Recipes."))
                    {
                        parent = file.Replace(xmlPath + "\\Recipes.", "").Replace(".xml", "");
                        foreach (Recipe recipe in ReadFromXmlFile<List<Recipe>>(file))
                        {
                            recipe.Parent = parent;
                            recipes.Add(recipe);
                        }
                        Functions.myLog("Loaded xml file:\n - " + file);
                    }
                }
                return recipes;
            }
            catch (Exception ex)
            {
                Functions.myLog(string.Format("XMLSettings.AllRecipes_ReadFromFile:\n - {0}", ex.Message));
                return recipes;
            }
        }


        /// <summary>
        /// Reads all the configs into their buckets
        /// </summary>
        /// <param name="xmlPath">path containing Smls</param>
        /// <returns>sucess?!</returns>
        public static bool ReadAll(string xmlPath = "Config")
        {
            _AllMaterials = _AllMaterials_ReadFromFile(xmlPath);
            _AllMachines = _AllMachines_ReadFromFile(xmlPath);
            _AllRecipes = _AllRecipes_ReadFromFile(xmlPath);
            return true;
        }

        /// <summary>
        /// Writes all my helper/builder classes to xml file during development phase
        /// </summary>
        public static bool WriteAll(string xmlPath = "Config")
        {
            string path;
            foreach (string category in new string[] {"Ores", "Components"})
            {
                path = string.Format("{0}\\Materials.{1}.xml", xmlPath, category);
                WriteToXmlFile<List<Material>>(path, XMLSettings.AllMaterials.FindAll(m => m.Category == category));
            }
            foreach (string parent in new string[] { "Assembler","Constructor","Manufacturer","Smelter"})
            {
                path = string.Format("{0}\\Recipes.{1}.xml", xmlPath, parent);
                WriteToXmlFile<List<Recipe>>(path, AllRecipes.FindAll(r => r.Parent == parent));
            }
            path = string.Format("{0}\\Machines.xml", xmlPath);
            WriteToXmlFile<List<Machine>>(path, AllMachines);
            return true;
        }

        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }


    }
}
