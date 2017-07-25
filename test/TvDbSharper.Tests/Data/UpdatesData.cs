﻿namespace TvDbSharper.Tests.Data
{
    using System.Collections;
    using System.Collections.Generic;

    public class UpdatesData : IEnumerable<object[]>
    {
        private IEnumerable<object[]> Data { get; } = new List<object[]>
        {
            new [] { "2017-07-25T17:22:35.9063328+03:00", "2017-07-30T17:22:35.9063328+03:00", "1501003355", "1501435355" },
            new [] { "2017-07-26T17:22:35.9063328+03:00", "2017-07-31T17:22:35.9063328+03:00", "1501089755", "1501521755" },
            new [] { "2017-07-27T17:22:35.9063328+03:00", "2017-08-01T17:22:35.9063328+03:00", "1501176155", "1501608155" },
            new [] { "2017-07-28T17:22:35.9063328+03:00", "2017-08-02T17:22:35.9063328+03:00", "1501262555", "1501694555" },
            new [] { "2017-07-29T17:22:35.9063328+03:00", "2017-08-03T17:22:35.9063328+03:00", "1501348955", "1501780955" },
            new [] { "2017-07-30T17:22:35.9063328+03:00", "2017-08-04T17:22:35.9063328+03:00", "1501435355", "1501867355" },
            new [] { "2017-07-31T17:22:35.9063328+03:00", "2017-08-05T17:22:35.9063328+03:00", "1501521755", "1501953755" },
            new [] { "2017-08-01T17:22:35.9063328+03:00", "2017-08-06T17:22:35.9063328+03:00", "1501608155", "1502040155" },
            new [] { "2017-08-02T17:22:35.9063328+03:00", "2017-08-07T17:22:35.9063328+03:00", "1501694555", "1502126555" },
            new [] { "2017-08-03T17:22:35.9063328+03:00", "2017-08-08T17:22:35.9063328+03:00", "1501780955", "1502212955" },
            new [] { "2017-08-04T17:22:35.9063328+03:00", "2017-08-09T17:22:35.9063328+03:00", "1501867355", "1502299355" },
            new [] { "2017-08-05T17:22:35.9063328+03:00", "2017-08-10T17:22:35.9063328+03:00", "1501953755", "1502385755" },
            new [] { "2017-08-06T17:22:35.9063328+03:00", "2017-08-11T17:22:35.9063328+03:00", "1502040155", "1502472155" },
            new [] { "2017-08-07T17:22:35.9063328+03:00", "2017-08-12T17:22:35.9063328+03:00", "1502126555", "1502558555" },
            new [] { "2017-08-08T17:22:35.9063328+03:00", "2017-08-13T17:22:35.9063328+03:00", "1502212955", "1502644955" },
            new [] { "2017-08-09T17:22:35.9063328+03:00", "2017-08-14T17:22:35.9063328+03:00", "1502299355", "1502731355" },
            new [] { "2017-08-10T17:22:35.9063328+03:00", "2017-08-15T17:22:35.9063328+03:00", "1502385755", "1502817755" },
            new [] { "2017-08-11T17:22:35.9063328+03:00", "2017-08-16T17:22:35.9063328+03:00", "1502472155", "1502904155" },
            new [] { "2017-08-12T17:22:35.9063328+03:00", "2017-08-17T17:22:35.9063328+03:00", "1502558555", "1502990555" },
            new [] { "2017-08-13T17:22:35.9063328+03:00", "2017-08-18T17:22:35.9063328+03:00", "1502644955", "1503076955" },
            new [] { "2017-08-14T17:22:35.9063328+03:00", "2017-08-19T17:22:35.9063328+03:00", "1502731355", "1503163355" },
            new [] { "2017-08-15T17:22:35.9063328+03:00", "2017-08-20T17:22:35.9063328+03:00", "1502817755", "1503249755" },
            new [] { "2017-08-16T17:22:35.9063328+03:00", "2017-08-21T17:22:35.9063328+03:00", "1502904155", "1503336155" },
            new [] { "2017-08-17T17:22:35.9063328+03:00", "2017-08-22T17:22:35.9063328+03:00", "1502990555", "1503422555" },
            new [] { "2017-08-18T17:22:35.9063328+03:00", "2017-08-23T17:22:35.9063328+03:00", "1503076955", "1503508955" },
            new [] { "2017-08-19T17:22:35.9063328+03:00", "2017-08-24T17:22:35.9063328+03:00", "1503163355", "1503595355" },
            new [] { "2017-08-20T17:22:35.9063328+03:00", "2017-08-25T17:22:35.9063328+03:00", "1503249755", "1503681755" },
            new [] { "2017-08-21T17:22:35.9063328+03:00", "2017-08-26T17:22:35.9063328+03:00", "1503336155", "1503768155" },
            new [] { "2017-08-22T17:22:35.9063328+03:00", "2017-08-27T17:22:35.9063328+03:00", "1503422555", "1503854555" },
            new [] { "2017-08-23T17:22:35.9063328+03:00", "2017-08-28T17:22:35.9063328+03:00", "1503508955", "1503940955" },
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var objects in this.Data)
            {
                yield return objects;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}