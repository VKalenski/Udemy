#region Usings
using AutoMapper;
using PersonAPI.Dtos;
using PersonAPI.Models;
#endregion

namespace PersonAPI.Profiles
{
    public class AgeResolver : IValueResolver<Person, PersonReadDto, int>
    {
        public int Resolve(Person source, PersonReadDto destination, int destMember, ResolutionContext context)
        {
            var today = DateTime.Today;

            var splidDoB = source.DoB!.Split("-");

            return today.Year - int.Parse(splidDoB[0]) + 100;
        }
    }
}