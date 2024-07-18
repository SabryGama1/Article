using Article.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Article.Data.SqlServerEF
{
    public class AuthorEntity : IDataHelper<Author>
    {
        private DBContext db;
        private Author _table;
        public AuthorEntity()
        {
            db = new DBContext();
        }
        public int Add(Author author)
        {
            if (db.Database.CanConnect())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return 1;
            }
            else 
            { 
                return 0; 
            }
        }

        public int Delete(int Id)
        {
            if (db.Database.CanConnect())
            {
                _table = Find(Id);
                db.Authors.Remove(_table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Edit(int Id, Author table)
        {
            db = new DBContext();
            if (db.Database.CanConnect())
            {
                db.Authors.Update(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Author Find(int Id)
        {
            if (db.Database.CanConnect())
            {
                return db.Authors.Where(c=>c.Id == Id).First();
            }
            else
            {
                return null;
            }
        }

        public List<Author> GetAllData()
        {
            if (db.Database.CanConnect())
            {
                return db.Authors.ToList();

            }
            else
            {
                return null;
            }
        }

        public List<Author> GetDataByUser(string UserId)
        {
            throw new NotImplementedException();
        }

        public List<Author> Search(string SearchItem)
        {
            if (db.Database.CanConnect())
            {
                return db.Authors.Where(c => 
                c.FullName.Contains(SearchItem)|| 
                c.UserName.Contains(SearchItem) || 
                c.FaceBook.Contains(SearchItem) || 
                c.Twitter.Contains(SearchItem) || 
                c.Instagram.Contains(SearchItem) || 
                c.UserId.ToString().Contains(SearchItem) || 
                c.Bio.Contains(SearchItem) || 
                c.Id.ToString().Contains(SearchItem)).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
