using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.DataAccess.Mappings
{
    public class TestimonialMapping : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasData(
                new Testimonial
                {
                    TestimonialID = 1,
                    Name = "Tarık Yüksel",
                    Title = "Memnun Müşteri",
                    Comment = "Yemekleri ve hizmeti çok seviyorum! Kesinlikle tavsiye ederim.",
                    ImageUrl = "/images/60111.jpg"
                },
                new Testimonial
                {
                    TestimonialID = 2,
                    Name = "Tekin Öztürk",
                    Title = "Düzenli Müşteri",
                    Comment = "Arkadaşlarınızla vakit geçirmek için harika bir yer. Lezzetli burgerler!",
                    ImageUrl = "/images/60111.jpg"
                },
                new Testimonial
                {
                    TestimonialID = 3,
                    Name = "Eren Yaman",
                    Title = "Memnun Müşteri",
                    Comment = "Mükemmel müşteri hizmeti. Kesinlikle tekrar ziyaret edeceğim.",
                    ImageUrl = "/images/60111.jpg"
                }
            // Diğer müşteri yorumları eklemeye devam edebilirsiniz.
            );
        }
    }
}
