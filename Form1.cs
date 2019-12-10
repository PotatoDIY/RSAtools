using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAtools
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewRSA_Click(object sender, EventArgs e)
        {
            //产生新的私钥公钥
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            textBoxPrivateKey.Text = Convert.ToBase64String(rsa.ExportCspBlob(true));//生成私钥
            textBoxPublicKey.Text = Convert.ToBase64String(rsa.ExportCspBlob(false));//生成公钥
        }

        
        private RSACryptoServiceProvider loadRSA(String key)
        {
            //从字符串装载rsa私钥或公钥
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] keyBytes = Convert.FromBase64String(key);
            rsa.ImportCspBlob(keyBytes);
            return rsa;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            //签名
            try
            {
                //根据需要加签时的哈希算法转化成对应的hash字符节
                byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(textBoxTextForSign.Text);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);
                RSAPKCS1SignatureFormatter formatter = new RSAPKCS1SignatureFormatter(loadRSA(textBoxPrivateKeyForSign.Text));
                formatter.SetHashAlgorithm("SHA256");//此处是你需要加签的hash算法，需要和上边你计算的hash值的算法一致，不然会报错。
                byte[] inArray = formatter.CreateSignature(rgbHash);
                textBoxSignedForSign.Text = Convert.ToBase64String(inArray);
            }
            catch
            {
                MessageBox.Show("加签失败");
            }
        }
        private void buttonSignCheck_Click(object sender, EventArgs e)
        {
            //验签
            try
            {
                byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(textBoxTextForSignCheck.Text);
                var sha256 = new SHA256CryptoServiceProvider();
                byte[] rgbHash = sha256.ComputeHash(bt);
                RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(loadRSA(textBoxPublicKeyForSignCheck.Text));
                deformatter.SetHashAlgorithm("SHA256");
                byte[] rgbSignature = Convert.FromBase64String(textBoxSignedTextForSignCheck.Text);
                if (deformatter.VerifySignature(rgbHash, rgbSignature))
                {
                    labelMsgForSignCheck.Text = "验签成功";
                }
                else
                {
                    labelMsgForSignCheck.Text = "验签失败";
                }
            }
            catch
            {
                labelMsgForSignCheck.Text = "验签失败";
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            //加密
            try
            {
                byte[] encryptedData = loadRSA(textBoxPublicKeyForEncode.Text).Encrypt(Encoding.GetEncoding("utf-8").GetBytes(textBoxTextForEncode.Text), false);
                textBoxEncodeForEncode.Text = Convert.ToBase64String(encryptedData);
            }
            catch
            {
                MessageBox.Show("加密失败");
            }
        }
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            //解密
            try
            {
                byte[] decryptedData = loadRSA(textBoxPrivateKeyForDecode.Text).Decrypt(Convert.FromBase64String(textBoxEncodeTextForDecode.Text), false);
                textBoxTextForDecode.Text = Encoding.GetEncoding("utf-8").GetString(decryptedData);
            }
            catch
            {
                MessageBox.Show("解密失败");
            }
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/potatoDIY/RSAtools");
        }

        private void buttonSavePriKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter streamWriter = new StreamWriter(saveDialog.FileName))
                {
                    streamWriter.Write(textBoxPrivateKey.Text);// 
                }
            }
        }

        private void buttonSavePubKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveDialog.FileName))
                {
                    streamWriter.Write(textBoxPublicKey.Text);// 
                }
            }
        }

        private void buttonOpenPrivateForSign_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPrivateKeyForSign.Text = streamReader.ReadToEnd();
            }
        }

        private void buttonOpenPublicKeyForSigncheck_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPublicKeyForSignCheck.Text = streamReader.ReadToEnd();
            }
        }

        private void buttonOpenPublicKeyForEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPublicKeyForEncode.Text = streamReader.ReadToEnd();
            }
        }

        private void buttonOpenPrivateKeyForDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Files (*.key;*.txt)|*.key;*.txt";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openDialog.FileName);
                textBoxPrivateKeyForDecode.Text = streamReader.ReadToEnd();
            }
        }
    }
}