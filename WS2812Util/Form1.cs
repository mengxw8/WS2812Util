using System.Text;
using System.Windows.Forms;

namespace WS2812Util
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private static string path = "";

        private void addPicBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                path = openFileDialog.FileName;

                var image = Image.FromFile(openFileDialog.FileName);
                if (image.Width < picBox.Width || image.Height < picBox.Height)
                {
                    picBox.Image = ScaleImage(image, picBox.Width, picBox.Height);
                }
                //重新选择了图片，所以要重新生成代码，原来的数据清空
                arrayTxb.Text = "";


            }

        }
        /// <summary>
        /// 按照目标的宽高重绘原图
        /// </summary>
        /// <param name="image">原图片</param>
        /// <param name="dstWidth">目标图片宽</param>
        /// <param name="dstHeight">目标图片高</param>
        /// <returns></returns>
        public Image ScaleImage(Image image, int dstWidth, int dstHeight)
        {
            Graphics g = null;
            try
            {
                //原始图
                Bitmap img = new Bitmap(image);
                //创建一块指定长宽的画布
                Bitmap destBitmap = new Bitmap(dstWidth, dstHeight);
                g = Graphics.FromImage(destBitmap);
                g.Clear(Color.Transparent);
                //设置画布的描绘质量         
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                //计算每个区域的大小
                var h = dstHeight / image.Height;
                var w = dstWidth / image.Width;
                for (var i = 0; i < image.Width; i++)
                {
                    for (var j = 0; j < image.Height; j++)
                    {
                        //获取一个像素点的颜色
                        Color pixel = img.GetPixel(i, j);
                        var brush = new SolidBrush(pixel);
                        //将这个像素点的颜色填充到这个区域
                        g.FillRectangle(brush, i * w, h * j, w, h);
                    }
                }
                return destBitmap;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (g != null)
                {
                    g.Dispose();
                }

                if (image != null)
                {
                    image.Dispose();
                }
            }
        }


        /// <summary>
        /// 
        /// 生成Python数组代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generatePythonArray_Click(object sender, EventArgs e)
        {

            if (path != "")
            {
                var image = Image.FromFile(path);
                var bitmap = new Bitmap(image);
                StringBuilder stringBuilder = new StringBuilder(image.Width * image.Height * 13);
                stringBuilder.Append("[\r\n");
                for (var i = 0; i < image.Height; i++)
                {
                    stringBuilder.Append("[");
                    for (var j = 0; j < image.Width; j++)
                    {
                        //获取一个像素点的颜色
                        Color pixel = bitmap.GetPixel(j, i);
                        stringBuilder.Append(String.Format("[{0},{1},{2}]", pixel.R, pixel.G, pixel.B));
                        System.Diagnostics.Debug.WriteLine(String.Format("[{0},{1},{2}]", pixel.R, pixel.G, pixel.B));
                    }
                    stringBuilder.Append("],\r\n");
                }
                stringBuilder.Append("]");
                arrayTxb.Text = stringBuilder.ToString();

            }
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            var pic = this.picBox;
            if (pic.Image == null)
            {
                return;
            }
            var status = e.Graphics.Save();
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            //e.Graphics.Clear(this.picBox.BackColor);
            e.Graphics.DrawImage(pic.Image, new Rectangle(0, 0, pic.Width, pic.Height), new Rectangle(0, 0, pic.Image.Width, pic.Image.Height), GraphicsUnit.Pixel);
            e.Graphics.Restore(status);
        }

        private void picBox_Resize(object sender, EventArgs e)
        {
            //锁定长宽比？
        }
    }
}