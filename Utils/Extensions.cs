using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Common;

namespace Common
{
    public static class Extensions
    {
        public static void Sort<T>(this ObservableCollection<T> collection, Comparison<T> comparison)
        {
            var sortableList = new List<T>(collection);
            sortableList.Sort(comparison);

            for (int i = 0; i < sortableList.Count; i++)
            {
                collection.Move(collection.IndexOf(sortableList[i]), i);
            }
        }

        public static int GetNewId<T>(this ObservableCollection<T> collection) where T : INotifyModel
        {
            var ids = collection.Select(r => r.Id).ToList();
            var highestId = ids.Max();
            return ++highestId;
        }
    }
}
