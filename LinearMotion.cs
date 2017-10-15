using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinematics
{
    public static class LinearMotion
    {
        //d - distance
        //t - time
        //v - speed
        //a - acceleration
        //Vo - initial speed

            //**** DISTANCE *******
        // find distance when speed and time are known 
        public static double Distance(double Speed, double Time)
        {
            return Speed * Time;
        }

        //find distance when initial speed, acceleration and time are known 
        public static double Distance(double InitialSpeed, double Time, double Acceleration)
        {
            return InitialSpeed * Time + 0.5 * Acceleration * Time * Time;
        }



        //**** TIME *******

        // find time when distance and speed are known
        public static double TimeV_D(double Speed, double Distance)
        {
            return Distance / Speed;
        }

        //find time when final speed, initial speed, and acceleration are known
        public static double TimeV_Vo_a(double Speed, double InitialSpeed, double Acceleration)
        {
            return (Speed - InitialSpeed) / Acceleration;
        }


        // find time when distance and acceleration are known
        public static double TImeD_a(double Distance, double Acceleration)
        {
            return Math.Sqrt(2 * Distance / Acceleration);
        }



        //**** SPEED *******

        // find speed when distance and time are known
        public static double Speed(double Distance, double Time)
        {
            return Distance/Time;
        }

        //find speed when initial speed, acceleration & time are known
        public static double SpeedVo_t_a(double InitialSpeed, double Time, double Acceleration)
        {
            return InitialSpeed+Acceleration*Time;
        }

        //find initial speed when final speed , acceleration & time are known
        public static double InitialSpeedV_t_a(double Speed, double Time, double Acceleration)
        {
            return Speed-Acceleration*Time;
        }

        
        //find initial speed when distance, acceleration and time are known
        public static double InitialSpeedD_t_a(double Distance, double Time, double Acceleration)
        {
            return Distance/Time - 0.5*Acceleration*Time;
        }




        //**** Acceleration *******
        //Find acceliation when intial and final sppeds & time are known
        public static double Acceleration(double InitialSpeed, double FinalSpeed, double Time)
        {
            return (FinalSpeed - InitialSpeed) / Time;
        }

        //find aceliation when distance travaled, initial speed, and time are known
        public static double AccelerationD_Vo_t(double Distance, double InitialSpeed, double Time)
        {
            return (2 * Distance - 2 * InitialSpeed * Time) / (Time * Time);
        }

        //time that takes to travel the distance d , acceleration a, to the maximum speed v
        // isosceles trapezoid linear motion with equal acceleration and deceleration 

        public static double TrapezoidMotionTime(double distance, double acceleration, double maximum_speed)
        {
            // create short names 
            double d = distance;
            double a = acceleration;
            double v = maximum_speed;

            // time that will take to reach full speed

            double Tfs = v / a;

            // distance that will take to reach full speed

            double Dfs = a * Tfs * Tfs * 0.5;

            if (d > 2*Dfs)
            {
                double Tv = (d - 2 * Dfs) / v;
                return 2 * Tfs + Tv;
            }
            else
            {
                return 2 * Math.Sqrt(d / a);
            }
            
        }
    }
}
