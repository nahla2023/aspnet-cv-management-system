using ASP_project.DB;

namespace ASP_project
{
    public class CRUD
    {

        public CRUD()
        {

        }
        public void create(CV c,DBHelper Context)
        {
                Context.CVs.Add(c);
                Context.SaveChanges();
            
        }

        public CV Read(DBHelper Context,int? id)
        {
            return Context.CVs.Find(id);
        }
       
        public void update(int id, DBHelper Context,string f,string l,string e,string g,string n,string d,string ps,int G,string img)
        {
               CV data = Context.CVs.Find(id);
                data.firstname = f;
                data.lastname = l;
                data.Email = e;
                data.Gender = g;
                data.Nationality = n;
                data.DateOfBirth = d;
                data.Skills = ps;
                data.grade = G;
                data.photo = img; Context.CVs.Update(data);
                Context.Update(data);

                Context.SaveChanges();
        }
        public void Delete(int id, DBHelper Context)
        {
              

                CV data = Context.CVs.Find(id);
               
                Context.CVs.Remove(data);
                
                Context.SaveChanges();
            
        }
    }
}
