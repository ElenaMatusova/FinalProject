using AutoMapper;
using CourseWork.BLL.DTOs;
using CourseWork.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.Infrastructure
{
    public class MapperModel : Profile
    {
        public MapperModel()
        {
            CreateMap<Campain, CampainDTO>()
             .ForMember(dto => dto.Tags, opt => opt.MapFrom(x => x.CampainTags.Select(y => y.Tag).ToList()));
            CreateMap<Bonus, BonusDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Like, LikeDTO>().ReverseMap();
            CreateMap<News, NewsDTO>().ReverseMap();
            CreateMap<PicturesGalary, PicturesGalaryDTO>().ReverseMap();
            CreateMap<Transaction, TransactionDTO>().ReverseMap();
            CreateMap<Vote, VoteDTO>().ReverseMap();
            CreateMap<User, UserInfoDTO>().ReverseMap();
            CreateMap<Tag, CampainTagDTO>().ReverseMap();
            CreateMap<CampainTag, CampainTagDTO>().ReverseMap();
            

        }
    }
}
