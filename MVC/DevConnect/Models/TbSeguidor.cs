using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_seguidor")]
public partial class TbSeguidor
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }
}
