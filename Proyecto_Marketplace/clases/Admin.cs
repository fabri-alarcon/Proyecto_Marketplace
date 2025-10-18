using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Marketplace.clases
{
    public class Admin : Usuario {

        //con base llamamos a LLAMAMOS al constructor del padre osea en este caso seria el constructo de Usuario
        public Admin(string nombre, string pass, string correo) : base(nombre, pass) {


        }
    }
}
