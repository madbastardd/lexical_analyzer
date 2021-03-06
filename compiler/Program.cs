﻿using System;
using Concrete.TableSpace;

namespace lexical_analyzer_c_sharp {
    class Program {
        static readonly UInt16
            ERROR = 0,
            SPACE = 1,
            ONE_SYMBOL = 2,
            MULTY_SYMBOL = 4,
            KEYWORDS = 8,
            CONST = 16,
            IDENTIFIERS = 32;
        
        static void Main(string[] args) {
            System.Collections.Generic.List<UInt16> attributes = new System.Collections.Generic.List<UInt16>();
            for (byte ind = 0; ind < 128; ind++) {
                if ((char)ind >= 'A' && (char)ind <= 'Z' || (char)ind >= 'a' && (char)ind <= 'z') {
                    //keyword or identifier
                    attributes.Add((UInt16)(IDENTIFIERS | KEYWORDS));
                }
                else if ((char)ind >= '0' && (char)ind <= '9') {
                    //constant
                    attributes.Add((UInt16)(CONST));
                }
                else {
                    attributes.Add((UInt16)(ERROR));
                }
            }

            Table table = new Table();

            table.insert("dimasik");
        }
    }
}
