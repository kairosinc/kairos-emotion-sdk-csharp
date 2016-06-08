/*
 * KairosEmotionAPI.PCL
 *
 * This file was automatically generated for kairos by APIMATIC v2.0 ( https://apimatic.io ) on 06/08/2016
 */
using System;
using KairosEmotionAPI.PCL.Controllers;
using KairosEmotionAPI.PCL.Http.Client;

namespace KairosEmotionAPI.PCL
{
    public partial class KairosEmotionAPIClient
    {

        /// <summary>
        /// Singleton access to EmotionAnalysis controller
        /// </summary>
        public EmotionAnalysisController EmotionAnalysis
        {
            get
            {
                return EmotionAnalysisController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public KairosEmotionAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public KairosEmotionAPIClient(string contentType, string appId, string appKey)
        {
            Configuration.ContentType = contentType;
            Configuration.AppId = appId;
            Configuration.AppKey = appKey;
        }
    }
}