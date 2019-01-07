﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrainingData.Exercise
{
    public class Exercise : NotifyModel
    {
        private string _Title;
        private string _Description;
        private int _Id;

        public int Id
        {
            get => _Id;
            set => ChangePropertyValue(ref _Id, value);
        }

        public string Title
        {
            get => _Title;
            set => ChangePropertyValue(ref _Title, value);
        }

        public string Description
        {
            get => _Description;
            set => ChangePropertyValue(ref _Description, value);
        }


        public override string ToString()
        {
            return Title;
        }

    }
}
