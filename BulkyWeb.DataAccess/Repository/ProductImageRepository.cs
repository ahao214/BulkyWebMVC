﻿using BulkyWeb.DataAccess.Data;
using BulkyWeb.DataAccess.Repository.BaseRepository;
using BulkyWeb.Models;

namespace BulkyWeb.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
