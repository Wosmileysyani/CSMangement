using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CsManager.Models
{
    public partial class V_Login
    {
        [Display(Name = "ยูสเซอร์เนม")]
        [Required(ErrorMessage = "กรุณาใส่ข้อมูล")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "รหัสควรมี 11 หลัก")]
        public string Log_ID { get; set; }

        [Required(ErrorMessage = "กรุณาใส่ข้อมูล")]
        public string Log_Pass { get; set; }
        public Nullable<int> Log_Role { get; set; }
    }
    [MetadataType(typeof(V_Login))]
    public partial class Login : Login_In { }
}