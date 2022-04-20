using System;

namespace MultiTarget
{
    public class TheClass
    {
#if NET6_0_OR_GREATER
        public void DoStringManipulation(ReadOnlySpan<char> input)
        {
            // use spans to do string operations.
        }
#else
        public void DoStringManipulation(string input)
        {
            // Do some string operations.
        }
#endif
    }
}