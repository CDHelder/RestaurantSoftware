using Microsoft.EntityFrameworkCore;
using Restaurant_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RestaurantDbContext db;

        public SqlRestaurantData(RestaurantDbContext db)
        {
            this.db = db;
        }

        public Table Add(Table newTable)
        {
            db.Add(newTable);
            return newTable;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Table Delete(int id)
        {
            var table = GetById(id);
            if (table != null)
            {
                db.Tables.Remove(table);
            }
            return table;
        }

        public Table GetById(int id)
        {
            return db.Tables.Find(id);
        }

        public Table Update(Table updatedTable)
        {
            var entity = db.Tables.Attach(updatedTable);
            entity.State = EntityState.Modified;
            return updatedTable;
        }
    }
}
