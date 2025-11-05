using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace QLKho.Models;

[Table("SANPHAM")]
public partial class SANPHAM
{
    [StringLength(10)]
    [Unicode(false)]
    public string MALOAI { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MASP { get; set; } = null!;

    [StringLength(100)]
    public string? TENSP { get; set; }

    [StringLength(255)]
    public string? HINH { get; set; }

    public DateOnly? NSX { get; set; }

    [StringLength(10)]
    public string? DVT { get; set; }

    [Column(TypeName = "money")]
    public decimal? GIABAN { get; set; }

    public int? SOLUONG { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MANCC { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string? BARCODE { get; set; }

    [StringLength(100)]
    public string? GHICHU { get; set; }

    [JsonIgnore]
    [Browsable(false)]
    [InverseProperty("MASPNavigation")]
    public virtual ICollection<CHITIETHDBAN> CHITIETHDBANs { get; set; } = new List<CHITIETHDBAN>();

    [JsonIgnore]
    [Browsable(false)]
    [InverseProperty("MASPNavigation")]
    public virtual ICollection<CHITIETHDNHAP> CHITIETHDNHAPs { get; set; } = new List<CHITIETHDNHAP>();

    [JsonIgnore]
    [Browsable(false)]
    [ForeignKey("MALOAI")]
    [InverseProperty("SANPHAMs")]
    public virtual LOAISANPHAM MALOAINavigation { get; set; } = null!;

    [JsonIgnore]
    [Browsable(false)]
    [ForeignKey("MANCC")]
    [InverseProperty("SANPHAMs")]
    public virtual NHACUNGCAP MANCCNavigation { get; set; } = null!;
}
