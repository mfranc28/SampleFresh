using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HorseShow.Model;

namespace HorseShow
{
	public interface IParseStorage
	{
		//Task<List<HSEventModel>> RefreshDataAsync();

		Task<List<HSEventModel>> GetDiscipline();

		Task<List<HSEventModel>> GetSchedule(string _discipline);

		Task<List<string>> GetDisciplineString();
	}
}

