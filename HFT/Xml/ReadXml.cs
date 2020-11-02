public static List<Person> LoadXml(string filename)
        {
            List<Person> people = new List<Person>();
            filename += ".xml";
            if (System.IO.File.Exists(filename))
            {
                foreach (var item in XDocument.Load(filename).Descendants("person"))//people-n belüli personok kell(egyes szám nem többes)
                {
                    Person p = new Person();
                    p.Id = item.Element("id")?.Value;
                    p.Name = item.Element("name")?.Value;
                    p.Age = int.Parse(item.Element("age")?.Value);
                    p.HairColor = (Haircolor)Enum.Parse(typeof(Haircolor), item.Element("haircolor")?.Value);
                    p.Sex = bool.Parse(item.Element("sex")?.Value);
                    people.Add(p);
                }
            }
            return people;
        }
