﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocuSign2011Q1Sample
{
    /// <summary>
    /// This just has some methods that create some common api objects to save typing and avoid cluttering up the main
    /// process code. Many of the values here are defaulted for the demo.
    /// </summary>
    public class ApiHelper
    {

    }

    public struct AccountCredentials
    {
        public string ApiUrl; // url endpoint of hte api
        public string AccountId; // billing account for sending envelopes
        public string UserName; // email address used for DocuSign login, prefixed with integrator key in square brackets
        public string Password; // password for DocuSign login
    }

}