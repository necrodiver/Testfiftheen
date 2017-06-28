using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstCodeFirstDemo.FirstCodeFirstApp;

namespace FirstCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();//如果数据库不存在时则创建
                var donators = new List<Donator>
                {
                    new Donator
                    {
                        Name="张三",
                        Amount=50,
                        DonateDate=new DateTime(2017,6,25)
                    },
                    new Donator
                    {
                        Name="李四",
                        Amount=5,
                        DonateDate=new DateTime(2017,6,26)
                    },
                    new Donator
                    {
                        Name="王五",
                        Amount=18.8m,
                        DonateDate=new DateTime(2017,6,28)
                    }
                };
                context.Donators.AddRange(donators);
                context.SaveChanges();
            }
            Console.WriteLine("DB has Created");//提示DB创建成功
            Console.ReadKey();
        }
    }
}
