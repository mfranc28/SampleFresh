using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HorseShow.Model;

namespace HorseShow
{
	public class HSEventsManager
	{
		IParseStorage storage;

		public HSEventsManager(IParseStorage storage)
		{
			this.storage = storage;
		}

		public Task<List<HSEventModel>> GetDiscipline()
		{
			return storage.GetDiscipline();
		}

		public Task<List<HSEventModel>> GetSchedule(string _discipline)
		{
			return storage.GetSchedule(_discipline);
		}

		public Task<List<string>> GetDisciplineString()
		{
			return storage.GetDisciplineString();
		}

		//public Task<List<HSEventModel>> GetTasksAsync()
		//{
		//	return storage.RefreshDataAsync();
		//}


	}
}

