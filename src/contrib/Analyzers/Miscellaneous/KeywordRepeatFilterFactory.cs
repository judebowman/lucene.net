﻿using System;
using System.Collections.Generic;
using System.Linq;
using Lucene.Net.Analysis.Util;

namespace Lucene.Net.Analysis.Miscellaneous
{
    public class KeywordRepeatFilterFactory : TokenFilterFactory 
    {
        public KeywordRepeatFilterFactory(IDictionary<string, string> args) : base(args)
        {
            if (args.Any())
            {
                throw new ArgumentException("Unknown parameters: " + args);
            }
        }

        public override TokenStream Create(TokenStream input)
        {
            return new KeywordRepeatFilter(input);
        }
    }
}