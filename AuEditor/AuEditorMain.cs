using System.IO;
using System.Windows.Forms;

namespace AuEditor
{
    public partial class AuEditorMain : Form
    {
        private AuFile _inputFile;

        public AuEditorMain()
        {
            InitializeComponent();
        }

        public void LoadInputFile(string inputFilePath)
        {
            if (string.IsNullOrEmpty(inputFilePath)) 
                return;

            _inputFile = null;
            using (var inputStream = new FileStream(inputFilePath, FileMode.Open))
            {
                using (var reader = new AuFileReader(inputStream))
                {
                    _inputFile = reader.ReadFile();
                }
            }
        }
    }
}
