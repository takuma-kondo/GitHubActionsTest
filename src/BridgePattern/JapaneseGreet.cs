using System;

namespace BridgePattern
{
    public class JapaneseGreet : Greet
    {
        /// <summary>
        /// 朝の挨拶
        /// </summary>
        private string Morning = "おはよう";

        /// <summary>
        /// 昼の挨拶
        /// </summary>
        private string Noon = "こんにちは";

        /// <summary>
        /// 夜の挨拶
        /// </summary>
        private string Night = "こんばんは";


        public override string GetGreet()
        {
            // 現在の時間帯に応じて挨拶を変える
            var nowTimeSlot = GetNowTimeSlot();

            switch (nowTimeSlot)
            {
                case TimeSlot.Morning:
                    return Morning;
                case TimeSlot.Noon:
                    return Noon;
                case TimeSlot.Night:
                    return Night;
                default:
                    throw new NotImplementedException();
            }
        }

        protected override TimeSlot GetNowTimeSlot()
        {
            // 現在の時間を取得する
            // 日本語のなのでカルチャ設定はいらない
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            // 時間に応じて、挨拶を返す
            if (hour >= 4 && hour < 10)
            {
                return TimeSlot.Morning;
            }
            else if (hour >= 10 && hour < 17)
            {
                return TimeSlot.Noon;
            }
            else
            {
                return TimeSlot.Night;
            }
        }
    }
}