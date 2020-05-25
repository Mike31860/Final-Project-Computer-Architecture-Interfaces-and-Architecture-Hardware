using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;


namespace ProyectoFinal2
{
    class Program
    {

        /*
        Proyecto de arquitectura de computadores | Universidad ICESI | 2020 - 1
        Integrantes del proyecto 
             -Cristian Cobo
             -Sebastian Cardona 
             -Miguel Romero
        */


        /*
        Inicio del proyecto : implementación ____________________________
        */

        /*
        A continuación se aprecian las 5 versiones para convetir una imagen a negativo
        */

        /*
        VERSIÓN NO. 1_____________________________________
        */
        /*
        El método AlgoritmoVersion_1 recibe como parametros tres variables:
        - La ruta de la imagen
        - La profundid de la imagen
        - El tamaño de la imagen
        */
        static void AlgoritmoVersion_1(String src, int profundidad, int tamanio)
        {

            /*
            Variable donde se carga los bits de la imagen.
            */
            Bitmap imagenOriginal = new Bitmap(src);

            Bitmap a = imagenOriginal;
            /*
            Variable de color 
            */
            Color color;
            /*
            Variable de tiempo
            */
            long tiempo = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            stopWatch.Start();

            /*
            Ciclo for para iniciar el algotimo de conversion.
            */
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb((255 - color.R), (255 - color.G), (255 - color.B));
                    a.SetPixel(i, j, color);
                }
            }
            /*
            Detenemos el reloj
            */
            stopWatch.Stop();

            /*
            Recolectamos la información
            */
            tiempo = (long)(stopWatch.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Algoritmo Version 1: " + tiempo);

            /*
            Guardamos la imagen en la carpeta correspondiente
            */
            a.Save("./imagenesInvertidas/" + profundidad +"-"+ tamanio + ".bmp");
        }

        /*
        VERSIÓN NO. 2_____________________________________
        */
        /*
        El método AlgoritmoVersion_1 recibe como parametros tres variables:
        - La ruta de la imagen
        - La profundid de la imagen
        - El tamaño de la imagen
        */
        static void AlgoritmoVersion_2(String src, int profundidad, int tamanio)
        {
            /*
            Variable donde se carga los bits de la imagen.
            */
            Bitmap imagenOriginal = new Bitmap(src);

            Bitmap a = imagenOriginal;
            /*
            Variable de color 
            */
            Color color;
            /*
            Variable de tiempo
            */
            long tiempo = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            stopWatch.Start();

            /*
            Ciclos for para iniciar el algotimo de conversion.
            */

            /*
            Ciclo No. 1
            */
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb(255, (255 - color.R), color.G, color.B);
                    a.SetPixel(i, j, color);
                }
            }
            /*
            Ciclo No. 2
            */
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb(255, color.R, (255 - color.G), color.B);
                    a.SetPixel(i, j, color);
                }
            }
            /*
            Ciclo No. 3.
            */
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb(255, color.R, -color.G, (255 - color.B));
                    a.SetPixel(i, j, color);
                }
            }

            /*
            Detenemos el reloj
            */
            stopWatch.Stop();

            /*
            Recolectamos la información
            */
            tiempo = (long)(stopWatch.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Algoritmo Version 2: " + tiempo);

            /*
            Guardamos la imagen en la carpeta correspondiente
            */
            a.Save("./imagenesInvertidas/" + profundidad + "/" + tamanio + ".bmp");
        }

        /*
        VERSIÓN NO. 3_____________________________________
        */
        /*
        El método AlgoritmoVersion_1 recibe como parametros tres variables:
        - La ruta de la imagen
        - La profundid de la imagen
        - El tamaño de la imagen
        */
        static void AlgoritmoVersion_3(String src, int profundidad, int tamanio)
        {
            /*
            Variable donde se carga los bits de la imagen.
            */
            Bitmap imagenOriginal = new Bitmap(src);

            Bitmap a = imagenOriginal;
            /*
            Variable de color 
            */
            Color color;
            /*
            Variable de tiempo
            */
            long tiempo = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            stopWatch.Start();

            /*
            Ciclo for para iniciar el algotimo de conversion.
            */

            for (int j = 0; j < a.Height - 1; j++)
            {
                for (int i = 0; i < a.Width - 1; i++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb((255 - color.R), (255 - color.G), (255 - color.B));
                    a.SetPixel(i, j, color);
                }
            }
            /*
            Detenemos el reloj
            */
            stopWatch.Stop();

            /*
            Recolectamos la información
            */
            tiempo = (long)(stopWatch.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Algoritmo Version 2: " + tiempo);

            /*
            Guardamos la imagen en la carpeta correspondiente
            */
            a.Save("./imagenesInvertidas/" + profundidad + "/" + tamanio + ".bmp");

        }

        /*
        VERSIÓN NO. 4_____________________________________
        */
        /*
        El método AlgoritmoVersion_1 recibe como parametros tres variables:
        - La ruta de la imagen
        - La profundid de la imagen
        - El tamaño de la imagen
        */
        static void AlgoritmoVersion_4(String src, int profundidad, int tamanio)
        {

            /*
            Variable donde se carga los bits de la imagen.
            */
            Bitmap imagenOriginal = new Bitmap(src);

            Bitmap a = imagenOriginal;
            /*
            Variable de color 
            */
            Color color;
            /*
            Variable de tiempo
            */
            long tiempo = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            stopWatch.Start();



            /*
            Ciclos for para iniciar el algotimo de conversion.
            */

            /*
            Ciclo No. 1
            */
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb(255, (255 - color.R), color.G, color.B);
                    a.SetPixel(i, j, color);
                }
            }

            /*
            Ciclo No. 2
            */
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb(255, color.R, (255 - color.G), (255 - color.B));
                    a.SetPixel(i, j, color);
                }
            }
            /*
            Detenemos el reloj
            */
            stopWatch.Stop();

            /*
            Recolectamos la información
            */
            tiempo = (long)(stopWatch.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Algoritmo Version 2: " + tiempo);

            /*
            Guardamos la imagen en la carpeta correspondiente
            */
            a.Save("./imagenesInvertidas/" + profundidad + "/" + tamanio + ".bmp");

        }

        /*
        VERSIÓN NO. 4_____________________________________
        */
        /*
        El método AlgoritmoVersion_1 recibe como parametros tres variables:
        - La ruta de la imagen
        - La profundid de la imagen
        - El tamaño de la imagen
        */
        static void AlgoritmoVersion_5(String src, int profundidad, int tamanio)
        {
            /*
            Variable donde se carga los bits de la imagen.
            */
            Bitmap imagenOriginal = new Bitmap(src);

            Bitmap a = imagenOriginal;
            /*
            Variable de color 
            */
            Color color;
            /*
            Variable de tiempo
            */
            long tiempo = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            stopWatch.Start();

            /*
            Ciclos for para iniciar el algotimo de conversion.
            */

            for (int i = 0; i < a.Height - 2; i += 2)
            {
                for (int j = 0; j < a.Width - 2; j += 2)
                {
                    color = a.GetPixel(i, j);
                    color = Color.FromArgb(255, (255 - color.R), (255 - color.G), (255 - color.B));
                    a.SetPixel(i, j, color);

                    color = a.GetPixel(i, j + 1);
                    color = Color.FromArgb(255, (255 - color.R), (255 - color.G), (255 - color.B));
                    a.SetPixel(i, j + 1, color);

                    color = a.GetPixel(i + 1, j);
                    color = Color.FromArgb(255, (255 - color.R), (255 - color.G), (255 - color.B));
                    a.SetPixel(i + 1, j, color);

                    color = a.GetPixel(i + 1, j + 1);
                    color = Color.FromArgb(255, (255 - color.R), (255 - color.G), (255 - color.B));
                    a.SetPixel(i + 1, j + 1, color);

                }
            }

            /*
Detenemos el reloj
*/
            stopWatch.Stop();

            /*
            Recolectamos la información
            */
            tiempo = (long)(stopWatch.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Algoritmo Version 2: " + tiempo);

            /*
            Guardamos la imagen en la carpeta correspondiente
            */
            a.Save("./imagenesInvertidas/" + profundidad + "/" + tamanio + ".bmp");

        }



        /*
        Metodo principal de la clase Program
        */

        static void Main(string[] args)
        {
            /*
            Realizamos la lecturas correspindientes en consola para la ejecución del programa principal
            */

            /*
            Lee la versión del algoritmo que se va utilizar.
            */
            Console.WriteLine("Inserte que versión del algoritmo a utilizar: (ej: 1)");
            int inputVersion = int.Parse(Console.ReadLine());
            /*
            Lee el tamanio de la imagen que se va utilizar.
            */
            Console.WriteLine("Inserte el tamanio de la imagen que se va utilizar: (ej: 640)");
            int inputTamanio = int.Parse(Console.ReadLine());
            /*
            Lee la profundidad de la imagen que se va utilizar.
            */
            Console.WriteLine("Inserte la profundidad de la imagen que se va utilizar: (ej: 32)");
            int inputProfundidad = int.Parse(Console.ReadLine());

            /*
            Ruta de la imagen que se requiere itilizar para la conversión a negativo 
            */
            String imagenUtilizada = "./img/" + inputTamanio + "[" + inputProfundidad + "].bmp";

            /*
            For que controla el numero de ejeciones a realizar: en este caso se realizaran
            3 ejeciones y solo se tendrá en cuenta la última para su correspondiente análisis.
            */
            for (int i = 0; i < 3; i++)
            {


                /*
                Switch para controlar que versión se escogerá para la conversión de la imagen
                */
                switch (inputVersion)
                {

                    case 1:
                        if (inputTamanio == 64)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 160)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 512)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 1500)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }
                        break;
                    case 2:
                        if (inputTamanio == 64)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 160)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 512)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 1500)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }
                        break;
                    case 3:
                        if (inputTamanio == 64)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 160)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 512)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 1500)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }
                        break;

                    case 4:

                        if (inputTamanio == 64)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 160)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 512)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 1500)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }
                        break;

                    case 5:

                        if (inputTamanio == 64)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 160)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 512)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }

                        if (inputTamanio == 1500)
                        {

                            if (inputProfundidad == 16)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 24)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }
                            if (inputProfundidad == 32)
                            {
                                AlgoritmoVersion_1(imagenUtilizada, inputProfundidad, inputTamanio);
                            }

                        }
                        break;

                }


            }


        }

        /*
        Fin de la ejeción del programa.
        */


    }



}