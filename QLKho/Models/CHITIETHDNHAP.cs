using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace QLKho.Models;

[PrimaryKey("MAHDNHAP", "MASP")]
[Table("CHITIETHDNHAP")]
public partial class CHITIETHDNHAP
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MAHDNHAP { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MASP { get; set; } = null!;

    public int SOLUONGTN { get; set; }

    public int DONGIANHAP { get; set; }

    public int? THANHTIENN { get; set; }

    [StringLength(225)]
    public string? GHICHU { get; set; }

    [JsonIgnore]
    [Browsable(false)]
    [ForeignKey("MAHDNHAP")]
    [InverseProperty("CHITIETHDNHAPs")]
    public virtual HDNHAP MAHDNHAPNavigation { get; set; } = null!;
    
    [JsonIgnore]
    [Browsable(false)]
    [ForeignKey("MASP")]
    [InverseProperty("CHITIETHDNHAPs")]
    public virtual SANPHAM MASPNavigation { get; set; } = null!;
}
