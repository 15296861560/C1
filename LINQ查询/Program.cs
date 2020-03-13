using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ查询
{
    class Pet
    {
        private string _name;
        private string _kind;
        private int _age;

        public string Name { get => _name; set => _name = value; }
        public string Kind { get => _kind; set => _kind = value; }
        public int Age { get => _age; set => _age = value; }

        public override string ToString()
        {
            return "宠物名"+Name+" 宠物种类"+Kind+" 宠物年龄"+Age;
        }

    }



    class Program
    {

        /// <summary>
        /// 生成宠物数据
        /// </summary>
        /// <returns></returns>
        private static List<Pet> CreateClasses()
        {
            List<Pet> result = new List<Pet>();
            result.Add(new Pet { Name = "小花", Kind = "猫", Age = 1 });
            result.Add(new Pet { Name = "小白", Kind = "猫", Age = 3 });
            result.Add(new Pet { Name = "旺财", Kind = "狗", Age = 2 });
            result.Add(new Pet { Name = "吃货", Kind = "仓鼠", Age = 1 });
            return result;
        }
        static void Main(string[] args)
        {
            List<Pet> pets = CreateClasses();


            #region 使用linq查询宠物列表中宠物名以小开头的宠物
            var queryResults1 = from pet in pets where pet.Name.StartsWith("小") select pet;


            foreach(var p in queryResults1)
            {
                Console.WriteLine("宠物名以小开头的宠物名有" + p.Name);

            }
            #endregion

            #region 使用linq中的orderby对宠物宠物列表中的宠物以年龄来排序
            //orderby默认升序可以添加descending关键字改为降序，降序例子： from pet in pets orderby pet.Age descending select pet;
            var queryResults2 = from pet in pets orderby pet.Age select pet;


            Console.WriteLine("\n排序后的宠物列表宠物名和年龄");

            foreach (var p in queryResults2)
            {
                Console.WriteLine("宠物名："+ p.Name+"；宠物年龄:"+p.Age);

            }
            #endregion

            #region 使用linq中的方法语法对宠物宠物列表中的宠物以年龄来排序
            var queryResults3 = pets.OrderBy(pet=>pet.Age);


            Console.WriteLine("\n使用方法语法排序后的宠物列表宠物名和年龄");

            foreach (var p in queryResults3)
            {
                Console.WriteLine("宠物名：" + p.Name + "；宠物年龄:" + p.Age);

            }
            #endregion

            #region 使用linq中的聚合函数
            int maxAge = pets.Select(pet => pet.Age).Max();//最大的宠物年龄
            int count = pets.Where(pet => pet.Kind.Equals("猫")).Count();//种类为猫的宠物数量
            double avg = pets.Select(pet => pet.Age).Average();//所有宠物的平均年龄


            Console.WriteLine("\n最大的宠物年龄:"+maxAge);
            Console.WriteLine("种类为猫的宠物数量:"+count);
            Console.WriteLine("所有宠物的平均年龄:"+avg);


            #endregion


            #region 查询复杂的对象（实质是重写类的toString（）函数与linq并没有什么关系）

            var queryResults4 =pets.Where(pet => pet.Kind.Equals("猫"));


            Console.WriteLine("\n种类为猫的宠物信息");

            foreach (Pet p in queryResults4)
            {
                Console.WriteLine(p);

            }
            #endregion

            #region 投影

            var queryResults6 = pets.Where(pet => pet.Kind.Equals("猫")).Select(pet=>new { pet.Name, pet.Age });


            Console.WriteLine("\n种类为猫的宠物名和年龄");

            foreach (var p in queryResults6)
            {
                Console.WriteLine(p);

            }
            #endregion

            #region 单值选择查询

            var queryResults7 = pets.Select(pet => pet.Kind).Distinct();


            Console.WriteLine("\n去重后的种类");

            foreach (var p in queryResults7)
            {
                Console.WriteLine(p);

            }
            #endregion

            #region Any()和All()方法

            bool anyCat = pets.Any(pet => pet.Kind == "猫");

            if (anyCat)
            {
                Console.WriteLine("\n宠物列表里的宠物中有猫");
            }
            else
            {
                Console.WriteLine("\n宠物列表里的宠物中没有有猫");
            }

            bool allCat=pets.All(pet => pet.Kind == "猫");

            if (allCat)
            {
                Console.WriteLine("宠物列表里的宠物都是猫");
            }
            else
            {
                Console.WriteLine("宠物列表里的宠物不全是猫");
            }

            #endregion

            #region 多级排序
            var queryResults8 = pets.OrderBy(pet => pet.Age).ThenBy(pet=>pet.Name);


            Console.WriteLine("\n一级排序为年龄二级排序为宠物名后的宠物列表");

            foreach (var p in queryResults8)
            {
                Console.WriteLine(p);

            }
            #endregion

            #region 组合查询
            var queryResults9 = from pet in pets group pet by pet.Kind;

            Console.WriteLine("\n以种类分组后的宠物列表");

            foreach (var ps in queryResults9)
            {
                Console.WriteLine("||");

                foreach (var p in ps)
                {

                    Console.WriteLine(p);

                }

            }
            #endregion

            #region Take（）和Skip（）方法
            var queryResults10 = from pet in pets select pet;

            Console.WriteLine("\n跳过前两个宠物之后的两个宠物");

            foreach (var p in queryResults10.Skip(2).Take(2))
            {
                    Console.WriteLine(p);

            }
            #endregion

            #region First（）和FirstOrDefault（）方法
            var queryResults11 = from pet in pets select pet;
            var firstCat = queryResults11.First(pet => pet.Kind == "猫");
            Console.WriteLine("\n第一个种类为猫的宠物是"+ firstCat);

            //如果使用First（）方法却没有找到符合条件的结果将会直接报错，但是使用FirstOrDefault（）方法后不会报错而是输出空结果集
            Pet firstPig = queryResults11.FirstOrDefault(pet => pet.Kind == "猪");
            Console.WriteLine("\n第一个种类为猪的宠物是"+ firstPig);



            #endregion

            #region Join查询
            int[] ages = { 1, 2 };
            var queryResults12 = from pet in pets join age in ages on pet.Age equals age select pet;

            Console.WriteLine("\n年龄在ages里的宠物");

            foreach (var p in queryResults12)
            {
                

                    Console.WriteLine(p);


            }
            #endregion


            Console.ReadKey();
        }
    }
}
