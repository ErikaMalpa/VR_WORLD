using UnityEngine;

namespace Assets.Script
{
    public class Circle
    {
        private readonly int _radius;
       

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public Vector3 GetPositionOnBoundaryOfCircle(int degrees)
        {
            return new Vector3(CalculateXCoordinate(degrees), 0, CalculateYCoordinateCoordinate(degrees));
        }

        private float CalculateYCoordinateCoordinate(int degrees)
        {
            var y = _radius * Mathf.Cos(degrees * Mathf.Deg2Rad);
            if (Mathf.Abs(y) < 0.01f) y = 0;
            return y;
        }

        private float CalculateXCoordinate(int degrees)
        {
            var x = _radius * Mathf.Cos(degrees * Mathf.Deg2Rad);
            if (Mathf.Abs(x) < 0.01f) x = 0;
            return x;
        }
    }
}