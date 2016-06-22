using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HorseShow.Model;
using Parse;

namespace HorseShow.Droid
{
	public class ParseStorage : IParseStorage
	{
		static ParseStorage HsEventServiceInstance = new ParseStorage();

		public static ParseStorage Default { get { return HsEventServiceInstance; } }

		public List<HSEventModel> Events { get; private set; }

		// Constructor
		protected ParseStorage()
		{
			Events = new List<HSEventModel>();
			// https://parse.com/apps/YOUR_APP_NAME/edit#app_keys
			// ApplicationId, Windows/.NET/Client key
			//ParseClient.Initialize ("APPLICATION_ID", ".NET_KEY");
			ParseClient.Initialize(Constants.ApplicationId, Constants.Key);
		}

		static HSEventModel DisciplineFromParseObject(ParseObject po)
		{
			var t = new HSEventModel();

			t.discipline = Convert.ToString(po["discipline"]);
		
			return t;
		}

		static HSEventModel ScheduleFromParseObject(ParseObject po)
		{
			var t = new HSEventModel();
			t.objectId = po.ObjectId;
			t.bubbleCnt = Convert.ToString(po["bubbleCnt"]);
			t.classGosCount = Convert.ToString(po["classGosCount"]);
			t.classId = Convert.ToString(po["classId"]);
			////t.createdAt = Convert.ToString(po["createdAt"]);
			t.defaultScheduleGroup = Convert.ToString(po["defaultScheduleGroup"]);
			t.discipline = Convert.ToString(po["discipline"]);
			t.drawHeldWith = Convert.ToString(po["drawHeldWith"]);
			t.eventId = Convert.ToString(po["eventId"]);
			t.goCd = Convert.ToString(po["goCd"]);
			t.type = Convert.ToString(po["type"]);
			t.location = Convert.ToString(po["location"]);
			t.name = Convert.ToString(po["name"]);
			t.numRanked = Convert.ToString(po["numRanked"]);
			t.reportScores = Convert.ToString(po["reportScores"]);
			t.resultType = Convert.ToString(po["resultType"]);
			t.srcShowDb_showId = Convert.ToString(po["srcShowDb_showId"]);
			t.startDateTime = Convert.ToString(po["startDateTime"]);
			////t.updatedAt = Convert.ToString(po["updatedAt"]);

			return t;
		}

		async public Task<List<HSEventModel>> GetSchedule(string _discipline)

		{
			bool exists = false;
			var query = ParseObject.GetQuery("HSEvent").WhereEqualTo("discipline", _discipline).OrderBy("stardatetime");
			query = query.Limit(1000);
			var ie = await query.FindAsync();

			var returnModel = new HSEventModel();

			var tl = new List<HSEventModel>();


			foreach (var t in ie)
			{
				returnModel = DisciplineFromParseObject(t);
				if (tl.Count == 0)
					tl.Add(returnModel);
				for (int i = 0; i < tl.Count; i++)
				{
					if (tl[i].discipline.Contains(returnModel.discipline))
						exists = true;
				}

				if (!exists)
					tl.Add(returnModel);

				exists = false;
			}

			return tl;
		}

		async public Task<List<HSEventModel>> GetDiscipline()

		{
			bool exists = false;
			var query = ParseObject.GetQuery("HSEvent").Select("discipline");
			query = query.Limit(1000);
			var ie = await query.FindAsync();

			var returnModel = new HSEventModel();

			var tl = new List<HSEventModel>();


			foreach (var t in ie)
			{
				returnModel = DisciplineFromParseObject(t);
				if (tl.Count == 0)
					tl.Add(returnModel);
				for (int i = 0; i < tl.Count; i++)
				{
					if (tl[i].discipline.Contains(returnModel.discipline))
						exists = true;
				}

				if (!exists)
					tl.Add(returnModel);

				exists = false;
			}

			return tl;
		}

		async public Task<List<HSEventModel>> GetSchedule(string _discipline)

		{
			//bool exists = false;
			var query = ParseObject.GetQuery("HSEvent").WhereEqualTo("discipline", _discipline).OrderBy("stardatetime");
			query = query.Limit(1000);
			var ie = await query.FindAsync();

			var returnModel = new HSEventModel();

			var tl = new List<HSEventModel>();


			foreach (var t in ie)
			{
				returnModel = ScheduleFromParseObject(t);
				//if (tl.Count == 0)
				//	tl.Add(returnModel);
				//for (int i = 0; i < tl.Count; i++)
				//{
				//	if (tl[i].discipline.Contains(returnModel.discipline))
				//		exists = true;
				//}

				//if (!exists)
				tl.Add(returnModel);

				//exists = false;
			}

			return tl;
		}


		}
}

