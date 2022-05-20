using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class PictureHepler
    {
        /// <summary>
        /// 截取图片
        /// </summary>
        /// <param name="xNum">X坐标</param>
        /// <param name="yNum">Y坐标</param>
        /// <param name="widthNum">宽度</param>
        /// <param name="heightNum">高度</param>
        /// <returns></returns>
        public static Bitmap GetScreenCapture(int xNum, int yNum, int widthNum, int heightNum)
        {
            Rectangle tScreenRect = new Rectangle(xNum, yNum, widthNum, heightNum);
            Bitmap tSrcBmp = new(tScreenRect.Width, tScreenRect.Height); // 用于屏幕原始图片保存
            Graphics gp = Graphics.FromImage(tSrcBmp);
            gp.CopyFromScreen(xNum, yNum, 0, 0, tScreenRect.Size);
            gp.DrawImage(tSrcBmp, xNum, yNum, tScreenRect, GraphicsUnit.Pixel);
            return tSrcBmp;
        }

        /// <summary>
        /// 判断两张图片是否一致
        /// </summary>
        /// <param name="bitmapSource">图片一</param>
        /// <param name="bitmapTarget">图片二</param>
        /// <returns>是否一致</returns>
        public static bool IsSameImg(Bitmap bitmapSource , Bitmap bitmapTarget)
        {
            int countSame = 0;
            int countDifferent = 0;
            for (int i = 0; i < bitmapTarget.Width; i++)
            {
                for (int j = 0; j < bitmapTarget.Height; j++)
                {
                    if (bitmapSource.GetPixel(i, j).Equals(bitmapTarget.GetPixel(i, j)))
                    {
                        countSame++;
                    }
                    else
                    {
                        countDifferent++;//不同之处，如果为0 则说明两张图片一样
                    }
                }
            }
  
            if (countDifferent == 0)
            {
                return true;
            }
            return false;  
        }

        /// <summary>
        /// 判断截取图片与本地图片是否一样
        /// </summary>
        /// <param name="bitmapSource">截取图片</param>
        /// <returns>是否一致</returns>
        public static bool IsSameImg(Bitmap bitmapSource)
        {
            try
            {
                Bitmap bitmapTarget = new(@"要比较的图片地址");
                Stopwatch stopwatch = new();
                stopwatch.Start();
                int countSame = 0;
                int countDifferent = 0;
                for (int i = 0; i < bitmapTarget.Width; i++)
                {
                    for (int j = 0; j < bitmapTarget.Height; j++)
                    {
                        if (bitmapSource.GetPixel(i, j).Equals(bitmapTarget.GetPixel(i, j)))
                        {
                            countSame++;
                        }
                        else
                        {
                            countDifferent++;//不同之处，如果为0 则说明两张图片一样
                        }
                    }
                }
                stopwatch.Stop();
                bitmapTarget.Dispose();//将本地图片释放掉
                if (countDifferent == 0)
                {
                    return true;
                }
                return false;
                
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
