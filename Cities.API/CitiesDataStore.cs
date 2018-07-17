using Cities.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.API
{
    public class CitiesDataStore
    {
        //autoproperty assignment new in C# 6
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }
        
        public CitiesDataStore()
        {
            //dum dum data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Richmond",
                    Description = "The River City",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "James River",
                            Description = "The river" },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "James River Walk",
                            Description = "The walk next to the river"}
                    }
                },
                 new CityDto()
                {
                    Id = 2,
                    Name = "Glen Allen",
                    Description = "Next to the River City",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Glen Allen River",
                            Description = "The little river"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Glen Allen River Walk",
                            Description = "The walk next to the little river"
                        }
                    }
                },
                  new CityDto()
                {
                    Id = 3,
                    Name = "Ashland",
                    Description = "The Center of the Universe"
                },

            };
        }
    }
}
