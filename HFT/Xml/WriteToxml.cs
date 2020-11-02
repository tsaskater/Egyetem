public static void WriteToXml<T>(List<T> All,string filename)
        {
            XDocument xdoc = new XDocument();
            var t =typeof(T);
            PropertyInfo[] props = t.GetProperties();
            XElement main = new XElement(t.Name.ToLower()+"s");
            xdoc.Add(main);
            foreach (var item in All)
            {
                XElement child = new XElement(t.Name.ToLower());
                foreach (var prop in props)
                {
                    XElement subchild =new XElement(prop.Name.ToLower());
                    subchild.Value = prop.GetValue(item).ToString();
                    child.Add(subchild);
                }
                main.Add(child);
            }
            xdoc.Save(filename+".xml");
        }
