﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager.NovaPasta1
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descrição { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]
        public TipoCombustivel Tipo { get; set; }

        [Required]
        public int VeiculoId { get; set; }
        public Veiculo Veiculo  { get; set; }

    }
    public enum TipoCombustivel
    {
        Diesel,
        Etanol,

    }
}
