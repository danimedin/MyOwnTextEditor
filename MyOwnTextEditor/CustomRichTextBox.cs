using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnTextEditor
{
    class CustomRichTextBox : System.Windows.Forms.RichTextBox

    {
        public CustomRichTextBox (int fileId) { this.FileId = fileId; }
        public int FileId { get; set; }

    }
}
