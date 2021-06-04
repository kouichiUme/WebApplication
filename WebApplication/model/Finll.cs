using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Antlr4.StringTemplate;
using Antlr4.StringTemplate.Compiler;


namespace WebApplication.model
{
    public class Finll



    {
        
        public void a()
        {
            Antlr4.StringTemplate.Template template = new Antlr4.StringTemplate.Template("hogehoge");
            template.Add("hoge", "hogehoge");


            Console.WriteLine(template);
            return;
        }
        

        
    }
}
