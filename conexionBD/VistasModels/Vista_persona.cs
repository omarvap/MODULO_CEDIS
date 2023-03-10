using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.VistasModels
{
    public class Vista_persona
    {
        public List<persona> cbPersona()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                return cn.persona.ToList();
            }
        }
    }
}
