/*
 * BoxFoldersRTX.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
using BoxFoldersRTX.Standard;
using BoxFoldersRTX.Standard.Utilities;


namespace BoxFoldersRTX.Standard.Models
{
    public class CreateFolderRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private Models.Parent parent;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("parent")]
        public Models.Parent Parent 
        { 
            get 
            {
                return this.parent; 
            } 
            set 
            {
                this.parent = value;
                onPropertyChanged("Parent");
            }
        }
    }
} 