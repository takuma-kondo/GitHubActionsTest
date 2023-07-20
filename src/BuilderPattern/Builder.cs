using System;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void OutputArea();

        void JudgeShape();

        void CalcArea();
    }
}