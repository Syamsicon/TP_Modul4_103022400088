// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    public string getKodePos(string kelurahan)
    {
        Dictionary<string, string> table = new Dictionary<string, string> { };
        table.Add("Batununggal", "40266");
        table.Add("Kujangsari", "40287");
        table.Add("Mengger", "40267");
        table.Add("Wates", "40256");
        table.Add("Cijaura", "40287");
        table.Add("Jatisari", "40286");
        table.Add("Margasari", "40266");
        table.Add("Sekejati", "40266");
        table.Add("Kebonwaru", "40272");
        table.Add("Maleer", "40274");

        return table[kelurahan];
    }
}

class program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        Console.WriteLine("Batununggal : " + kp.getKodePos("Batununggal"));
        Console.WriteLine("Kujangsari : " + kp.getKodePos("Kujangsari"));
        Console.WriteLine("Mengger : " + kp.getKodePos("Mengger"));
        Console.WriteLine("Wates : " + kp.getKodePos("Wates"));
        Console.WriteLine("Cijaura : " + kp.getKodePos("Cijaura"));
        Console.WriteLine("Jatisari : " + kp.getKodePos("Jatisari"));
        Console.WriteLine("Margasari : " + kp.getKodePos("Margasari"));
        Console.WriteLine("Sekejati : " + kp.getKodePos("Sekejati"));
        Console.WriteLine("Kebonwaru : " + kp.getKodePos("Kebonwaru"));
        Console.WriteLine("Maleer : " + kp.getKodePos("Maleer"));
    }
}