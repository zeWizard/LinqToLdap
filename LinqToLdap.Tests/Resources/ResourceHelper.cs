using System.IO;
using System.Reflection;

namespace LinqToLdap.Tests.Resources
{
    /// <summary>
    /// Resource Helper
    /// </summary>
    public static class ResourceHelper
    {
        /// <summary>
        /// Gets the assembly resource.
        /// </summary>
        /// <param name="relativePath">The relative path.</param>
        /// <returns>The resource as a byte array.</returns>
        public static byte[] GetAssemblyResource(string relativePath)
        {
            var location = Assembly.GetEntryAssembly().Location;
            var directory = Path.GetDirectoryName(location);

            return File.ReadAllBytes(Path.Combine(directory, relativePath));
        }
    }
}