using Sorteio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorteio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Participante> list = new List<Participante>();

            list.Add(new Participante(100, "Freedy Carvalho"));
            list.Add(new Participante(200, "Raphael Carvalho"));
            list.Add(new Participante(300, "Bruno Carvalho"));
            list.Add(new Participante(400, "Francis Carvalho"));
            list.Add(new Participante(500, "Vanessa Moro"));
            list.Add(new Participante(600, "Eliane Martins"));


            //var sorteado = list.OrderBy(x=> x.Nome).Select(x => x.Nome).Take(1);
            var sorteado = list.OrderBy(n => Guid.NewGuid()).Take(2).Select(n => n.Nome);

            foreach (string item in sorteado)
            {
                Console.WriteLine(item);

            }
        }
    }
}
