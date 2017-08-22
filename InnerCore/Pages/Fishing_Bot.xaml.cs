using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;
using System.Drawing;






namespace InnerCore.Pages
{
    /// <summary>
    /// Interaction logic for Fishing_Bot.xaml
    /// </summary>
    public partial class Fishing_Bot : UserControl
    {
        bool toggle_aktiv = false;
        Thread Observer_trd;


        bool foundletter = false;
        Letter keyletter;
        //Create a new bitmap.
        static Bitmap bmpScreenshot = new Bitmap(120, 152);


        System.Drawing.Color color_;

        // Create a graphics object from the bitmap.
        static Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);

        List<Letter> Letterlist = new List<Letter>();

        Letter A = new Letter("a");
        Letter C = new Letter("c");
        Letter D = new Letter("d");
        Letter E = new Letter("e");
        Letter Q = new Letter("q");
        Letter S = new Letter("s");
        Letter W = new Letter("w");
        Letter X = new Letter("x");
        Letter Z = new Letter("z");


        public Fishing_Bot()
        {
            InitializeComponent();
            aktiv_image.Visibility = Visibility.Hidden;
            FhishingObserverInit();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (toggle_aktiv == false)
            {
                unaktiv_image.Visibility = Visibility.Hidden;
                aktiv_image.Visibility = Visibility.Visible;
                button.Content = "Stop Fishing Bot";
                toggle_aktiv = true;

              //  FhishingObserver mFhishingObserver = new FhishingObserver();
                Observer_trd = new Thread(new ThreadStart(ThreadFhishingObserver));
                Observer_trd.IsBackground = true;
                Observer_trd.Start();

            }
            else
            {
                aktiv_image.Visibility = Visibility.Hidden;
                unaktiv_image.Visibility = Visibility.Visible;
                button.Content = "Start Fishing Bot";
                toggle_aktiv = false;
                Observer_trd.Abort();
            }
        }

        public void showText(string text)
        {
            if (Application.Current.Dispatcher.CheckAccess())
            {
                this.show_detected_letter.Text = (text.ToUpper());
            }
            else
            {
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
                {
                    this.show_detected_letter.Text = (text.ToUpper());
                }));
            }
        }





public void FhishingObserverInit()
        {
            Letterlist.Add(A);
            Pixel aw_1 = new Pixel(58, 108, PixelColor.WHITE);
            A.AddPixel(aw_1);
            Pixel aw_2 = new Pixel(58, 22, PixelColor.WHITE);
            A.AddPixel(aw_2);
            Pixel aw_3 = new Pixel(71, 52, PixelColor.WHITE);
            A.AddPixel(aw_3);
            Pixel aw_4 = new Pixel(83, 90, PixelColor.WHITE);
            A.AddPixel(aw_4);


            Letterlist.Add(C);
            Pixel cw_1 = new Pixel(59, 140, PixelColor.WHITE);
            C.AddPixel(cw_1);
            Pixel cw_2 = new Pixel(78, 111, PixelColor.WHITE);
            C.AddPixel(cw_2);
            Pixel cw_3 = new Pixel(39, 91, PixelColor.WHITE);
            C.AddPixel(cw_3);
            Pixel cb_1 = new Pixel(78, 88, PixelColor.BLACK);
            C.AddPixel(cb_1);
            Pixel cb_2 = new Pixel(78, 61, PixelColor.BLACK);
            C.AddPixel(cb_2);

            Letterlist.Add(D);
            Pixel dw_1 = new Pixel(60, 137, PixelColor.WHITE);
            D.AddPixel(dw_1);
            Pixel dw_2 = new Pixel(80, 60, PixelColor.WHITE);
            D.AddPixel(dw_2);
            Pixel db_1 = new Pixel(60, 151, PixelColor.BLACK);
            D.AddPixel(db_1);

            Letterlist.Add(E);
            Pixel ew_1 = new Pixel(56, 136, PixelColor.WHITE);
            E.AddPixel(ew_1);
            Pixel ew_2 = new Pixel(56, 76, PixelColor.WHITE);
            E.AddPixel(ew_2);
            Pixel ew_3 = new Pixel(43, 40, PixelColor.WHITE);
            E.AddPixel(ew_3);
            Pixel ew_4 = new Pixel(76, 15, PixelColor.WHITE);
            E.AddPixel(ew_4);
            Pixel eb_1 = new Pixel(79, 31, PixelColor.BLACK);
            E.AddPixel(eb_1);

            Letterlist.Add(Q);
            Pixel qw_1 = new Pixel(60, 151, PixelColor.WHITE);
            Q.AddPixel(qw_1);
            Pixel qw_2 = new Pixel(78, 40, PixelColor.WHITE);
            Q.AddPixel(qw_2);
            Pixel qw_3 = new Pixel(59, 13, PixelColor.WHITE);
            Q.AddPixel(qw_3);
            Pixel qw_4 = new Pixel(40, 111, PixelColor.WHITE);
            Q.AddPixel(qw_4);


            Letterlist.Add(S);
            Pixel sw_1 = new Pixel(59, 141, PixelColor.WHITE);
            S.AddPixel(sw_1);
            Pixel sw_2 = new Pixel(59, 75, PixelColor.WHITE);
            S.AddPixel(sw_2);
            Pixel sw_3 = new Pixel(59, 13, PixelColor.WHITE);
            S.AddPixel(sw_3);
            Pixel sb_1 = new Pixel(78, 44, PixelColor.WHITE);
            S.AddPixel(sb_1);

            Letterlist.Add(W);
            Pixel ww_1 = new Pixel(110, 26, PixelColor.WHITE);
            W.AddPixel(ww_1);
            Pixel ww_2 = new Pixel(8, 38, PixelColor.WHITE);
            W.AddPixel(ww_2);
            Pixel ww_3 = new Pixel(59, 59, PixelColor.WHITE);
            W.AddPixel(ww_3);

            Letterlist.Add(X);
            Pixel xw_1 = new Pixel(59, 90, PixelColor.WHITE);
            X.AddPixel(xw_1);
            Pixel xw_2 = new Pixel(61, 50, PixelColor.WHITE);
            X.AddPixel(xw_2);
            Pixel xw_3 = new Pixel(79, 12, PixelColor.WHITE);
            X.AddPixel(xw_3);
            Pixel xw_4 = new Pixel(45, 35, PixelColor.WHITE);
            X.AddPixel(xw_4);
          
            Letterlist.Add(Z);
            Pixel zw_1 = new Pixel(59, 138, PixelColor.WHITE);
            Z.AddPixel(zw_1);
            Pixel zw_2 = new Pixel(59, 72, PixelColor.WHITE);
            Z.AddPixel(zw_2);
            Pixel zw_3 = new Pixel(68, 39, PixelColor.WHITE);
            Z.AddPixel(zw_3);
        }

        public void ThreadFhishingObserver()
        {
            while (true)
            {

                if (foundletter == false)
                {
                    // Take the screenshot from the upper left corner to the right bottom corner.
                    //gfxScreenshot.CopyFromScreen(1140, 860, 0, 0, bmpScreenshot.Size, CopyPixelOperation.SourceCopy);
                    foreach (Letter letter in Letterlist)
                    {
                  //       bmpScreenshot.Save("img.png", System.Drawing.Imaging.ImageFormat.Png);
                        // Take the screenshot from the upper left corner to the right bottom corner.
                        gfxScreenshot.CopyFromScreen(1103, 854, 0, 0, bmpScreenshot.Size, CopyPixelOperation.SourceCopy);


                        foreach (Pixel pixel in letter.Pixellist)
                        {
                            color_ = bmpScreenshot.GetPixel(pixel.X, pixel.Y);

                            if (pixel.Color == PixelColor.BLACK)
                            {
                                if (true == (color_.R > 249 || color_.G > 249 || color_.B > 249))
                                {
                                    break;
                                }
                            }
                            if (pixel.Color == PixelColor.WHITE)
                            {
                                if (true == (color_.R < 249 || color_.G < 249 || color_.B < 249))
                                {
                                    break;
                                }
                            }
                            if (pixel == letter.Pixellist.Last())
                            {
                                foundletter = true;
                                keyletter = letter;
                                System.Windows.Forms.SendKeys.SendWait(letter.key);
                                showText(letter.key);
                            }

                        }
                        if (foundletter == true)
                        {
                            break;
                        }

                    }
                }
                else
                {
                    foreach (Pixel pixel in keyletter.Pixellist)
                    {
                        var color_ = bmpScreenshot.GetPixel(pixel.X, pixel.Y);
                        // Take the screenshot from the upper left corner to the right bottom corner.
                        gfxScreenshot.CopyFromScreen(1103, 854, 0, 0, bmpScreenshot.Size, CopyPixelOperation.SourceCopy);
                        if (pixel.Color == PixelColor.WHITE)
                        {
                            if (true == (color_.R < 110 && color_.G > 230 && color_.B < 115))
                            {
                                foundletter = false;
                                showText("");
                                break;
                            }
                        }
                    }
                }


                   }
                }

                
            }
}



