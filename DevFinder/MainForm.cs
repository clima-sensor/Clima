using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace DevFinder
{
    public partial class Main : Form
    {
        List<string> answ = new List<string>();
        UdpClient UDPcli;
        UdpClient UDPsrv;
        DataTable dataTable;

        public Main()
        {
            InitializeComponent();
			// создаем БД
            dataTable = new DataTable("Devices");
			dataTable.Columns.Add(new DataColumn("DC_Type", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_Ver", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_ID", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_MAC", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_DHCP", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_IP", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_Mask", typeof(string)));
			dataTable.Columns.Add(new DataColumn("DC_Gate", typeof(string)));
			dataGridView1.DataSource = dataTable;
			// прорисовываем форму
			Show();
			try
			{
				// клиент для отправки широковещательного запроса
                UDPcli = new UdpClient(44555);
				// сервет для приема ответов
                UDPsrv = new UdpClient(44550);
            }
            catch
            {
                MessageBox.Show("Не удалось создать слушающий сокет. Возможно, запущена еще одна копия программы.", 
						Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				// выходим с кодом -1
				Environment.Exit(-1);
            }
			// запускаем процесс поиска
			FindUDP();
		}

		/// <summary>
		/// обработчик нажатия кнопки 'Поиск'
		/// </summary>
		private void FindBtn_Click(object sender, EventArgs e)
        {
             // вызываем метод 
            FindUDP();
        }

		/// <summary>
		/// метод поиска UDP
		/// </summary>
		private void FindUDP()
        {
            string msg = "devscan";
            byte[] data = Encoding.ASCII.GetBytes(msg);
			string[] S;// = new string[8];

			// делаем кнопку неактивной и курсор - часики
			FindBtn.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
             // очищаем таблицу 
            dataTable.Clear();
             // перерисовываем окно программы, чтобы показать пустой список
            Update();
            // очищаем список принятых сообщений
            answ.Clear();
            // посылаем широковещательный запрос
            UDPcli.Send(data, data.Length, "255.255.255.255", 44550);
			// создаем слушающий UDP поток с токеном отмены
			CancellationTokenSource cts = new CancellationTokenSource();
            Task.Run(() => GetResponse(cts.Token));
             // ждем 2 сек
            Thread.Sleep(2000);
             // завершаем слушающий UDP поток
            cts.Cancel();
			// убираем дублирующиеся ответы (некоторые устр-ва шлют по 2 одинаковых ответа)
			IEnumerable<string> dAnsw = answ.Distinct(); 
            foreach (string s in dAnsw)
            {
				// разделяем строку на подстроки по символу-разделителю
				S = s.Split('&');
                 // новая запись
                DataRow row = dataTable.NewRow();
                 // заполняем запись данными из массива строк
                for (int i = 0; i < 8; i++)
                {
                    row[i] = S[i];
                }
                 // добавляем запись в таблицу
                dataTable.Rows.Add(row);
            }
             // делаем кнопку активной, курсор - обычный
            Cursor.Current = Cursors.Default;
            FindBtn.Enabled = true;
        }

         // слушающий UDP поток
        void GetResponse(CancellationToken token)
        {
          IPEndPoint remoteEP = new IPEndPoint(0, 0);
          byte[] data;
			// пока не получен токен отмены
            while (!token.IsCancellationRequested)
            {
				// принимаем ответы по UDP
                data = UDPcli.Receive(ref remoteEP);
				// преобразуем массив байт в строку
                string msg = Encoding.ASCII.GetString(data);
				// добавляем ее в список
                answ.Add(msg);
            }
        }

         // запускаем веб браузер по выбранному адресу
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[5];
            string IP = cell.Value.ToString();
            Process.Start("http://" + IP);
        }
    }
}
