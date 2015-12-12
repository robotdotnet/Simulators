using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using HAL.Simulator;
using Microsoft.Xna.Framework;
using Color = System.Drawing.Color;
using Microsoft.Xna.Framework.Input;

namespace DriverStationGUI
{
    public partial class DriverStation : Form
    {
        private static Thread s_dsThread;
        /// <summary>
        /// Starts the Driver Station GUI in a seperate thread.
        /// </summary>
        public static void StartDriverStationGui()
        {
            s_dsThread = new Thread(Run);
            s_dsThread.Start();
        }

        private static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DriverStation());
        }

        int[] controllerIndex = new int[4];

        Controller controller = new Controller();

        public DriverStation()
        {
            for (int i = 0; i < 4; i++)
            {
                controllerIndex[i] = i;
            }

            InitializeComponent();
            DriverStationHelper.SetRobotMode(DriverStationHelper.RobotMode.Teleop);
            DriverStationHelper.SetEnabledState(DriverStationHelper.EnabledState.Disabled);
            DriverStationHelper.JoystickCallback = UpdateJoysticks;
            DriverStationHelper.StartDSLoop();
        }

        public void UpdateJoysticks()
        {
            controller.updateInput();
            setEnabledControllers(controller.GetActiveControllers());
            for (int i = 0; i < 4; i++)
            {
                float[] sticks;
                bool[] buts;
                controller.GetControllerData(controllerIndex[i], out sticks, out buts);
                DriverStationHelper.SetJoystickAxesCount(i, sticks.Length);
                for (int j = 0; j < sticks.Length; j++)
                {
                    DriverStationHelper.SetJoystickAxis(i, j, sticks[j]);
                }
                DriverStationHelper.SetJoystickButtonCount(i, buts.Length);
                for (int j = 0; j < buts.Length; j++)
                {
                    DriverStationHelper.SetJoystickButton(i, j + 1, buts[j]);
                }
            }
        }

        public bool checkButtonPress(byte data1, byte data2, int controller)
        {
            bool set = false;
            if (data1 != 0 || data2 != 0)
            {
                setChecked(true, controller.ToString());
                set = true;
            }
            return set;
        }

        private void setChecked(bool a, string b)
        {
            if (this.CheckButtons.InvokeRequired)
            {
                Action<bool, string> d = setChecked;
                this.Invoke(d, new object[] { a, b });
            }
            else
            {
                this.CheckButtons.Checked = a;
                this.CheckButtons.Text = b;
            }
        }

        private void Controller_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            string name = box.Name;
            switch (name)
            {
                case "controller1":
                    {
                        switch (box.SelectedIndex)
                        {
                            case 0: controllerIndex[0] = (int)(0); break;
                            case 1: controllerIndex[0] = (int)(1); break;
                            case 2: controllerIndex[0] = (int)(2); break;
                            case 3: controllerIndex[0] = (int)(3); break;
                            case 4: controllerIndex[0] = (int)(4); break;
                            case 5: controllerIndex[0] = (int)(5); break;
                            case 6: controllerIndex[0] = (int)(6); break;
                            case 7: controllerIndex[0] = (int)(7); break;
                            default: controllerIndex[0] = (int)(0); break;
                        }
                        break;
                    }
                case "controller2":
                    {
                        switch (box.SelectedIndex)
                        {
                            case 0: controllerIndex[1] = (int)(0); break;
                            case 1: controllerIndex[1] = (int)(1); break;
                            case 2: controllerIndex[1] = (int)(2); break;
                            case 3: controllerIndex[1] = (int)(3); break;
                            case 4: controllerIndex[1] = (int)(4); break;
                            case 5: controllerIndex[1] = (int)(5); break;
                            case 6: controllerIndex[1] = (int)(6); break;
                            case 7: controllerIndex[1] = (int)(7); break;
                            default: controllerIndex[1] = (int)(0); break;
                        }
                        break;
                    }
                case "controller3":
                    {
                        switch (box.SelectedIndex)
                        {
                            case 0: controllerIndex[2] = (int)(0); break;
                            case 1: controllerIndex[2] = (int)(1); break;
                            case 2: controllerIndex[2] = (int)(2); break;
                            case 3: controllerIndex[2] = (int)(3); break;
                            case 4: controllerIndex[2] = (int)(4); break;
                            case 5: controllerIndex[2] = (int)(5); break;
                            case 6: controllerIndex[2] = (int)(6); break;
                            case 7: controllerIndex[2] = (int)(7); break;
                            default: controllerIndex[2] = (int)(0); break;
                        }
                        break;
                    }
                case "controller4":
                    {
                        switch (box.SelectedIndex)
                        {
                            case 0: controllerIndex[3] = (int)(0); break;
                            case 1: controllerIndex[3] = (int)(1); break;
                            case 2: controllerIndex[3] = (int)(2); break;
                            case 3: controllerIndex[3] = (int)(3); break;
                            case 4: controllerIndex[3] = (int)(4); break;
                            case 5: controllerIndex[3] = (int)(5); break;
                            case 6: controllerIndex[3] = (int)(6); break;
                            case 7: controllerIndex[3] = (int)(7); break;
                            default: controllerIndex[3] = (int)(0); break;
                        }
                        break;
                    }
                default: { break; }
            }
        }

        public void setEnabledControllers(ActiveController[] active)
        {
            if (active[(int)controllerIndex[0]].Active)
            {
                SetBox1(Color.GreenYellow);
            }
            else
                SetBox1(Color.Violet);
            if (active[(int)controllerIndex[1]].Active)
            {
                SetBox2(Color.GreenYellow);
            }
            else
                SetBox2(Color.Violet);
            if (active[(int)controllerIndex[2]].Active)
            {
                SetBox3(Color.GreenYellow);
            }
            else
                SetBox3(Color.Violet);
            if (active[(int)controllerIndex[3]].Active)
            {
                SetBox4(Color.GreenYellow);
            }
            else
                SetBox4(Color.Violet);
        }

        private void SetBox1(Color color)
        {
            if (this.Controller1Panel.InvokeRequired)
            {
                Action<Color> d = new Action<Color>(SetBox1);
                this.Invoke(d, new object[] { color });
            }
            else
                this.Controller1Panel.BackColor = color;
        }
        private void SetBox2(Color color)
        {
            if (this.Controller2Panel.InvokeRequired)
            {
                Action<Color> d = new Action<Color>(SetBox2);
                this.Invoke(d, new object[] { color });
            }
            else
                this.Controller2Panel.BackColor = color;
        }
        private void SetBox3(Color color)
        {
            if (this.Controller3Panel.InvokeRequired)
            {
                Action<Color> d = new Action<Color>(SetBox3);
                this.Invoke(d, new object[] { color });
            }
            else
                this.Controller3Panel.BackColor = color;
        }
        private void SetBox4(Color color)
        {
            if (this.Controller4Panel.InvokeRequired)
            {
                Action<Color> d = new Action<Color>(SetBox4);
                this.Invoke(d, new object[] { color });
            }
            else
                this.Controller4Panel.BackColor = color;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            disableButton.PerformClick();
            if (teleopRadio.Checked)
            {
                DriverStationHelper.SetRobotMode(DriverStationHelper.RobotMode.Teleop);
            }
            else if (autonRadio.Checked)
            {
                DriverStationHelper.SetRobotMode(DriverStationHelper.RobotMode.Autonomous);
            }
            if (testRadio.Checked)
            {
                DriverStationHelper.SetRobotMode(DriverStationHelper.RobotMode.Test);
            }
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            DriverStationHelper.SetEnabledState(DriverStationHelper.EnabledState.Enabled);
            enableButton.Enabled = false;
            disableButton.Enabled = true;
            enableButton.BackColor = Color.Green;
            disableButton.BackColor = DefaultBackColor;
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            DriverStationHelper.SetEnabledState(DriverStationHelper.EnabledState.Disabled);
            enableButton.Enabled = true;
            disableButton.Enabled = false;
            enableButton.BackColor = DefaultBackColor;
            disableButton.BackColor = Color.Red;
        }
    }
}
