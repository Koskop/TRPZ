using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TRPZ_project
{
    public partial class TransactionHistoryForm : Form
    {
        List<Receipt> receipts;
        public TransactionHistoryForm(List<Receipt> r)
        {
            InitializeComponent();
            receipts = r;
            for (int i = 0; i < receipts.Count; i++)
            {
                listBox1.Items.Add(receipts.ElementAt(i).DataForList());
            }
        }

        private void BtnCreateReceipt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (!File.Exists("Receipt\\" + Convert.ToString(listBox1.SelectedIndex + 1) + ".png"))
                {
                    Bitmap bitmap = new Bitmap(2480, 3508);
                    Font fontH1 = new Font("Arial", 50);
                    Font font = new Font("Arial", 35);
                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    Bitmap logo = new Bitmap("logo.png");
                    Pen pen = new Pen(solidBrush);
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.White);
                        graphics.DrawImage(logo, 0, 0, 2480, 700);
                        graphics.DrawString("Квитанція про обмін валюти", fontH1, solidBrush, 800, 705);
                        graphics.DrawString("Клієнт: " + receipts.ElementAt(listBox1.SelectedIndex).getClientName(), font, solidBrush, 100, 800);
                        graphics.DrawString("Касир №" + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getWorkerID()) + " " + receipts.ElementAt(listBox1.SelectedIndex).getWorkerName(), font, solidBrush, 100, 860);
                        graphics.DrawString("Відділення №" + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getDepartmentID()), font, solidBrush, 100, 920);
                        graphics.DrawString("Валюта, що надав клієнт:  " + receipts.ElementAt(listBox1.SelectedIndex).getFrom(), font, solidBrush, 100, 990);
                        graphics.DrawString("Сума: " + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getSumaFrom()), font, solidBrush, 100, 1050);
                        graphics.DrawString("Валюта, що була видана клієнту: " + receipts.ElementAt(listBox1.SelectedIndex).getTo(), font, solidBrush, 100, 1130);
                        graphics.DrawString("Сума: " + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getSumaTo()), font, solidBrush, 100, 1190);
                        graphics.DrawString("Підпис клієнта: ", font, solidBrush, 100, 1350);
                        graphics.DrawString("___________________________", font, solidBrush, 100, 1430);
                        graphics.DrawString("Підпис касира: ", font, solidBrush, 1700, 1350);
                        graphics.DrawString("___________________________", font, solidBrush, 1700, 1430);
                        graphics.DrawString("Дата: " + receipts.ElementAt(listBox1.SelectedIndex).getDataTime(), font, solidBrush, 1800, 1600);
                        graphics.DrawImage(logo, 0, 0 + 1754, 2480, 700);
                        graphics.DrawLine(pen, 0, 1754, 2480, 1754);
                        graphics.DrawString("Квитанція про обмін валюти", fontH1, solidBrush, 800, 705 + 1754);
                        graphics.DrawString("Клієнт: " + receipts.ElementAt(listBox1.SelectedIndex).getClientName(), font, solidBrush, 100, 800 + 1754);
                        graphics.DrawString("Касир №" + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getWorkerID()) + " " + receipts.ElementAt(listBox1.SelectedIndex).getWorkerName(), font, solidBrush, 100, 860 + 1754);
                        graphics.DrawString("Відділення №" + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getDepartmentID()), font, solidBrush, 100, 920 + 1754);
                        graphics.DrawString("Валюта, що надав клієнт:  " + receipts.ElementAt(listBox1.SelectedIndex).getFrom(), font, solidBrush, 100, 990 + 1754);
                        graphics.DrawString("Сума: " + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getSumaFrom()), font, solidBrush, 100, 1050 + 1754);
                        graphics.DrawString("Валюта, що була видана клієнту: " + receipts.ElementAt(listBox1.SelectedIndex).getTo(), font, solidBrush, 100, 1130 + 1754);
                        graphics.DrawString("Сума: " + Convert.ToString(receipts.ElementAt(listBox1.SelectedIndex).getSumaTo()), font, solidBrush, 100, 1190 + 1754);
                        graphics.DrawString("Підпис клієнта: ", font, solidBrush, 100, 1350 + 1754);
                        graphics.DrawString("___________________________", font, solidBrush, 100, 1430 + 1754);
                        graphics.DrawString("Підпис касира: ", font, solidBrush, 1700, 1350 + 1754);
                        graphics.DrawString("___________________________", font, solidBrush, 1700, 1430 + 1754);
                        graphics.DrawString("Дата: " + receipts.ElementAt(listBox1.SelectedIndex).getDataTime(), font, solidBrush, 1800, 1600 + 1754);

                    }
                    bitmap.Save("Receipt\\" + Convert.ToString(listBox1.SelectedIndex + 1) + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
                Process.Start("Receipt\\" + Convert.ToString(listBox1.SelectedIndex + 1) + ".png");
            }
        }
    }
}
