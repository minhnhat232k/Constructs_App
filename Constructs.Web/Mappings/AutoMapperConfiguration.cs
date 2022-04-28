using AutoMapper;
using Constructs.Model.Models;
using Constructs.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Constructs.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}