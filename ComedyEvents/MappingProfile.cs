using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ComedyEvents.Dto;
using ComedyEvents.Models;

namespace ComedyEvents
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Event, EventDto>();
            CreateMap<EventDto, Event>();
        }
    }
}
