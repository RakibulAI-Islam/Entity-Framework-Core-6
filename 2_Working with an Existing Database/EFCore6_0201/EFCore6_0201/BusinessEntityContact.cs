﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore6_0201
{
    /// <summary>
    /// Cross-reference table mapping stores, vendors, and employees to people
    /// </summary>
    [Table("BusinessEntityContact", Schema = "Person")]
    [Index("Rowguid", Name = "AK_BusinessEntityContact_rowguid", IsUnique = true)]
    [Index("ContactTypeId", Name = "IX_BusinessEntityContact_ContactTypeID")]
    [Index("PersonId", Name = "IX_BusinessEntityContact_PersonID")]
    public partial class BusinessEntityContact
    {
        /// <summary>
        /// Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        [Key]
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        /// <summary>
        /// Primary key. Foreign key to Person.BusinessEntityID.
        /// </summary>
        [Key]
        [Column("PersonID")]
        public int PersonId { get; set; }
        /// <summary>
        /// Primary key.  Foreign key to ContactType.ContactTypeID.
        /// </summary>
        [Key]
        [Column("ContactTypeID")]
        public int ContactTypeId { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("BusinessEntityId")]
        [InverseProperty("BusinessEntityContacts")]
        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
        [ForeignKey("ContactTypeId")]
        [InverseProperty("BusinessEntityContacts")]
        public virtual ContactType ContactType { get; set; } = null!;
        [ForeignKey("PersonId")]
        [InverseProperty("BusinessEntityContacts")]
        public virtual Person Person { get; set; } = null!;
    }
}
