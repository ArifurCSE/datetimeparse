﻿// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Globalization;

Console.WriteLine("Hello, World!");
//Although MSDN says that "s" and "o" formats reflect the standard, they seem to be able to parse only a limited subset of it. Especially it is a problem if the string contains time zone specification. (Neither it does for basic ISO8601 formats, or reduced precision formats - however this is not exactly your case.) That is why I make use of custom format strings when it comes to parsing ISO8601. Currently my preferred snippet is:

   string[] frm = { 
    // Basic formats
    "yyyyMMddTHHmmsszzz",
    "yyyyMMddTHHmmsszz",
    "yyyyMMddTHHmmssZ",
    // Extended formats
    "yyyy-MM-ddTHH:mm:sszzz",
    "yyyy-MM-ddTHH:mm:sszz",
    "yyyy-MM-ddTHH:mm:ssZ",
    // All of the above with reduced accuracy
    "yyyyMMddTHHmmzzz",
    "yyyyMMddTHHmmzz",
    "yyyyMMddTHHmmZ",
    "yyyy-MM-ddTHH:mmzzz",
    "yyyy-MM-ddTHH:mmzz",
    "yyyy-MM-ddTHH:mm",
    "yyyy-MM-ddTHH:mmZ",
    // Accuracy reduced to hours
    "yyyyMMddTHHzzz",
    "yyyyMMddTHHzz",
    "yyyyMMddTHHZ",
    "yyyy-MM-ddTHHzzz",
    "yyyy-MM-ddTHHzz",
    "yyyy-MM-ddTHHZ"
    };
List<DateTime> dateTime = ParseISO8601String();
var l =dateTime.GroupBy(e => e.Day);

foreach (var item in l)
{
    Console.WriteLine(item.Key);
    Console.WriteLine($"Total Count=> {item.Count()}");
    foreach (var item2 in item)
    {
        Console.WriteLine(item2);
        Console.WriteLine(item2.Hour);
    }
}
//Console.WriteLine(dateTime.Hour);
//Console.WriteLine(dateTime.Day);
//Console.WriteLine(dateTime.Date);
//Console.WriteLine(ParseISO8601String("2023-05-16T17:00", frm));
Console.ReadKey();

static List<DateTime> ParseISO8601String()
{
    List < DateTime > list = new List<DateTime> ();
    string[] date = {"2023-05-10T00:00",
"2023-05-10T01:00",
"2023-05-10T02:00",
"2023-05-10T03:00",
"2023-05-10T04:00",
"2023-05-10T05:00",
"2023-05-10T06:00",
"2023-05-10T07:00",
"2023-05-10T08:00",
"2023-05-10T09:00",
"2023-05-10T10:00",
"2023-05-10T11:00",
"2023-05-10T12:00",
"2023-05-10T13:00",
"2023-05-10T14:00",
"2023-05-10T15:00",
"2023-05-10T16:00",
"2023-05-10T17:00",
"2023-05-10T18:00",
"2023-05-10T19:00",
"2023-05-10T20:00",
"2023-05-10T21:00",
"2023-05-10T22:00",
"2023-05-10T23:00",
"2023-05-11T00:00",
"2023-05-11T01:00",
"2023-05-11T02:00",
"2023-05-11T03:00",
"2023-05-11T04:00",
"2023-05-11T05:00",
"2023-05-11T06:00",
"2023-05-11T07:00",
"2023-05-11T08:00",
"2023-05-11T09:00",
"2023-05-11T10:00",
"2023-05-11T11:00",
"2023-05-11T12:00",
"2023-05-11T13:00",
"2023-05-11T14:00",
"2023-05-11T15:00",
"2023-05-11T16:00",
"2023-05-11T17:00",
"2023-05-11T18:00",
"2023-05-11T19:00",
"2023-05-11T20:00",
"2023-05-11T21:00",
"2023-05-11T22:00",
"2023-05-11T23:00",
"2023-05-12T00:00",
"2023-05-12T01:00",
"2023-05-12T02:00",
"2023-05-12T03:00",
"2023-05-12T04:00",
"2023-05-12T05:00",
"2023-05-12T06:00",
"2023-05-12T07:00",
"2023-05-12T08:00",
"2023-05-12T09:00",
"2023-05-12T10:00",
"2023-05-12T11:00",
"2023-05-12T12:00",
"2023-05-12T13:00",
"2023-05-12T14:00",
"2023-05-12T15:00",
"2023-05-12T16:00",
"2023-05-12T17:00",
"2023-05-12T18:00",
"2023-05-12T19:00",
"2023-05-12T20:00",
"2023-05-12T21:00",
"2023-05-12T22:00",
"2023-05-12T23:00",
"2023-05-13T00:00",
"2023-05-13T01:00",
"2023-05-13T02:00",
"2023-05-13T03:00",
"2023-05-13T04:00",
"2023-05-13T05:00",
"2023-05-13T06:00",
"2023-05-13T07:00",
"2023-05-13T08:00",
"2023-05-13T09:00",
"2023-05-13T10:00",
"2023-05-13T11:00",
"2023-05-13T12:00",
"2023-05-13T13:00",
"2023-05-13T14:00",
"2023-05-13T15:00",
"2023-05-13T16:00",
"2023-05-13T17:00",
"2023-05-13T18:00",
"2023-05-13T19:00",
"2023-05-13T20:00",
"2023-05-13T21:00",
"2023-05-13T22:00",
"2023-05-13T23:00",
"2023-05-14T00:00",
"2023-05-14T01:00",
"2023-05-14T02:00",
"2023-05-14T03:00",
"2023-05-14T04:00",
"2023-05-14T05:00",
"2023-05-14T06:00",
"2023-05-14T07:00",
"2023-05-14T08:00",
"2023-05-14T09:00",
"2023-05-14T10:00",
"2023-05-14T11:00",
"2023-05-14T12:00",
"2023-05-14T13:00",
"2023-05-14T14:00",
"2023-05-14T15:00",
"2023-05-14T16:00",
"2023-05-14T17:00",
"2023-05-14T18:00",
"2023-05-14T19:00",
"2023-05-14T20:00",
"2023-05-14T21:00",
"2023-05-14T22:00",
"2023-05-14T23:00",
"2023-05-15T00:00",
"2023-05-15T01:00",
"2023-05-15T02:00",
"2023-05-15T03:00",
"2023-05-15T04:00",
"2023-05-15T05:00",
"2023-05-15T06:00",
"2023-05-15T07:00",
"2023-05-15T08:00",
"2023-05-15T09:00",
"2023-05-15T10:00",
"2023-05-15T11:00",
"2023-05-15T12:00",
"2023-05-15T13:00",
"2023-05-15T14:00",
"2023-05-15T15:00",
"2023-05-15T16:00",
"2023-05-15T17:00",
"2023-05-15T18:00",
"2023-05-15T19:00",
"2023-05-15T20:00",
"2023-05-15T21:00",
"2023-05-15T22:00",
"2023-05-15T23:00",
"2023-05-16T00:00",
"2023-05-16T01:00",
"2023-05-16T02:00",
"2023-05-16T03:00",
"2023-05-16T04:00",
"2023-05-16T05:00",
"2023-05-16T06:00",
"2023-05-16T07:00",
"2023-05-16T08:00",
"2023-05-16T09:00",
"2023-05-16T10:00",
"2023-05-16T11:00",
"2023-05-16T12:00",
"2023-05-16T13:00",
"2023-05-16T14:00",
"2023-05-16T15:00",
"2023-05-16T16:00",
"2023-05-16T17:00",
"2023-05-16T18:00",
"2023-05-16T19:00",
"2023-05-16T20:00",
"2023-05-16T21:00",
"2023-05-16T22:00",
"2023-05-16T23:00" };
    for (int i = 0; i < date.Length; i++)
    {
        //Console.WriteLine(Convert.ToDateTime(date[i]));
        list.Add(Convert.ToDateTime(date[i]));
    }
    //return DateTime.ParseExact(str, formats,
    //    new System.Globalization.CultureInfo("en-US"), DateTimeStyles.None);
    return list;
}
//static DateTime ParseISO8601String(string str, string[] formats)
//{
//    //return DateTime.ParseExact(str, formats,
//    //    new System.Globalization.CultureInfo("en-US"), DateTimeStyles.None);
//    return Convert.ToDateTime(str);
//}
