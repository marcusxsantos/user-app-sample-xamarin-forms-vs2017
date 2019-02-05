using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioApp
{

    public class ExmploMasterDetailPageMenuItem
    {
        public ExmploMasterDetailPageMenuItem()
        {
            TargetType = typeof(ExmploMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}