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
        //a - acceliration
        //Vo - initial speed

        // find distance when speed and time is known 
        public static double Distance(double Speed, double Time)
        {
            return Speed * Time;
        }

        // find time when distance and speed is known
        public static double Time(double Speed, double Distance)
        {
            return Distance / Speed;
        }
       
        // find speed when distance and time is known
        public static double Speed(double Distance, double Time)
        {
            return Distance/Time;
        }

        //find speed when initial speed, acceleration & time is known
        public static double SpeedByAcceleration(double InitialSpeed, double Time, double Acceleration)
        {
            return InitialSpeed+Acceleration*Time;
        }

        //find initial speed when final speed , acceleration & time is known
        public static double InitialSpeedByAcceleration(double Speed, double Time, double Acceleration)
        {
            return Speed-Acceleration*Time;
        }

        //find time when final speed, initial speed, and acceleration is known
        public static double TimeByAcceleration(double Speed, double InitialSpeed, double Acceleration)
        {
            return (Speed - InitialSpeed) / Acceleration;
        }

        //find distance when initial speed, acceleration and time is known 
        public static double Distance(double InitialSpeed, double Time, double Acceleration)
        {
            return InitialSpeed * Time + 0.5 * Acceleration * Time * Time;
        }

        //find initial speed when distance, acceleration and time is known
        public static double InitialSpeedDistanceAcceleration(double Distance, double Time, double Acceleration)
        {
            return Distance/Time - 0.5*Acceleration*Time;
        }

        // find time when distance and acceleration is known
        public static double TimeByDistanceAndAcceleration(double Acceleration, double Distance)
        {
            return Math.Sqrt(2 * Distance / Acceleration);
        }
    }
}
