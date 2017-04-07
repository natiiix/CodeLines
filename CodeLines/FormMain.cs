using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace CodeLines
{
    public partial class FormMain : Form
    {
        const int FORM_HEIGHT = 315;
        const int TEXTBOX_HEIGHT_OFFSET = 181;

        private LineCounter[] counters;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openFileDialogSelect.ShowDialog();
        }

        private void openFileDialogSelect_FileOk(object sender, CancelEventArgs e)
        {
            countLines(openFileDialogSelect.FileName.Substring(0, openFileDialogSelect.FileName.LastIndexOf('\\')));
        }

        private void countLines(string path)
        {
            counters = new LineCounter[]
            {
                new LineCounter("c"),
                new LineCounter("h"),
                new LineCounter("cpp"),
                new LineCounter("hpp"),
                new LineCounter("sh"),
                new LineCounter("asm"),
                new LineCounter("py"),
            };

            processDirectory(path);

            string outputstr = string.Empty;

            for (int i = 0; i < counters.Length; i++)
            {
                if (i > 0)
                {
                    outputstr += Environment.NewLine;
                }

                outputstr += counters[i].ToString();
            }

            textBoxLineCounts.Text = outputstr;

            Height = FORM_HEIGHT;
            textBoxLineCounts.Height = Height - TEXTBOX_HEIGHT_OFFSET;
        }

        private void processDirectory(string path)
        {
            string[] subdirs = Directory.GetDirectories(path);

            for (int i = 0; i < subdirs.Length; i++)
            {
                processDirectory(subdirs[i]);
            }

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                processFile(files[i]);
            }
        }

        private void processFile(string path)
        {
            string ext = path.Substring(path.LastIndexOf('.') + 1);
            int lines = File.ReadAllLines(path).Length;

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i].AddIfMatch(ext, lines);
            }
        }
    }

    public class LineCounter
    {
        private string m_extension;
        private long m_count;

        public LineCounter(string ext)
        {
            m_extension = ext;
            m_count = 0;
        }

        public void AddIfMatch(string ext, long lines)
        {
            if (ext == m_extension)
            {
                m_count += lines;
            }
        }

        public override string ToString()
        {
            return m_extension.PadRight(4, ' ') + " - " + m_count.ToString().PadLeft(6, ' ');
        }
    }
}
