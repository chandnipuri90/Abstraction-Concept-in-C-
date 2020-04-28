using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    class Program
    {
        static void Main()
        {


            //..........................................................
            //method syntax

            List<string> books_name = new List<string>
            {
                "java learning", "c learning", "c#","vb.net"

            };

            var book = books_name.Where(a => a.Contains("learning"));
            foreach (var a in book)
            {
                Console.WriteLine( a);

                Console.Read();
            }
            //...............................................................






            Test_Parent p = new Test_Parent();
            Test_child c = new Test_child();
            Test_Parent Y = new Test_child();//refere parent class object to child class u7
                                             //p.show2();
                                             //p.show3();
                                             //c.show2();
                                             //c.show3();
                                             //Y.show2();
                                             //Y.show3();

            c.show();
            book fiction = new book();
            fiction.book_();
            fiction.ink_();
            fiction.paper_();


        }
    }
    class Test_Parent    //difference between abstract method and virtual method is
    {                       //Abstract means you MUST override it. Virtual means you CAN override it. More or less.
                            //  Abstract means you MUST override it means we never give defination of abstract method 
                            //so it is must to override in a child class. Virtual means you CAN override it
                            //(coz u have defintion of virtual fuction already so u can change or not.
        private int a;
        public void show()
        {
            Console.Write("hello");
            Console.Read();
        }

        //  public abstract void show1();//abstract method only have declaration means signature only cant defined here or one more thing it should always in abstract class

        public virtual void show2()//virtual function can be in abstract and non abstarcty class ,moreover it always have body of a method 
        {
            Console.Write("hello i m a virtual functiion of show2 method of  parent class");
            Console.Read();
        }
        public virtual void show3()//virtual function can be in abstract and non abstarcty class ,moreover it always have body of a method 
        {
            Console.Write("hello i m a virtual functiion of show3 method of parent class");
            Console.ReadKey();
        }
        public virtual int show4()
        {
            return (1);

        }
    }

    class Test_child : Test_Parent
    {
        public new void show()//new keyword is used coz both parent and child class have same funcytion so it will give warning  if we not use new keyword
        {                      // data type can be different if we use new but in case of override datatype of function must be same
            Console.Write("i m show of child");
            Console.Read();
        }

        public override void show2()
        {
            Console.Write("hello i m a  override method of show2 of child  class");
            Console.Read();
        }
        public new void show3()//in a child class u can chenge the defination of virtual method
        {
            Console.Write("hello i m a new functiion of show3 of child class ");
            Console.ReadKey();
        }

        //public override float show4()//give error always so override must match datatype 
        //{
        //    return (2.0);

        //}
        public override int show4()//not giving error coz override must match datatype so here match in parent fxn and child fxn 
        {
            return (2);

        }


    }


    abstract class animal          //abstract class always start with abstract keyword and it can have abstarct an non abstarcty method
    {                           // abstract class can  never create its instance or object but its child class can inherit 
        private int car;
        public void color()
        {
            Console.Write("brown");


        }

        public abstract void breed();
        //abstarct method cant have defination only its signature so define abstarct method in child class


    }
    class pig : animal
    {

        public override void breed()
        {
            Console.Write("bchdcbhd");
        }


    }

    //showing throw interface multiple inheitennce is possible otherwise through classes multiple inheritence is not possible
    public interface paper
    {
        void paper_();
    }

    public interface ink
    {
        void ink_();
    }

    public class book : paper, ink
    {
        public void paper_()

        {
            Console.Write("papers");
            Console.Read();
        }

        public void ink_()
        {

            Console.Write("ink");
            Console.Read();
        }

        public void book_()
        {
            Console.Write("Book is here");
            Console.Read();
        }

    }



}
