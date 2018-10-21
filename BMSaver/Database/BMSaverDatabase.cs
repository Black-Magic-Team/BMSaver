using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMSaver.Models;
using SQLite;

namespace BMSaver.Database
{
    public class BMSaverDatabase
    {

        readonly SQLiteAsyncConnection database;

        public BMSaverDatabase(string path)
        {
            database = new SQLiteAsyncConnection(path);
            database.CreateTableAsync<EquipmentItem>().Wait();
            database.CreateTableAsync<DocumentItem>().Wait();
            database.CreateTableAsync<PharmacyItem>().Wait();
            database.CreateTableAsync<FireItem>().Wait();
            database.CreateTableAsync<FloodItem>().Wait();
            database.CreateTableAsync<StormItem>().Wait();
            database.CreateTableAsync<EarthquakeItem>().Wait();
            database.CreateTableAsync<TornadoItem>().Wait();
            database.CreateTableAsync<EruptionItem>().Wait();
            database.CreateTableAsync<TsunamiItem>().Wait();
            database.CreateTableAsync<AnotherItem>().Wait();



        }

        public Task<List<AnotherItem>> GetAnotherItems()
        {
            return database.Table<AnotherItem>().ToListAsync();
        }

        public Task<List<DocumentItem>> GetDocumentItems()
        {
            return database.Table<DocumentItem>().ToListAsync();
        }

        public Task<List<EarthquakeItem>> GetEarthquakeItems()
        {
            return database.Table<EarthquakeItem>().ToListAsync();
        }

        public Task<List<EquipmentItem>> GetEquipmentItems()
        {
            return database.Table<EquipmentItem>().ToListAsync();
        }

        public Task<List<EruptionItem>> GetEruptionItems()
        {
            return database.Table<EruptionItem>().ToListAsync();
        }

        public Task<List<FireItem>> GetFireItems()
        {
            return database.Table<FireItem>().ToListAsync();
        }

        public Task<List<FloodItem>> GetFloodItems()
        {
            return database.Table<FloodItem>().ToListAsync();
        }

        public Task<List<PharmacyItem>> GetPharmacyItems()
        {
            return database.Table<PharmacyItem>().ToListAsync();
        }

        public Task<List<StormItem>> GetStormItems()
        {
            return database.Table<StormItem>().ToListAsync();
        }

        public Task<List<TornadoItem>> GetTornadoItems()
        {
            return database.Table<TornadoItem>().ToListAsync();
        }

        public Task<List<TsunamiItem>> GetTsunamiItems()
        {
            return database.Table<TsunamiItem>().ToListAsync();
        }

        public Task<int> SaveItemAsync(AnotherItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(AnotherItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(DocumentItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(DocumentItem item)
        {
            return database.DeleteAsync(item);
        }


        public Task<int> SaveItemAsync(EarthquakeItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(EarthquakeItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(EquipmentItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(EquipmentItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(EruptionItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(EruptionItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(FireItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(FireItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(FloodItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(FloodItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(PharmacyItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(PharmacyItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(StormItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(StormItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(TornadoItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(TornadoItem item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> SaveItemAsync(TsunamiItem item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(TsunamiItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
