//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json.Serialization;

namespace NorthwindEFBase.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
            this.Territories = new HashSet<EmployeeTerritories>();
        }
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        [JsonIgnore]
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<EmployeeTerritories> Territories { get; set; }

        [NotMapped]
        public string Base64String
        {
            get
            {
                var base64Str = string.Empty;
                using (var ms = new MemoryStream())
                {
                    int offset = 78;
                    ms.Write(Photo, offset, Photo.Length - offset);
                    var bmp = new Bitmap(ms);
                    using (var jpegms = new MemoryStream())
                    {
                        bmp.Save(jpegms, ImageFormat.Jpeg);
                        base64Str = Convert.ToBase64String(jpegms.ToArray());
                    }
                }
                return base64Str;
            }
        }
    }
}