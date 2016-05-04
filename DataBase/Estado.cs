﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicaMedicaCodeFirst.DataBase
{
    [Table("estado")]
    public class Estado
    {
        [Key]
        [Column("id_estado", TypeName = "INT")]        
        public int EstadoID { get; set; }

        [Required]
        [Column("est_nombre", TypeName = "VARCHAR"), MaxLength(45)]                
        public String Nombre { get; set; }

        [Column("est_descripcion", TypeName = "VARCHAR"), MaxLength(250)]                
        public String Descripcion { get; set; }

        [Required]
        [Column("est_fecha_creacion", TypeName = "DATE")]
        public DateTime FechaCrecion { get; set; }

        public virtual List<tcAlergia> tcAlergias { get; set; }
        public virtual List<tcMedicamento> tcMedicamentos { get; set; }
        public virtual List<tcUnidadMedida> tcUnidadMedidas { get; set; }
        public virtual List<tcEnfermedad> tcEnfermedades{ get; set; }
        public virtual List<tcLaboratorio> tcLaboratorios { get; set; }
        public virtual List<Paciente> Pacientes { get; set; }
        public virtual List<Expediente> Expedientes { get; set; }
        public virtual List<tcGenero> tcGeneros { get; set; }
        public virtual List<tcProfesion> tcProfeciones { get; set; }
        public virtual List<AlergiaExpediente> AlergiasExpedientes { get; set; }
        public virtual List<CondicionMedicaExpediente> CondicionMedicaExpedientes { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
        public virtual List<OrdenLaboratorio> OrdenLaboratorios { get; set; }
        public virtual List<ExamenLaboratorio> ExamenLaboratorios { get; set; }
        public virtual List<ImagenLaboratorio> ImagenLaboratorios { get; set; }
        public virtual List<InstitucionReferencia> InstitutoReferencias { get; set; }
        public virtual List<Medico> Medicos { get; set; }
        public virtual List<Tratamiento> Tratamientos { get; set; }
        public virtual List<TratamientoMedicamento> TratamientoMedicamentos { get; set; }

    }
}