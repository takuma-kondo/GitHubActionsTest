using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    public class TriangleAreaBuilder : IBuilder
    {
        #region privateなメンバ

        /// <summary>
        /// 辺の長さのリスト
        /// </summary>
        private List<int> m_Sides = new List<int>();

        /// <summary>
        /// 総面積
        /// </summary>
        private double m_Area;

        #endregion

        #region 構築

        /// <summary>
        /// 三角形を受け取って、辺の長さを格納する
        /// </summary>
        /// <param name="triangle"></param>
        public TriangleAreaBuilder(Triangle triangle)
        {
            m_Sides.Add(triangle.SideA);
            m_Sides.Add(triangle.SideB);
            m_Sides.Add(triangle.SideC);
        }

        #endregion

        /// <summary>
        /// 三角形の面積を求める
        /// </summary>
        /// <param name="func"></param>
        public void CalcArea(Func<List<int>, double> func)
        {
            m_Area = func(m_Sides);
        }

        /// <summary>
        /// 三角形の形を判定する
        /// </summary>
        /// <returns>三角形の面積を求めるメソッドをfuncで返す</returns>
        public Func<List<int>, double> JudgeShape()
        {
            // 三角形かどうかを判定する
            if (m_Sides.Max() > m_Sides.Sum() - m_Sides.Max())
            {
                return null;
            }

            // 辺の長さがいくつ同じものがあるかを判定する
            var sideTotals = m_Sides.GroupBy(x => x).
                ToDictionary(side => side.Key, side => side.Count());

            // 同じ辺の長さでまとめたDictionaryがの要素数が1つなら正三角形、それ以外は不等辺三角形
            switch (sideTotals.Count)
            {
                case 1:
                    return EquilateralTriangleCalcArea;
                default:
                    return ScaleneTriangleCalcArea;
            }
        }

        /// <summary>
        /// 三角形の総面積を出力する
        /// </summary>
        /// <returns></returns>
        public double OutputArea()
        {
            return m_Area;
        }

        /// <summary>
        /// 正三角形の面積を求める
        /// </summary>
        /// <param name="sides">辺の長さのリスト</param>
        /// <returns></returns>
        private double EquilateralTriangleCalcArea(List<int> sides)
        {
            return (sides[0] * sides[0] * 1.7 / 4);
        }

        /// <summary>
        /// 不等辺三角形の面積を求める
        /// </summary>
        /// <param name="sides">辺の長さのリスト</param>
        /// <returns></returns>
        private double ScaleneTriangleCalcArea(List<int> sides)
        {
            var tmpArea = sides.Sum() / 2;

            return Math.Sqrt(tmpArea * (tmpArea - sides[0]) * (tmpArea - sides[1]) * (tmpArea - sides[2]));
        }
    }
}