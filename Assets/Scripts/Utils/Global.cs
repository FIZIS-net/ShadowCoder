using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class Input
    {
        public const string Horizontal = "Horizontal";
        public const string Vertical = "Vertical";
        public const string Jump = "Jump";
        public const string Attack = "Fire1";

    }

    public class Global
    {
        public static int GetFrameCount(float time)
        {
            float frames = time / Time.fixedDeltaTime;
            int roundedFrames = Mathf.RoundToInt(frames);

            if (Mathf.Approximately(frames, roundedFrames))
            {
                return roundedFrames;
            }
            return Mathf.CeilToInt(frames);
        }
    }
}
