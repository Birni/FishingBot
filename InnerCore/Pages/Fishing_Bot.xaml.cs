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
        static Bitmap bmpScreenshot = new Bitmap(130, 140);


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
            Pixel aw_1 = new Pixel(63, 22, PixelColor.WHITE);
            A.AddPixel(aw_1);
            Pixel aw_2 = new Pixel(65, 92, PixelColor.WHITE);
            A.AddPixel(aw_2);
            Pixel aw_3 = new Pixel(108, 117, PixelColor.WHITE);
            A.AddPixel(aw_3);
            Pixel ab_1 = new Pixel(63, 65, PixelColor.BLACK);
            A.AddPixel(ab_1);

            Letterlist.Add(C);
            Pixel cw_1 = new Pixel(36, 31, PixelColor.WHITE);
            C.AddPixel(cw_1);
            Pixel cw_2 = new Pixel(106, 36, PixelColor.WHITE);
            C.AddPixel(cw_2);
            Pixel cw_3 = new Pixel(43, 43, PixelColor.WHITE);
            C.AddPixel(cw_3);
            Pixel cb_1 = new Pixel(88, 41, PixelColor.BLACK);
            C.AddPixel(cb_1);

            Letterlist.Add(D);
            Pixel dw_1 = new Pixel(22, 20, PixelColor.WHITE);
            D.AddPixel(dw_1);
            Pixel dw_2 = new Pixel(104, 100, PixelColor.WHITE);
            D.AddPixel(dw_2);
            Pixel dw_3 = new Pixel(41, 31, PixelColor.WHITE);
            D.AddPixel(dw_3);
            Pixel db_1 = new Pixel(47, 66, PixelColor.BLACK);
            D.AddPixel(db_1);

            Letterlist.Add(E);
            Pixel ew_1 = new Pixel(97, 70, PixelColor.WHITE);
            E.AddPixel(ew_1);
            Pixel ew_2 = new Pixel(57, 70, PixelColor.WHITE);
            E.AddPixel(ew_2);
            Pixel ew_3 = new Pixel(69, 31, PixelColor.WHITE);
            E.AddPixel(ew_3);
            Pixel ew_4 = new Pixel(37, 97, PixelColor.WHITE);
            E.AddPixel(ew_4);
            Pixel eb_1 = new Pixel(66, 52, PixelColor.BLACK);
            E.AddPixel(eb_1);

            Letterlist.Add(Q);
            Pixel qw_1 = new Pixel(81, 134, PixelColor.WHITE);
            Q.AddPixel(qw_1);
            Pixel qw_2 = new Pixel(113, 67, PixelColor.WHITE);
            Q.AddPixel(qw_2);
            Pixel qw_3 = new Pixel(48, 107, PixelColor.WHITE);
            Q.AddPixel(qw_3);
            Pixel qb_1 = new Pixel(39, 72, PixelColor.BLACK);
            Q.AddPixel(qb_1);

            Letterlist.Add(S);
            Pixel sw_1 = new Pixel(37, 112, PixelColor.WHITE);
            S.AddPixel(sw_1);
            Pixel sw_2 = new Pixel(98, 36, PixelColor.WHITE);
            S.AddPixel(sw_2);
            Pixel sw_3 = new Pixel(100, 78, PixelColor.WHITE);
            S.AddPixel(sw_3);
            Pixel sb_1 = new Pixel(26, 78, PixelColor.BLACK);
            S.AddPixel(sb_1);
            Pixel sb_2 = new Pixel(37, 97, PixelColor.BLACK);
            S.AddPixel(sb_2);

            Letterlist.Add(W);
            Pixel ww_1 = new Pixel(0, 20, PixelColor.WHITE);
            W.AddPixel(ww_1);
            Pixel ww_2 = new Pixel(125, 20, PixelColor.WHITE);
            W.AddPixel(ww_2);
            Pixel ww_3 = new Pixel(114, 93, PixelColor.WHITE);
            W.AddPixel(ww_3);
            Pixel wb_1 = new Pixel(63, 66, PixelColor.BLACK);
            W.AddPixel(wb_1);

            Letterlist.Add(X);
            Pixel xw_1 = new Pixel(28, 104, PixelColor.WHITE);
            X.AddPixel(xw_1);
            Pixel xw_2 = new Pixel(98, 36, PixelColor.WHITE);
            X.AddPixel(xw_2);
            Pixel xw_3 = new Pixel(66, 68, PixelColor.WHITE);
            X.AddPixel(xw_3);
            Pixel xw_4 = new Pixel(80, 47, PixelColor.WHITE);
            X.AddPixel(xw_4);
            Pixel xb_1 = new Pixel(22, 97, PixelColor.BLACK);
            X.AddPixel(xb_1);
          

            Letterlist.Add(Z);
            Pixel zw_1 = new Pixel(93, 45, PixelColor.WHITE);
            Z.AddPixel(zw_1);
            Pixel zw_2 = new Pixel(49, 82, PixelColor.WHITE);
            Z.AddPixel(zw_2);
            Pixel zw_3 = new Pixel(61, 120, PixelColor.WHITE);
            Z.AddPixel(zw_3);
            //old 30 41
            Pixel zb_1 = new Pixel(32, 43, PixelColor.BLACK);
            Z.AddPixel(zb_1);
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
                        //     bmpScreenshot.Save("test.png", System.Drawing.Imaging.ImageFormat.Png);
                        // Take the screenshot from the upper left corner to the right bottom corner.
                        gfxScreenshot.CopyFromScreen(1140, 860, 0, 0, bmpScreenshot.Size, CopyPixelOperation.SourceCopy);

                        foreach (Pixel pixel in letter.Pixellist)
                        {
                            color_ = bmpScreenshot.GetPixel(pixel.X, pixel.Y);

                            if (pixel.Color == PixelColor.BLACK)
                            {
                                if (true == (color_.R > 115 || color_.G > 115 || color_.B > 115))
                                {
                                    break;
                                }
                            }
                            if (pixel.Color == PixelColor.WHITE)
                            {
                                if (true == (color_.R < 220 || color_.G < 220 || color_.B < 220))
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
                        gfxScreenshot.CopyFromScreen(1140, 860, 0, 0, bmpScreenshot.Size, CopyPixelOperation.SourceCopy);
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



