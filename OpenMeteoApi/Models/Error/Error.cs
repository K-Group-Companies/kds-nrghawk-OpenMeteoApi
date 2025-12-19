using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class Error
{
	[JsonPropertyName("error")]
	public bool? IsError { get; set; }

	[JsonPropertyName("reason")]
	public string? Reason { get; set; }
}