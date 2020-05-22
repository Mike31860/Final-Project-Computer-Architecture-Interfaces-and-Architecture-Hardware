using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace prueba3
{
    class Program
    {
        public static void Main(string[] args)
        {

            Bitmap img = new Bitmap(@"C:\Users\MIGUEL\Desktop\imagen.jpg");
            StreamWriter sw = new StreamWriter(@"C:\Users\MIGUEL\Desktop\TimeSem13_1000local.txt");

            int totalR = 0;
            int totalG = 0;
            int totalB = 0;
            Color color = new Color();
            int valor = 1;

            long tiempo = 0;

            int repeticion = 0;
            //versión 1
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();

            int pixeles = 65535;


            for (int k = repeticion; k < 0; k++)
            {
                switch (valor)
                {
                    //TIPO,#BITS,TAMANO 
                    //TAMANO=64x64, 160x160, 512x512, 1500x1500.
                    //#BITS=8,16,32
                    //TIPO=1,2,3,4,5

                    //VERSION1
                    case 1:

                        for (int i = 1; i < img.Width; i++)
                        {
                            for (int j = 1; j < img.Height; j++)
                            {
                                color = img.GetPixel(i, j);
                                int primero = (pixeles - color.R);
                                int segundo = (pixeles - color.G);
                                int tercero = (pixeles - color.B);
                                color = Color.FromArgb(pixeles, primero, segundo, tercero);
                                img.SetPixel(i, j, color);


                            }

                        }



                        break;

                    //VERSION2
                    case 2:
                        for (int i = 1; i < img.Width; i++)
                        {
                            for (int j = 1; j < img.Height; j++)
                            {
                                color = img.GetPixel(i, j);
                                int primero = (pixeles - color.R);
                                color = Color.FromArgb(pixeles, primero, (color.G), (color.B));
                                img.SetPixel(i, j, color);
                                //totalR = pixeles - img.GetPixel(i, j).R;

                            }
                        }
                        for (int i = 1; i < img.Width; i++)
                        {
                            for (int j = 1; j < img.Height; j++)
                            {
                                int segundo = (pixeles - color.G);
                                color = img.GetPixel(i, j);
                                color = Color.FromArgb(pixeles, (color.R), segundo, (color.B));
                                img.SetPixel(i, j, color);
                                // totalG = pixeles - img.GetPixel(i, j).G;

                            }

                        }

                        for (int i = 1; i < img.Width; i++)
                        {
                            for (int j = 1; j < img.Height; j++)
                            {

                                int tercero = (pixeles - color.B);
                                color = img.GetPixel(i, j);
                                color = Color.FromArgb(pixeles, (color.R), (color.G), tercero);
                                img.SetPixel(i, j, color);
                                //totalB = pixeles - img.GetPixel(i, j).B;

                            }

                        }

                        break;

                    //VERSION3
                    case 3:
                        for (int i = 1; i < img.Height; i++)
                        {
                            for (int j = 1; j < img.Width; j++)
                            {
                                int primero = (pixeles - color.R);
                                int segundo = (pixeles - color.G);
                                int tercero = (pixeles - color.B);
                                color = img.GetPixel(i, j);
                                color = Color.FromArgb(pixeles, primero, segundo, tercero);
                                img.SetPixel(i, j, color);

                                //totalR = pixeles - img.GetPixel(i, j).R;
                                //totalG = pixeles - img.GetPixel(i, j).G;
                                // totalB = pixeles - img.GetPixel(i, j).B;

                            }

                        }

                        break;

                    //VERSION4
                    case 4:
                        for (int i = 1; i < img.Width; i++)
                        {
                            for (int j = 1; j < img.Height; j++)
                            {
                                color = img.GetPixel(i, j);
                                int primero = (pixeles - color.R);
                                color = Color.FromArgb(pixeles, primero, (color.G), (color.B));
                                img.SetPixel(i, j, color);

                                // totalR = pixeles - img.GetPixel(i, j).R;

                            }
                        }
                        for (int i = img.Width; i >= 1; i--)
                        {
                            for (int j = img.Height; j >= 1; j--)
                            {
                                color = img.GetPixel(i, j);
                                int segundo = (pixeles - color.G);
                                int tercero = (pixeles - color.B);
                                color = Color.FromArgb(pixeles, (color.R), segundo, tercero);
                                img.SetPixel(i, j, color);

                                //totalG = pixeles - img.GetPixel(i, j).G;
                                // totalB = pixeles - img.GetPixel(i, j).B;
                            }



                        }
                        break;

                    //VERSION5
                    case 5:
                        Color color2 = new Color();
                        Color color3 = new Color();
                        Color color4 = new Color();

                        for (int i = 1; i < img.Width - 1; i += 2)
                        {
                            for (int j = 1; j < img.Height - 1; j += 2)
                            {

                                int primero = (pixeles - color.R);
                                int segundo = (pixeles - color.G);
                                int tercero = (pixeles - color.B);



                                color = img.GetPixel(i, j);
                                color = Color.FromArgb(pixeles, primero, segundo, tercero);
                                img.SetPixel(i, j, color);

                                color2 = img.GetPixel(i, j + 1);
                                color2 = Color.FromArgb(pixeles, primero, segundo, tercero);
                                img.SetPixel(i, j + 1, color2);

                                color3 = img.GetPixel(i + 1, j);
                                color3 = Color.FromArgb(pixeles, primero, segundo, tercero);
                                img.SetPixel(i + 1, j, color3);

                                color4 = img.GetPixel(i + 1, j + 1);
                                color4 = Color.FromArgb(pixeles, primero, segundo, tercero);
                                img.SetPixel(i + 1, j + 1, color4);

                                // totalR = pixeles - img.GetPixel(i, j).R;
                                //  totalG = pixeles - img.GetPixel(i, j).G;
                                //  totalB = pixeles - img.GetPixel(i, j).B;


                            }

                        }

                        break;

                }
                timeA.Stop();
                tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
                sw.WriteLine(tiempo);
            }
            sw.Close();
        }
    }


    
}
