using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacePlagIn;
using System.Windows.Forms;

namespace txt_plagin
{
    [PlagInInfoAttribute(PlagInName = "Text file viewer",
    FileFormat = ".txt")]
    public class CSharpModule : IAppFunctionality
    {
        public void IncludeIt()
        {
            MessageBox.Show("You have just included PlagIn!");
        }
        public void OpenFile(string fileName)
        {
        }
    }
}