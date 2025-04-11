using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFullMark
{
    public class Game 
    {
       public Game() { }
	   public int storage_required;
       public int number_of_users = 0;
       public Account creator;
       public DateTime release_date;
       public double version = 1.0;
       public bool in_app_purchases;
    }


}

