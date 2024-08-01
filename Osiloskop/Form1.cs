using System.IO.Ports;

namespace Osiloskop
{
    public partial class Form1 : Form
    {
        private enum State
        {
            PAUSE,
            CONTINUE
        }
        private SerialPort serial;
        private List<int> points = new List<int>();
        private int lenght = 58;
        State state = State.CONTINUE;

        public Form1()
        {
            InitializeComponent();
            table.Dock = DockStyle.Fill;
            table.Paint += new PaintEventHandler(tablePaint);
        }

        private void tablePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (points.Count > 1)
            {
                Pen pen = new Pen(Color.Tomato, 4);
                for (int i = 0; i < points.Count - 1; i++)
                {
                    int x1 = i * 20 + 10;
                    int y1 = points[i] * 2 + 10;
                    int x2 = i * 20 + 30;
                    int y2 = points[i + 1] * 2 + 10;

                    g.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial = new SerialPort();
            String[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                portsBox.Items.Add(port);
            }
            if (portsBox.Items.Count > 0)
            {
                portsBox.SelectedIndex = 0;
            }
            serial.BaudRate = 9600;
            serial.Parity = Parity.None;
            serial.StopBits = StopBits.One;
            serial.DataBits = 8;
            serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serial.ReadLine().Trim();
            int data = int.Parse(str);
            resultBox.Text = data.ToString();
            data = 255 - data;
            if (points.Count > lenght)
            {
                points.RemoveAt(0);
            }
            points.Add(data);

            table.Invalidate();
            if (state == State.CONTINUE)
            {
                serial.WriteLine("continue");
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            serial.PortName = portsBox.Text;
            try
            {
                serial.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Baðlanamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            connectBtn.Enabled = false;
            disconnectBtn.Enabled = true;
            pauseBtn.Enabled = true;
            continueBtn.Enabled = true;
            resetBtn.Enabled = true;
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            serial.Close();
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
            pauseBtn.Enabled = false;
            continueBtn.Enabled = false;
            resetBtn.Enabled = false;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            state = State.PAUSE;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            state = State.CONTINUE;
            serial.WriteLine("continue");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            state = State.PAUSE;
            points.Clear();
            table.Invalidate();
        }
    }
}
