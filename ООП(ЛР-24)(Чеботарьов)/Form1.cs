using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Cryptography;
using System.Security.Policy;
using System.IO;

namespace ООП_ЛР_24__Чеботарьов_
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource1;
        private CancellationTokenSource cancellationTokenSource2;
        private CancellationTokenSource cancellationTokenSource3;
        public Form1()
        {
            InitializeComponent();
            firstThreadStart.Click += firstThreadStart_Click;
            secondThreadStart.Click += secondThreadStart_Click;
            thirdThreadStart.Click += thirdThreadStart_Click;
            allThreadStart.Click += allThreadStart_Click;
            firstThreadStop.Click += firstThreadStop_Click;
            secondThreadStop.Click += secondThreadStop_Click;
            thirdThreadStop.Click += thirdThreadStop_Click;
            allThreadStop.Click += allThreadStop_Click;

            FormClosed += Form1_FormClosed;
            tabControl1.SelectedIndexChanged += tabControl1_TabIndexChanged;
            RunButton.Click += RunButton_Click;

        }
        Thread thread1;
        Thread thread2;
        Thread thread3;

        private void DrawRectangle()
        {
            try
            {
                Random rnd = new Random();
                while (true)
                {
                    if (cancellationTokenSource1.Token.IsCancellationRequested)
                        break;

                    Thread.Sleep(4);
                    panel1.Invoke((MethodInvoker)delegate
                    {
                        using (Graphics g = panel1.CreateGraphics())
                        {
                            g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(panel1.Width), rnd.Next(panel1.Height));
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawEllipse()
        {
            try
            {
                Random rnd = new Random();
                while (true)
                {
                    if (cancellationTokenSource2.Token.IsCancellationRequested)
                        break;

                    Thread.Sleep(4);
                    panel2.Invoke((MethodInvoker)delegate
                    {
                        using (Graphics g = panel2.CreateGraphics())
                        {
                            g.DrawEllipse(Pens.Yellow, 0, 0, rnd.Next(panel2.Width), rnd.Next(panel2.Height));
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RandomNumber()
        {
            try
            {
                Random rnd = new Random();
                for (int i = 0; i < 500; i++)
                {
                    if (cancellationTokenSource3.Token.IsCancellationRequested)
                        break;

                    randomNumberTextBox.Invoke((MethodInvoker)delegate
                    {
                        randomNumberTextBox.Text += rnd.Next().ToString();
                    });

                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void firstThreadStart_Click(object sender, EventArgs e)
        {
            cancellationTokenSource1 = new CancellationTokenSource();
            Task.Run(() => DrawRectangle(), cancellationTokenSource1.Token);
        }

        private void secondThreadStart_Click(object sender, EventArgs e)
        {
            cancellationTokenSource2 = new CancellationTokenSource();
            Task.Run(() => DrawEllipse(), cancellationTokenSource2.Token);
        }

        private void thirdThreadStart_Click(object sender, EventArgs e)
        {
            cancellationTokenSource3 = new CancellationTokenSource();
            Task.Run(() => RandomNumber(), cancellationTokenSource3.Token);
        }

        private void allThreadStart_Click(object sender, EventArgs e)
        {
            cancellationTokenSource1 = new CancellationTokenSource();
            cancellationTokenSource2 = new CancellationTokenSource();
            cancellationTokenSource3 = new CancellationTokenSource();
            Task.Run(() => DrawRectangle(), cancellationTokenSource1.Token);
            Task.Run(() => DrawEllipse(), cancellationTokenSource2.Token);
            Task.Run(() => RandomNumber(), cancellationTokenSource3.Token);
        }

        private void firstThreadStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource1?.Cancel();
        }

        private void secondThreadStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource2?.Cancel();
        }

        private void thirdThreadStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource3?.Cancel();
        }

        private void allThreadStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource1?.Cancel();
            cancellationTokenSource2?.Cancel();
            cancellationTokenSource3?.Cancel();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancellationTokenSource1?.Cancel();
            cancellationTokenSource2?.Cancel();
            cancellationTokenSource3?.Cancel();
        }
        

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            cancellationTokenSource1?.Cancel();
            cancellationTokenSource2?.Cancel();
            cancellationTokenSource3?.Cancel();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            await RunCryptoMethodsAsync();
            MessageBox.Show("Всі методи криптографії виконані.", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task RunCryptoMethodsAsync()
        {
            string inputText1 = plainTextBox1.Text;
            string inputText2 = plainTextBox2.Text;
            string inputText3 = plainTextBox3.Text;

            await Task.WhenAll(
                Task.Run(async () =>
                {
                    await Task.Delay(1000);
                    string encryptedText = EncryptREDOC(inputText1);
                    encryptedTextBox1.Invoke((MethodInvoker)(() => encryptedTextBox1.Text = encryptedText));
                }),
                Task.Run(async () =>
                {
                    await Task.Delay(1500);
                    string hashedText = HashSHA256(inputText2);
                    encryptedTextBox2.Invoke((MethodInvoker)(() => encryptedTextBox2.Text = hashedText));
                }),
                Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    string encryptedText2 = EncryptAES(inputText3);
                    encryptedTextBox3.Invoke((MethodInvoker)(() => encryptedTextBox3.Text = encryptedText2));
                })
            );
        }

        private string EncryptREDOC(string plainText)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in plainText)
            {
                char encryptedChar = (char)(c - 1);
                encryptedText.Append(encryptedChar);
            }

            return encryptedText.ToString();
        }

        private string HashSHA256(string plainText)
        {
            using (var hasher = SHA256.Create())
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] hashBytes = hasher.ComputeHash(plaintextBytes);
                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }

        private string EncryptAES(string plainText)
        {
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                // Генеруємо ключ довжиною 128 біт
                aesAlg.GenerateKey();
                byte[] key = aesAlg.Key;

                aesAlg.Mode = CipherMode.ECB; // Режим шифрування
                aesAlg.Padding = PaddingMode.PKCS7; // Режим доповнення

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }

                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }
    }
}



