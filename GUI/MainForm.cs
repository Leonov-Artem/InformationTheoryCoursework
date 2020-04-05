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
        const string TEXT_FOR_HUFFMAN_CODING = "often this information is the individual identification";
        const string SOURCE_HEX_MESSAGE = "89 56 9E 4A";
        const string SOURCE_GEN_POLYNOM = "x^8 + x^7 + x^3 + x^2 + 1";
        const string INPUT_ALL_DATA_MESSAGE = "Введите все необходимые данные!";
        const string ERROR_NOTIFICATION = "Ошибка";

        CyclicalRedundancyCheck _crc;

        public MainForm()
        {
            InitializeComponent();

            TextForHuffamnCoding = TEXT_FOR_HUFFMAN_CODING;
            HexMessage = SOURCE_HEX_MESSAGE;
            GeneratingPolynom = SOURCE_GEN_POLYNOM;
        }

        string TextForHuffamnCoding
        {
            get => sourceTextBox.Text;
            set => sourceTextBox.Text = value;
        }

        string Encode
        {
            get => encodedTextBox.Text;
            set => encodedTextBox.Text = value;
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

        bool HuffmanFielsNotEmpty
        {
            get => TextForHuffamnCoding != "";
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

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if (HuffmanFielsNotEmpty)
            {
                var huffman = new HuffmanCode(TextForHuffamnCoding);
                FillTable(huffman.Frequencies, huffman.CodeTable);
                Encode = huffman.Encode();
            }
            else
                MessageBox.Show(INPUT_ALL_DATA_MESSAGE, ERROR_NOTIFICATION);
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
                MessageBox.Show(INPUT_ALL_DATA_MESSAGE, ERROR_NOTIFICATION);
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
                MessageBox.Show(INPUT_ALL_DATA_MESSAGE, ERROR_NOTIFICATION);
        }

        private void FillTable(Dictionary<char, int> frequencies, Dictionary<char, string> codeTable)
        {
            var zip = frequencies.Zip(codeTable,
                                      (freq, code) => new
                                      {
                                          Symbol = freq.Key,
                                          Frequency = freq.Value,
                                          Code = codeTable[freq.Key]
                                      });

            int rowIndex = 0;
            codesDataGridView.RowCount = frequencies.Count;

            foreach (var group in zip.OrderByDescending(x => x.Frequency).GroupBy(x => x.Code.Length))
            {
                foreach (var data in group)
                {
                    codesDataGridView.Rows[rowIndex].Cells[0].Value = data.Symbol;
                    codesDataGridView.Rows[rowIndex].Cells[1].Value = data.Frequency;
                    codesDataGridView.Rows[rowIndex].Cells[2].Value = data.Code;
                    rowIndex++;
                }
            }
        }
    }
}
