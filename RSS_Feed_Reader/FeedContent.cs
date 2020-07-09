using System;
using System.Collections.Generic;
using System.Text;
using CodeHollow.FeedReader;

namespace RSS_Feed_Reader
{
    class FeedContent
    {
        

        public string URLtext;
        public Feed filledFeed;


        public Feed fillFeed(string iURLtext) {
            
            filledFeed= FeedReader.Read(iURLtext);

            return filledFeed;
        }



    }
}
