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
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
                new Contact
                {
                    ContactID = 1,
                    Location = "İstanbul, Türkiye",
                    Phone = "+90 123 456 7890",
                    Mail = "info@example.com",
                    FooterTitle = "Lezzetin Adresi",
                    FooterDescription = "Kaliteli ve lezzetli yemekleriyle müşterilerimize hizmet veriyoruz.",
                    OpenDays = "Pazartesi - Cumartesi",
                    OpenDaysDescription = "Haftanın 6 günü açığız.",
                    OpenHours = "10:00 - 22:00"
                }
              
            );
        }
    }
}
