using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_by_Task
{
	public partial class Form1 : Form
	{
		private int Count = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			await Task.Run(() =>
			{
				Count++;
				label1.Invoke((Action)(() => label1.Text = Count.ToString()));
			});
		}
	}
}
