using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrnekProje.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="KAMERA",Description="Kamera Ürünleri" },
                new Category() {Name="BİLGİSAYAR",Description="Bilgisayar Ürünleri" }
              
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {Name="Canon",Description="Kamera Ürünleri",Price=2500,Stock=10,IsApproved=true,IsHome=true,CategoryId=1,Image="kamera1.jpg" },
                new Product() {Name="Asus",Description="Bilgisayar Ürünleri",Price=1250,Stock=50,IsHome=true,IsApproved=true,CategoryId=2,Image="pc2.jpg"},
                new Product() {Name="Lenova",Description="Bilgisayar Ürünleri",Price=1250,Stock=50,IsHome=true,IsApproved=true,CategoryId=2,Image="pc3.jpg"},
                new Product() {Name="Casper",Description="Bilgisayar Ürünleri",Price=1000,Stock=150,IsHome=true,IsApproved=true,CategoryId=2,Image="pc1.jpg" }
               
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}