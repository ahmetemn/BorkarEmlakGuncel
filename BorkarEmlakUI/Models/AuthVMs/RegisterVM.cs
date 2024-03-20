using System.ComponentModel.DataAnnotations;

namespace BorkarEmlakUI.Models.AuthVMs
{
    public class RegisterVM
    {

        [Display(Name = "Mail Adresi"), Required(ErrorMessage = "Email  Boş Geçilemez.")]

      

        public string Email { get; set; }

        [Display(Name = "Telefon Numarası") , Required(ErrorMessage = "Telefon Numarası  Boş Geçilemez.")]

        public string PhoneNumber { get; set; }

        [Display(Name = "Kullanıcı Adı"), Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez.")]

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Kullanıcı adı en az 3, en fazla 30 karakter uzunluğunda olmalıdır.")]

        public string UserName { get; set; }


        [DataType(DataType.Password)]

        [Display(Name = "Kullanıcı Şifresi"), Required(ErrorMessage = "Şifre boş geçilemez.")]

        [StringLength(20, MinimumLength = 8, ErrorMessage = "Şifre en az 8, en fazla 20 karakter uzunluğunda olmalıdır.")]

        public string Password { get; set; }

        [Display(Name = "Kullanıcı Şifresi Tekrar")]

        public string PasswordConfirm { get; set; }


    }
}
