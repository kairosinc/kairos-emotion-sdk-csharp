/*
 * KairosEmotionAPI.PCL
 *
 * This file was automatically generated for kairos by APIMATIC BETA v2.0 on 01/15/2016
 */
using System;
using KairosEmotionAPI.PCL.Controllers;

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
        /// Client constructor
        /// </summary>
        public KairosEmotionAPIClient(string contentType, string appId, string appKey)
        {
            Configuration.ContentType = contentType;
            Configuration.AppId = appId;
            Configuration.AppKey = appKey;
        }
    }
}