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
using AForge.Controls;
using System.Threading;


namespace Piu__Input_Test
{
    /// <summary>
    /// Lógica de interacción para IO.xaml
    /// </summary>
    public partial class IO : UserControl
    {
        private Joystick joystick;
        private Thread botonesActivos;
        private Data data;
        public IO()
        {
            InitializeComponent(); 
            CargaJoystick();
            
          
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
         
            Config config = new Config();
            Panel.Children.Clear();
            Panel.Children.Add(config);
        }

       
       

        private void CargaJoystick()
        {
            try
            {
                joystick = new Joystick(0);
                botonesActivos = new Thread(detectarBotones);


                botonesActivos.Start();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message); 
            }
            
          
        }
  

        private void detectarBotones() {
           
            var UpLeft = calibrarUpLeft();
            var UpRight = calibrarUpRight();
            var Center = calibrarCenter();
            var DownLeft = calibrarDownLeft();
            var DownRight = calibrarDownRight();

            while (true)
            {
                Thread.Sleep(50);
                Joystick.Status status = joystick.GetCurrentStatus();
                changeBotonCenter(status.IsButtonPressed(Center));
                changeBotonUpLeft(status.IsButtonPressed(UpLeft));
                changeBotonUpRight(status.IsButtonPressed(UpRight));
                changeBotonDownLeft(status.IsButtonPressed(DownLeft));
                changeBotonDownRight(status.IsButtonPressed(DownRight));
              

            }
        

        }

        private Joystick.Buttons calibrarDownRight()
        {
            var buttonDownRight = Joystick.Buttons.Button12;
            data = new Data();
            switch (Int32.Parse(data.DownRight))
            {

                case 1:
                    buttonDownRight = Joystick.Buttons.Button1;
                    break;
                case 2:
                    buttonDownRight = Joystick.Buttons.Button2;
                    break;
                case 3:
                    buttonDownRight = Joystick.Buttons.Button3;
                    break;
                case 4:
                    buttonDownRight = Joystick.Buttons.Button4;
                    break;
                case 5:
                    buttonDownRight = Joystick.Buttons.Button5;
                    break;
                case 6:
                    buttonDownRight = Joystick.Buttons.Button6;
                    break;
                case 7:
                    buttonDownRight = Joystick.Buttons.Button7;
                    break;
                case 8:
                    buttonDownRight = Joystick.Buttons.Button8;
                    break;
                case 9:
                    buttonDownRight = Joystick.Buttons.Button9;
                    break;
                case 10:
                    buttonDownRight = Joystick.Buttons.Button10;
                    break;
                case 11:
                    buttonDownRight = Joystick.Buttons.Button11;
                    break;
            }

            return buttonDownRight;
        }

        private Joystick.Buttons calibrarDownLeft()
        {
            var buttonDownLeft = Joystick.Buttons.Button12;
            data = new Data();
            switch (Int32.Parse(data.DownLeft))
            {

                case 1:
                    buttonDownLeft = Joystick.Buttons.Button1;
                    break;
                case 2:
                    buttonDownLeft = Joystick.Buttons.Button2;
                    break;
                case 3:
                    buttonDownLeft = Joystick.Buttons.Button3;
                    break;
                case 4:
                    buttonDownLeft = Joystick.Buttons.Button4;
                    break;
                case 5:
                    buttonDownLeft = Joystick.Buttons.Button5;
                    break;
                case 6:
                    buttonDownLeft = Joystick.Buttons.Button6;
                    break;
                case 7:
                    buttonDownLeft = Joystick.Buttons.Button7;
                    break;
                case 8:
                    buttonDownLeft = Joystick.Buttons.Button8;
                    break;
                case 9:
                    buttonDownLeft = Joystick.Buttons.Button9;
                    break;
                case 10:
                    buttonDownLeft = Joystick.Buttons.Button10;
                    break;
                case 11:
                    buttonDownLeft = Joystick.Buttons.Button11;
                    break;
            }

            return buttonDownLeft;
        }

        private Joystick.Buttons calibrarCenter()
        {
            var buttonCenter = Joystick.Buttons.Button12;
            data = new Data();
            switch (Int32.Parse(data.Center))
            {

                case 1:
                    buttonCenter = Joystick.Buttons.Button1;
                    break;
                case 2:
                    buttonCenter = Joystick.Buttons.Button2;
                    break;
                case 3:
                    buttonCenter = Joystick.Buttons.Button3;
                    break;
                case 4:
                    buttonCenter = Joystick.Buttons.Button4;
                    break;
                case 5:
                    buttonCenter = Joystick.Buttons.Button5;
                    break;
                case 6:
                    buttonCenter = Joystick.Buttons.Button6;
                    break;
                case 7:
                    buttonCenter = Joystick.Buttons.Button7;
                    break;
                case 8:
                    buttonCenter = Joystick.Buttons.Button8;
                    break;
                case 9:
                    buttonCenter = Joystick.Buttons.Button9;
                    break;
                case 10:
                    buttonCenter = Joystick.Buttons.Button10;
                    break;
                case 11:
                    buttonCenter = Joystick.Buttons.Button11;
                    break;
            }

            return buttonCenter;
        }

        private Joystick.Buttons calibrarUpRight()
        {
            var buttonUpRight = Joystick.Buttons.Button12;
            data = new Data();
            switch (Int32.Parse(data.UpRight))
            {

                case 1:
                    buttonUpRight = Joystick.Buttons.Button1;
                    break;
                case 2:
                    buttonUpRight = Joystick.Buttons.Button2;
                    break;
                case 3:
                    buttonUpRight = Joystick.Buttons.Button3;
                    break;
                case 4:
                    buttonUpRight = Joystick.Buttons.Button4;
                    break;
                case 5:
                    buttonUpRight = Joystick.Buttons.Button5;
                    break;
                case 6:
                    buttonUpRight = Joystick.Buttons.Button6;
                    break;
                case 7:
                    buttonUpRight = Joystick.Buttons.Button7;
                    break;
                case 8:
                    buttonUpRight = Joystick.Buttons.Button8;
                    break;
                case 9:
                    buttonUpRight = Joystick.Buttons.Button9;
                    break;
                case 10:
                    buttonUpRight = Joystick.Buttons.Button10;
                    break;
                case 11:
                    buttonUpRight = Joystick.Buttons.Button11;
                    break;
            }

            return buttonUpRight;
        }

        private Joystick.Buttons calibrarUpLeft()
        {
            var buttonUpLeft= Joystick.Buttons.Button12;
            data = new Data();
            switch (Int32.Parse(data.UpLeft))
            {
               
                case 1:
                    buttonUpLeft = Joystick.Buttons.Button1;
                    break;
                case 2:
                    buttonUpLeft = Joystick.Buttons.Button2;
                    break;
                case 3:
                    buttonUpLeft = Joystick.Buttons.Button3;
                    break;
                case 4:
                    buttonUpLeft = Joystick.Buttons.Button4;
                    break;
                case 5:
                    buttonUpLeft = Joystick.Buttons.Button5;
                    break;
                case 6:
                    buttonUpLeft = Joystick.Buttons.Button6;
                    break;
                case 7:
                    buttonUpLeft = Joystick.Buttons.Button7;
                    break;
                case 8:
                    buttonUpLeft = Joystick.Buttons.Button8;
                    break;
                case 9:
                    buttonUpLeft = Joystick.Buttons.Button9;
                    break;
                case 10:
                    buttonUpLeft = Joystick.Buttons.Button10;
                    break;
                case 11:
                    buttonUpLeft = Joystick.Buttons.Button11;
                    break;
            }

            return buttonUpLeft;
        }

        delegate void changeBotonCenterDelegate(Boolean estado);
        private void changeBotonCenter(Boolean estado)
        {


            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(new changeBotonCenterDelegate(changeBotonCenter), estado);
                return;
            }



            if (estado)
                Center.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);
          
            else
                Center.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
        




        }

      

        delegate void changeBotonUpLeftDelegate(Boolean estado);
        private void changeBotonUpLeft(Boolean estado)
        {


            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(new changeBotonUpLeftDelegate(changeBotonUpLeft), estado);
                return;
            }


            if (estado)
                UpLeft.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);

            else
                UpLeft.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);




        }

       

        delegate void changeBotonUpRightDelegate(Boolean estado);
        private void changeBotonUpRight(Boolean estado)
        {


            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(new changeBotonUpRightDelegate(changeBotonUpRight), estado);
                return;
            }


            if (estado)
                UpRight.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);

            else
                UpRight.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);




        }


       

        delegate void changeBotonDownLefttDelegate(Boolean estado);
        private void changeBotonDownLeft(Boolean estado)
        {


            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(new changeBotonDownLefttDelegate(changeBotonDownLeft), estado);
                return;
            }


            if (estado)
                DownLeft.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);

            else
                DownLeft.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);




        }



        delegate void changeBotonDownRightDelegate(Boolean estado);
        private void changeBotonDownRight(Boolean estado)
        {


            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(new changeBotonDownRightDelegate(changeBotonDownRight), estado);
                return;
            }


            if (estado)
                DownRight.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Red);

            else
                DownRight.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Yellow);




        }
    }
}
