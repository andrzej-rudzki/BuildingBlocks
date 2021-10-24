// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace FacadeGridByColumnGrid
{
    public class FacadeGridByColumnGridOutputs: ResultsBase
    {
		/// <summary>
		/// The number of unique facade panels.
		/// </summary>
		[JsonProperty("Unique Panel Count")]
		public double UniquePanelCount {get;}

		/// <summary>
		/// The total number of facade panels.
		/// </summary>
		[JsonProperty("Total Panel Count")]
		public double TotalPanelCount {get;}



        /// <summary>
        /// Construct a FacadeGridByColumnGridOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public FacadeGridByColumnGridOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a FacadeGridByColumnGridOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public FacadeGridByColumnGridOutputs(double uniquePanelCount, double totalPanelCount): base()
        {
			this.UniquePanelCount = uniquePanelCount;
			this.TotalPanelCount = totalPanelCount;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}