using System;
using HAL.Simulator;
using WPILib;

namespace Game1
{
    public static class Program
    {
        public static void Main()
        {
            RobotBase.Main(null, typeof(Robot));
        }
    }

    public class Robot : IterativeRobot
    {
        private Joystick joy = new Joystick(0);

        public override void RobotInit()
        {
            
            base.RobotInit();
        }

        public override void DisabledPeriodic()
        {
            Console.WriteLine(joy.ButtonCount);
        }
    }

    public class Simulator : ISimulator
    {
        public void Initialize()
        {
        }

        public void Start()
        {
            SimHooks.WaitForProgramStart();
            DriverStationGUI.DriverStation.StartDriverStationGui();
            using (var game = new Game1())
                game.Run();
        }

        public string Name => "Mono Game Simulator";
    }
}