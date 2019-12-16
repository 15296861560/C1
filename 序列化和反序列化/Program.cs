using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{

    /*
     * 序列化：将对象转换为二进制
     * 反序列化：将二进制转换为对象
     * 作用：传输数据
     * 
     * 序列化：
     * 1.将对象标记为序列化
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {

            Pet pet = new Pet("宠物",0);
            string path =@"D:\Test\c#\lgy.txt";
            
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs, pet);
            //}
            //    Console.WriteLine("序列化成功!");

            //接受对方发送过来的二进制 反序列化成对象
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //开始反序列化
                BinaryFormatter bf = new BinaryFormatter();
                Pet pet2 = (Pet)bf.Deserialize(fsRead);
                
            }

            Console.WriteLine(pet.Name);
            Console.WriteLine(pet.Age);
            Console.WriteLine("反序列化成功!");
        }
    }

    [Serializable]
    public class Pet
    {
        private string _name;
        private int _age;

        public Pet()
        {

            Name = "pet";
            Age = 0;
        }

        public Pet(string name, int age)
        {

            Name = name;
            Age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }



        public void Yell()
        {
            Console.WriteLine("呃呃呃");
        }
    }

}
