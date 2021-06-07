namespace Xml2
{
    using System;
    using System.Xml;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Bus bus1 = new Bus("Mercedes", "AC-203", "140", "20000", "18");
            Bus bus2 = new Bus("Ford", "AC-203", "160", "3455", "16");
            Bus bus3 = new Bus("BMW", "AC-203", "120", "53455", "14");
            Bus bus4 = new Bus("Chevrolet", "AC-203", "140", "2344", "8");
            Bus bus5 = new Bus("Opel", "AC-203", "140", "1232", "22");
            
            XmlDocument doc=  new XmlDocument();
            var declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            var root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            var el1 = doc.CreateElement("item");  
            doc.AppendChild(el1);
            var el2 = doc.CreateElement("Brand");
            el1.AppendChild(el2);
            var el3 = doc.CreateElement("Model");
            el1.AppendChild(el3);
            var el4 = doc.CreateElement("Max Speed");
            el1.AppendChild(el4);
            var el5 = doc.CreateElement("Max Capacity");
            el1.AppendChild(el5);
            var el6 = doc.CreateElement("Amount of wheels");
            el1.AppendChild(el6);


            var el2Text = doc.CreateTextNode(bus1.Brand);
            var el3Text = doc.CreateTextNode(bus1.Model);
            var el4Text = doc.CreateTextNode(bus1.MaxSpeed);
            var el5Text = doc.CreateTextNode(bus1.MaxCapacity);
            var el6Text = doc.CreateTextNode(bus1.AmountOfWheels);
            el2.AppendChild(el2Text);
            el3.AppendChild(el3Text);
            el4.AppendChild(el4Text);
            el5.AppendChild(el5Text);
            el6.AppendChild(el6Text);
            var atr = doc.CreateAttribute("size");
            atr.Value = "2";
            el1.Attributes.Append(atr);
            try
            {
                doc.Save("xml_dom_test.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not save: "+e.Message);
            }
        }
    }
}