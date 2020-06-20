using PFE.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PFE.Shared
{
    public static class ProjectHandler
    {
        public static Boolean createNewProject(string projectName, string directory)
        {
            try
            {
                Project p = new Project { id = 2, name = projectName };
                XmlSerializer xmlSerializer = new XmlSerializer((typeof(Project)));
                if (File.Exists(directory + "\\" + projectName + ".xml"))
                {
                    File.Delete(directory + "\\" + projectName + ".xml");
                }
                TextWriter writer = new StreamWriter(directory + "\\" + projectName + ".xml");
                xmlSerializer.Serialize(writer, p);
                Data.currentProject = p;
                Data.directory = directory + "\\" + projectName + ".xml";
                writer.Close();
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return false;
        }

        public static Boolean saveProject()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((typeof(Project)));
                if (File.Exists(Data.directory))
                {
                    File.Delete(Data.directory);
                }
                TextWriter writer = new StreamWriter(Data.directory);
                xmlSerializer.Serialize(writer, Data.currentProject);
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return false;
        }

        public static Boolean loadProject(string directory)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Project));
                if (File.Exists(directory))
                {
                    TextReader reader = new StreamReader(directory);
                    Data.currentProject = (Project)xmlSerializer.Deserialize(reader);
                    Data.directory = directory;
                    Console.WriteLine("EZ = " + Data.currentProject.name);
                    reader.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return false;
        }
    }
}
