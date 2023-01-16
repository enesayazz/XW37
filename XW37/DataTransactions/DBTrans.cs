using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using XW37.Models;

namespace XW37.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Child>();
            conn.CreateTable<Parent>();
            conn.CreateTable<Assignment>();
        }

        public List<Child> GetChildren()
        {
            Init();
            return conn.Table<Child>().ToList();
        }
        public List<Parent> GetParents()
        {
            Init();
            return conn.Table<Parent>().ToList();
        }
        public List<Assignment> GetAssignments()
        {
            Init();
            return conn.Table<Assignment>().ToList();
        }
        public void AddChild(Child child)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(child);
        }
        public void AddParent(Parent parent)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(parent);
        }
        public void AddAssignment(Assignment assignment)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(assignment);
        }
        public void DeleteChild(int child_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Child { C_ID = child_id });

        }
        public void DeleteParent(int parent_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Parent { P_ID = parent_id });
        }
        public void DeleteAssignment(int assignment_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Assignment { A_ID = assignment_id });
        }
    }
}