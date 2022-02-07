using System;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace The_Cat_Cafe_Agenda
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        EventModel eventModel = new EventModel();
        public object XmlFileManager2 { get; private set; }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var filePath2 = @"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml";

            double dif = (DatePickerEnd.Value - DatePickerStart.Value).TotalMinutes;
            Math.Round(dif, MidpointRounding.AwayFromZero);
            string d = (string)dif.ToString();

            if (File.Exists(filePath2))
            {
                XDocument XMLdatabase = XDocument.Load(filePath2);
                XElement cust = XMLdatabase.Element("EventModel");
                cust.Add(new XElement("Event",
                    new XElement("CustomerName", TextCustomer.Text),
                    new XElement("EventName", TextEvent.Text),
                    new XElement("DateStart", XmlConvert.ToString(DatePickerStart.Value)),
                    new XElement("DateEnd", XmlConvert.ToString(DatePickerEnd.Value))));
                XMLdatabase.Save(filePath2);
            }


            //string dif = DatePickerEnd - DatePickerStart;

            //eventLength.Text = "Your visit will last for " + d + " minutes, is that correct?";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            XmlDocument XMLdatabase = new XmlDocument();
            XMLdatabase.Load(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml");
        //     var root = XMLdatabase.SelectSingleNode("EventModel");
        //     var tgtnode = XMLdatabase.SelectSingleNode("/EventModel/Event");
            foreach (XmlNode node in XMLdatabase.SelectNodes("/EventModel/Event"))
                if ((node.SelectSingleNode("CustomerName").InnerText == TextCustomer.Text) && ((node.SelectSingleNode("EventName").InnerText == TextEvent.Text)) && (node.SelectSingleNode("DateStart").InnerText == XmlConvert.ToString(DatePickerStart.Value)) && (node.SelectSingleNode("DateEnd").InnerText == XmlConvert.ToString(DatePickerEnd.Value))) node.ParentNode.RemoveChild(node);
            XMLdatabase.Save(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml");
        }

        private void BntGetXML_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml");
            dataGridViewEvent.DataSource = dataset.Tables[0];
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void BtnFetch_Click(object sender, EventArgs e)
        {
            string a1 = TextCustomer.Text;
            string a2 = TextEvent.Text;
            DateTime b1 = DatePickerStart.Value;
            DateTime b2 = DatePickerEnd.Value;

            XmlDocument XMLdatabase = new XmlDocument();
            XMLdatabase.Load(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml");
            foreach (XmlNode node in XMLdatabase.SelectNodes("/EventModel/Event"))

                if ((node.SelectSingleNode("CustomerName").InnerText == TextCustomer.Text) && ((node.SelectSingleNode("EventName").InnerText == TextEvent.Text)) && (node.SelectSingleNode("DateStart").InnerText == XmlConvert.ToString(DatePickerStart.Value)) && (node.SelectSingleNode("DateEnd").InnerText == XmlConvert.ToString(DatePickerEnd.Value)))
                {
                    node.ParentNode.RemoveChild(node);
                }

            XMLdatabase.Save(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml");

            TextCustomer.Text = a1;
            TextEvent.Text = a2;
            DatePickerStart.Value = b1;
            DatePickerEnd.Value = b2;
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            var filePath2 = @"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\XMLdatabase.xml";

            double dif = (DatePickerEnd.Value - DatePickerStart.Value).TotalMinutes;
            Math.Round(dif, MidpointRounding.AwayFromZero);
            string d = (string)dif.ToString();

            if (File.Exists(filePath2))
            {
                XDocument XMLdatabase = XDocument.Load(filePath2);
                XElement cust = XMLdatabase.Element("EventModel");
                cust.Add(new XElement("Event",
                    new XElement("CustomerName", TextCustomer.Text),
                    new XElement("EventName", TextEvent.Text),
                    new XElement("DateStart", XmlConvert.ToString(DatePickerStart.Value)),
                    new XElement("DateEnd", XmlConvert.ToString(DatePickerEnd.Value))));
                XMLdatabase.Save(filePath2);
            }
        }
    }
}

public class MyXmlParser
{
    ///This method will loop through each node to get to the data we want.
    public static List<string> GetItemsFromXmlByLoopingThroughEachNode(string Filename)
    {
        List<string> Items = new List<string>();
        XmlDocument doc = new XmlDocument();
        doc.Load(Filename);
        foreach (XmlNode RootNode in doc.ChildNodes)
        {
            if (RootNode.NodeType != XmlNodeType.XmlDeclaration)
            {
                foreach (XmlNode Node1Node in RootNode.ChildNodes)
                {
                    XmlAttributeCollection attributes = Node1Node.Attributes;
                    XmlAttribute Attribute1 = attributes["attribute1"];

                    foreach (XmlNode Node2Node in Node1Node.ChildNodes)
                    {
                        foreach (XmlNode Node3Node in Node2Node.ChildNodes)
                        {
                            Items.Add(Node3Node.InnerText);
                        }
                    }
                }
            }
        }
        return Items;
    }

    public static List<string> GetItemsFromXmlUsingTagNames(string Filename, string TagName)
    {
        List<string> Items = new List<string>();
        XmlDocument doc = new XmlDocument();
        doc.Load(Filename);

        XmlNodeList Node3Nodes = doc.GetElementsByTagName(TagName);
        foreach (XmlNode Node3Node in Node3Nodes)
        {
            Items.Add(Node3Node.InnerText);
        }
        return Items;
    }
}

public class EventModel
{
    private string CustomerName;
    private string EventName;
    private string DateStart;
    private string DateEnd;
    //private double Duration;

    //private string CustomerName { get => customerName; set => customerName = value; }
    //private string EventName { get => eventName; set => eventName = value; }
    //private string DateStart { get => dateStart; set => dateStart = value; }
    //private string DateEnd { get => dateEnd; set => dateEnd = value; }
    //private double Duration { get => duration; set => duration = value; }
}
public class XmlManager2
{
    public static void XmlDataWriter(object obj, string filename)
    {
        XmlSerializer sr2 = new XmlSerializer(obj.GetType());
        TextWriter writer2 = new StreamWriter(filename);
        sr2.Serialize(writer2, obj);
        writer2.Close();
    }
    public static EventModel XmlDataReader2(string filename)
    {
        XmlSerializer xs2 = new XmlSerializer(typeof(EventModel));
        FileStream reader2 = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
        EventModel obj = xs2.Deserialize(reader2) as EventModel;
        reader2.Close();
        return obj;
    }
}