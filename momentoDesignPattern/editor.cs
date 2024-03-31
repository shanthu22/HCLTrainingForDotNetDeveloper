using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace momentoDesignPattern
{
    internal class editor
    {
        private String content;
        public EditorState createState() {
            return new EditorState(content);
        }

        public void restore(EditorState state) { 
        content = state.getContent();
        }
        public String getContent() { 
        return content;
        }
        public void setContent(String content)
        {
            this.content = content;
        }
    
    }
}
