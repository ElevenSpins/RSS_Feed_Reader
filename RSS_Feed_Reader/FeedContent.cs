using System;
using System.Collections.Generic;
using System.Text;
using CodeHollow.FeedReader;

namespace RSS_Feed_Reader
{
    class FeedContent
    {
        
        //public Variablen
        public string URLtext;
        public Feed filledFeed;

        //Methode zum abruf des Feeds
        public Feed fillFeed(string iURLtext) {
            
            //iURLText aus TextBox
            filledFeed= FeedReader.Read(iURLtext);

            return filledFeed;
        }



    }
}
