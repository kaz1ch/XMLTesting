using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace XMLTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            const string file_name = "TestData.xml";

            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load(file_name);

            var Dekanate = xml_doc.DocumentElement;

            var Students = Dekanate.FirstChild;

            var Groups = Students.ChildNodes;

            var group1 = Groups[1];
            var group2 = Groups[2];

            var StudentGroup1 = group1.ChildNodes;
            var StudentGroup2 = group2.ChildNodes;

            Console.WriteLine(group1.Attributes["Name"].Value);
            foreach (XmlElement student_node in group1.ChildNodes)
            {
                Console.WriteLine("Student id: {0}", student_node.Attributes["Id"].Value);
                Console.WriteLine("\tName: {0}", student_node.GetElementsByTagName("Name")[0].Value);
                Console.WriteLine("\tSurname: {0}", student_node.GetElementsByTagName("Surname")[0].Value);
                Console.WriteLine("\tPatronymic: {0}", student_node.GetElementsByTagName("Patronymic")[0].Value);
                Console.WriteLine("\tDateBirth: {0}", student_node.GetElementsByTagName("DateBirth")[0].Value);
                Console.WriteLine("\tRating: {0}", student_node.Attributes["Rating"].Value);
            }

            Console.WriteLine(group2.Attributes["Name"].Value);
            foreach (XmlElement student_node in group2.ChildNodes)
            {
                Console.WriteLine("Student id: {0}", student_node.Attributes["Id"].Value);
                Console.WriteLine("\tName: {0}", student_node.GetElementsByTagName("Name")[0].Value);
                Console.WriteLine("\tSurname: {0}", student_node.GetElementsByTagName("Surname")[0].Value);
                Console.WriteLine("\tPatronymic: {0}", student_node.GetElementsByTagName("Patronymic")[0].Value);
                Console.WriteLine("\tDateBirth: {0}", student_node.GetElementsByTagName("DateBirth")[0].Value);
                Console.WriteLine("\tRating: {0}", student_node.Attributes["Rating"].Value);
            }



            Console.ReadLine();
        }
    }


    class Group //make a structure with at least 100 students and 10 groups
    {
        public string Name { get; set; }
        public string 
    }
}
