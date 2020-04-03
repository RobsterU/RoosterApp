using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppRooster
{
    class LesRooster
    {
        List<Les> rooster = new List<Les>();

        public void addLes(Les les)
        {
            rooster.Add(les);
        }

        public List<Les> geefRooster()
        {
            return rooster;
        }

    }
}
