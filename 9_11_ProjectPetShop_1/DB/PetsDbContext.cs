using _9_11_ProjectPetShop_1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11_ProjectPetShop_1.DB
{
    public class PetsDbContext:DbContext
    {
        public /*IHostingEnvironment*/IWebHostEnvironment _webHostingEnvironment { get; set; }
        public PetsDbContext(DbContextOptions<PetsDbContext> options,IWebHostEnvironment webHostEnvironment):base(options)
        {
            _webHostingEnvironment = webHostEnvironment;
        }
        public DbSet<Animals> Animals { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comments> Comments  { get; set; }
        public DbSet<Image> images  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new { Id = 1, Name = "Mamal" },
                new { Id = 2, Name = "Aquatic" },
                new { Id = 3, Name = "Birds" },
                new { Id = 4, Name = "Reptile" }
            );
            modelBuilder.Entity<Animals>().HasData(
                new { Id = 1, ImageId=1, Name = "Shark", Age = 10, Description = "Sharks are similar to other fish. They swim underwater, extract oxygen from the water through a series of gills located on each side of their heads and have tails and fins like other fish. Unlike most fish, however, sharks do not have a bony skeleton or a swim bladder (an internal organ used to create buoyancy).Highly active sharks tend to be sleek,streamlined fish.Less active ones tend to be fairly flat.The larger and more active sharks cruise and hunt in the upper and middle depths of the oceans.Smaller ones tend to stay near the seafloor.", CategoryId = 2 },
                new { Id = 2,ImageId=2, Name = "Clown Fish", Age = 8, Description = "The clownfish is a type of fish that lives in salt water habitats. It is also called an Anemonefish. Clownfish are typically very bright, orange fish that have three white stripes, one at the head, middle and tail. If you look really closely, you may notice that there are thin black lines around the white stripes. Also, the tips of their fins have a thin black rounded stripe.", CategoryId = 2 },
                new { Id = 3,ImageId=3, Name = "Zebra", Age = 6, Description = "Zebras are famously stripy members of the horse family. These distinctive creatures are native to Africa, and actually consist of three different species. The plains zebra is the most common, the largest is the Grevy’s zebra, and the last species is the mountain zebra.", CategoryId = 1 },
                new { Id = 4,ImageId=4, Name = "Reindeer", Age = 13, Description = "The reindeer (Rangifer tarandus) is an even-toed ungulate mammal of the deer family. In North America it is also called caribou. There are about 10-20 reindeer subspecies. The reindeer is the only deer that has been domesticated.", CategoryId = 1 },
                new { Id = 5, ImageId = 5, Name = "Rainbow lorikeet", Age = 8,  Description ="The rainbow lorikeet (Trichoglossus haematodus) is an Australasian parrot. This brightly colored parrot lives on the east coast of Australia, eastern Indonesia (Maluku and Western New Guinea), Papua New Guinea, New Caledonia, Solomon Islands and Vanuatu In Australia, it is common along the eastern seaboard, from Queensland to South Australia and Tasmania. Its habitat is rainforest, coastal bush and woodland areas It has a number of subspecies,in fact, some classifications list about 20 subspecies. In some places (Western Australia, North Island of New Zealand) they have been artificially introduced, and are looked on as a pest species.", CategoryId = 3 }
            );
            modelBuilder.Entity<Comments>().HasData(
                new { Id=1, AnimaleId=3, Comment="a" },
                new { Id=2, AnimaleId=3, Comment="b" },
                new { Id = 3, AnimaleId=2, Comment="c" }
            );
            modelBuilder.Entity<Image>().HasData(
                new { Id=1, AnimaleId = 1, ImageTitle= "Shark", ImageData= TurnImageToByteArray(@"\Shark.jpg") },
                new { Id=2,AnimaleId = 2,ImageTitle= "Clown Fish", ImageData= TurnImageToByteArray(@"\ClownFish.jpg") },
                new { Id=3,AnimaleId = 3,ImageTitle= "Zebra", ImageData= TurnImageToByteArray(@"\Zebra.jpg") },
                new { Id=4,AnimaleId = 4,ImageTitle= "Reindeer", ImageData= TurnImageToByteArray(@"\Reindeer.jpg")},
                new { Id=5, AnimaleId =5, ImageTitle= "Rainbow lorikeet", ImageData= TurnImageToByteArray(@"\Rainbow_lorikeet.jpg") }
            );

        }
        public byte[] TurnImageToByteArray(string path)
        {
            string uploadFolder = Path.Combine(_webHostingEnvironment.WebRootPath, "Images");
            string filePath = uploadFolder + path;
            return File.ReadAllBytes(filePath);
        }
    }
}
