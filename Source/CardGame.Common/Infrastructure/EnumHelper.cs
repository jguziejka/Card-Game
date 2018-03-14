using CardGame.Common.Models;
using System;
using System.Collections.Generic;

namespace CardGame.Common.Infrastructure
{
    public static class EnumHelper
    {
        public static IEnumerable<T> EnumerateType<T>()
        {
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                yield return (T)item;
            }
        }

        public static string ToShortString(this Suits suit)
        {
            return suit.ToString().Substring(0, 1);
        }

        public static string ToShortString(this FaceValues faceValue)
        {
            var result = string.Empty;
            switch (faceValue)
            {
                case FaceValues.Two:
                case FaceValues.Three:
                case FaceValues.Four:
                case FaceValues.Five:
                case FaceValues.Six:
                case FaceValues.Seven:
                case FaceValues.Eight:
                case FaceValues.Nine:
                case FaceValues.Ten:
                    result = ((int)faceValue).ToString();
                    break;
                case FaceValues.Jack:
                case FaceValues.Queen:
                case FaceValues.King:
                case FaceValues.Ace:
                    result = faceValue.ToString().Substring(0, 1);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
