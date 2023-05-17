using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;

SectionTitle("Writing to text streams");

// define a file to write to
string textFile = Combine(CurrentDirectory, "streams.txt");


// create a text file and return a helper writer
StreamWriter text = File.CreateText(textFile);

// enumerate the strings, writing each one
// to the stream on a separate line
foreach (string item in Viper.Callsigns)
{
    text.WriteLine(item);
}

text.Close(); // release resources
              // ​
// output the contents of the file
WriteLine("{0} contains {1:N0} bytes.", textFile, new FileInfo(textFile).Length);
WriteLine(File.ReadAllText(textFile));



SectionTitle("Writing to XML streams");

//define a file path to write to
string xmlfile = Combine(CurrentDirectory, "streams.xml");

//declare variables for the filestream and XML writer
FileStream? xmlfilestream = null;
XmlWriter? xml = null;
try
{
    //create a file stream
    xmlfilestream = File.Create(xmlfile);
    // wrap the file stream in an XML writer helper
    // and automatically indent nested elements
    xml = XmlWriter.Create(xmlfilestream, new XmlWriterSettings { Indent = true });

    //write the XML declaration
    xml.WriteStartDocument();

    //write a root element
    xml.WriteStartElement("callsigns");
    //enumerate the strings, writing each one to the stream
    foreach (string item in Viper.Callsigns)
    {
        xml.WriteElementString("callsigns", item);
    }
    //write the close root element
    xml.WriteEndElement();
    //close helper and stream
    xml.Close();
    xmlfilestream.Close();

}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");

}
finally
{
    if (xml != null)
    {
        xml.Dispose();
        WriteLine("The XML writer's unmanaged resources have been disposed.");
    }
    if (xmlfilestream != null)
    {
        xmlfilestream.Dispose();
        WriteLine("The file stream's unmanaged resources have been disposed.");
    }
}