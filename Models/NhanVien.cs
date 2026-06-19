using System.ComponentModel.DataAnnotations;

public class NhanVien
{
    [Key]
    [Required]
    public string MaNhanVien { get; set; }

    [Required]
    [Range(0, 3)]
    public string TenNhanVien { get; set; }

    public string MaPhongBan { get; set; }
    public PhongBan PhongBan { get; set; }
}