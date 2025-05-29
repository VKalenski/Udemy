#region Usings
using AutoMapper;
#endregion

namespace PersonAPI.Profiles
{
    public class IntTypeConverter : ITypeConverter<string, int>
    {
        public int Convert(string source, int destination, ResolutionContext context)
        {
            var convertedInt = 1;

            try
            {
                convertedInt = System.Convert.ToInt32(source);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Whoops! Error converting: {ex.Message}");
            }

            return convertedInt;
        }
    }
}