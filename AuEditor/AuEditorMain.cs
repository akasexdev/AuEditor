using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AuEditor
{
    public partial class AuEditorMain : Form
    {
        private AuFile _inputFile;
        private bool _useLogarithmic = false;
        private string _effectKind = "FadeIn";

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

        private void SaveInputFile(string outputFilePath)
        {
            if (string.IsNullOrEmpty(outputFilePath))
                return;

            using (var outputStream = new FileStream(outputFilePath, FileMode.Create))
            {
                using (var writer = new AuFileWriter(outputStream))
                {
                    writer.WriteFile(_inputFile);
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
                lblCurrentEffect.Text = "None";
                lblEffectOption.Text = "Linear";
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
                lblCurrentEffect.Text = "Fade In";
                lblEffectOption.Text = "Linear";
            }

            if (_inputFile == null || !_inputFile.Header.IsValid)
            {
                btnSaveFileAs.Enabled = false;
                gbEffects.Enabled = false;
                gbEffectOptions.Enabled = false;
                btnApplyEffect.Enabled = false;
                btnPlayAudio.Enabled = false;
            }
            else
            {
                btnSaveFileAs.Enabled = true;
                gbEffects.Enabled = true;
                gbEffectOptions.Enabled = true;
                btnApplyEffect.Enabled = true;
                btnPlayAudio.Enabled = true;
                nuStart.Maximum = (decimal) _inputFile.Header.Duration;
                nuDuration.Maximum = (decimal)_inputFile.Header.Duration;
            }
            
            rbFadeIn.Checked = true;
            rbLinear.Checked = true;
            nuStart.Value = 0;
            nuDuration.Value = 1;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Not Applied";

            pnlWave.Refresh();
        }

        private void btnOpenFile_Click(object sender, System.EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Multiselect = false;
                dlg.Filter = "AU File (*.au)|*.au";
                dlg.Title = "Open File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadInputFile(dlg.FileName);
                    ShowInputFileInfo();
                }
            }
        }

        private void btnSaveFileAs_Click(object sender, System.EventArgs e)
        {
            if (_inputFile != null && _inputFile.Header.IsValid)
            {
                using (var dlg = new SaveFileDialog())
                {
                    dlg.Filter = "AU File (*.au)|*.au";
                    dlg.Title = "Save File";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        SaveInputFile(dlg.FileName);
                    }
                }
            }
        }

        private void pnlWave_Paint(object sender, PaintEventArgs e)
        {
            AuFileRenderer.Render(pnlWave.Width, pnlWave.Height, _inputFile, e.Graphics);
        }

        private void rbFadeIn_CheckedChanged(object sender, System.EventArgs e)
        {
            _effectKind = "FadeIn";
            nuStart.Value = 0;
            nuDuration.Value = 1;
            lblCurrentEffect.Text = "Fade In";
        }

        private void rbFadeOut_CheckedChanged(object sender, System.EventArgs e)
        {
            _effectKind = "FadeOut";
            nuStart.Value = 0;
            nuDuration.Value = 1;
            lblCurrentEffect.Text = "Fade Out";
        }

        private void rbCrossFade_CheckedChanged(object sender, System.EventArgs e)
        {
            _effectKind = "CrossFade";
            nuStart.Value = 0;
            nuDuration.Value = 1;
            lblCurrentEffect.Text = "CrossFade";
        }

        private void rbLinear_CheckedChanged(object sender, System.EventArgs e)
        {
            _useLogarithmic = false;
            lblEffectOption.Text = "Linear";
        }

        private void rbLogarithmic_CheckedChanged(object sender, System.EventArgs e)
        {
            _useLogarithmic = true;
            lblEffectOption.Text = "Logarithmic";
        }

        private void btnApplyEffect_Click(object sender, System.EventArgs e)
        {
            var startPosition = (float) nuStart.Value;
            var duration = (float) nuDuration.Value;

            if (startPosition + duration > _inputFile.Header.Duration)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Length of the effect is bigger than the file duration. Please, validate Start Time and Duration parameters.";
                return;
            }

            var result = false;
            if (_effectKind == "FadeIn")
            {
                if (_useLogarithmic)
                    result = AudioHelper.FadeIn(_inputFile, AudioHelper.GetLogarithmicValue,
                        startPosition, duration);
                else
                    result = AudioHelper.FadeIn(_inputFile, AudioHelper.GetLinearValue,
                        startPosition, duration);
            }
            else if (_effectKind == "FadeOut")
            {
                if (_useLogarithmic)
                    result = AudioHelper.FadeOut(_inputFile, AudioHelper.GetLogarithmicValue,
                        startPosition, duration);
                else
                    result = AudioHelper.FadeOut(_inputFile, AudioHelper.GetLinearValue,
                        startPosition, duration);
            }
            else if (_effectKind == "CrossFade")
            {
                if (_useLogarithmic)
                    result = AudioHelper.CrossFade(_inputFile, AudioHelper.GetLogarithmicValue,
                        startPosition, duration);
                else
                    result = AudioHelper.CrossFade(_inputFile, AudioHelper.GetLinearValue,
                        startPosition, duration);
            }

            if (result)
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = string.Format("{0} Effect was applied", _effectKind);
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = string.Format("Failed to apply {0} Effect", _effectKind);
            }

            pnlWave.Refresh();
        }

        private void btnSetMaxDuration_Click(object sender, System.EventArgs e)
        {
            if (_inputFile == null || !_inputFile.Header.IsValid)
                return;

            nuDuration.Value = (decimal)(_inputFile.Header.Duration - ((float) nuStart.Value));
        }

        private void btnPlayAudio_Click(object sender, System.EventArgs e)
        {

        }
    }
}
