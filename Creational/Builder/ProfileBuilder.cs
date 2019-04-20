using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Abstract base class for Profile Construction
    /// </summary>
    abstract class ProfileBuilder
    {
        /// <summary> Finds the correct position for a profile element </summary>
        ///
        /// Reevaluate position in design. Maybe this dosen't go here. 
        /// 
        public abstract void PositionElement(Element e);

        /// <summary>Gets the string representation of a given element</summary>
        public abstract string GetElementOutput(Element e);

    }
}