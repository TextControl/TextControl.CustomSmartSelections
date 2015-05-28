using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tx_sample_selectdecimalnumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textControl1_DoubleClick(object sender, EventArgs e)
        {
            string sLineText = String.Empty; // the text of the current line
            int iLineStartPosition; // the start index of the durrent line
            int iInputPosition; // the input position in the current line

            // the current line
            TXTextControl.Line lineCurrent = textControl1.Lines.GetItem(
                textControl1.InputPosition.TextPosition);

            sLineText = lineCurrent.Text;
            iLineStartPosition = lineCurrent.Start;

            iInputPosition = textControl1.Selection.Start
                - iLineStartPosition + 1;

            if (iInputPosition < 0) // nothing selected?
                return;

            // check the next space backwards
            int iStart = sLineText.Substring(0, iInputPosition).LastIndexOf(" ");
            int iLength = 0;

            // check the next space forwards
            int iNextSpacePosition = 
                sLineText.Substring(
                    iInputPosition,
                    sLineText.Length - iInputPosition).IndexOf(" ");

            // specialties when string is at first or last position in line
            if (iNextSpacePosition != -1)
                iLength = iNextSpacePosition + (iInputPosition - iStart) - 1;
            else
            {
                iLength = textControl1.Lines.GetItem(
                    textControl1.InputPosition.TextPosition).Length - 
                    iStart - 1;
            }

            // select the new string
            textControl1.Select(iLineStartPosition + iStart, iLength);
        }
    }
}
