using System;
using System.Drawing;

namespace FlipThisPic
{
    class ImageRotation
    {
        public static Bitmap Rotate(Bitmap bitmap, float angle)
        {
            return RotateFlip(bitmap, angle, false, false);
        }

        public static Image Rotate(Image image, float angle)
        {
            Bitmap bitmap = new Bitmap(image);
            return RotateFlip(bitmap, angle,false,false);
        }

        public static Bitmap FlipHorizontally(Bitmap bitmap)
        {
            return RotateFlip(bitmap, 0, false, true);
        }

        public static Bitmap FlipVertically(Bitmap bitmap)
        {
            return RotateFlip(bitmap, 0, true, false);
        }

        public static Bitmap RotateFlip(Image bitmap, float angle, bool flipVertically, 
            bool flipHorizontally)
        {
            double radians = angle / 180 * Math.PI;
            int newHeight = (int)(bitmap.Height * Math.Abs(Math.Cos(radians)) +
                                  bitmap.Width * Math.Abs(Math.Sin(radians)));
            int newWidth = (int)(bitmap.Width * Math.Abs(Math.Cos(radians)) + 
                                 bitmap.Height * Math.Abs(Math.Sin(radians)));
            Bitmap rotatedBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(rotatedBitmap))
            {
                graphics.TranslateTransform(newWidth / 2f,  
                    newHeight / 2f); // puts the transform in the center

                if (flipVertically)
                {
                    graphics.ScaleTransform(1, -1);
                    angle = (float)(Math.PI - angle);
                }

                if (flipHorizontally)
                {
                    graphics.ScaleTransform(-1, 1);
                    angle = (float)(Math.PI - angle);
                }
                graphics.RotateTransform(angle); // rotate the image from the center
                graphics.TranslateTransform(-bitmap.Width / 2f,
                    -bitmap.Height / 2f); // puts the transform back in correct place
                graphics.DrawImage(bitmap, 0, 0);
            }
            return rotatedBitmap;
        }
    }
}
