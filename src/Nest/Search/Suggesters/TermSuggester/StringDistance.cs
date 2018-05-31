﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nest
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StringDistance
	{
		[EnumMember(Value = "internal")]
		Internal,
		[EnumMember(Value = "damerau_levenshtein")]
		DamerauLevenshtein,
		/// <summary>
		/// Use for Elasticsearch 6.2.0+
		/// </summary>
		/// <remarks>Use Levenstein for Elasticsearch < 6.2.0</remarks>
		[EnumMember(Value = "levenshtein")]
		Levenshtein,
		/// <summary>
		/// Use for Elasticsearch < 6.2.0
		/// </summary>
		/// <remarks>Use Levenshtein for Elasticsearch 6.2.0+</remarks>
		[EnumMember(Value = "levenstein")]
		Levenstein,
		[EnumMember(Value = "jaro_winkler")]
		Jarowinkler,
		[EnumMember(Value = "ngram")]
		Ngram
	}
}
