using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reaxml.Util
{
    public static class HtmlHelperUtil
    {
        public static bool IsDebug(this HtmlHelper htmlHelper)
        {
#if DEBUG
      return true;
#else
            return false;
#endif
        }
    }
}