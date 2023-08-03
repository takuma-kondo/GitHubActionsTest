using System.Collections.Generic;
using System;

namespace BuilderPattern
{
    public class Director
    {
        /// <summary>
        /// 骨組みとなるBuilder
        /// </summary>
        private IBuilder m_builder;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="builder"></param>
        public Director(IBuilder builder)
        {
            m_builder = builder;
        }

        /// <summary>
        /// 骨組みとなるBuilderを使って、三角形の面積を求める
        /// </summary>
        public void Construct()
        {
            var shapeResult = m_builder.JudgeShape();
            if (shapeResult == null)
            {
                Console.WriteLine("三角形ではありません");
                return;
            }
            m_builder.CalcArea(shapeResult);
            var area = m_builder.OutputArea();

            Console.WriteLine("面積は{0}です", area);
        }
    }
}