using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnTextEditor.Model
{
    class Content
    {
        private string fileName;
        private bool dirtyBit;

        public Content()
        {
            this.FileName = String.Empty;
            this.DirtyBit = false;
        }
        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        } 

        public bool DirtyBit
        {
            get { return this.dirtyBit; }
            set { this.dirtyBit = value;  }
        }

        public void onDirtyBit()
        {
            this.DirtyBit = true;
        }
        public void offDirtyBit()
        {
            this.DirtyBit = false;
        }

    }
}
