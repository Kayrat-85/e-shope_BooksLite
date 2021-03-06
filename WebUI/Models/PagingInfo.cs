using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }     //Общее количество книг
        public int ItemsPerPage { get; set; }   //Количество книг на странице 
        public int CurrentPage { get; set; }    //Номер текущей страницы 
        public int TotalPages                   //Общее количество страниц
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}