using System;
using System.ComponentModel.DataAnnotations;

namespace beautyclinic_uni.Models
{
    public class ContactRequest
    {
        public int Id { get; set; }

        [Required, Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }

        [Required, Display(Name = "شماره تماس")]
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "نوع خدمت موردنیاز")]
        public string Service { get; set; }

        [Display(Name = "بازه زمانی ترجیحی")]
        public string Time { get; set; }

        [Display(Name = "توضیحات تکمیلی")]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
