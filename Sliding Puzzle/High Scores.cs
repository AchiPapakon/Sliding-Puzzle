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
        public frmHighScores()
        {
            InitializeComponent();
        }

        private void High_Scores_Load(object sender, EventArgs e)
        {
            if (records.PotentialTime != null)
            {
                int timeInSeconds = timeToMilliseconds(records.PotentialTime);
                if (readHighScores()) // false if the data.xml doesn't exist
                {
                    searchHighScoresAndReplace(timeInSeconds, records.playersList, records.timeList);
                }
                else
                {
                    justAddHighScore(timeInSeconds, records.playersList, records.timeList);
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

        public Records records = new Records();

        public class Records
        {
            public List<string> playersList = new List<string>();
            public List<int> timeList = new List<int>();
            public string PotentialTime { get; set; }
            public string NewPlayerName { get; set; }
            
            public void Clear()
            {
                playersList.Clear();
                timeList.Clear();
            }
        }

        int highScoreEntries = 5;

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
                foreach (XmlNode record in doc.DocumentElement.ChildNodes[0].ChildNodes)
                {
                    records.playersList.Add(record.Attributes["playername"].Value);
                    records.timeList.Add(timeToMilliseconds(record.Attributes["time"].Value));
                }
            }
            catch //(Exception)
            {
                // Corrupted data in the xml file.
                System.IO.File.Delete(xmlPath);
                records.Clear();
                return false;
            }

            // Robustness:
            var playersListCount = records.playersList.Count;
            if (playersListCount < highScoreEntries)
            {
                for (int i = playersListCount; i < highScoreEntries; i++)
                {
                    records.playersList.Add(null);
                    records.timeList.Add(-1);
                }
            }
            else if (playersListCount > highScoreEntries)
            {
                records.playersList.RemoveRange(highScoreEntries, playersListCount - highScoreEntries);
                records.timeList.RemoveRange(highScoreEntries, playersListCount - highScoreEntries);
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

            XmlElement highScoreCount = doc.CreateElement("HighScoreRecords");
            highScoreCount.SetAttribute("count", "5"); // The '5' value is decorative.
            doc.DocumentElement.AppendChild(highScoreCount);

            for (int i = 0; i < records.playersList.Count; i++)
            {
                if (records.playersList[i] != null)
                {
                    XmlElement element = doc.CreateElement("Record");
                    element.SetAttribute("playername", records.playersList[i]);
                    element.SetAttribute("time", millisecondsToTime(records.timeList[i]));
                    doc.DocumentElement.ChildNodes[0].AppendChild(element);
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
            // I have created an empty list called 'items' which is the data source.
            var items = new[] { new { Player = "one", Time = "ONE" } }.ToList();
            items.Remove(items[0]);

            try
            {
                for (int i = 0; i < records.playersList.Count; i++)
                {
                    if (records.playersList[i] == null)
                    {
                        break;
                    }
                    items.Add(new { Player = records.playersList[i], Time = millisecondsToTime(records.timeList[i]) });
                }

                var source = new BindingSource();
                source.DataSource = items;
                gridHighScores.DataSource = source;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(xmlPath);
            records.Clear();
            populateList();
            //gridHighScores.Refresh();
        }
    }
}
