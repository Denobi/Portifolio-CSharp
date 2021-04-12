using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.DAL;
using TCC.DTO;

namespace TCC.BLL
{
    public class TccBLL
    {
        public List<TccDTO> CargaProd()
        {
            try
            {
                return new TccDAL().Cargaprod();

            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
    }
}
