using System;
using System.Collections.Generic;
using BMSaver.Models;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace BMSaver.Views
{
    public partial class ItemsPopup : PopupPage
    {

        public ItemsPopup()
        {
            InitializeComponent();
        }

        public async void OnItemSaved(object sender, System.EventArgs e)
        {
            if (ClothesListPage.CurrentDataType == typeof(DocumentItem))
            {
                if (!string.IsNullOrEmpty(PopupEntry.Text))
                {
                    DocumentItem documentItem = new DocumentItem()
                    {
                        Todo = PopupEntry.Text
                    };
                    await App.Database.SaveItemAsync(documentItem);
                }
            }
            if (ClothesListPage.CurrentDataType == typeof(EquipmentItem))
            {
                if (!string.IsNullOrEmpty(PopupEntry.Text))
                {
                    EquipmentItem equipmentItem = new EquipmentItem()
                    {
                        Todo = PopupEntry.Text
                    };
                    await App.Database.SaveItemAsync(equipmentItem);
                }
            }
            if (ClothesListPage.CurrentDataType == typeof(PharmacyItem))
            {
                if (!string.IsNullOrEmpty(PopupEntry.Text))
                {
                    PharmacyItem pharmacyItem = new PharmacyItem()
                    {
                        Todo = PopupEntry.Text
                    };
                    await App.Database.SaveItemAsync(pharmacyItem);
                }
            }
            await this.Navigation.PopModalAsync();
        }

        public async void OnItemCreationDismiss(object sender, System.EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}
