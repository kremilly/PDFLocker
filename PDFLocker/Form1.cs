using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;
using System.Diagnostics;

namespace PDFLocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "";

            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Select PDF";
            openDlg.FilterIndex = 2;
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "PDF Document (.pdf)|*.pdf";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                pathTxt.Text = openDlg.FileName;
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (passTxt.UseSystemPasswordChar)
            {
                passTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passTxt.UseSystemPasswordChar = true;
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            string validChars = "abcdefghijklmnopqrstuvwxyz";

            if (allowUpperCheck.Checked)
            {
                validChars += "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            }

            if (allowNumbersCheck.Checked)
            {
                validChars += "0123456789";
            }

            if (allowSymbolsCheck.Checked)
            {
                validChars += "!@#$%^&*?_+-<>()[]{}";
            }

            Random random = new Random();
            char[] chars = new char[Convert.ToInt32(passSize.Value)];

            for (int i = 0; i < Convert.ToInt32(passSize.Value); i++)
            {
                chars[i] = validChars[
                    random.Next(
                        0, validChars.Length
                    )
                ];
            }

            passTxt.Text = new string(chars);
        }

        private void genPass_CheckedChanged(object sender, EventArgs e)
        {
            if (genPass.Checked)
            {
                passGenGroup.Visible = true;
            }
            else
            {
                passGenGroup.Visible = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pathTxt.Text == "" || passTxt.Text == "" || outputFileTxt.Text == "")
            {
                protectBtn.Enabled = false;
                statusLbl.Text = "";
            }
            else
            {
                protectBtn.Enabled = true;
            }

        }

        private void protectBtn_Click(object sender, EventArgs e)
        {
            PdfDocument document = PdfReader.Open(pathTxt.Text, PdfDocumentOpenMode.Modify);
            PdfSecuritySettings securitySettings = document.SecuritySettings;

            securitySettings.UserPassword = passTxt.Text;
            securitySettings.OwnerPassword = passTxt.Text;

            if (permitAcessibilityExtractContent.Checked)
            {
                securitySettings.PermitAccessibilityExtractContent = true;
            }
            else
            {
                securitySettings.PermitAccessibilityExtractContent = false;
            }

            if (permitAnnotations.Checked)
            {
                securitySettings.PermitAnnotations = true;
            }
            else
            {
                securitySettings.PermitAnnotations = false;
            }

            if (permitAssembleDocument.Checked)
            {
                securitySettings.PermitAssembleDocument = true;
            }
            else
            {
                securitySettings.PermitAssembleDocument = false;
            }

            if (permitExtractContent.Checked)
            {
                securitySettings.PermitExtractContent = true;
            }
            else
            {
                securitySettings.PermitExtractContent = false;
            }

            if (permitFormsFill.Checked)
            {
                securitySettings.PermitFormsFill = true;
            }
            else
            {
                securitySettings.PermitFormsFill = false;
            }

            if (permitFullQualityPrint.Checked)
            {
                securitySettings.PermitFullQualityPrint = true;
            }
            else
            {
                securitySettings.PermitFullQualityPrint = false;
            }

            if (permitModifyDocument.Checked)
            {
                securitySettings.PermitModifyDocument = true;
            }
            else
            {
                securitySettings.PermitModifyDocument = false;
            }

            if (permitPrintDocument.Checked)
            {
                securitySettings.PermitPrint = true;
            }
            else
            {
                securitySettings.PermitPrint = false;
            }

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            document.Save(outputFileTxt.Text);

            statusLbl.Text = "Output saved with successfully";

            if (deleteOriginalFile.Checked)
            {
                File.Delete(pathTxt.Text);
                pathTxt.Text = "";
            }

            if (openOutputFile.Checked)
            {
                Process.Start("explorer", outputFileTxt.Text);
            }
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = "Save PDF Protected";
            saveDlg.FilterIndex = 2;
            saveDlg.RestoreDirectory = true;
            saveDlg.Filter = "PDF Document (.pdf)|*.pdf";

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                outputFileTxt.Text = saveDlg.FileName;
            }
        }

        private void selectAllPermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            permitAnnotations.Checked = true;
            permitFormsFill.Checked = true;
            permitFullQualityPrint.Checked = true;
            permitModifyDocument.Checked = true;
            permitExtractContent.Checked = true;
            permitPrintDocument.Checked = true;
            permitAssembleDocument.Checked = true;
            permitAcessibilityExtractContent.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void creditsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "https://github.com/kremilly/PDFLocker");
        }
    }
}