using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.Model;
using MetroFramework.Controls;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Bunifu.Core.forms.licensing;
using LiveCharts;
using PFE.Constants;
using LiveCharts.Wpf;

namespace PFE.UserContol
{
    public partial class QuestionResultControl : UserControl
    {

        Question question;

        Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        List<String> choices;
        int[] counts;

        public QuestionResultControl(Question question)
        {
            InitializeComponent();
            Init(question);
        }

        private void Init(Question question)
        {

            switch (question.type)
            {
                case QuestionTypes.CHECK_BOX :
                    counts = new int[question.choices.Count()];
                    choices = question.choices.ToList();
                    foreach (Answer answer in question.answers)
                    {
                        int j = 0;
                        foreach(String choice in question.choices)
                        {
                            if (answer.chValues.Contains(j))
                            {
                                counts[j]++;
                            }
                            j++;
                        }
                    }
                    break;

                case QuestionTypes.RADIO :
                    counts = new int[question.choices.Count()];
                    choices = question.choices.ToList();
                    foreach (Answer answer in question.answers)
                    {
                        counts[answer.value - 1]++;
                    }
                    break;

                case QuestionTypes.LIKERT_3 :
                    counts = new int[3];
                    choices = QuestionTypes.likertStrings_3();
                    foreach (Answer answer in question.answers)
                    {
                        counts[answer.value - 1]++;
                    }
                    break;

                case QuestionTypes.LIKERT_5 :
                    counts = new int[5];
                    choices = QuestionTypes.likertStrings_5();
                    foreach (Answer answer in question.answers)
                    {
                        counts[answer.value - 1]++;
                    }
                    break;

                case QuestionTypes.LIKERT_7 :
                    counts = new int[7];
                    choices = QuestionTypes.likertStrings_7();
                    foreach (Answer answer in question.answers)
                    {
                        counts[answer.value - 1]++;
                    }
                    break;
            }

            labelQuestion.DataBindings.Add("Text", question, "text", true, DataSourceUpdateMode.OnPropertyChanged);
            SeriesCollection series = new SeriesCollection();

            int i = 0;
            foreach (String choice in choices)
            {
                series.Add(new PieSeries { Title = choices.ElementAt(i), Values = new ChartValues<int> { counts[i] }, LabelPoint = labelPoint, DataLabels = false });
                i++;
            }
            
            pieChart.Series = series;
            pieChart.Visible = true;
            pieChart.LegendLocation = LegendLocation.Right;
        }

    }
}
