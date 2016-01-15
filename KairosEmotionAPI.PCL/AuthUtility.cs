/*
 * KairosEmotionAPI.PCL
 *
 * This file was automatically generated for kairos by APIMATIC BETA v2.0 on 01/15/2016
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KairosEmotionAPI.PCL.Http.Request;
namespace KairosEmotionAPI.PCL
{
    internal partial class AuthUtility
    {
        /// <summary>
        /// Appends the necessary Custom Authentication credentials for making this authorized call
        /// </summary>
        /// <param name="request">The out going request to access the resource</param>        
        internal static void AppendCustomAuthParams(HttpRequest request)
        {
            // TODO: Add your custom authentication here
			// The following properties are available to use
			//     Configuration.ContentType
			//     Configuration.AppId
			//     Configuration.AppKey
			// 
			// ie. Add a header through:
			//     request.header("Key", "Value");
        }
    }
}
