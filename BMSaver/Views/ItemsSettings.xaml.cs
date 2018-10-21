using System;
using System.Collections.Generic;
using BMSaver.Models;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace BMSaver.Views
{
    public partial class ItemsSettings : PopupPage
    {


        public ItemsSettings()
        {
            InitializeComponent();
        }

        async void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            if (BindingContext != null)
            {
                if (ClothesListPage.CurrentDataType == typeof(DocumentItem))
                {
                    DocumentItem documentItem = (BMSaver.Models.DocumentItem)BindingContext;
                    await App.Database.DeleteItemAsync(documentItem);
                }
                if (ClothesListPage.CurrentDataType == typeof(EquipmentItem))
                {
                    EquipmentItem equipmentItem = (BMSaver.Models.EquipmentItem)BindingContext;
                    await App.Database.DeleteItemAsync(equipmentItem);
                }
                if (ClothesListPage.CurrentDataType == typeof(PharmacyItem))
                {
                    PharmacyItem pharmacyItem = (BMSaver.Models.PharmacyItem)BindingContext;
                    await App.Database.DeleteItemAsync(pharmacyItem);
                }
                await Application.Current.MainPage.Navigation.PopToRootAsync(false);
                //await Application.Current.MainPage.Navigation.(false);
            }
        }

        async void OnDeleteClicked(object sender, System.EventArgs e)
        {
            if (BindingContext != null)
            {

                if (BindingContext.GetType() == typeof(DocumentItem))
                {
                    DocumentItem documentItem = (BMSaver.Models.DocumentItem)BindingContext;
                    await App.Database.DeleteItemAsync(documentItem);
                }
                if (BindingContext.GetType() == typeof(EquipmentItem))
                {
                    EquipmentItem equipmentItem = (BMSaver.Models.EquipmentItem)BindingContext;
                    await App.Database.DeleteItemAsync(equipmentItem);
                }
                if (BindingContext.GetType() == typeof(PharmacyItem))
                {
                    PharmacyItem pharmacyItem = (BMSaver.Models.PharmacyItem)BindingContext;
                    await App.Database.DeleteItemAsync(pharmacyItem);
                }
                await Application.Current.MainPage.Navigation.PopAsync(false);
            }
        }

        async void OnSaveClicked(object sender, System.EventArgs e)
        {
            if (BindingContext != null)
            {

                if (BindingContext.GetType() == typeof(DocumentItem))
                {
                    DocumentItem documentItem = (BMSaver.Models.DocumentItem)BindingContext;
                    await App.Database.SaveItemAsync(documentItem);
                }
                if (BindingContext.GetType() == typeof(EquipmentItem))
                {
                    EquipmentItem equipmentItem = (BMSaver.Models.EquipmentItem)BindingContext;
                    await App.Database.SaveItemAsync(equipmentItem);
                }
                if (BindingContext.GetType() == typeof(PharmacyItem))
                {
                    PharmacyItem pharmacyItem = (BMSaver.Models.PharmacyItem)BindingContext;
                    await App.Database.SaveItemAsync(pharmacyItem);
                }
                await Application.Current.MainPage.Navigation.PopAsync(false);
            }
        }
    }
}
