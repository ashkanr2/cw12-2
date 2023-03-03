using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Models
{
    public class Product
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        //[MaxLength(6,ErrorMessage = "طول نام نباید بیشتر از شش کاراکتر باشد.")]
        //[MinLength(6,ErrorMessage = "طول نام نباید بیشتر از شش کاراکتر باشد.")]
        [StringLength(6, ErrorMessage = "طول نام نباید بیشتر از شش کاراکتر باشد.")]
        [Required(ErrorMessage = "این فیلد اجباریست!")]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "رنگ")]
        public string Color { get; set; }

        [Display(Name = "مدل")]
        [Required(ErrorMessage = "این فیلد اجباریست!")]
        public string Model { get; set; }

        [Display(Name = "کد")]
        [Range(1000, 9999, ErrorMessage = "کد باید بین 1000 تا 9999 باشد.")]
        [Required(ErrorMessage = "این فیلد اجباریست!")]
        //[Remote(controller:"Product",action:"CheckCode",ErrorMessage = "کد باید بین 1000 تا 9999 باشد.")]
        public int Code { get; set; }

        [Display(Name = "برند")]
        public Brand Brand { get; set; }

        public List<string> Feature { get; set; } = new();
        public bool IsAvailable { get; set; }

    }
   

    public enum Brand
    {
        Apple =1,
        Sumsung =2,
        Xiaomi = 3
    }
    public enum Feature
    {
        amoled=1,
        speaker=2,
        battery=3,
        adaptor=4
    }
    
}

