using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {    public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EshopContext>();

            context.Database.Migrate();

            if(!context.Products.Any())
            {
                var products = new[]
                {
                      new Product(){ ProductName="Photo Camera", Price=153,Image="product1.jpg", IsHome=true, IsApproved=true,IsFutured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-10)},
                      new Product(){ ProductName="Ahşap Sandalye", Price=99 ,Image="product2.jpg",IsHome=false, IsApproved=true,IsFutured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-20) },
                      new Product(){ ProductName="Rahat Koltuk", Price=526 ,Image="product3.jpg",IsHome=true, IsApproved=false,IsFutured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-30) },
                      new Product(){ ProductName="El Çantası", Price=125,Image="product4.jpg",IsHome=true,IsApproved=true, IsFutured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-5)  },
                      new Product(){ ProductName="Mobilya", Price=250,Image="product3.jpg",IsHome=true, IsApproved=true,IsFutured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-2)}
                 };

                context.Products.AddRange(products);
                var categories = new[]
                {
                      new Category(){ CategoryName="Elektronik" },
                      new Category(){ CategoryName="Aksesuar" },
                       new Category(){ CategoryName="Mobilya" },
                       new Category(){CategoryName="Kozmetik"}
                  };
                context.Categories.AddRange(categories);
                var productcategories = new[]
                {
                    new ProductCategory(){ Product=products[0], Category=categories[0] },
                    new ProductCategory(){ Product=products[1], Category=categories[0] },
                    new ProductCategory(){ Product=products[3], Category=categories[2] },
                    new ProductCategory(){ Product=products[2], Category=categories[1] },

                };
                context.AddRange(productcategories);

                var images = new[]
                {
                    new Image(){ImageName="product1.jpg", Product=products[0]},
                    new Image(){ImageName="product2.jpg", Product=products[0]},
                    new Image(){ImageName="product3.jpg", Product=products[0]},
                    new Image(){ImageName="product4.jpg", Product=products[0]},

                    new Image(){ImageName="product1.jpg", Product=products[1]},
                    new Image(){ImageName="product2.jpg", Product=products[1]},
                    new Image(){ImageName="product3.jpg", Product=products[1]},
                    new Image(){ImageName="product4.jpg", Product=products[1]},

                    new Image(){ImageName="product1.jpg", Product=products[2]},
                    new Image(){ImageName="product2.jpg", Product=products[2]},
                    new Image(){ImageName="product3.jpg", Product=products[2]},
                    new Image(){ImageName="product4.jpg", Product=products[2]},

                    new Image(){ImageName="product1.jpg", Product=products[3]},
                    new Image(){ImageName="product2.jpg", Product=products[3]},
                    new Image(){ImageName="product3.jpg", Product=products[3]},
                    new Image(){ImageName="product4.jpg", Product=products[3]},

                };
                context.Images.AddRange(images);

                var attributes = new[]
                {
                    new ProductAttribute(){ Attribute="Ekran",Value="15.6",Product=products[0]},
                    new ProductAttribute(){ Attribute="İşlemci",Value="Intel i7",Product=products[0]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",Product=products[0]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",Product=products[0]},
                    new ProductAttribute(){ Attribute="Renk",Value="Siyah",Product=products[0]},

                    new ProductAttribute(){ Attribute="Ekran",Value="15.6",Product=products[1]},
                    new ProductAttribute(){ Attribute="İşlemci",Value="Intel i7",Product=products[1]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",Product=products[1]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",Product=products[1]},
                    new ProductAttribute(){ Attribute="Renk",Value="Siyah",Product=products[1]},

                    new ProductAttribute(){ Attribute="Ekran",Value="15.6",Product=products[2]},
                    new ProductAttribute(){ Attribute="İşlemci",Value="Intel i7",Product=products[2]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",Product=products[2]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",Product=products[2]},
                    new ProductAttribute(){ Attribute="Renk",Value="Siyah",Product=products[2]},

                    new ProductAttribute(){ Attribute="Ekran",Value="15.6",Product=products[3]},
                    new ProductAttribute(){ Attribute="İşlemci",Value="Intel i7",Product=products[3]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",Product=products[3]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",Product=products[3]},
                    new ProductAttribute(){ Attribute="Renk",Value="Siyah",Product=products[3]},

                    new ProductAttribute(){ Attribute="Ekran",Value="15.6",Product=products[4]},
                    new ProductAttribute(){ Attribute="İşlemci",Value="Intel i7",Product=products[4]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB",Product=products[4]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB",Product=products[4]},
                    new ProductAttribute(){ Attribute="Renk",Value="Siyah",Product=products[4]},



                };

                context.Attributes.AddRange(attributes);

                context.SaveChanges();
            }
        }           
            }}
