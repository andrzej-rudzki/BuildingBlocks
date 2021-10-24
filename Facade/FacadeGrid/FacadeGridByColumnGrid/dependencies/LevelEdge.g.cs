//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>Represents a single edge of a panel system at a level</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    [UserElement]
	public partial class LevelEdge : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public LevelEdge(IList<string> @panelIds, string @levelVolumeId, Line @edge, System.Guid @id, string @name)
            : base(id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<LevelEdge>
            ();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @panelIds, @levelVolumeId, @edge, @id, @name});
            }
        
                this.PanelIds = @panelIds;
                this.LevelVolumeId = @levelVolumeId;
                this.Edge = @edge;
            
            if(validator != null)
            {
            validator.PostConstruct(this);
            }
            }
    
        /// <summary>The Ids of panels along this edge</summary>
        [Newtonsoft.Json.JsonProperty("Panel Ids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<string> PanelIds { get; set; }
    
        /// <summary>The Id of the Level Volume this edge belongs to</summary>
        [Newtonsoft.Json.JsonProperty("Level Volume Id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LevelVolumeId { get; set; }
    
        /// <summary>The edge these panels belong to</summary>
        [Newtonsoft.Json.JsonProperty("Edge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Line Edge { get; set; }
    
    
    }
}