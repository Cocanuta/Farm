using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

public class MyXML  {

    static public List<T> DeserializeFromXML<T>(string path)
    {
        XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
        TextReader textReader = new StreamReader(path);
        List<T> list;
        list = (List<T>)deserializer.Deserialize(textReader);
        textReader.Close();

        return (List<T>)list;
    }

    static public void SerializeToXML<T>(List<T> list, string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        TextWriter textWriter = new StreamWriter( path);
        serializer.Serialize(textWriter, list);
        textWriter.Close();
    }
}
