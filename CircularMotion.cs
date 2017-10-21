using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinematics
{
    public static class CircularMotion
    {
        //Uniform Circuilar motion 
        //w - anguar velocity (rad per second)
        //Wo - initial angular velocity (rad per second)
        //T - period (sec)
        //f - frequency (Hz)
        //a - angular acceleration rad per sec^2
        //Fc - centripetal force
        //v - circular speed 
        //Omega - O - angle in rad
        //Atan - tangential acceleration  Atan=a*r  
        //r - radius 
        //m - mass


        //*** Angle

        public static double Angle_t_T(double Time, double Period)
        {
            return 2 * Math.PI * Time / Period;
        }

        public static double Angle_w_t(double AngularVelocity, double Time)
        {
            return AngularVelocity * Time;
        }

        public static double Angle_Wo_t_a(double InitialAngularVelocity, double Time, double AngularAcceleration)
        {
            return InitialAngularVelocity * Time + 0.5 * AngularAcceleration * Time * Time;
        }

        //**** angle conversion
        public static double ConvertToDegrees(double Radinas)
        {
            return Radinas * 180 / Math.PI;
        }

        public static double ConvertToRadians(double Degrees)
        {
            return Degrees * Math.PI / 180;
        }


        //*** angular velocity

        public static double AngularSpeed_T(double Period_Sec)
        {
            return 2 * Math.PI / Period_Sec;
        }

        public static double AngularSpeed_f(double Frequency_Hz)
        {
            return 2 * Math.PI * Frequency_Hz;
        }

        public static double AnglularSpeed_O2_O1_t(double AngleNew, double AngleOld, double Time)
        {
            return (AngleNew - AngleOld) / Time;
        }

        public static double AngularSpeed_Wo_a_t(double IntitalAnuglarSpeed, double AngularAcceleration, double Time)
        {
            return IntitalAnuglarSpeed + AngularAcceleration * Time;
        }

        //** circular Speed
        public static double CircularSpeed_r_T(double Radius, double period)
        {
            return 2 * Math.PI * Radius / period;
        }

        public static double CircularSpeed_w_r(double AngularSpeed, double Radius)
        {
            return AngularSpeed * Radius;
        }

        //** Angular acceleration 
        public static double AngularAcceleration_w2_w1_t(double AngularSpeedNew, double AngularSpeedOld, double Time)
        {
            return (AngularSpeedNew - AngularSpeedOld) / Time;
        }

        public static double AngularAcceleration_v_t(double CircularSpeed, double Time)
        {
            return CircularSpeed *CircularSpeed/ Time;
        }

        public static double AngularAcceleration_w_r(double AngularSpeed, double Radius)
        {
            return AngularSpeed * AngularSpeed / Radius;
        }        

        public static double TangentialAcceleration(double AngularAcceleration, double Radius)
        {
            return AngularAcceleration * Radius;
        }

        public static double CentripetalForce(double Mass, double CircularSpeed, double Radius)
        {
            return Mass * CircularSpeed * CircularSpeed / Radius;
        }

        //*** Projectile  motion
        public static double ProjectileDistance(double InitialSpeed, double Angle)
        {
            double g = 9.834;
            return InitialSpeed * InitialSpeed * Math.Sin(2*Angle) / g;
        }

        public static double ProjectileHeight(double InitialSpeed, double Angle)
        {
            double g = 9.834;
            return InitialSpeed * InitialSpeed * Math.Sin(Angle)* Math.Sin(Angle) /(2* g);
        }

        public static double ProjectileTime(double InitialSpeed, double Angle)
        {
            double g = 9.834;
            return 2 * InitialSpeed * Math.Sin(Angle) / g; 
        }

        public static double ProjectileInitialSpeed(double FinalX, double FinalY, double Angle)
        {
            double g = 9.834;
            double top = FinalX * FinalX * g;
            double btm = FinalX * Math.Sin(2 * Angle) - 2 * FinalY * Math.Cos(Angle) * Math.Cos(Angle);
            return Math.Sqrt(top / btm);
        }
    }

}


