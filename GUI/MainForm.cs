using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.CRC;
using Algorithms.Huffman;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        const string SOURCE_HEX_MESSAGE = "89 56 9E 4A";
        const string SOURCE_GEN_POLYNOM = "x^8 + x^7 + x^3 + x^2 + 1";
        const string ERROR_NOTIFICATION = "Ошибка";

        CyclicalRedundancyCheck _crc;

        public MainForm()
        {
            InitializeComponent();

            HexMessage = SOURCE_HEX_MESSAGE;
            GeneratingPolynom = SOURCE_GEN_POLYNOM;
        }

        string HexMessage
        {
            get => hexMessageTextBox.Text;
            set => hexMessageTextBox.Text = value;
        }

        string GeneratingPolynom
        {
            get => generatingPolynomTextBox.Text;
            set => generatingPolynomTextBox.Text = value;
        }

        string BitString
        {
            get => bitStringTextBox.Text;
            set => bitStringTextBox.Text = value;
        }

        string BitGeneratingPolynom
        {
            get => bitGenPolyTextBox.Text;
            set => bitGenPolyTextBox.Text = value;
        }

        string CrcResult
        {
            get => CrcTextBox.Text;
            set => CrcTextBox.Text = value;
        }

        bool CrcFieldsNotEmpty
        {
            get => HexMessage != "" && GeneratingPolynom != "";
        }

        bool LabelsForCopyingNotEmpty
        {
            get => bitStringLabel.Text != "0" &&
                   bitGenPolynomLabel.Text != "0" &&
                   crcResultLabel.Text != "0";
        }

        bool ChecksumFieldsNotEmpty
        {
            get => BitString != "" &&
                   CrcResult != "" &&
                   BitGeneratingPolynom != "";
        }

        private void ComputeCRCButton_Click(object sender, EventArgs e)
        {
            if (CrcFieldsNotEmpty)
            {
                _crc = new CyclicalRedundancyCheck(HexMessage, GeneratingPolynom);
                bitStringLabel.Text = _crc.BinaryText;
                bitGenPolynomLabel.Text = _crc.GeneratingPolynom;
                crcResultLabel.Text = _crc.Compute();
            }
            else
                MessageBox.Show("Введите все необходимые данные!", ERROR_NOTIFICATION);
        }

        private void CopyDataButton_Click(object sender, EventArgs e)
        {
            if (LabelsForCopyingNotEmpty)
            {
                BitString = _crc.BinaryText;
                BitGeneratingPolynom = _crc.GeneratingPolynom;
                CrcResult = crcResultLabel.Text;
            }
            else
                MessageBox.Show("Поля пусты!", ERROR_NOTIFICATION);
        }

        private void ComputeRemainderButton_Click(object sender, EventArgs e)
        {
            if (ChecksumFieldsNotEmpty)
            {
                var dataIntegrity = new CyclicalRedundancyCheck();
                var res = dataIntegrity.CheckMessageIntegrity(BitString + CrcResult, BitGeneratingPolynom);
                remainderLabel.Text = res;
            }
            else
                MessageBox.Show("Введите все необходимые данные!", ERROR_NOTIFICATION);
        }
    }
}
