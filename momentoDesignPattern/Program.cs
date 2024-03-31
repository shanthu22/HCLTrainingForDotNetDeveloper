using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace momentoDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


class EditorState {
    private  String content;
    public EditorState(String content) {
        this.content = content;

    }
   
    public String getContent() { 
        return content;
    }
}