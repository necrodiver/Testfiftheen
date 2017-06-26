using AutoMapper;
using System;

namespace Test_AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(x => x.CreateMap<Aliens, Person>().ForMember(dest => dest.Age, opt => opt.Condition(src => src.Age > 0 && src.Age < 149)));
            var p1 = Mapper.Map<Person>(new Aliens() { Age = -1 });//false
            var p2 = Mapper.Map<Person>(new Aliens() { Age = 0 });//false
            var p3 = Mapper.Map<Person>(new Aliens() { Age = 1 });//true
            var p4 = Mapper.Map<Person>(new Aliens() { Age = 148 });//true
            var p5 = Mapper.Map<Person>(new Aliens() { Age = 149 });//false

            Console.WriteLine(p1.Age);
            Console.WriteLine(p2.Age);
            Console.WriteLine(p3.Age);
            Console.WriteLine(p4.Age);
            Console.WriteLine(p5.Age);
            Console.ReadKey();
        }
    }
    public class Person
    {
        public Person()
        {
            Age = 22;
        }
        public int Age { set; get; }//Person的Age属性默认值是22
    }

    public class Aliens
    {
        public Aliens()
        {
            Age = -23;
        }
        public int Age { get; set; }//Aliens的Age属性默认值是-23
    }
}