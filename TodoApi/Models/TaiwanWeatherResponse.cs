using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public class WeatherResponse
    {
        public string Location { get; set; }
        public string? WeatherDescription { get; set; }
        public string? TodayForecast { get; set; }
        public string? TomorrowForecast { get; set; }
    }

    public class TaiwanWeatherResponse
    {
        public CwaOpenData CwaOpenData { get; set; }
    }

    public class CwaOpenData
    {
        public string Identifier { get; set; }
        public string Sender { get; set; }
        public DateTime Sent { get; set; }
        public string Status { get; set; }
        public string MsgType { get; set; }
        public string Scope { get; set; }
        public string Dataid { get; set; }
        public string Source { get; set; }
        public Dataset Dataset { get; set; }
    }

    public class Dataset
    {
        public DatasetInfo DatasetInfo { get; set; }
        public Location Location { get; set; }
        public ParameterSet ParameterSet { get; set; }
    }

    public class DatasetInfo
    {
        public string DatasetDescription { get; set; }
        public string DatasetLanguage { get; set; }
        public DateTime IssueTime { get; set; }
    }

    public class Location
    {
        public string LocationName { get; set; }
        public string StationId { get; set; }
        public string Geocode { get; set; }
    }

    public class ParameterSet
    {
        public string ParameterSetName { get; set; }
        public List<Parameter> Parameter { get; set; }
    }

    public class Parameter
    {
        public string? ParameterValue { get; set; }
    }
}