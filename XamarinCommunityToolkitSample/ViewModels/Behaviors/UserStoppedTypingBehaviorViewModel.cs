﻿using System;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Sample.Resx;
using Xamarin.Forms;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Behaviors
{
	public class UserStoppedTypingBehaviorViewModel : BaseViewModel
	{
		#region Properties

		string performedSearches;

		public string PerformedSearches
		{
			get => performedSearches;
			set => Set(ref performedSearches, value);
		}

		public ICommand SearchCommand { get; }

		#endregion Properties

		public UserStoppedTypingBehaviorViewModel()
			=> SearchCommand = new Command<string>(PerformSearch);

		void PerformSearch(string searchTerms)
			=> PerformedSearches += string.Format(AppResources.UserStoppedTypingBehaviorSearchResultLabelFormat, searchTerms) + Environment.NewLine;
	}
}