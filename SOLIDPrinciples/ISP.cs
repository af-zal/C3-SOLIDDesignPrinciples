using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class ISP
    {
    }

    //public interface IPrinterTasks
    //{
    //    void Print(string PrintContent);
    //    void Scan(string ScanContent);
    //    void Fax(string FaxContent);
    //    void PrintDuplex(string PrintDuplexContent);
    //}

    //public class HPLaserJetPrinter : IPrinterTasks
    //{
    //    public void Print(string PrintContent)
    //    {
    //        Console.WriteLine("Print Done");
    //    }
    //    public void Scan(string ScanContent)
    //    {
    //        Console.WriteLine("Scan content");
    //    }
    //    public void Fax(string FaxContent)
    //    {
    //        Console.WriteLine("Fax content");
    //    }
    //    public void PrintDuplex(string PrintDuplexContent)
    //    {
    //        Console.WriteLine("Print Duplex content");
    //    }
    //}

    //class LiquidInkjetPrinter : IPrinterTasks
    //{
    //    public void Print(string PrintContent)
    //    {
    //        Console.WriteLine("Print Done");
    //    }
    //    public void Scan(string ScanContent)
    //    {
    //        Console.WriteLine("Scan content");
    //    }

    //    //Not needed
    //    //Solution - deviding interface into diff. parts
    //    public void Fax(string FaxContent)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public void PrintDuplex(string PrintDuplexContent)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    public interface IPrinterCommonOperation
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }

    public interface IFaxOperation
    {
        void Fax(string FaxContent);
    }
    public interface IPrintDuplex
    {
        void PrintDuplex(string PrintDuplexContent);
    }


    public class HPLaserJetPrinter : IPrinterCommonOperation, IFaxOperation, IPrintDuplex
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }

    class LiquidInkjetPrinter : IPrinterCommonOperation
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
