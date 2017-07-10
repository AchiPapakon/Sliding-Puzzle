using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Sliding_Puzzle
{
    public partial class frmHighScores : Form
    {
        private int highScoreEntries = 5;
        private int backboardDifferentSizes = 6;
        // How can I do some proper unit testing for this class (frmHighScores)?
        //private int backboardSize = 5; // test
        private int backboardSize;
        //private string txtTimeText = "00:00:04"; // test
        private string txtTimeText;
        List<DataGridView> gridArray = new List<DataGridView>();

        public frmHighScores(int in_backboardSize)
        {
            this.backboardSize = in_backboardSize;
        }

        public frmHighScores(int in_backboardSize, string in_txtTimeText) : this(in_backboardSize)
        {
            this.txtTimeText = in_txtTimeText;
        }

        public frmHighScores()
        {
            InitializeComponent();
            
            for (int i = 0; i < backboardDifferentSizes; i++)
            {
                int num = i + 2;
                string elementName = "grid" + num + "x" + num;
                //gridArray.Add(this.Controls.Find(elementName, true));

                // getElementById:
                gridArray.Add(this.Controls.Find(elementName, true).FirstOrDefault() as DataGridView);
                records.Add(new Records());

                //TextBox tbx = this.Controls.Find("textBox1", true).FirstOrDefault() as TextBox;
                //tbx.Text = "found!";

                //Control[] tbxs = this.Controls.Find(txtbox_and_message[0, 0], true);
                //if (tbxs != null && tbxs.Length > 0)
                //{
                //    tbxs[0].Text = "Found!";
                //}
            }

            foreach (var item in gridArray)
            {
                item.BackgroundColor = this.BackColor;
            }
            //grid2x2.BackgroundColor = this.BackColor; // cleanup before merge
        }

        private void High_Scores_Load(object sender, EventArgs e)
        {
            Records.PotentialTime = txtTimeText;
            if (Records.PotentialTime != null /*redundant ?*/) 
            {
                int timeInSeconds = timeToMilliseconds(Records.PotentialTime);
                if (readHighScores()) // false if the data.xml doesn't exist
                {
                    searchHighScoresAndReplace(timeInSeconds, records[backboardSize-2].playersList, records[backboardSize-2].timeList);
                }
                else
                {
                    justAddHighScore(timeInSeconds, records[backboardSize-2].playersList, records[backboardSize-2].timeList);
                }

                saveXML();
            }
            else
            {
                readHighScores();
            }

            populateList();
        }

        string xmlPath = System.IO.Path.Combine(Environment.CurrentDirectory, "data.xml");

        private List<Records> records = new List<Records>(); // 3 + 3 = 6. Ignore 0 and 1, so 6+2=8

        private class Records
        {
            public static string PotentialTime { get; set; }
            public static string NewPlayerName { get; set; }
            public List<string> playersList = new List<string>();
            public List<int> timeList = new List<int>();

            // Can I destroy all the instances of PotentionTime and NewPlayerName?
            public void Clear()
            {
                playersList.Clear();
                timeList.Clear();
            }
        }

        private bool searchHighScoresAndReplace(int m_timeInSeconds, List<string> m_playersList, List<int> m_timeList)
        {
            // Searches the High Score array and inserts (or not) the new value.
            for (int i = 0; i < m_timeList.Count; i++)
            {
                // Condition A: m_timeList[i] == -1
                // Condition B: m_timeInSeconds < m_timeList[i]
                // (Algebra Boole) Code_Section_C = A + A'*B
                bool A = m_timeList[i] == -1;
                bool B = m_timeInSeconds < m_timeList[i];
                if (A || (!A && B))
                {
                    // time list:
                    m_timeList.Insert(i, m_timeInSeconds);
                    m_timeList.RemoveAt(highScoreEntries);

                    // player list:
                    frmEnterPlayerName enterPlayerName = new frmEnterPlayerName();
                    enterPlayerName.ShowDialog();
                    m_playersList.Insert(i, enterPlayerName.GetPlayerName());
                    m_playersList.RemoveAt(highScoreEntries);
                    return true;
                }
            }
            return false;
        }

        private void justAddHighScore(int m_timeInSeconds, List<string> m_playersList, List<int> m_timeList)
        {
            m_timeList.Add(m_timeInSeconds);
            frmEnterPlayerName enterPlayerName = new frmEnterPlayerName();
            enterPlayerName.ShowDialog();
            m_playersList.Add(enterPlayerName.GetPlayerName());
        }

        private bool readHighScores()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlPath);
            }
            catch (IOException e)
            {
                // Cannot read from file. (File not found)
                //MessageBox.Show(e.ToString());
                return false;
            }
            catch (XmlException e)
            {
                // Error reading the xml file
                //MessageBox.Show(e.ToString());
                File.Delete(xmlPath);
                return false;
            }

            try
            {
                foreach (XmlElement item in doc.DocumentElement.ChildNodes)
                {
                    //item.GetAttribute("size");
                    //MessageBox.Show(item.GetAttribute("size"));
                    int size = Convert.ToInt32(item.GetAttribute("size"));

                    foreach (XmlElement record in item.ChildNodes)
                    {
                        // Fix: This can be done using constructor!
                        records[size - 2].playersList.Add(record.Attributes["playername"].Value);
                        records[size - 2].timeList.Add(timeToMilliseconds(record.Attributes["time"].Value));
                    }
                }

                //foreach (XmlNode record in doc.DocumentElement.ChildNodes[0].ChildNodes)
                //{
                //    records.playersList.Add(record.Attributes["playername"].Value);
                //    records.timeList.Add(timeToMilliseconds(record.Attributes["time"].Value));
                //}
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                // Corrupted data in the xml file.
                System.IO.File.Delete(xmlPath);
                records.Clear();
                return false;
            }

            // Robustness:
            foreach (var item in records)
            {
                var playersListCount = item.playersList.Count;
                if (playersListCount < highScoreEntries)
                {
                    for (int i = playersListCount; i < highScoreEntries; i++)
                    {
                        item.playersList.Add(null);
                        item.timeList.Add(-1);
                    }
                }
                else if (playersListCount > highScoreEntries)
                {
                    item.playersList.RemoveRange(highScoreEntries, playersListCount - highScoreEntries);
                    item.timeList.RemoveRange(highScoreEntries, playersListCount - highScoreEntries);
                }
            }
            return true;
        }

        private int timeToMilliseconds(string time)
        {
            string[] timeList = time.Split(':');
            var timespan = new TimeSpan(Convert.ToInt32(timeList[0]), Convert.ToInt32(timeList[1]), Convert.ToInt32(timeList[2]));
            return Convert.ToInt32(timespan.TotalMilliseconds);
        }

        private string millisecondsToTime(int ms)
        {
            double seconds = Math.Round(ms / 1000.0);
            double minutes = Math.Floor(seconds / 60);
            seconds %= 60;
            double hours = Math.Floor(minutes / 60);
            minutes %= 60;

            string text = (hours < 10) ? "0" + hours.ToString() : hours.ToString();
            text += (minutes < 10) ? ":0" + minutes.ToString() : ":" + minutes.ToString();
            text += (seconds < 10) ? ":0" + seconds.ToString() : ":" + seconds.ToString();
            return text;
        }

        private void saveXML()
        {
            // Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<HighScores></HighScores>");

            for (int i = 0; i < records.Count; i++)
            {
                XmlElement highScoreCount = doc.CreateElement("HighScoreRecords");
                highScoreCount.SetAttribute("size", (i + 2).ToString());
                doc.DocumentElement.AppendChild(highScoreCount);

                for (int j = 0; j < records[i].playersList.Count; j++)
                {
                    if (records[i].playersList[j] != null)
                    {
                        XmlElement element = doc.CreateElement("Record");
                        element.SetAttribute("playername", records[i].playersList[j]);
                        element.SetAttribute("time", millisecondsToTime(records[i].timeList[j]));
                        doc.DocumentElement.ChildNodes[i].AppendChild(element);
                    }
                }
            }

            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                // Save the document to a file and auto-indent the output.
                using (XmlWriter writer = XmlWriter.Create(xmlPath, settings))
                {
                    doc.Save(writer);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        interface xmlReadWrite
        {
            int[] ReadHighScores();
        }

        private void populateList()
        {
            for (int i = 0; i < backboardDifferentSizes; i++)
            {
                // I have created an empty list called 'items' which is the data source.
                var items = new[] { new { Player = "one", Time = "ONE" } }.ToList();
                items.Remove(items[0]); // Now it's empty!

                try
                {
                    if (records.Count != 0) // (if the High Scores have just been reset)
                    {
                        for (int j = 0; j < records[i].playersList.Count; j++)
                        {
                            if (records[i].playersList[j] == null)
                            {
                                break;
                            }
                            else
                            {
                                items.Add(new { Player = records[i].playersList[j], Time = millisecondsToTime(records[i].timeList[j]) });
                            }
                        }
                    }

                    var source = new BindingSource();
                    source.DataSource = items;
                    gridArray[i].DataSource = source;

                    if (gridArray[i].RowCount != 0)
                        gridArray[i].Rows[0].Cells[0].Selected = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(xmlPath);
            records.Clear();
            populateList();
            //grid2x2.Refresh();
        }
    }
}
