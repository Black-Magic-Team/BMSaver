using System;
using System.Collections.Generic;
using BMSaver.Models;
using BMSaver.ViewModels;
using Xamarin.Forms;

namespace BMSaver.Views
{
    public partial class ClothesListPage : ContentPage
    {
        public static Type CurrentDataType;

        public ClothesListPage()
        {

            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            if (this.BindingContext == null)
            {
                this.BindingContext = new ClothesListPageViewModel();
            }
            ItemsList.ItemsSource = await App.Database.GetEquipmentItems();
            CurrentDataType = typeof(EquipmentItem);
            base.OnAppearing();
        }

        public async void OnEquipmentsTapped(object sender, EventArgs eventArgs)
        {
            ItemsList.ItemsSource = await App.Database.GetEquipmentItems();
            CurrentDataType = typeof(EquipmentItem);
        }

        public async void OnDocumentsTapped(object sender, EventArgs eventArgs)
        {
            ItemsList.ItemsSource = await App.Database.GetDocumentItems();
            CurrentDataType = typeof(DocumentItem);
        }

        public async void OnPharmaciesTapped(object sender, EventArgs eventArgs)
        {
            ItemsList.ItemsSource = await App.Database.GetPharmacyItems();
            CurrentDataType = typeof(PharmacyItem);
        }


        public async void AddItemToList(object sender, EventArgs eventArgs)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ItemsPopup());
        }

        public async void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ItemsSettings itemsSettings = new ItemsSettings()
                {
                    BindingContext = e.SelectedItem
                };

                await Application.Current.MainPage.Navigation.PushModalAsync(itemsSettings,false);
            }
        }



    }
}
