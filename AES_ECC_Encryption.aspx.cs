using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
namespace AES_ECC_JEGADESH
{
    public partial class AES_ECC_Encryption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FileUpload1_Load(object sender, EventArgs e)
        {
           
        }

        protected void FileUploadControl_DataBinding(object sender, EventArgs e)
        {
           
        }


        private string Encrypt(string clearText)
        {
            string EncryptionKey = TextBox2.Text;
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

       
        protected void Button5_Click(object sender, EventArgs e)
        {
            string str;
            if (FileUploadControl.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadControl.FileName);
                    str = Server.MapPath("~/jegadesh/") + filename;
                    FileUploadControl.SaveAs(Server.MapPath("~/jegadesh/") + filename);
                    StreamReader reader1 = new StreamReader(str);
                    string text1 = reader1.ReadToEnd();
                    txtplain.Text = text1;
                    reader1.Close();
                    // Label2.Text = "Upload status: File uploaded!";
                    FileInfo fi = new FileInfo(str);
                    double imageMB = fi.Length;
                    Session["filesi"] = imageMB;
                    //Label13.Text = "File Name: " + fi.Name;
                    Label41.Text =  imageMB + " Bytes";
                    //Session["filesize"] = Label14.Text;

                }


                catch (Exception ex)
                {
                    Label2.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {

            }
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                TextBox6.Text = this.Encrypt(txtplain.Text.Trim());

                watch.Stop();
                var d = watch.ElapsedMilliseconds;
                Session["exe_en"] = d;
                Session["cipher"] = Label41.Text;
               
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Data encryption successful...')", true);
               
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
          //  strings ss = new strings();


            string file_name1 = "e:\\EncryptionResult.txt";
            if (File.Exists(file_name1))
            {
               File.Delete(file_name1);
            }
            using (StreamWriter objWriter = new StreamWriter(file_name1, true))
            {
                objWriter.Write(TextBox6.Text);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Details have been saved successfully...')", true);
                objWriter.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string file_name1 = "e:\\EncryptedKEY.txt";
            if (File.Exists(file_name1))
            {
                File.Delete(file_name1);
            }
            using (StreamWriter objWriter = new StreamWriter(file_name1, true))
            {
                objWriter.Write(TextBox3.Text);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Details have been saved successfully...')", true);
                objWriter.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                string q ;
               int x=Convert.ToInt32(txtX.Text);
            int y=Convert.ToInt32(txtY.Text);
            int d=Convert.ToInt32(txtdvalue.Text);
           int q1=d*x;
            int q2=d*y;
            int c = Convert.ToInt16('A');
            string str = TextBox2.Text;
            string c1 = 3 * x + "," + 3 * y;
            for (int i = 0; i < str.Length; i++)
            {
               
                int i1 = Convert.ToInt16(str[i]) + q1;
                int i2 = Convert.ToInt16(str[i]) + q2;
                TextBox3.Text+=i1+","+i2+",";
            }
            TextBox3.Text += c1;
        }
    }
}