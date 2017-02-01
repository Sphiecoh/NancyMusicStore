﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyMusicStore.Common
{
    public static class Extensions
    {
        public static string GetUserName(this Nancy.NancyContext context) => context.CurrentUser?.Identity.Name;
    }
}