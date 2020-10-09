
using System;


namespace классы
{
    //public class FirstClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        int total = 3;
    //        Person[] persons = new Person[total];
    //        for (int i = 0; i < total; i++)
    //        {
    //            persons[i] = new Person()
    //            {
    //                Name = Console.ReadLine()
    //            };

    //        }
    //        for (int i = 0; i < total; i++)
    //        {
    //            Console.WriteLine(persons[i].ToString());

    //        }
    //        Console.ReadKey();
    //    }
    //    public class Person
    //    {
    //        public string Name { get; set; }
    //        public override string ToString()
    //        {
    //            return "Hello, my name is " + Name;
    //        }


    //    }

    //}



    //public static class DestruktorandKonstruktor
    //{
    //    public static void Main(string[] args)
    //    {
    //        int total = 3;
    //        Person[] persons = new Person[total];

    //        for (int i = 0; i < total; i++)
    //        {
    //            persons[i] = new Person(Console.ReadLine());
    //        }

    //        for (int i = 0; i < total; i++)
    //        {
    //            Console.WriteLine(persons[i].ToString());
    //        }

    //    }
    //    public class Person
    //    {
    //        public string Name { get; set; }
    //        public Person(string name)
    //        {
    //            Name = name;
    //        }

    //        public override string ToString()
    //        {
    //            return "Hello, my name is " + Name;
    //        }
    //        ~Person()
    //        {
    //            Name = string.Empty;
    //        }

    //    }


    //}
    //public class PfotografAndModelTest
    //{
    //    public static void Main(string[] args)
    //    {
    //        Person myperson = new Person();
    //        myperson.Greet();
    //        myperson.setAge(21);
    //        Pfotograf mypfotograf = new Pfotograf();
    //        mypfotograf.makeFoto(); 
    //        Model mymodel = new Model();
    //        mymodel.makePose();
    //        mymodel.setAge(25);
    //        mymodel.showAge();



    //    }



    //}

    //public class Person
    //{
    //    protected int Age;
    //    public void Greet()
    //    {
    //        Console.WriteLine("Hallo");

    //    }
    //    public void setAge(int n)
    //    {
    //        Age = n;
    //    }

    //}

    //public class Pfotograf : Person
    //{
    //    public void makeFoto()
    //    {
    //        Console.WriteLine("I am making a Foto");

    //    }
    //}
    //public class Model : Person
    //{
    //    public void makePose()
    //    {
    //        Console.WriteLine("I maling a Pose");
    //    }
    //    public void showAge()
    //    {
    //        Console.WriteLine("My age is {0}", Age);
    //    }


    //}
    //public class PhotoBookTest
    //{
    //    public static void Main(string[] args)
    //    {
    //        PhotoBook myalbum1 = new PhotoBook();
    //        Console.WriteLine(myalbum1.GetNumberPages());
    //        PhotoBook myalbum2 = new PhotoBook(24);
    //        Console.WriteLine(myalbum2.GetNumberPages());
    //        BigPhotoBook largalbum = new BigPhotoBook();
    //        Console.WriteLine(largalbum.GetNumberPages());


    //    }
    //}

    //public class PhotoBook
    //{
    //    protected int numpages;
    //    public PhotoBook()
    //    {
    //        numpages = 16;        
    //    }

    //    public PhotoBook(int numpages)
    //    {
    //        this.numpages = numpages;
    //    }
    //    public int GetNumberPages()
    //    {
    //        return numpages;
    //    }
    //}

    //public class BigPhotoBook : PhotoBook
    //{

    //    public BigPhotoBook()
    //    {
    //        numpages = 64;
    //    }
    //}


    //public class Program
    //{
    //    static int[] array = {10, 55, 85, 102, 256};
    //    static int largest()
    //    {
    //        int i;
    //        int max = 0;
    //        for (i = 0; i < array.Length; i++)
    //        {
    //            if (array[i] > max)
    //            {
    //                max = array[i];
    //            }
    //        }

    //        return max;
    //    }

    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(largest());
    //    }

    //}

    //public class Program
    //{
    //    static int[] array = { 10, 55, 85, 102, 256 };
    //    static int largest()
    //    {
    //        int i;
    //        int min = array[0];
    //        for (i = 0; i < array.Length; i++)
    //        {
    //            if (min > array[i])
    //            {
    //                min = array[i];
    //            }
    //        }

    //        return min;
    //    }

    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(largest());
    //    }

    //}

    //public class Program
    //{

    //    static int largest(int[]a, int n)
    //    {
    //        int i;
    //        int sum = 0;
    //        for (i = 0; i < a.Length; i++)
    //        {
    //            sum = sum + a[i];
    //        }

    //        return sum / n;
    //    }

    //    public static void Main(string[] args)
    //    {
    //        int[] a = { 10, 55, 85, 102, 256 };
    //        int n = a.Length;
    //        Console.WriteLine(largest(a, n));
    //    }

    //}



    //public class Program
    //{

    //    static int largest(int[] a, int n)
    //    {
    //        int i;
    //        int k = 0;
    //        for (i = 0; i < a.Length; i++)
    //        {
    //            if (i == a.Length / 2)
    //            {
    //                k= a[i];

    //            }

    //        }
    //        return k;

    //    }

    //    public static void Main(string[] args)
    //    {
    //        int[] a = { 10, 55, 85, 102, 256 };
    //        int n = a.Length;
    //        Console.WriteLine(largest(a, n));
    //    }

    //}

    //class fa
    //{

    //    static bool HalfDiagonalSums(int[,] mat, int n)
    //    {
    //        int leftdiag1 = 0,
    //            rightdiag1 = 0;
    //        int leftdiag2 = 0,
    //            rightdiag2 = 0;

    //        for (int i = 0, j = n - 1; 
    //                 i < n; i++, j--)
    //        {

    //            if (i < n / 2)
    //            {
    //                leftdiag1 += mat[i, i];
    //                leftdiag2 += mat[j, i];
    //            }

    //            else if (i > n / 2)
    //            { 
    //                rightdiag1 += mat[i, i];
    //                rightdiag2 += mat[j, i];
    //            }

    //        }

    //        return (leftdiag1 == rightdiag2 &&
    //                rightdiag2 == leftdiag2 &&
    //                rightdiag1 == leftdiag2 &&
    //                rightdiag2 == mat[n / 2, n / 2]);

    //    }

    //    static public void Main()
    //    {
    //        int[,] f =
    //        {
    //            {2,9,1,4,-2},
    //            {6,7,2,11,4},
    //            {4,2,9,2,4 },
    //            {1,9,2,4,4 },
    //            {0,2,4,2,1 }
    //        };
    //        Console.WriteLine(HalfDiagonalSums(f, 5) ?
    //            "Yes":"No");
    //    }

    //}

}
