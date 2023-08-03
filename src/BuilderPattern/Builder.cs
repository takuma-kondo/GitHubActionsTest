using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public interface IBuilder
    {
        /// <summary>
        /// 面積の出力
        /// </summary>
        /// <returns></returns>
        double OutputArea();

        /// <summary>
        /// 三角形の形を判定
        /// </summary>
        Func<List<int>,double> JudgeShape();

        /// <summary>
        /// 面積の計算
        /// </summary>
        /// <param name="func"></param>
        void CalcArea(Func<List<int>, double> func);
    }
}