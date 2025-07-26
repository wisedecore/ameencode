using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Frmimage : Form
    {
        public Frmimage()
        {
            InitializeComponent();
        }

        string fName;
        public  string Id;
        public string fromform;
        SqlConnection cnn;
        string connectionString = null;
        private void Frmimage_Load(object sender, EventArgs e)
        {
            if (fromform == "PI")
            {
                picImage.BackgroundImage = CommonClass._Nextg.DisplayImages(Id, "select Billimg from tbltransactionreceipt where vno='" + Id + "' and recpttype='PI'");
                picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }

            CommonClass._Nextg.FormIcon(this);

        }

        private void btnLoadAndSave_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source= Localhost\\sqlexpress;Initial Catalog=KVR;Max Pool Size=500;Persist Security Info=True;User ID=sa;Password=hello";
            cnn = new SqlConnection(connectionString);
            fName = "D:\\Penguins.jpg";
            if (File.Exists(fName))
            {
                int id = 4;
                byte[] content = ImageToStream(fName);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into imgtable (id,img) values ( @id,@img)", cnn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@img", content);
                cmd.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Image inserted");

      
            }
            else
            {
                MessageBox.Show(fName + " not found ");
            }
        }

        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void btnDisplayImage_Click(object sender, EventArgs e)
        {



            connectionString = "Data Source= Localhost\\sqlexpress;Initial Catalog=KVR;Max Pool Size=500;Persist Security Info=True;User ID=sa;Password=hello";
            cnn = new SqlConnection(connectionString);

            MemoryStream stream = new MemoryStream();
            cnn.Open();
            SqlCommand command = new SqlCommand("select img from imgtable where id=4", cnn);
            byte[] image = (byte[])command.ExecuteScalar();
            stream.Write(image, 0, image.Length);
            cnn.Close();
            Bitmap bitmap = new Bitmap(stream);
            picImage.Image = bitmap;
        }
    }
}
