using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConfirmationApp
{
    public class QuoteNames
    {

        public string Name { get; set; }
        public string Tel { get; set; }

        public static List<QuoteNames> GetNames()
        {

            //List<QuoteNames> names = new List<QuoteNames>();
            //names.Add(new QuoteNames { Name = "tom", Tel = "13800001235" });
            //names.Add(new QuoteNames { Name = "jim", Tel = "18600761234" });
            //return names;

            return GetXmlNames();
        }

        public static List<QuoteNames> GetXmlNames()
        {
            string xmlfilePath = AppDomain.CurrentDomain.BaseDirectory+"\\tools\\temp\\UserInfo.xml";
            XElement xe = XElement.Load(xmlfilePath);
            IEnumerable<XElement> elements = from ele in xe.Elements("Info")
                                             select ele;


            List<QuoteNames> nameList = new List<QuoteNames>();
            foreach (var ele in elements)
            {
                QuoteNames model = new QuoteNames();
               
                model.Name = ele.Attribute("Name").Value;

                model.Tel = ele.Attribute("Tel").Value;
                nameList.Add(model);
            }

            return nameList;

        }
    }


}
