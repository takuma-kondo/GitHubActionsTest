using System.Collections.Generic;

namespace BuilderPattern
{
    public class RectangleArea : IBuilder
    {
        private List<int> m_Sides = new List<int>();

        public RectangleArea()
        {
            var rectangle = new Rectangle();
            m_Sides.Add(rectangle.Width1);
            m_Sides.Add(rectangle.Height2);
            m_Sides.Add(rectangle.Width3);
            m_Sides.Add(rectangle.Height4);
        }

        public void OutputArea()
        {
            throw new System.NotImplementedException();
        }

        public void JudgeShape()
        {
            ;
        }

        public void CalcArea()
        {
            throw new System.NotImplementedException();
        }

        private double EquilateralTriangleCalcArea(int sideA, int sideB, int sideC)
        {
            return 0.0;
        }
    }
}