using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IPurchase
    {
        double Summarize();
        double Calculate();
        Product product { get; set; }
        int amount { get; set; }
    }
}
