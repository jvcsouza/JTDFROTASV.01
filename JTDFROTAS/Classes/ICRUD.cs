using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTDFROTAS.Classes
{
    interface ICRUD
    {
        bool Registrar();
        bool Deletar();
        bool Atualizar();
        bool Buscar(int id);
    }
}
