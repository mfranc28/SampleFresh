using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HorseShow.Model;
using Xamarin.Forms;

namespace HorseShow.View
{
	public partial class ClassesGroup : ContentPage
	{
		private ObservableCollection<GroupedHSEventModel> grouped1 { get; set; }

		private ObservableCollection<GroupedDisciplineHSEventModel> grouped { get; set; }

		List<HSEventModel> listDiscipline = new List<HSEventModel>();

		List<string> lista = new List<string>();

		public ClassesGroup()
		{
			InitializeComponent();
			this.Padding = new Thickness(1, Device.OnPlatform(20, 20, 0), 2, 5);

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			//NavigationPage.SetHasNavigationBar(this, true);

			LoadListview();

		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
			}
			HSEventModel args = new HSEventModel();
			args.discipline = e.SelectedItem.ToString();
			await Navigation.PushAsync(new Schedule(args));
			//DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
			//((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
			//comment out if you want to keep selections
			ListView lst = (ListView)sender;
			lst.SelectedItem = null;

		}
		void OnRefresh(object sender, EventArgs e)
		{
			LoadListview();
			listViewDiscipline.IsRefreshing = false;
		}

		//async void LoadListview1()
		//{
		//	grouped = new ObservableCollection<GroupedHSEventModel>();
		//	var DateGroup = new GroupedHSEventModel() { HeaderName = "Date" };

		//	var DisciplineGroup = new GroupedHSEventModel() { HeaderName = "Discipline" };

		//	DateGroup.Add(new HSEventModel() { discipline = "All Classes By Date" });
		//	listDiscipline = await App.HSEventManager.GetDiscipline();
		//	if (listDiscipline != null)

		//	{
		//		foreach (var e in listDiscipline)
		//		{
		//			DisciplineGroup.Add(e);
		//		}
		//	}
		//	grouped.Add(DateGroup);
		//	grouped.Add(DisciplineGroup);

		//	listViewDiscipline.ItemsSource = grouped;
		//}

		async void LoadListview()
		{
			grouped = new ObservableCollection<GroupedDisciplineHSEventModel>();
			var DateGroup = new GroupedDisciplineHSEventModel() { HeaderName = "Date" };

			var DisciplineGroup = new GroupedDisciplineHSEventModel() { HeaderName = "Discipline" };

			DateGroup.Add("All Classes By Date");
			//listDiscipline = await App.HSEventManager.GetDiscipline();
			//if (listDiscipline != null)
			lista = await App.HSEventManager.GetDisciplineString();
			{
				foreach (var e in lista)
				{
					DisciplineGroup.Add(e);
				}
			}
			grouped.Add(DateGroup);
			grouped.Add(DisciplineGroup);

			listViewDiscipline.ItemsSource = grouped;
		}
	}
}

