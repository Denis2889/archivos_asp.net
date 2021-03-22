using System.ComponentModel.DataAnnotations;

namespace ApiSQLDes05.Models
{
    public class GendAccAplExt
    {
        [Key]
        public string cCodPerson {get; set; }

        public string cCodApl {get; set; }

        public string dFecIniAcc {get; set; }

        public string dFecFinAcc {get; set; }

        public string dFecUsuMod {get; set;}

        public string cCodUsuMod {get; set; }

        public string lEstReg {get; set; }
    }
}