﻿// Dapplo - building blocks for .NET applications
// Copyright (C) 2017-2019 Dapplo
// 
// For more information see: http://dapplo.net/
// Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
// This file is part of Dapplo.Jira
// 
// Dapplo.Jira is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Dapplo.Jira is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have a copy of the GNU Lesser General Public License
// along with Dapplo.Jira. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dapplo.Jira.Entities
{
	/// <summary>
	///     Container for the fields
	/// </summary>
	[JsonObject]
	public class IssueFields
	{
		/// <summary>
		///     The summary of the time spend on this issue
		/// </summary>
		[JsonProperty("aggregatetimespent")]
		public long? AggregateTimeSpent { get; set; }

		/// <summary>
		///     User who this issue is assigned to
		/// </summary>
		[JsonProperty("assignee")]
		public User Assignee { get; set; }

		/// <summary>
		///     Attachments for this issue
		/// </summary>
		[JsonProperty("attachment")]
		public IList<Attachment> Attachments { get; set; }

		/// <summary>
		///     Container for the comments for this issue
		/// </summary>
		[JsonProperty("comment")]
		public Comments Comments { get; set; }

		/// <summary>
		///     Components for this issue
		/// </summary>
		[JsonProperty("components")]
		public IList<Component> Components { get; set; }

		/// <summary>
		///     When was this issue created
		/// </summary>
		[JsonProperty("created")]
		public DateTimeOffset? Created { get; set; }

		/// <summary>
		///     User who created this issue
		/// </summary>
		[JsonProperty("creator")]
		public User Creator { get; set; }

		/// <summary>
		///     All custom field values, or rather those that don't have a matching
		/// </summary>
		[JsonExtensionData]
		public IDictionary<string, object> CustomFields { get; } = new Dictionary<string, object>();

		/// <summary>
		///     Description of this issue
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     Versions where this issue is fixed
		/// </summary>
		[JsonProperty("fixVersions")]
		public IList<Version> FixVersions { get; set; }

		/// <summary>
		///     Type of the issue
		/// </summary>
		[JsonProperty("issuetype")]
		public IssueType IssueType { get; set; }

		/// <summary>
		///     Labels for this issue
		/// </summary>
		[JsonProperty("labels")]
		public IList<string> Labels { get; set; }

		/// <summary>
		///     When was this issue viewed (by whom??)
		/// </summary>
		[JsonProperty("lastViewed")]
		public DateTimeOffset? LastViewed { get; set; }

		/// <summary>
		///     Priority for this issue
		/// </summary>
		[JsonProperty("priority")]
		public Priority Priority { get; set; }

		/// <summary>
		///     Progress for this issue
		/// </summary>
		[JsonProperty("progress")]
		public ProgressInfo Progress { get; set; }

		/// <summary>
		///     Project to which this issue belongs
		/// </summary>
		[JsonProperty("project")]
		public Project Project { get; set; }

		/// <summary>
		///     What user reported the issue?
		/// </summary>
		[JsonProperty("reporter")]
		public User Reporter { get; set; }

		/// <summary>
		///     The resolution for this issue
		/// </summary>
		[JsonProperty("resolution")]
		public Resolution Resolution { get; set; }

		/// <summary>
		///     Resolution date for this issue
		/// </summary>
		[JsonProperty("resolutiondate")]
		public DateTimeOffset? ResolutionData { get; set; }

		/// <summary>
		///     Current status of the issue
		/// </summary>
		[JsonProperty("status")]
		public Status Status { get; set; }

		/// <summary>
		///     Summary for the issue
		/// </summary>
		[JsonProperty("summary")]
		public string Summary { get; set; }

		/// <summary>
		///     How much time is spent on this issue
		/// </summary>
		[JsonProperty("timespent")]
		public long? TimeSpent { get; set; }

		/// <summary>
		///     Time tracking information
		/// </summary>
		[JsonProperty("timetracking")]
		public TimeTracking TimeTracking { get; set; }

		/// <summary>
		///     When was the last update
		/// </summary>
		[JsonProperty("updated")]
		public DateTimeOffset? Updated { get; set; }

		/// <summary>
		///     Version for which this ticket is
		/// </summary>
		[JsonProperty("versions")]
		public IList<Version> Versions { get; set; }

		/// <summary>
		///     Information on the watches for the ticket
		/// </summary>
		[JsonProperty("watches")]
		public Watches Watches { get; set; }

		/// <summary>
		///     The worklog entries
		/// </summary>
		[JsonProperty("worklog")]
		public Worklogs Worklogs { get; set; }

        /// <summary>
        ///     Due date
        /// </summary>
        [JsonProperty("duedate")]
        public DateTimeOffset DueDate { get; set; }
	}
}