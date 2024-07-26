// See https://aka.ms/new-console-template for more information
using GeoTimeZone;

string tz = TimeZoneLookup.GetTimeZone(24.87891882071562, 67.08686263125412).Result;
var test = TimeZoneInfo.FindSystemTimeZoneById(tz);
Console.WriteLine(DateTime.UtcNow.AddMinutes(test.BaseUtcOffset.TotalMinutes));
