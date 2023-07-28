using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DateTimeDisplay
{
    public static class Formats
    {


        /// <summary>
        /// Sample: DateTime.Now.FormatToString(3)------
        /// 1-ToLongDateString()
        /// 2-oString("yy/MM/dd")
        /// 3-ToString("yyyy/MM/dd")
        /// 4-ToString("zzz tt HH:mm:ss")
        /// 5-ToString("tt HH:mm")
        /// 6-ToString("tt HH:mm:ss  yyyy/MM/dd")
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string FormatToString(this DateTime? dt, int type=0)
        {
            string StringDateTime = "";

            if (dt != null)
            {
                switch (type)
                {
                    case 1:
                        StringDateTime = dt.Value.ToLongDateString();
                        break;
                    case 2:
                        StringDateTime = dt.Value.ToString("yy/MM/dd");
                        break;
                    case 3:
                        StringDateTime = dt.Value.ToString("yyyy/MM/dd");
                        break;
                    case 4:
                        StringDateTime = dt.Value.ToString("zzz tt HH:mm:ss");
                        break;
                    case 5:
                        StringDateTime = dt.Value.ToString("tt HH:mm");
                        break;
                    case 6:
                        StringDateTime = dt.Value.ToString("tt HH:mm:ss  yyyy/MM/dd");
                        break;
                    default:
                        StringDateTime = dt.Value.ToString("yyyy/MM/dd");
                        break;
                }
            }

            return StringDateTime;
        }

        /// <summary>
        /// Convert DateTime To Formated String , 
        /// Sample: DateTime.Now.FormatToString(1) =>
        /// 1-ToLongDateString()
        /// 2-oString("yy/MM/dd")
        /// 3-ToString("yyyy/MM/dd")
        /// 4-ToString("zzz tt HH:mm:ss")
        /// 5-ToString("tt HH:mm")
        /// 6-ToString("tt HH:mm:ss  yyyy/MM/dd")
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string FormatToString(this DateTime dt, int type=0)
        {
            string StringDateTime = "";


            switch (type)
            {
                case 1:
                    StringDateTime = dt.ToLongDateString();
                    break;
                case 2:
                    StringDateTime = dt.ToString("yy/MM/dd");
                    break;
                case 3:
                    StringDateTime = dt.ToString("yyyy/MM/dd");
                    break;
                case 4:
                    StringDateTime = dt.ToString("zzz tt HH:mm:ss");
                    break;
                case 5:
                    StringDateTime = dt.ToString("tt HH:mm");
                    break;
                case 6:
                    StringDateTime = dt.ToString("tt HH:mm:ss  yyyy/MM/dd");
                    break;
                default:
                    StringDateTime = dt.ToString("yyyy/MM/dd");
                    break;

            }

            return StringDateTime;
        }



    }
}