using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace StoneScissors
{
	public partial class Form1 : Form
	{
		int port = 12345;
		StreamReader reader;
		StreamWriter writer;
		bool sentHand = false;
		bool gotHand = false;
		string myHand = string.Empty;
		string opHand = string.Empty;

		public Form1()
		{
			InitializeComponent();
			SetButtons(false);
		}

		private void SetButtons(bool enable)
		{
			btnStone.Enabled = enable;
			btnScissors.Enabled = enable;
			btnPaper.Enabled = enable;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if(rbServer.Checked)
			{
				try
				{
					StartServer();
				}
				catch(SocketException)
				{
					MessageBox.Show("Указан неверный IP-адрес.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				catch(FormatException)
				{
					MessageBox.Show("Недопустимый формат IP-адреса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			if(rbClient.Checked)
			{
				try
				{
					StartClient();
				}
				catch(SocketException)
				{
					MessageBox.Show("Сервер не запущен либо отверг запрос на подключение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			btnStart.Enabled = false;
			SetButtons(true);
			timer.Enabled = true;
		}

		private void StartClient()
		{
			TcpClient client = new TcpClient();
			client.Connect(tbxAddress.Text, port);
			client.ReceiveTimeout = 50;
			reader = new StreamReader(client.GetStream());
			writer = new StreamWriter(client.GetStream());
			writer.AutoFlush = true;
		}

		private void StartServer()
		{
			TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Parse(tbxAddress.Text), port));
			listener.Start();
			TcpClient server = listener.AcceptTcpClient();
			server.ReceiveTimeout = 50;
			reader = new StreamReader(server.GetStream());
			writer = new StreamWriter(server.GetStream());
			writer.AutoFlush = true;
		}

		private string GetLocalIP()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach(var ip in host.AddressList)
			{
				if(ip.AddressFamily == AddressFamily.InterNetwork)
					return ip.ToString();
			}
			throw new Exception("В системе нет адаптеров с адресами типа IPv4");
		}

		private void btnStone_Click(object sender, EventArgs e)
		{
			Send("Камень");
		}

		private void btnScissors_Click(object sender, EventArgs e)
		{
			Send("Ножницы");
		}

		private void btnPaper_Click(object sender, EventArgs e)
		{
			Send("Бумага");
		}

		private void Send(string item)
		{
			if(sentHand)
				return;
			writer.WriteLine(item);
			sentHand = true;
			myHand = item;
			SetButtons(false);
			tbxDebug.Text += "Sent " + item + Environment.NewLine;
		}

		private string Read()
		{
			if(gotHand)
				return string.Empty;
			try
			{
				string item;
				item = reader.ReadLine();
				gotHand = true;
				opHand = item;
				tbxDebug.Text += "Got " + item + Environment.NewLine;
				return item;
			}
			catch
			{
				return string.Empty;
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			tbxDebug.Text =
				"sent_hand = " + sentHand.ToString() + Environment.NewLine +
				"got_hand = " + gotHand.ToString() + Environment.NewLine +
				"my_hand = " + myHand + Environment.NewLine +
				"op_hand = " + opHand + Environment.NewLine;
			string hand = Read();
			if(sentHand && gotHand)
			{
				if(!lblResult.Visible)
					lblResult.Visible = true;
				int ch = CompareHands(myHand, opHand);
				string res = string.Empty;
				if(ch == 0)
				{
					res = "ничья";
					lblResult.ForeColor = Color.Blue;
				}
				if(ch == 1)
				{
					res = "победа";
					lblResult.ForeColor = Color.Green;
				}
				if(ch == 2)
				{
					res = "поражение";
					lblResult.ForeColor = Color.Red;
				}
				lblResult.Text = myHand + " - " + opHand + ": " + res;
				sentHand = false;
				gotHand = false;
				SetButtons(true);
				myHand = string.Empty;
				opHand = string.Empty;
			}
		}

		private int CompareHands(string hand1, string hand2)
		{
			if(hand1 == hand2)
				return 0;
			if(hand1 == "Камень")
				if(hand2 == "Ножницы")
					return 1;
				else
					return 2;
			if(hand1 == "Ножницы")
				if(hand2 == "Бумага")
					return 1;
				else
					return 2;
			if(hand1 == "Бумага")
				if(hand2 == "Камень")
					return 1;
				else
					return 2;
			return 0;
		}

		private void tbxAddress_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbxAddress.Text = GetLocalIP();
		}

		private void btnInstruct_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			form.ShowDialog();
		}
	}
}
