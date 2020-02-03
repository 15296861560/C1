using System;
using System.Xml;

namespace 创建XML
{
    /*
     * XML可扩展的标记语言
     * 作用：存储数据
     * 注意：
     * XML是严格区分大小写的
     * XML标签也是成对出现的
     * XML文档有且只有一个根节点
     */
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            //1.引用命名空间
            //2.创建XML文档对象
            XmlDocument doc = new XmlDocument();
            //3.创建一个行描述信息，并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //4.创建根节点
            XmlElement books = doc.CreateElement("Books");
            //将根节点添加到文档中
            doc.AppendChild(books);
            //5.给根节点Books创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将book添加到根节点
            books.AppendChild(book1);

            //6.给Book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "C程序设计";
            book1.AppendChild(name1);
            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "30";
            book1.AppendChild(price1);
            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "学习C语言的教程";
            book1.AppendChild(des1);


            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
