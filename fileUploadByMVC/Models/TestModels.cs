using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fileUploadByMVC.Models
{
    public class TestModels
    {
        [Display(Name ="标题")]
        [Required]
        public string title
        {
            get;
            set;
        }

        [Display(Name ="内容")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Content
        {
            get;
            set;
        }

        public string AttachmentPath
        {
            get;
            set;
        }
    }
}