using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_managment_system
{
    internal class Model
    {
        private static List<Model> Models = new List<Model>();
        public string Name { get; set; }
        public string Contact_Number { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
      

        public Model findone(String Name)
        {
            return Models.Find(p => p.Name == Name);
        }
        public void save()
        {
            Models.Add(this);
            MessageBox.Show("Saved Succesfuly");
        }
        public static List<Model> GetAll()
        {
            return Models;
        }


    }
}
