using System;

namespace tw.ccnet.remote
{
	/// <summary>
	/// Value type that contains extensive details about a project's most recent
	/// integration.
	/// </summary>
	/// <remarks>
	/// This class is serialized to persist CruiseControl.NET's state for a
	/// particular project, hence is is marked <see cref="Serializable"/>.
	/// </remarks>
	[Serializable]
	public struct ProjectStatus
	{
		private CruiseControlStatus status;
		private IntegrationStatus buildStatus;
		private ProjectActivity activity;
		private string name;
		private string webURL;
		private DateTime lastBuildDate;
		private string lastBuildLabel;

		public ProjectStatus(
			CruiseControlStatus status, 
			IntegrationStatus buildStatus, 
			ProjectActivity activity, 
			string name, 
			string webURL,
			DateTime lastBuildDate,
			string lastBuildLabel
			) 
		{
			this.status = status;
			this.buildStatus = buildStatus;
			this.activity = activity;
			this.name = name;
			this.webURL = webURL;
			this.lastBuildDate = lastBuildDate;
			this.lastBuildLabel = lastBuildLabel;
		}

		/// <summary>
		/// The state of the CruiseControl.NET server.
		/// </summary>
		public CruiseControlStatus Status 
		{
			get { return status; }
		}

		public IntegrationStatus BuildStatus 
		{
			get { return buildStatus; }
		}

		public ProjectActivity Activity 
		{
			get { return activity; }
		}

		public string Name 
		{
			get { return name; }
		}

		public string WebURL
		{
			get { return webURL; }
		}

		public DateTime LastBuildDate
		{
			get { return lastBuildDate; }
		}

		public string LastBuildLabel
		{
			get { return lastBuildLabel; }
		}
	}
}
