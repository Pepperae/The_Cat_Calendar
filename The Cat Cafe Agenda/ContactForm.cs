using System.Data;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace The_Cat_Cafe_Agenda
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        CustomerModel customer = new CustomerModel();
        DataSet ds = new DataSet();

        public object XmlFileManager { get; private set; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2011, 6, 10);
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var filePath = @"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\doc.xml";
    
            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);
                XElement cust = doc.Element("CustomerModel");
                cust.Add(new XElement("Customer",
                    new XElement("FirstName", textBox1.Text),
                    new XElement("LastName", textBox2.Text),
                    new XElement("DateOfBirth", dateTimePicker1.Value.ToString("dd/MM/yyyy"))));

                doc.Save(filePath);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\doc.xml");
            var root = doc.SelectSingleNode("CustomerModel");
            var tgtnode = doc.SelectSingleNode("/CustomerModel/Customer");
            foreach (XmlNode node in doc.SelectNodes("/CustomerModel/Customer"))
                if ((node.SelectSingleNode("FirstName").InnerText == textBox1.Text) && (node.SelectSingleNode("LastName").InnerText == textBox2.Text) && (node.SelectSingleNode("DateOfBirth").InnerText == dateTimePicker1.Value.ToString("dd/MM/yyyy"))) node.ParentNode.RemoveChild(node);
            doc.Save(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\doc.xml");
        }

        private void BntGetXML_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            //if (dataset == null || dataset.Tables.Count == 0) 
            //{
            //    XDocument doc = XDocument.Load(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\doc.xml");
            //    XElement cust = doc.Element("CustomerModel");
            //    cust.Add(new XElement("Customer",
            //        new XElement("FirstName", textBox1.Text),
            //        new XElement("LastName", textBox2.Text),
            //        new XElement("DateOfBirth", dateTimePicker1.Value.ToString("dd/MM/yyyy"))));

            //    doc.Save(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\doc.xml");

            //}
            //else
            //{
                //DataSet dataset = new DataSet();
                dataset.ReadXml(@"F:\Documents\MyMadeGames\The Cat Cafe Agenda\The Cat Cafe Agenda\doc.xml");
                dataGridView1.DataSource = dataset.Tables[0];
        //    }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}

public class CustomerModel
{
    private string firstName;
    private string lastName;
    private string dateOfBirth;

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
}

public class XmlManager
{
    public static void XmlDataWriter(object obj, string filename)
    {
        XmlSerializer sr = new XmlSerializer(obj.GetType());
        TextWriter writer = new StreamWriter(filename);
        sr.Serialize(writer, obj);
        writer.Close();
    }

    public static CustomerModel XmlDataReader(string filename)
    {
        XmlSerializer xs = new XmlSerializer(typeof(CustomerModel));
        FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
        CustomerModel obj = xs.Deserialize(reader) as CustomerModel;
        reader.Close();
        return obj;
    }
}