using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class SortCars : IComparable<SortCars> , IPrintable
    {
        private string Name;
        private int Id;

        public SortCars(string NameIn, int IdIn)
        {
            Name = NameIn;
            Id = IdIn;
        }
        public SortCars()
        {
        }
        public int CompareTo(SortCars obj)
        {
            if (obj == null) { return 1; }
            SortCars that = obj as SortCars;
            if (that != null)
            {
                return this.Name.CompareTo(that.Name);
            }
            else
                return -1;
        }

        public string Print()
        {
            return ("Model: " + Name + ", Year: " + Id);
        }

        // public int CompareTo(SortCars other)
        // {
        //     throw new NotImplementedException();
        //}
        /*
public int CompareTo(T other)
{
   SortCars that = T as SortCars;
   if (that != null)
   {
       return this.Name.CompareTo(that.Name);
   }
   else
       return -1;
}*/
        // public string Name { set; get; }
        //public int Id { set; get; }
    }

}
