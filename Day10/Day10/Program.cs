//using System.Linq;
//using System.Xml.Linq;

using System.Xml.Linq;

namespace Day10
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "Main";

            //Console.WriteLine($"This is {th.Name} thread.");

            //ThreadStart childThreadRef = new ThreadStart(CallToChildThread);
            //Console.WriteLine("Creating child thread");

            //Thread childThread = new Thread(childThreadRef);
            //childThread.Start();


            //// main thread sleep
            //Thread.Sleep(2000);


            //Console.WriteLine("Aborting child thread!");
            //childThread.Abort();

            //ThreadStart moreImpChildRef = new ThreadStart(MoreImportantThread);
            //ThreadStart lessImpChildRef = new ThreadStart(LessImportantThread);

            //Console.WriteLine("In the main thread... created the sub threads");

            //Thread moreImpThread = new Thread(moreImpChildRef);
            //Thread lessImpThread = new Thread(lessImpChildRef);

            //moreImpThread.Start();
            ////moreImpThread.Join();

            //lessImpThread.Start();


            //string[] names = new string[] { "Anil", "Soujanyo", "Suman", "Meghna", "Preet", "Hirak", "Ayush" };
            //UsingLinq(names);
            //UsingLinqExtensions(names);
            //UsingLinqWithFunc(names);
            //UsingLinqWithAnonFunc(names);

            //UsingLinqQuestion(names);

            //LinqReadXML();

            //LinqReadAddXML();
            //LinqRemove();

            ServiceProxy serviceProxy = new ServiceProxy(null);
            serviceProxy.Get();
            serviceProxy.Post("");
            Console.ReadKey();

        }

        

        public static void LinqRemove()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-sales</Department>
                            <Department>Marketing</Department>
                            <Hello><Hello2>Sales</Hello2></Hello>
                            </Departments>";

            XDocument xDoc = new XDocument();
            xDoc = XDocument.Parse(myXML);

            xDoc.Descendants().Where(s => s.Value == "Sales").Remove();

            var result = xDoc.Element("Departments").Descendants();
            //var result2 = xDoc.Element("Departments").Descendants();

            foreach (var item in result)
            {
                Console.WriteLine($"Department Name - {item}");
            }

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result2);
        }

        public static void LinqReadAddXML()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";

            XDocument xDoc = new XDocument();
            xDoc = XDocument.Parse(myXML);

            xDoc.Element("Departments").Add(new XElement("Department", "Finance"));
            xDoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xDoc.Element("Departments").Descendants();

            foreach (var item in result)
            {
                Console.WriteLine($"Department Name - {item.Value}");
            }
        }


        public static void LinqReadXML()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";

            XDocument xDoc = new XDocument();
            xDoc = XDocument.Parse(myXML);

            var result = xDoc.Element("Departments").Descendants();

            foreach (var item in result) 
            {
                Console.WriteLine($"Department Name - {item.Value}");
            }
        }

        public static void UsingLinqQuestion(string[] names)
        {
            IEnumerable<string> list = from s in names
                                       where s[0] == 'A' || s[0] == 'a'
                                       orderby s descending
                                       select s.ToUpper();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        public static void UsingLinqWithAnonFunc(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };

            Func<string, string> order = delegate (string s)
            {
                return s;
            };

            Func<string, string> selection = delegate (string s)
            {
                return s.ToUpper();
            };

            IEnumerable<string> list = names.Where(filter).OrderBy(order).Select(selection);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void UsingLinqWithFunc(string[] names)
        {
            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> order = s => s;
            Func<string, string> selection = s => s.ToUpper();

            IEnumerable<string> list = names.Where(filter).OrderBy(order).Select(selection);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void UsingLinqExtensions(string[] names)
        {
            IEnumerable<string> result = names
                .Where(s => s.Length == 5)
                .OrderBy(s => s)
                .Select(s => s.ToUpper());

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void UsingLinq(string[] names)
        {
            IEnumerable<string> list = from s in names
                                       where s.Length == 5
                                       orderby s descending
                                       select s.ToUpper();

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            
        }


        public static void MoreImportantThread()
        {
            Console.WriteLine("More important thread started...");
            Thread.Sleep(2000);
            Console.WriteLine("More imp thread completed!");
        }

        public static void LessImportantThread()
        {
            Console.WriteLine("Less important thread started...");
            Thread.Sleep(3000);
            Console.WriteLine("Less important thread completed!");
        }


        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts...");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.Write($"\r{i}");
                }

                Console.WriteLine("Child thread resumes!");
            } catch(ThreadAbortException ex)
            {
                Console.WriteLine($"Thread aborted: {ex.Message}");
            } finally
            {
                Console.WriteLine($"Thread ended!");
            }
        }
    }
}