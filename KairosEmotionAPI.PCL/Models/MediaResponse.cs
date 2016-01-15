/*
 * KairosEmotionAPI.PCL
 *
 * This file was automatically generated for kairos by APIMATIC BETA v2.0 on 01/15/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using KairosEmotionAPI.PCL;

namespace KairosEmotionAPI.PCL.Models
{
    public class MediaResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int statusCode;
        private string id;
        private string statusMessage;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode 
        { 
            get 
            {
                return this.statusCode; 
            } 
            set 
            {
                this.statusCode = value;
                onPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status_message")]
        public string StatusMessage 
        { 
            get 
            {
                return this.statusMessage; 
            } 
            set 
            {
                this.statusMessage = value;
                onPropertyChanged("StatusMessage");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 