using Restaurant_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Data
{
    public interface IRestaurantData
    {
        Table GetById(int id);
        Table Update(Table updatedTable);
        Table Add(Table newTable);
        Table Delete(int id);
        int Commit();
    }
}
