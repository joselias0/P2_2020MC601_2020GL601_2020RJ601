﻿using System.ComponentModel.DataAnnotations;

namespace P2_2020MC601_2020GL601_2020RJ601.Models
{
    public class Departamentos
    {
        [Key]
        public int id_departamento { get; set; }
        public string? nombre_departamento { get; set; }
    }
}
