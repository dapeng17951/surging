﻿using Surging.Core.KestrelHttpServer.Filters.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Surging.Core.KestrelHttpServer.Filters
{
   public interface IExceptionFilter
    { 
          Task OnException(ExceptionContext context);
    }
}
