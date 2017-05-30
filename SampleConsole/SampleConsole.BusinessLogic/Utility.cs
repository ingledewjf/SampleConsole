namespace SampleConsole.BusinessLogic
{
    using System;
    using System.CodeDom;
    using System.Diagnostics;
    using System.Drawing;

    public static class Utility
    {
        public static DoublePoint GetEndpoint(double x, double y, double angle, double length)
        {
            double xe = x + length * Math.Cos(angle);
            double ye = y + length * Math.Sin(angle);
            return new DoublePoint(xe, ye);
        }

        public static double Flip(double x, double height)
        {
            return height - x;
        }

        public static void DrawLine(Graphics target, Brush brush, double x, double y, double angle, double length, double width, double height)
        {
            var endpoint = GetEndpoint(x, y, angle, length);
            PointF origin = new PointF((float)x, (float)Flip(y, height));
            PointF dest = new PointF((float)endpoint.X, (float)Flip(endpoint.Y, height));
            Pen pen = new Pen(brush, (float)width);
            target.DrawLine(pen, origin, dest);
        }
    }

    public struct DoublePoint
    {
        public DoublePoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override bool Equals(object obj)
        {
            DoublePoint? other = obj as DoublePoint?;
            return other.HasValue && X.Equals(other.Value.X) && Y.Equals(other.Value.Y);
        }

        public bool Equals(DoublePoint other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public static bool operator ==(DoublePoint left, DoublePoint right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DoublePoint left, DoublePoint right)
        {
            return !left.Equals(right);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }
    }
}