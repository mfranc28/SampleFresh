using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HorseShow.Model;
using Xamarin.Forms;

namespace HorseShow.View
{
	public partial class ClassesPage : ContentPage
	{
	

		public ClassesPage()
		{
			InitializeComponent();
			
			this.Padding = new Thickness(1, Device.OnPlatform(20, 20, 0), 2, 5);

		    
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
		
		}

		public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
           
            Navigation.PushModalAsync(new Schedule((HSEventModel) listViewDiscipline.SelectedItem));
        }
	}
}

