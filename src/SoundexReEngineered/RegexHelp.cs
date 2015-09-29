using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoundexCore
{
    public static class RegexHelp
    {
        //Regex to find three letters match, two letters match, one letter match
        public static Regex regSquare = new Regex(@"\Boosh\B|\Boosh\b|\boosh\B|\boosh\b");
        public static Regex regTriples = new Regex(@"\Baou\B|\Biya\B|\Baou\b|\Biya\b|\baou\B|\biya\B|\baou\b|\biya\b|\Bish\B|\Bish\b|\bish\B|\bish\b|\bush\B|\bush\b|\Bush\b|\Bush\B|\Bder\b|\Bdra\b");
        public static Regex regDoubles = new Regex(@"\Baa\B|\Bou\B|\Bau\B|\Baw\B|\Bav\B|\Bow\B|\Bov\B|\Bee\B|\Bii\B|\Bea\B|\Bei\B|\Bai\B|\Bph\B|\Bia\B|\Bck\B|\Buv\B|\Boo\B|
                                                     \Baa\b|\Bou\b|\Bau\b|\Baw\b|\Bav\b|\Bow\b|\Bov\b|\Bee\b|\Bii\b|\Bea\b|\Bei\b|\Bai\b|\Bph\b|\Bia\b|\Bck\b|\Buv\b|\Boo\b|
                                                     \baa\B|\bou\B|\bau\B|\baw\B|\bav\B|\bow\B|\bov\B|\bee\B|\bii\B|\bea\B|\bei\B|\bai\B|\bph\B|\bia\B|\bck\B|\buv\B|\boo\B|
                                                     \baa\b|\bou\b|\bau\b|\baw\b|\bav\b|\bow\b|\bov\b|\bee\b|\bii\b|\bea\b|\bei\b|\bai\b|\bph\b|\bia\b|\bck\b|\buv\b|\boo\b");
        public static Regex regSingle = new Regex(@"[a,i,u,e,o,f,c,k,y]");

        //Evaluators to replace matching part of string.
        public static MatchEvaluator evalSquare = match =>
        {
            switch (match.Value)
            {
                case "oosh": return "7";
                default: throw new Exception("Unexpected match!");
            }
        };
        
        
        public static MatchEvaluator evalTriples = match =>
        {
            switch (match.Value)
            {
                case "aou": return "1";
                case "iya": return "8";
                case "der": return "9";
                case "dra": return "9";
                case "ush": return "7";
                case "ish": return "7";
                default: throw new Exception("Unexpected match!");
            }
        };

        public static MatchEvaluator evalDoubles = match =>
        {
            switch (match.Value)
            {
                case "aa": return "0";
                case "ou":
                case "au":
                case "aw":
                case "av":
                case "ow":
                case "uv":
                case "ov": return "1";
                case "ee":
                case "ii":
                case "ea":
                case "ai":
                case "ei": return "2";
                case "oo": return "3";
                case "ph": return "6";
                case "ia": return "8";
                case "ck": return "k";
                default: throw new Exception("Unexpected match!");
            }
        };

        public static MatchEvaluator evalSingle = match =>
        {
            switch (match.Value)
            {

                case "a":
                case "u": return "3";
                case "y":
                case "i": return "2";
                case "e": return "4";
                case "o": return "5";
                case "f": return "6";
                case "c":
                case "k": return "k";
                case "v":
                case "w": return "v";
                default: throw new Exception("Unexpected match!");
            }
        };

    }
}
