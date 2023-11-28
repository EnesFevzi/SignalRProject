using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SıgnalRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.DataAccess.Mappings
{
    public class SocialMediaMapping : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasData(
                new SocialMedia
                {
                    SocialMediaID = 1,
                    Title = "GitHub",
                    Url = "https://github.com/EnesFevzi",
                    Icon = "fa fa-github"
                },
                new SocialMedia
                {
                    SocialMediaID = 2,
                    Title = "LinkedIn",
                    Url = "www.linkedin.com/in/enes-fevzi-cicekli\r\n\r\n",
                    Icon = "fa fa-linkedin"
                },
                new SocialMedia
                {
                    SocialMediaID = 3,
                    Title = "Portföy Sitesi",
                    Url = "https://enesfevzicicekli.com.tr/",
                    Icon = "fa fa-briefcase"
                }
           
            );
        }
    }
}
