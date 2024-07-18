using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data
{
    public interface IDataHelper<Table>
    {
        List<Table> GetAllData();
        List<Table> GetDataByUser(string UserId);
        List<Table> Search(string SearchItem);
        Table Find(int Id);
        int Add(Table table);
        int Edit(int Id,Table table);
        int Delete(int Id);
    }
}
