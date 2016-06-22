using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HorseShow.Model;
using Xamarin.Forms;

namespace HorseShow.View
{
	public partial class Schedule : ContentPage
	{
		private ObservableCollection<GroupedHSEventModel> grouped { get; set; }
		List<HSEventModel> listSchedule = new List<HSEventModel>();
		string _discipline = string.Empty;

		public Schedule(HSEventModel _eventmodel)
		{
			InitializeComponent();
			this.Padding = new Thickness(1, Device.OnPlatform(20, 20, 0), 2, 5);
			_discipline = _eventmodel.discipline;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			//NavigationPage.SetHasNavigationBar(this, true);

			LoadListview();

		}

		async void LoadListview()
		{
			grouped = new ObservableCollection<GroupedHSEventModel>();
			//var DateGroup = new GroupedHSEventModel() { HeaderName = "stardatetime" };

			var ScheduleGroup = new GroupedHSEventModel() { HeaderName = "aaaaa" };

			//DateGroup.Add(new HSEventModel() { DateEvent = "All Classes By Date" });
			listSchedule = await App.HSEventManager.GetSchedule(_discipline);
			if (listSchedule != null)
			{
				foreach (var e in listSchedule)
				{
					ScheduleGroup.Add(e);
				}
			}
			//grouped.Add(DateGroup);
			grouped.Add(ScheduleGroup);

			schedulelist.ItemsSource = grouped;
		}
	}
}

