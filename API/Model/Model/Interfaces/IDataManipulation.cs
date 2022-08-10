using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IDataManipulation
    {
        public void delete();

        public int save();

        public void update();
    }
}
