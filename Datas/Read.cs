using libraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryGUI.Datas
{
    internal class Read
    {
        public List<Authors> Readauthors()
        {
            try
            {
                using (var context = new Models.librarydbContext())
                {
                    var authors = context.Authors.ToList();
                    return authors;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
