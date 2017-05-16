using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnTextEditor
{
    class CustomRichTextBox : System.Windows.Forms.RichTextBox

    {
        public CustomRichTextBox (Model.Content content) { this.Content = content; }
        public Model.Content Content { get; set; }

    }
}
