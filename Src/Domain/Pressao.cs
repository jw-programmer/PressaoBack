using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Src.Domain.Enuns;

namespace Src.Domain
{
    public class PressaoArterial
    {
        private PressaoArterial()
        {

        }

        public PressaoArterial(long id, int pressaoArterialSistolica, int pressaoArterialDiastalica, DateTime dataMedicao) : this(pressaoArterialSistolica, pressaoArterialDiastalica)
        {
            this.PressaoArterialId = id;
            this.DataMedicao = dataMedicao;
        }



        public PressaoArterial(int pressaoArterialSistolica, int pressaoArterialDiastalica)
        {
            this.PressaoArterialSistolica = pressaoArterialSistolica;
            this.PressaoArterialDiastalica = pressaoArterialDiastalica;
            this.DataMedicao = DateTime.Now;
            MedirRisco();
        }
        [Key]
        public long? PressaoArterialId { get; private set; }

        [Required]
        [Column (TypeName = "decimal(3,2)")]
        public decimal PressaoArterialSistolica { get; private set; }

        [Required]
        [Column (TypeName = "decimal(3,2)")]
        public decimal PressaoArterialDiastalica { get; private set; }

        [Required]
        public ClassificacaoRisco ClassificaoMedida { get; private set; }

        [Required]
        public DateTime DataMedicao { get; private set; }

        private ClassificacaoRisco MedirRisco()
        {

            if (PressaoArterialSistolica <= 120 && PressaoArterialDiastalica <= 80)
            {
                ClassificaoMedida = ClassificacaoRisco.Normal;
            }
            if ((PressaoArterialSistolica > 120 && PressaoArterialSistolica <= 139.9M) || (PressaoArterialDiastalica > 80 && PressaoArterialDiastalica <= 89.9M))
            {
                ClassificaoMedida = ClassificacaoRisco.Leve;
            }
            if ((PressaoArterialSistolica >= 140 && PressaoArterialSistolica <= 159.9M) || (PressaoArterialDiastalica >= 90 && PressaoArterialDiastalica <= 100M))
            {
                ClassificaoMedida = ClassificacaoRisco.Moderada;
            }
            if (PressaoArterialSistolica >= 160 || PressaoArterialDiastalica > 100M)
            {
                ClassificaoMedida = ClassificacaoRisco.Grave;
            }


            return ClassificaoMedida;
        }
    }
}