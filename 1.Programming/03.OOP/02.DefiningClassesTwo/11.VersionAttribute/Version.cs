using System;

namespace _11.VersionAttribute
{
     [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]

    public class Version : System.Attribute
    {
        private int major;
        private int minor;

        public Version(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public int Minor
        {
            get { return minor; }
            set { minor = value; }
        }

        public int Major
        {
            get { return major; }
            set { major = value; }
        }
    }
}
