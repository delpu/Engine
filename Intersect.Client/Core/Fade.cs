using System;
using Intersect.Utilities;

namespace Intersect.Client.Core
{

    public static partial class Fade
    {

        public enum FadeType
        {

            None = 0,

            In = 1,

            Out = 2,

        }

        private static FadeType sCurrentAction;

        private static FadeType CurrentAction
        {
            get => sCurrentAction;

            set
            {
                sCurrentAction = value;
                if (sCurrentAction == FadeType.None && CompleteCallback != null)
                {
                    CompleteCallback();
                }
            }
        }

        private static float sFadeAmt;

        private static float sFadeRate = 3000f;

        private static long sLastUpdate;

        private static Action CompleteCallback;

        public static void FadeIn(bool fast = false, Action callback = null)
        {
            CurrentAction = FadeType.In;
            sFadeAmt = 255f;
            sLastUpdate = Timing.Global.Milliseconds;
        }

        public static void FadeOut(bool alertServerWhenFaded = false, bool fast = false, Action callback = null)
        {
            CurrentAction = FadeType.Out;
            sFadeAmt = 0f;
            sLastUpdate = Timing.Global.Milliseconds;
        }

        public static bool DoneFading()
        {
            return CurrentAction == FadeType.None;
        }

        public static float GetFade()
        {
            return sFadeAmt;
        }

        public static void Update()
        {
            if (CurrentAction == FadeType.In)
            {
                sFadeAmt -= (Timing.Global.Milliseconds - sLastUpdate) / sFadeRate * 255f;
                if (sFadeAmt <= 0f)
                {
                    CurrentAction = FadeType.None;
                    sFadeAmt = 0f;
                }
            }
            else if (CurrentAction == FadeType.Out)
            {
                sFadeAmt += (Timing.Global.Milliseconds - sLastUpdate) / sFadeRate * 255f;
                if (sFadeAmt >= 255f)
                {
                    CurrentAction = FadeType.None;
                    sFadeAmt = 255f;
                }
            }

            sLastUpdate = Timing.Global.Milliseconds;
        }

    }

}
