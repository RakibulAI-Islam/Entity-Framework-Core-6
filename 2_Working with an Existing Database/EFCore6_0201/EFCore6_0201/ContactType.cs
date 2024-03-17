﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore6_0201
{
    /// <summary>
    /// Lookup table containing the types of business entity contacts.
    /// </summary>
    [Table("ContactType", Schema = "Person")]
    [Index("Name", Name = "AK_ContactType_Name", IsUnique = true)]
    public partial class ContactType
    {
        public ContactType()
        {
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        }

        /// <summary>
        /// Primary key for ContactType records.
        /// </summary>
        [Key]
        [Column("ContactTypeID")]
        public int ContactTypeId { get; set; }
        /// <summary>
        /// Contact type description.
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("ContactType")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
