using System.Collections.Generic;

namespace OOTPiSP
{
    abstract public class AbstractVector
    {
        public List<int> Vector { get; set; }

        public abstract void Sort();
    }
}