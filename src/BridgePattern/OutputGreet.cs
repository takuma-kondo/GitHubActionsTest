using System;

namespace BridgePattern
{
    public abstract class OutputGreet
    {
        protected Greet m_Greet;

        protected OutputGreet(Greet greet)
        {
            m_Greet = greet;
        }

        public abstract void Output();

        protected string GetGreet()
        {
            // 現在の時間を取得して、それに応じて挨拶を変える
            var hour = GetTimeSlot();

            switch (hour)
            {
                case TimeSlot.Morning:
                    return m_Greet.GetMorning();
                case TimeSlot.Afternoon:
                    return m_Greet.GetAfternoon();
                case TimeSlot.Night:
                    return m_Greet.GetNight();
                default:
                    throw new NotImplementedException();
            }
        }

        protected TimeSlot GetTimeSlot()
        {
            // 現在の時間を取得する
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            // 時間に応じて、挨拶を返す
            if (hour >= 6 && hour < 12)
            {
                return TimeSlot.Morning;
            }
            else if (hour >= 12 && hour < 18)
            {
                return TimeSlot.Afternoon;
            }
            else
            {
                return TimeSlot.Night;
            }
        }
    }
}