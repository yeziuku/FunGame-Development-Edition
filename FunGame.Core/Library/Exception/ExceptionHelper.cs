﻿namespace Milimoe.FunGame.Core.Library.Exception
{
    public static class ExceptionHelper
    {
        public static string GetErrorInfo(this System.Exception e)
        {
            return (e.InnerException != null) ? $"InnerExceoption: {e.InnerException}\n{e}" : e.ToString();
        }
    }
}
