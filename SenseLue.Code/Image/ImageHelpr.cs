using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SenseLue.Code.Image
{
    public class ImageHelpr
    {
        /// <summary>
        /// 图片转二进制
        /// </summary>
        /// <param name="imagepath">图片地址</param>
        /// <returns></returns>
        public byte[] GetPictureData(string imagepath)
        {
            /**/////根据图片文件的路径使用文件流打开，并保存为byte[] 
            FileStream fs = new FileStream(imagepath, FileMode.Open);//可以是其他重载方法 
            byte[] byData = new byte[fs.Length];
            fs.Read(byData, 0, byData.Length);
            fs.Close();
            return byData;
        }

        /// <summary>
        /// 图片转二进制
        /// </summary>
        /// <param name="imgPhoto">Image类型图片</param>
        /// <returns></returns>
        public byte[] PhotoImageInsert(System.Drawing.Image imgPhoto)
        {
            //将Image转换成流数据，并保存为byte[] 
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length);
            mstream.Close();
            return byData;
        }

        /// <summary>
        /// 二进制转图片
        /// </summary>
        /// <param name="streamByte">图片二进制</param>
        /// <returns></returns>
        public System.Drawing.Image ReturnPhoto(byte[] streamByte)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(streamByte);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }



        /// <summary>
        /// 将图片数据转换为Base64字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private string ToBase64(System.Drawing.Image img)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            binFormatter.Serialize(memStream, img);
            byte[] bytes = memStream.GetBuffer();
            string base64 = Convert.ToBase64String(bytes);
            return base64;
        }


        /// <summary>
        /// 将Base64字符串转换为图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private System.Drawing.Image ToImage(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream memStream = new MemoryStream(bytes);
            BinaryFormatter binFormatter = new BinaryFormatter();
            System.Drawing.Image img = (System.Drawing.Image)binFormatter.Deserialize(memStream);
            return img;
        }


        /// <summary>
        /// 制作文字图片
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isBold"></param>
        /// <param name="fontSize"></param>
        /// <returns>文件名</returns>
        public static string CreateFontImage(string fontName, string text, bool isBold, int fontSize)
        {
            int length = text.Length;
            string textCopy = string.Empty;

            if (text.Length > 12)
            {
                int i;
                for (i = 0; i < text.Length; i += 12)
                {
                        if (i + 12 > text.Length)
                            textCopy += text.Substring(i, text.Length - i) + "\n";
                        else
                            textCopy += text.Substring(i, 12) + "\n";
                    
                }
                text = textCopy;
            }

            int wid = 980;
            int high = 160;
            Font font;

            PrivateFontCollection prc = new PrivateFontCollection();
            string fileName = Guid.NewGuid().ToString("N").Substring(0, 10);
            prc.AddFontFile(System.Web.HttpContext.Current.Server.MapPath("/Content/fonts/custom/" + fontName));
            font = new Font(prc.Families[0], fontSize);

            //绘笔颜色
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            Bitmap image = new Bitmap(wid, high);
            Graphics g = Graphics.FromImage(image);
            SizeF sizef = g.MeasureString(text, font, PointF.Empty, format);//得到文本的宽高
            int width = (int)(sizef.Width + 1);
            int height = (int)(sizef.Height + 10);
            if (width <= 980)
                width = 980;
            image.Dispose();
            image = new Bitmap(width, height);
            g = Graphics.FromImage(image);
            g.Clear(Color.White);//透明

            RectangleF rect = new RectangleF(0, 20, width, height);
            //绘制图片
            g.DrawString(text, font, brush, rect);
            //释放对象
            g.Dispose();

            image.Save(System.Web.HttpContext.Current.Server.MapPath("/Resource/Files/fontImage/" + fileName + ".png"), ImageFormat.Png);
            return fileName;
        }
    }
}
