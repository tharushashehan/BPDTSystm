﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BPDTSystmAPI.Controllers
{
    public class RepeatRegistrationLoadDataController : ApiController
    {
        public IHttpActionResult LoadRepeatRegistrationData(Repeat_Registration_Data data)
        {
            return Ok(DA_AdminController.LoadRepeatRegistrationData(data));
        }
    }
}
