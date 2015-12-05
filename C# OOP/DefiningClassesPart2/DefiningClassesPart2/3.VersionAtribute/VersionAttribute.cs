using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Attribute
{
   
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface
        | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        private int minor;
        private int major;


        public int Major
        {
            get { return major; }
            set
            {
                if (value < 0) throw new ArgumentException("Negative version is impossible!");
                major = value;
            }
        }
        public int Minor
        {
            get { return minor; }
            set
            {
                if (value < 0) throw new ArgumentException("Negative version is impossible!");
                minor = value;
            }
        }


        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }


        public override string ToString()
        {
            return this.Major + "." + this.Minor;
        }


    }
}

