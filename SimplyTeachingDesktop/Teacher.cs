using System.IO;
namespace SimplyTeachingDesktop
{
    internal class Teacher
    {
        public int id;
        public string name;
        public string last_name_1;
        public string last_name_2;
        public string post_address;
        public int seg_social;
        public int tel_1;
        public int tel_2;
        public string email;
        public byte[] image;

        public void setImage(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            image = photo;
        }

    }
}
