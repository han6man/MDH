using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.DataBase
{
    public static class DBHelper
    {
        // Хранение изображений в MS SQL в двоичном формате в ячейке с типом «image»
        // в двоичном формате данные в базе занимают места меньше примерно в 100 раз по сравнению с методом с типом «varchar»
        // CREATE TABLE[report] (
        //     [id] bigint NOT NULL PRIMARY KEY IDENTITY,
        //     [screen] IMAGE DEFAULT(0x),
        //     [screen_format] VARCHAR(5) DEFAULT NULL,
        // );
        //PutImageBinaryInDb(@"C:\primer.jpg"); // запись изображения в БД
        private static void PutImageBinaryInDb(string iFile)
        {
            // конвертация изображения в байты
            byte[] imageData = null;
            FileInfo fInfo = new FileInfo(iFile);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(iFile, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imageData = br.ReadBytes((int)numBytes);

            // получение расширения файла изображения не забыв удалить точку перед расширением
            string iImageExtension = (Path.GetExtension(iFile)).Replace(".", "").ToLower();

            // запись изображения в БД
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=dbtest; User Id=sa; Password=pass")) // строка подключения к БД
            {
                string commandText = "INSERT INTO report (screen, screen_format) VALUES(@screen, @screen_format)"; // запрос на вставку
                SqlCommand command = new SqlCommand(commandText, sqlConnection);
                command.Parameters.AddWithValue("@screen", (object)imageData); // записываем само изображение
                command.Parameters.AddWithValue("@screen_format", iImageExtension); // записываем расширение изображения
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        private static void GetImageBinaryFromDb()
        {
            // получаем данные их БД
            List<byte[]> iScreen = new List<byte[]>(); // сделав запрос к БД мы получим множество строк в ответе, поэтому мы их сможем загнать в массив/List
            List<string> iScreen_format = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=dbtest; User Id=sa; Password=pass"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [screen], [screen_format] FROM [report] WHERE [id] = 1"; // наша запись в БД под id=1, поэтому в запросе "WHERE [id] = 1"
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                byte[] iTrimByte = null;
                string iTrimText = null;
                while (sqlReader.Read()) // считываем и вносим в лист результаты
                {
                    iTrimByte = (byte[])sqlReader["screen"]; // читаем строки с изображениями
                    iScreen.Add(iTrimByte);
                    iTrimText = sqlReader["screen_format"].ToString().TrimStart().TrimEnd(); // читаем строки с форматом изображения
                    iScreen_format.Add(iTrimText);
                }
                sqlConnection.Close();
            }

            // конвертируем бинарные данные в изображение
            byte[] imageData = iScreen[0]; // возвращает массив байт из БД. Так как у нас SQL вернёт одну запись и в ней хранится нужное нам изображение, то из листа берём единственное значение с индексом '0'
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms);

            // сохраняем изоражение на диск
            string iImageExtension = iScreen_format[0]; // получаем расширение текущего изображения хранящееся в БД
            string iImageName = @"C:\result_new" + "." + iImageExtension; // задаём путь сохранения и имя нового изображения
            if (iImageExtension == "png") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Png); }
            else if (iImageExtension == "jpg" || iImageExtension == "jpeg") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Jpeg); }
            else if (iImageExtension == "gif") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Gif); }
            // и т.д., можно все if заменить на одну строку "newImage.Save(iImageName)", насколько это правильно сказать не могу, но работает
        }

        // Хранение изображений в MS SQL в формате base64 в ячейке с типом «varchar»
        // CREATE TABLE[report_base64] (
        //     [id] bigint NOT NULL PRIMARY KEY IDENTITY,
        //     [screen] VARCHAR(MAX) DEFAULT NULL,
        //     [screen_format] VARCHAR(5) DEFAULT NULL,
        // );
        // PutImageBase64InDb(@"C:\primer.jpg"); // запись изображения в БД
        private static void PutImageBase64InDb(string iFile)
        {
            // конвертация изображения в base64
            string base64String = null;
            using (Image image = Image.FromFile(iFile))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    base64String = Convert.ToBase64String(imageBytes);
                }
            }

            // получение расширения файла изображения не забыв удалить точку перед расширением
            string iImageExtension = (Path.GetExtension(iFile)).Replace(".", "").ToLower();

            // запись изображения в БД
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=dbtest; User Id=sa; Password=saSA")) // строка подключения к БД
            {
                string commandText = "INSERT INTO report_base64 (screen, screen_format) VALUES(@screen, @screen_format)"; // запрос на вставку
                SqlCommand command = new SqlCommand(commandText, sqlConnection);
                command.Parameters.AddWithValue("@screen", base64String); // записываем само изображение
                command.Parameters.AddWithValue("@screen_format", iImageExtension); // записываем расширение изображения
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        private static void GetImageBase64FromDb()
        {
            // получаем данные их БД
            List<string> iScreen = new List<string>(); // сделав запрос к БД мы получим множество строк в ответе, поэтому мы их сможем загнать в массив/List
            List<string> iScreen_format = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=dbtest; User Id=sa; Password=saSA"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [screen], [screen_format] FROM [report_base64] WHERE [id] = 1"; // наша запись в БД под id=1, поэтому в запросе "WHERE [id] = 1"
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                string iTrimText = null;
                while (sqlReader.Read()) // считываем и вносим в лист результаты
                {
                    iTrimText = sqlReader["screen"].ToString().TrimStart().TrimEnd(); // читаем строки с изображениями
                    iScreen.Add(iTrimText);
                    iTrimText = sqlReader["screen_format"].ToString().TrimStart().TrimEnd(); // читаем строки с форматом изображения
                    iScreen_format.Add(iTrimText);
                }
                sqlConnection.Close();
            }

            // конвертируем данные в изображение
            string base64StringImage = iScreen[0]; // возвращает массив байт из БД. Так как у нас SQL вернёт одну запись и в ней хранится нужное нам изображение, то из листа берём единственное значение с индексом '0'
            byte[] imageData = Convert.FromBase64String(base64StringImage);
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms);

            // сохраняем изоражение на диск
            string iImageExtension = iScreen_format[0]; // получаем расширение текущего изображения хранящееся в БД
            string iImageName = @"C:\result_new_base64" + "." + iImageExtension; // задаём путь сохранения и имя нового изображения
            if (iImageExtension == "png") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Png); }
            else if (iImageExtension == "jpg" || iImageExtension == "jpeg") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Jpeg); }
            else if (iImageExtension == "gif") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Gif); }
            // и т.д., можно все if заменить на одну строку "newImage.Save(iImageName)", насколько это правильно сказать не могу, но работает
        }

    }
}
