using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AES_ECC_JEGADESH
{
    public partial class AES_ECC_Decryption : System.Web.UI.Page
    {

      //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\AES_ECC_JEGADESH\AES_ECC_JEGADESH\App_Data\Database2.mdf;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void FileUpload1_Load(object sender, EventArgs e)
        {

        }

        protected void FileUploadControl_DataBinding(object sender, EventArgs e)
        {

        }


        private string Decrypt(string cipherText)
        {
            string EncryptionKey = TextBox2.Text;
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
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
                    TextBox1.Text = text1;
                    reader1.Close();
                    // Label2.Text = "Upload status: File uploaded!";
                    FileInfo fi = new FileInfo(str);
                    double imageMB = fi.Length;
                    Session["filesi"] = imageMB;
                    //Label13.Text = "File Name: " + fi.Name;
                    //Label14.Text = "Text Size: " + imageMB + " Bytes";
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
                TextBox6.Text = this.Decrypt(txtcipher.Text.Trim());
                watch.Stop();
                var d = watch.ElapsedMilliseconds;
                
                 
               
               // SqlCommand exe = new SqlCommand
                       // ("insert into  times([filesize],[exe_time],[exe_time1]) values(@a1,@a2,@a3) ", con);
              //  con.Open();
               // exe.Parameters.AddWithValue("@a1", Session["cipher"].ToString());
               // exe.Parameters.AddWithValue("@a2", Session["exe_en"].ToString());
                //exe.Parameters.AddWithValue("@a3", d.ToString());
                //exe.ExecuteNonQuery();
                //con.Close();
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Data Decryption successful...')", true);

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //  strings ss = new strings();


            string file_name1 = "e:\\DecryptionResult" + System.DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
          
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

        protected void Button7_Click(object sender, EventArgs e)
        {
            string[] dump = TextBox1.Text.Split(',');
            int c1,c2;
            int c11 = Convert.ToInt16(txtdvalue.Text) * Convert.ToInt16(dump[dump.Length - 2]);
            int c12 = Convert.ToInt16(txtdvalue.Text) * Convert.ToInt16(dump[dump.Length - 1]);
            for (int i = 1; i < dump.Length-2; i=i+2)
            {
                int m = Convert.ToInt16(dump[i]) - c11;
                TextBox2.Text += (char)m;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string str;
            if (FileUpload1 .HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUpload1.FileName);
                    str = Server.MapPath("~/jegadesh/") + filename;
                    FileUpload1.SaveAs(Server.MapPath("~/jegadesh/") + filename);
                    StreamReader reader1 = new StreamReader(str);
                    string text1 = reader1.ReadToEnd();
                    txtcipher.Text = text1; reader1.Close();
                    // Label2.Text = "Upload status: File uploaded!";
                    FileInfo fi = new FileInfo(str);
                    double imageMB = fi.Length;
                    Session["filesi"] = imageMB;
                    //Label13.Text = "File Name: " + fi.Name;
                    //Label14.Text = "Text Size: " + imageMB + " Bytes";
                    //Session["filesize"] = Label14.Text;

                }


                catch (Exception ex)
                {
                    Label2.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }

            }
        }
    }
}