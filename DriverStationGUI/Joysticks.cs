using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DriverStationGUI
{
    public struct ActiveController
    {
        public bool Active { get; set; }
        public bool IsXbox { get; set; }
        public int NumAxes { get; set; }
        public int NumButtons { get; set; }
    }

    public class Controller
    {
        readonly ActiveController[] activeControllers = new ActiveController[8];
        bool _continue = true;
        public bool getContinue()
        {
            return _continue;
        }
        public void updateInput()
        {
            if (_continue)
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        var capabilities = GamePad.GetCapabilities((PlayerIndex) i);
                        if (capabilities.IsConnected)
                        {
                            activeControllers[i].Active = true;
                            activeControllers[i].IsXbox = true;
                            activeControllers[i].NumAxes = 6;
                            activeControllers[i].NumButtons = 10;
                        }
                        else
                        {
                            activeControllers[i].Active = false;
                            activeControllers[i].NumAxes = 0;
                            activeControllers[i].NumButtons = 0;
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        JoystickCapabilities capabilities = Joystick.GetCapabilities(i);
                        if (capabilities.IsConnected)
                        {
                            activeControllers[i + 4].Active = true;
                            activeControllers[i].IsXbox = false;
                            activeControllers[i + 4].NumAxes = capabilities.AxisCount;
                            activeControllers[i + 4].NumButtons = capabilities.ButtonCount;
                        }
                        else
                        {
                            activeControllers[i + 4].Active = false;
                            activeControllers[i + 4].NumAxes = 0;
                            activeControllers[i + 4].NumButtons = 0;
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Please Restart Program to Poll New Controllers");
                    _continue = false;
                }
            }
        }
        public ActiveController[] GetActiveControllers()
        {
            return activeControllers;
        }
        public void GetControllerData(int index, out float[] axis, out bool[] buttons)
        {
            axis = GetAxes(index);
            buttons = GetButtons(index);
        }

        public bool[] GetButtons(int pad)
        {
            ActiveController active = activeControllers[pad];
            if (active.Active)
            {
                if (active.IsXbox)
                {
                    var buttons = GamePad.GetState((PlayerIndex)pad).Buttons;
                    bool[] result = new bool[10];
                    result[0] = (buttons.A == ButtonState.Pressed);
                    result[1] = (buttons.B == ButtonState.Pressed);
                    result[2] = (buttons.X == ButtonState.Pressed);
                    result[3] = (buttons.Y == ButtonState.Pressed);
                    result[4] = (buttons.LeftShoulder == ButtonState.Pressed);
                    result[5] = (buttons.RightShoulder == ButtonState.Pressed);
                    result[6] = (buttons.Start == ButtonState.Pressed);
                    result[7] = (buttons.Back == ButtonState.Pressed);
                    result[8] = (buttons.LeftStick == ButtonState.Pressed);
                    result[9] = (buttons.RightStick == ButtonState.Pressed);

                    return result;
                }
                else
                {
                    var buttons = Joystick.GetState(pad).Buttons;
                    bool[] retVal = new bool[buttons.Length];
                    for (int i = 0; i < retVal.Length; i++)
                    {
                        retVal[i] = buttons[i] == ButtonState.Pressed;
                    }
                    return retVal;
                }
            }
            else
            {
                return new bool[0];
            }
        }

        public float[] GetAxes(int pad)
        {
            ActiveController active = activeControllers[pad];
            if (active.Active)
            {
                if (active.IsXbox)
                {
                    float[] result = new float[6];
                    var state = GamePad.GetState((PlayerIndex) pad);
                    GamePadThumbSticks sticks = state.ThumbSticks;
                    GamePadTriggers triggers = state.Triggers;
                    result[0] = sticks.Left.X;
                    result[1] = sticks.Left.Y;
                    result[2] = triggers.Left;
                    result[3] = triggers.Right;
                    result[4] = sticks.Right.X;
                    result[5] = sticks.Right.Y;
                    return result;
                }
                else
                {
                    return Joystick.GetState(pad).Axes;
                }
            }
            else
            {
                return new float[0];
            }
        }
    }
}
