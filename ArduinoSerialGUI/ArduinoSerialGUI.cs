using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace ArduinoSerialGUI
{
    public partial class ArduinoSerialGUI : Form
    {
        int[] baudrate = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200 };

        //データ格納用インナークラス
        private class myDataset : Object
        {
            private string m_name = "";
            private int m_value = 0;

            // 表示名称
            public string NAME
            {
                set { m_name = value; }
                get { return m_name; }
            }

            // 設定値
            public int VALUE
            {
                set { m_value = value; }
                get { return m_value; }
            }

            // コンボボックス表示用の文字列取得関数.
            public override string ToString()
            {
                return m_name;
            }
        }

        private delegate void Delegate_RcvDataToTextBox(string data);


        public ArduinoSerialGUI()
        {
            InitializeComponent();
        }

        private void ArduinoSerialGUI_Load(object sender, EventArgs e)
        {
            //! 利用可能なシリアルポート名の配列を取得する.
            string[] PortList = SerialPort.GetPortNames();

            com_cbbox.Items.Clear();

            //! シリアルポート名をコンボボックスにセットする.
            foreach (string PortName in PortList)
            {
                com_cbbox.Items.Add(PortName);
            }
            if (com_cbbox.Items.Count > 0)
            {
                com_cbbox.SelectedIndex = 0;
            }

            speed_cbbox.Items.Clear();

            // ボーレート選択コンボボックスに選択項目をセットする.
            myDataset baud;
            foreach( int data in baudrate )
            {
                baud = new myDataset();
                baud.NAME = data.ToString();
                baud.VALUE = data;
                speed_cbbox.Items.Add(baud);
            }
            speed_cbbox.SelectedIndex = 5;

            data1_trkbar.Value = 0;
            data2_trkbar.Value = 0;
            data3_trkbar.Value = 0;

            data1_txtbox.Text = string.Format("{0:D4}", data1_trkbar.Value);
            data2_txtbox.Text = string.Format("{0:D4}", data2_trkbar.Value);
            data3_txtbox.Text = string.Format("{0:D4}", data3_trkbar.Value);


            // 送受信用のテキストボックスをクリアする
            receive_txtbox.Clear();
        }

        private void ArduinoSerialGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            // シリアルポートをオープンしている場合、クローズする.
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                //! シリアルポートをクローズする.
                serialPort1.Close();

                //! ボタンの表示を[切断]から[接続]に変える.
                connect_btn.Text = "Connect";
            }
            else
            {
                //! オープンするシリアルポートをコンボボックスから取り出す.
                serialPort1.PortName = com_cbbox.SelectedItem.ToString();

                //! ボーレートをコンボボックスから取り出す.
                myDataset baud = (myDataset)speed_cbbox.SelectedItem;
                serialPort1.BaudRate = baud.VALUE;

                //! データビットをセットする. (データビット = 8ビット)
                serialPort1.DataBits = 8;

                //! パリティビットをセットする. (パリティビット = なし)
                serialPort1.Parity = Parity.None;

                //! ストップビットをセットする. (ストップビット = 1ビット)
                serialPort1.StopBits = StopBits.One;

                //! フロー制御をコンボボックスから取り出す.
                serialPort1.Handshake = Handshake.None;

                //! 文字コードをセットする.
                serialPort1.Encoding = Encoding.Unicode;

                try
                {
                    //! シリアルポートをオープンする.
                    serialPort1.Open();

                    //! ボタンの表示を[接続]から[切断]に変える.
                    connect_btn.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            // シリアルポートをオープンしていない場合、処理を行わない.
            if (serialPort1.IsOpen == false)
            {
                return;
            }
            // テキストボックスから、送信するテキストを取り出す.
            String data = "j" + code_txtbox.Text + "x";

            // 送信するテキストがない場合、データ送信は行わない.
            if (string.IsNullOrEmpty(data) == true)
            {
                return;
            }

            try
            {
                // シリアルポートからテキストを送信する.
                serialPort1.Write(data);

                // 送信データを入力するテキストボックスをクリアする.
                code_txtbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //! シリアルポートをオープンしていない場合、処理を行わない.
            if (serialPort1.IsOpen == false)
            {
                return;
            }

            try
            {
                //! 受信データを読み込む.
                string data = serialPort1.ReadExisting();

                //! 受信したデータをテキストボックスに書き込む.
                Invoke(new Delegate_RcvDataToTextBox(receiveDataToTextBox), new Object[] { data });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receiveDataToTextBox(string data)
        {
            //! 受信データをテキストボックスの最後に追記する.
            if (data != null)
            {
                receive_txtbox.AppendText(data);
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            // シリアルポートをオープンしていない場合、処理を行わない.
            if (serialPort1.IsOpen == false)
            {
                return;
            }
            // テキストボックスから、送信するテキストを取り出す.
            String data = "j0x";

            // 送信するテキストがない場合、データ送信は行わない.
            if (string.IsNullOrEmpty(data) == true)
            {
                return;
            }

            try
            {
                // シリアルポートからテキストを送信する.
                serialPort1.Write(data);

                // 送信データを入力するテキストボックスをクリアする.
                code_txtbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void data1_trkbar_Scroll(object sender, EventArgs e)
        {
            data1_txtbox.Text = string.Format("{0:D4}", data1_trkbar.Value);

            code_txtbox.Text = mode_cbbox.SelectedItem.ToString();
            if (data1_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data1_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data1_trkbar.Value);
            }
            if (data2_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data2_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data2_trkbar.Value);
            }
            if (data3_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data3_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data3_trkbar.Value);
            }
        }

        private void data2_trkbar_Scroll(object sender, EventArgs e)
        {
            data2_txtbox.Text = string.Format("{0:D4}", data2_trkbar.Value);

            code_txtbox.Text = mode_cbbox.SelectedItem.ToString();
            if (data1_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data1_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data1_trkbar.Value);
            }
            if (data2_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data2_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data2_trkbar.Value);
            }
            if (data3_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data3_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data3_trkbar.Value);
            }
        }

        private void data3_trkbar_Scroll(object sender, EventArgs e)
        {
            data3_txtbox.Text = string.Format("{0:D4}", data3_trkbar.Value);

            code_txtbox.Text = mode_cbbox.SelectedItem.ToString();
            if (data1_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data1_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data1_trkbar.Value);
            }
            if (data2_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data2_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data2_trkbar.Value);
            }
            if (data3_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data3_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data3_trkbar.Value);
            }
        }

        private void mode_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            code_txtbox.Text = mode_cbbox.SelectedItem.ToString();
            if (data1_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data1_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data1_trkbar.Value);
            }
            if (data2_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data2_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data2_trkbar.Value);
            }
            if (data3_trkbar.Value < 0)
            {
                code_txtbox.Text += string.Format("1{0:D4}", -data3_trkbar.Value);
            }
            else
            {
                code_txtbox.Text += string.Format("0{0:D4}", data3_trkbar.Value);
            }
        }

    }
}
