using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;

namespace EmiChoiceTravels.DTOs
{
    //
    //term=PRG&locale=en-US&location_types=airport&limit=10&active_only=true&sort=name
    public class BaseLocationDto
    {
        public string Term { get; set; }
        public string Locale { get; set; }
        public List<string> LocationTypes { get; set; }
        public int Limit { get; set; }
        public bool ActiveOnly { get; set; }
        public string Sort { get; set; }
    }
    //type=radius&term=london_gb&lat=40.730610&lon=-73.935242&radius=250&locale=en-US&location_types=airport&limit=20&sort=name&active_only=true
    public class CoordinateDto
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Radius { get; set; }
        public string Locale { get; set; }
        public List<string> LocationTypes { get; set; }
        public int Limit { get; set; }
        public bool ActiveOnly { get; set; }
        public string Sort { get; set; }
    }

    public class CoordinateMaximaDto
    {
        public double LowLat { get; set; }
        public double LowLon { get; set; }
        public double HighLat { get; set; }
        public double HighLon { get; set; }
        public double Radius { get; set; }
        public string Locale { get; set; }
        public List<string> LocationTypes { get; set; }
        public int Limit { get; set; }
        public bool ActiveOnly { get; set; }
        public string Sort { get; set; }
    }
    //https://api.skypicker.com/locations?type=subentity&term=ZW&locale=en-US&active_only=true&location_types=airport&limit=20&sort=name
    public class LocationHierarchical : BaseLocationDto
    {
        public string LocationType { get; set; }
    }
    //https://api.skypicker.com/locations?type=id&id=ZW&locale=en-US&active_only=true
    public class LocationById
    {
        public string LocationType { get; set; }
        public int Id { get; set; }
        public string Locale { get; set; }
        public bool ActiveOnly { get; set; }
    }

    public class KeyValue
    {
        public string LocationType { get; set; }
        public string Key { get; set; }
        public int Value { get; set; }
    }
    //type=dump&locale={locale}&location_types={location_types}&limit={limit}&sort={sort}&active_only={active_only}
    public class LocationByLanguage
    {
        public string LocationType { get; set; }
        public string Locale { get; set; }
        public List<string> LocationTypes { get; set; }
        public bool ActiveOnly { get; set; }
        public int Limit { get; set; }
        public string Sort { get; set; }
    }
    //type=top_destinations&term={term}&locale={locale}&limit={limit}&sort={sort}&active_only={active_only}&source_popularity={source_popularity}&fallback_popularity={fallback_popularity}
    public class MostSearch
    {
        public string LocationType { get; set; }
        public string Term { get; set; }
        public string Locale { get; set; }
        public int Limit { get; set; }
        public string Sort { get; set; }
        public bool ActiveOnly { get; set; }
        public string SourcePopularity { get; set; }
        public string FallbackPopularity { get; set; }
        
    }
    //type=hashtag&hashtag={hashtag}&term={term}&month={month}&locale={locale}&limit={limit}&sort={sort}&active_only={active_only}
    public class MostSearchWithHasTag
    {
        public string Hashtag { get; set; }
        public string Month { get; set; }
        public string LocationType { get; set; }
        public string Term { get; set; }
        public string Locale { get; set; }
        public int Limit { get; set; }
        public string Sort { get; set; }
        public bool ActiveOnly { get; set; }
    }
    
    
    //type=slug&term={term}&locale={locale}&active_only={active_only}
    public class Slug
    {
        public string Term { get; set; }
        public string Locale { get; set; }
        public bool ActiveOnly { get; set; }
    }
}
