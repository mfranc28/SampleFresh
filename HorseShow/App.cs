using System;
using HorseShow.PageModel;
using HorseShow.View;

using Xamarin.Forms;

namespace HorseShow
{
	public class App : Application
	{
		public static double ScreenHeight;
		public static double ScreenWidth;

        public App()
        {

            MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ClassesPageModel>();
        }

        



        #region Parse stuff
        static HSEventsManager hseventManager;

		public static HSEventsManager HSEventManager
		{
			get { return hseventManager; }
			set { hseventManager = value; }
		}

		public static void SetHSEventManager(HSEventsManager hseventManager)
		{
			HSEventManager = hseventManager;
		}
        #endregion

       
    }
}

