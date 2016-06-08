/*
 * KairosEmotionAPI.PCL
 *
 * This file was automatically generated for kairos by APIMATIC v2.0 ( https://apimatic.io ) on 06/08/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KairosEmotionAPI.PCL;
using KairosEmotionAPI.PCL.Http.Request;
using KairosEmotionAPI.PCL.Http.Response;
using KairosEmotionAPI.PCL.Http.Client;
using KairosEmotionAPI.PCL.Models;

namespace KairosEmotionAPI.PCL.Controllers
{
    public partial class EmotionAnalysisController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EmotionAnalysisController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EmotionAnalysisController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EmotionAnalysisController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Create a new media object to be processed.
        /// </summary>
        /// <param name="source">Optional parameter: The source URL of the media.</param>
        /// <return>Returns the MediaResponse response from the API call</return>
        public MediaResponse CreateMedia(string source = null)
        {
            Task<MediaResponse> t = CreateMediaAsync(source);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new media object to be processed.
        /// </summary>
        /// <param name="source">Optional parameter: The source URL of the media.</param>
        /// <return>Returns the MediaResponse response from the API call</return>
        public async Task<MediaResponse> CreateMediaAsync(string source = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/media");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "source", source }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null);

            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<MediaResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Returns the results of a specific uploaded piece of media.
        /// </summary>
        /// <param name="id">Required parameter: The id of the media you are looking for the results from.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetMediaById(string id)
        {
            Task<dynamic> t = GetMediaByIdAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Returns the results of a specific uploaded piece of media.
        /// </summary>
        /// <param name="id">Required parameter: The id of the media you are looking for the results from.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetMediaByIdAsync(string id)
        {
            //validating required parameters
            if (null == id)
                throw new ArgumentNullException("id", "The parameter \"id\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/media/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Delete media results. It returns the status of the operation.
        /// </summary>
        /// <param name="id">Required parameter: The id of the media.</param>
        /// <return>Returns the MediaByIdResponse response from the API call</return>
        public MediaByIdResponse DeleteMediaById(string id)
        {
            Task<MediaByIdResponse> t = DeleteMediaByIdAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Delete media results. It returns the status of the operation.
        /// </summary>
        /// <param name="id">Required parameter: The id of the media.</param>
        /// <return>Returns the MediaByIdResponse response from the API call</return>
        public async Task<MediaByIdResponse> DeleteMediaByIdAsync(string id)
        {
            //validating required parameters
            if (null == id)
                throw new ArgumentNullException("id", "The parameter \"id\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/media/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Content-Type", Configuration.ContentType);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<MediaByIdResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 