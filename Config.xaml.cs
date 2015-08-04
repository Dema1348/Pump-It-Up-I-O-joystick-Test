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
    /// Lógica de interacción para Config.xaml
    /// </summary>
    public partial class Config : UserControl
    {
        private Joystick joystick;
        private Thread botonesActivos;
        private int labelIndex;
        public Config()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            Data data = new Data();
            LabelUpLeft.Text =data.UpLeft;
            LabelUpRight.Text = data.UpRight;
            LabelCenter.Text = data.Center;
            LabelDownLeft.Text = data.DownLeft;
            LabelDownRight.Text = data.DownRight;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            IO io = new IO();
            Panel.Children.Clear();
            Panel.Children.Add(io);
        }

        private void LabelUpLeft_GotFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                joystick = new Joystick(0);
                botonesActivos = new Thread(detectarBotones);
                labelIndex = 1;
                botonesActivos.Start();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
           
            
        }

        private void detectarBotones()
        {
            while (true)
            {
                Thread.Sleep(100);
                Joystick.Status status = joystick.GetCurrentStatus();
                if (status.IsButtonPressed(Joystick.Buttons.Button1))
                    changeLabel(1, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button2))
                    changeLabel(2, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button3))
                    changeLabel(3, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button4))
                    changeLabel(4, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button5))
                    changeLabel(5, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button6))
                    changeLabel(6, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button7))
                    changeLabel(7, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button8))
                    changeLabel(8, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button9))
                    changeLabel(9, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button10))
                    changeLabel(10, labelIndex);
                if (status.IsButtonPressed(Joystick.Buttons.Button11))
                    changeLabel(11, labelIndex);


            }


        }


        delegate void changeLabelDelegate(int button, int labelIndex);
        private void changeLabel(int button, int labelIndex)
        {

            if (!Dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(new changeLabelDelegate(changeLabel), button, labelIndex);
                return;
            }

                switch (labelIndex) {
                    case 1:
                        LabelUpLeft.Text = button.ToString();
                        break;
                    case 2:
                        LabelUpRight.Text = button.ToString();
                        break;
                    case 3:
                        LabelCenter.Text = button.ToString();
                        break;
                    case 4:
                        LabelDownLeft.Text = button.ToString();
                        break;
                    case 5:
                        LabelDownRight.Text = button.ToString();
                        break;


            }
               
        }

        private void LabelUpLeft_LostFocus(object sender, RoutedEventArgs e)
        {
            botonesActivos.Abort();
            
        }

        private void LabelUpRight_GotFocus(object sender, RoutedEventArgs e)
        {
            joystick = new Joystick(0);
            botonesActivos = new Thread(detectarBotones);
            labelIndex = 2;
            botonesActivos.Start();
        }

        private void LabelCenter_GotFocus(object sender, RoutedEventArgs e)
        {
            joystick = new Joystick(0);
            botonesActivos = new Thread(detectarBotones);
            labelIndex = 3;
            botonesActivos.Start();
        }

        private void LabelDownLeft_GotFocus(object sender, RoutedEventArgs e)
        {
            joystick = new Joystick(0);
            botonesActivos = new Thread(detectarBotones);
            labelIndex = 4;
            botonesActivos.Start();
        }

        private void LabelDownRight_GotFocus(object sender, RoutedEventArgs e)
        {
            joystick = new Joystick(0);
            botonesActivos = new Thread(detectarBotones);
            labelIndex = 5;
            botonesActivos.Start();
        }

        private void LabelUpRight_LostFocus(object sender, RoutedEventArgs e)
        {
            botonesActivos.Abort();
        }

        private void LabelCenter_LostFocus(object sender, RoutedEventArgs e)
        {
            botonesActivos.Abort();
        }

        private void LabelDownLeft_LostFocus(object sender, RoutedEventArgs e)
        {
            botonesActivos.Abort();
        }

        private void LabelDownRight_LostFocus(object sender, RoutedEventArgs e)
        {
            botonesActivos.Abort();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Data.UpdateSetting("UpLeft",LabelUpLeft.Text);
            Data.UpdateSetting("UpRight",LabelUpRight.Text);
            Data.UpdateSetting("Center",LabelCenter.Text );
            Data.UpdateSetting("DownLeft",LabelDownLeft.Text );
            Data.UpdateSetting("DownRight",LabelDownRight.Text );
         
            MessageBox.Show("Ok");
        }
    }
}
