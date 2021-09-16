using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace blogdeneme.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="Java"},
                new Category(){KategoriAdi="C"},
                new Category(){KategoriAdi="Python"}

            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C#1 ", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="Java1", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-150),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=2},
                new Blog(){Baslik="C1", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-102),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=3},
                new Blog(){Baslik="Python1", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-101),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=4},
                new Blog(){Baslik="C#2 ", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-120),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="Java2", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-210),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=2},
                new Blog(){Baslik="C2", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-110),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=3},
                new Blog(){Baslik="Python2", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-110),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=4},
                new Blog(){Baslik="C#3", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-1088),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="Java3", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa= true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=2},
                new Blog(){Baslik="C3", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-190),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=3},
                new Blog(){Baslik="Python3 ", Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="Yazılım Dili",Resim="1.jpg",CategoryId=4},

            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();


            base.Seed(context);
        }
    }
}