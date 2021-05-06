using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spMedicalGroup_webApi.Domains
{
    public partial class Consulta
    {
        public int IdConsulta { get; set; }

        [Required(ErrorMessage = "O campo ID do Paciente é obrigatório.")]
        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "O campo ID do Médico é obrigatório.")]
        public int IdMedico { get; set; }
        public int? IdSituacao { get; set; }
        [Required(ErrorMessage ="Informe a data para agendamento da consulta!")]
        public DateTime DataAgendamento { get; set; }
        public string Descricao { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Situaco IdSituacaoNavigation { get; set; }
    }
}
