﻿using CAF.Infrastructure.Core;
using System.Runtime.Serialization;

namespace CAF.Infrastructure.Core.Domain.Cms.Articles
{
	/// <summary>
	/// Represents a store mapping record
	/// </summary>
	[DataContract]
    public partial class ArticleCategoryMapping : BaseEntity
	{
		/// <summary>
		/// Gets or sets the entity identifier
		/// </summary>
		[DataMember]
		public virtual int EntityId { get; set; }

		/// <summary>
		/// Gets or sets the entity name
		/// </summary>
		[DataMember]
		public virtual string EntityName { get; set; }

		/// <summary>
		/// Gets or sets the store identifier
		/// </summary>
		[DataMember]
        public virtual int ArticleCategoryId { get; set; }
	}
}
