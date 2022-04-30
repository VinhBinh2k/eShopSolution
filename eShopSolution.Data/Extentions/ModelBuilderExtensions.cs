using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage of eshopsolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eshopsolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eshopsolution" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Status.Active },
                new Category() { Id = 2, IsShowOnHome = true, ParentId = null, SortOrder = 2, Status = Status.Active }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Aó nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                 new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt product for men", SeoTitle = "The shirt product for men" },
                 new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Aó nữ", LanguageId = "vi-VN", SeoAlias = "ao-nữ", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                 new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt product for women", SeoTitle = "The shirt product for women" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, DateCreated = DateTime.Now, OriginalPrice = 100000, Price = 200000, Stock = 0, ViewCount = 0 }
            );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Aó sơ mi nam trắng việt tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-sơ-mi-nam-trang-viet-tien",
                    SeoDescription = "Sản phẩm Aó sơ mi nam trắng việt tiến",
                    SeoTitle = "Sản phẩm Aó sơ mi nam trắng việt tiến",
                    Details = "Aó sơ mi nam trắng việt tiến",
                    Description = " "
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viet-tien-men-T-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = " "
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
            );






        }
    }
}
