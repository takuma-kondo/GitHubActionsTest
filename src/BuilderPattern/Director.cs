namespace BuilderPattern
{
    public class Director
    {
        private IBuilder m_builder;

        public Director(IBuilder builder)
        {
            m_builder = builder;
        }
        public void Construct()
        {
            m_builder.JudgeShape();
            m_builder.CalcArea();
            m_builder.OutputArea();
        }
    }
}