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

            Template template = new Template("hogehoge <hoge>!");
            template.Add("hoge", "hogehoge");



            Console.WriteLine(template.Render());
            return;
        }
        

        
    }
}
