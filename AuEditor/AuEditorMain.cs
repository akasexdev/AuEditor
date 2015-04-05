using System.Drawing;
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

            ShowInputFileInfo();
        }

        private void LoadInputFile(string inputFilePath)
        {
            if (string.IsNullOrEmpty(inputFilePath)) 
                return;

            _inputFile = null;
            using (var inputStream = new FileStream(inputFilePath, FileMode.Open))
            {
                using (var reader = new AuFileReader(inputStream))
                {
                    _inputFile = reader.ReadFile();
                    _inputFile.FilePath = inputFilePath;
                }
            }
        }

        private void ShowInputFileInfo()
        {
            if (_inputFile == null)
            {
                gbFileInfo.Text = "File Info";
                lblCurrentFile.Text = "None";
                lblMagicNumber.Text = "0";
                lblHeaderSize.Text = "0";
                lblDataSize.Text = "0";
                lblEncoding.Text = "None";
                lblSampleRate.Text = "0";
                lblChannels.Text = "0";
                lblBytesPerSample.Text = "0";
                lblSamplesPerChannel.Text = "0";
                lblDuration.Text = "0";
                lblIsValid.Text = "False";
                lblIsValid.ForeColor = Color.Red;
            }
            else
            {
                gbFileInfo.Text = string.Format("File Info: {0}", 
                    Path.GetFileName(_inputFile.FilePath));
                lblCurrentFile.Text = _inputFile.FilePath;
                lblMagicNumber.Text = _inputFile.Header.MagicNumber.ToString();
                lblHeaderSize.Text = _inputFile.Header.HeaderSize.ToString();
                lblDataSize.Text = _inputFile.Header.DataSize.ToString();
                lblEncoding.Text = _inputFile.Header.Encoding.ToString();
                lblSampleRate.Text = _inputFile.Header.SampleRate.ToString();
                lblChannels.Text = _inputFile.Header.Channels.ToString();
                lblBytesPerSample.Text = _inputFile.Header.BytesPerSample.ToString();
                lblSamplesPerChannel.Text = _inputFile.Header.SamplesPerChannel.ToString();
                lblDuration.Text = _inputFile.Header.Duration.ToString();
                lblIsValid.Text = _inputFile.Header.IsValid.ToString();
                lblIsValid.ForeColor = _inputFile.Header.IsValid ? Color.Green : Color.Red;
            }
        }

        private void btnOpenFile_Click(object sender, System.EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Multiselect = false;
                dlg.Filter = "AU File (*.au)|*.au";
                dlg.Title = "Select Input file";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadInputFile(dlg.FileName);
                    ShowInputFileInfo();
                }
            }
        }
    }
}
