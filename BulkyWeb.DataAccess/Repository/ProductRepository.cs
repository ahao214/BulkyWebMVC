﻿using BulkyWeb.DataAccess.Data;
using BulkyWeb.DataAccess.Repository.BaseRepository;
using BulkyWeb.Models;

namespace BulkyWeb.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
