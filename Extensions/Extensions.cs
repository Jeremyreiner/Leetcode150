using System.Text;

namespace LeetCode.Extensions
{
    public static class Extensions
    {
        public static Version ValidVersion(this string version)
        {
            if (Version.TryParse(version, out var v1))
            {
                var build = v1.Build != -1
                    ? v1.Build
                    : 0;
                var major = v1.Major != -1
                    ? v1.Major
                    : 0;
                var minor = v1.Minor != -1
                    ? v1.Minor
                    : 0;
                var revision = v1.Revision != -1
                    ? v1.Revision
                    : 0;

                return new Version(major, minor, build, revision);
            }

            if (int.TryParse(version, out var intVersion1))
            {
                return new Version(intVersion1, 0, 0, 0);
            }

            Console.WriteLine($"Invalid version string: {version}");

            var versions = version.Split('.').ToList();

            return ValidVersion(versions.InvalidVersion());
        }

        private static string InvalidVersion(this List<string> versions)
        {
            var builder = new StringBuilder();

            for (var i = 0; i < versions.Count; i++)
            {
                if (i > 2)
                {
                    if (versions[i] == "0")
                        continue;

                    //Last instance of invalid can append at the end with no period
                    builder.Append($"{versions[i]}");
                }
                else
                    builder.Append($"{versions[i]}.");
            }

            var v = builder.ToString();

            if (v.LastOrDefault() == '.')
                builder.Append("0");

            return builder.ToString();
        }
    }
}
