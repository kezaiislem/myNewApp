using Newtonsoft.Json;
using PFE.model;
using PFE.Model;
using PFE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class AddHypothesisViewModel : INotifyPropertyChanged
    {
        public BindingList<Factor> start { get; set; }
        public BindingList<Factor> arrival { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Factor selectedStart;

        public Factor SelectedStart
        {
            get => selectedStart;
            set
            {
                selectedStart = value;
                UpdateArrival();
            }
        }

        public List<Hypothesis> hypotheses { get; set; }

        public Factor selectedArrival { get; set; }

        public AddHypothesisViewModel(List<Factor> factors, List<Hypothesis> hypotheses)
        {
            this.start = new BindingList<Factor>();
            foreach (Factor factor in factors)
            {
                if (factor.title != "None")
                {
                    start.Add(factor);
                }
            }
            this.arrival = new BindingList<Factor>();
            this.hypotheses = hypotheses;
            this.SelectedStart = start.First<Factor>();
        }

        private void UpdateArrival()
        {
            this.arrival.Clear();                                                      
            foreach (Factor factor in start)
            {
                if (factor!= selectedStart)
                {
                    arrival.Add(factor);
                }
            }
            selectedArrival = arrival.First<Factor>();
            OnNotifyPropertyChanged("");
        }

        private void OnNotifyPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                tmp(null, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
