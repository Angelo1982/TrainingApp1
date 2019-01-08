using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Common;

namespace TrainingData.Plan
{
    public class OccurenceRepository
    {
        private static OccurenceRepository _Instance;
        public static OccurenceRepository Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new OccurenceRepository();
                return _Instance;
            }
        }

        private OccurenceRepository()
        {

            Occurences = new ObservableCollection<Occurence>{
                new Occurence
                {
                    Id = 1
                },
                new Occurence
                {
                    Id = 2
                },
                new Occurence
                {
                    Id = 3
                }
            };
            SortOccurences();
        }

        public void Add(Occurence occurence)
        {
            occurence.Id = Occurences.GetNewId();
            Occurences.Add(occurence);
            SortOccurences();
        }

        public void SortOccurences()
        {
            //ToDo:
//            Occurences.Sort((a, b) => a.Title.CompareTo(b.Title));
        }

        /// <summary>
        /// The list of available flags
        /// </summary>
        public ObservableCollection<Occurence> Occurences { get; private set; }
    }
}
