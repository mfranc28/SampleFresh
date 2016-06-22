using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace HorseShow.Model
{
	public class HSEventModel
	{
		
		[JsonProperty(PropertyName ="bubbleCnt")] 
		public string bubbleCnt {get;set;}
		[JsonProperty(PropertyName ="classGosCount")] 
		public string classGosCount {get;set;}
		[JsonProperty(PropertyName = "classId")]
		public string classId {get;set;}
		[JsonProperty(PropertyName = "createdAt")]
		public string createdAt {get;set;}
		[JsonProperty(PropertyName = "defaultScheduleGroup")]
		public string defaultScheduleGroup {get;set;}
		[JsonProperty(PropertyName = "discipline")]
		public string discipline {get;set;}
		[JsonProperty(PropertyName = "drawHeldWith")]
		public string drawHeldWith {get;set;}
		[JsonProperty(PropertyName = "eventId")]
		public string eventId {get;set;}
		[JsonProperty(PropertyName = "goCd")]
		public string goCd {get;set;}
		[JsonProperty(PropertyName = "goDrawsMsg")]
		public string goDrawsMsg {get;set;}
		[JsonProperty(PropertyName = "goDrawsReadyAt")]
		public string goDrawsReadyAt {get;set;}
		[JsonProperty(PropertyName = "goSummaryMsg")]
		public string goSummaryMsg {get;set;}
		[JsonProperty(PropertyName = "goSummaryMsgAt")]
		public string goSummaryMsgAt {get;set;}
		[JsonProperty(PropertyName = "location")]
		public string location {get;set;}
		[JsonProperty(PropertyName = "name")]
		public string name {get;set;}
		[JsonProperty(PropertyName = "numRanked")]
		public string numRanked {get;set;}
		[JsonProperty(PropertyName = "objectId")]
		public string objectId {get;set;}
		[JsonProperty(PropertyName = "reportScores")]
		public string reportScores {get;set;}
		[JsonProperty(PropertyName = "resultType")]
		public string resultType {get;set;}
		[JsonProperty(PropertyName = "srcShowDb_showId")]
		public string srcShowDb_showId {get;set;}
		[JsonProperty(PropertyName = "startDateTime")]
		public string startDateTime {get;set;}
		[JsonProperty(PropertyName = "type")]
		public string type {get;set;}
		[JsonProperty(PropertyName = "updatedAt")]
		public string updatedAt {get;set;}


	
	}

	public class GroupedHSEventModel : ObservableCollection<HSEventModel>
	{
		public string HeaderName { get; set; }

	}

	public class GroupedDisciplineHSEventModel : ObservableCollection<string>
	{
		public string HeaderName { get; set; }

	}

	public class ClassByDate
	{
		public string Title { get; set; }
	}

	public class GroupedScheduleScreen : ObservableCollection<HSEventModel>
	{
		public string DateEvent { get; set;}
	}
}

