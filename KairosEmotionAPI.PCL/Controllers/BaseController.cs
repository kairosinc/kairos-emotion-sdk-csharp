/*
 * KairosEmotionAPI.PCL
 *
 * This file was automatically generated for kairos by APIMATIC BETA v2.0 on 01/15/2016
 */
using System;
using KairosEmotionAPI.PCL;
using KairosEmotionAPI.PCL.Http.Client;
using KairosEmotionAPI.PCL.Http.Response;

namespace KairosEmotionAPI.PCL.Controllers
{
	public partial class BaseController
    {
        internal IHttpClient ClientInstance = null;

        public BaseController()
        {
            ClientInstance = UnirestClient.SharedClient;
        }

        public BaseController(IHttpClient client)
        {
            ClientInstance = client;
        }

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="_response">The response recieved</param>
        /// <param name="_context">Context of the request and the recieved response</param>
		internal void ValidateResponse(HttpResponse _response, HttpContext _context)
        {
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);
        }
    }
} 