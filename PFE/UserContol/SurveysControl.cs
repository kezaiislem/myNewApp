using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.ViewModel;
using PFE.Shared;
using Microsoft.VisualBasic;
using PFE.Model;
using PFE.CustomObjects;

namespace PFE.UserContol
{
    public partial class SurveysControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ResultsControl currentControl;

        private void OnNotifyPropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null)
            {
                tmp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        SurveysControlViewModel viewModel;

        public SurveysControl(int modelId)
        {
            InitializeComponent();
            viewModel = new SurveysControlViewModel(modelId);
            loadSurveys();
        }

        private void loadSurveys()
        {
            while(viewModel.surveys == null) { }

            foreach (CustomSurveysObject s in viewModel.surveys)
            {
                SurveyTabControl surveyTab = new SurveyTabControl(s);
                this.panelSurveyTableContent.SuspendLayout();
                surveyTab.Dock = DockStyle.Top;
                surveyTab.Height = 55;
                surveyTab.Visible = true;
                surveyTab.PropertyChanged += PropretyChanged;
                this.panelSurveyTableContent.Controls.Add(surveyTab);
                this.panelSurveyTableContent.Controls.SetChildIndex(surveyTab, 0);
                this.panelSurveyTableContent.ResumeLayout(false);
            }
        }

        private void SurveysControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.panelSurveyTableContent.Controls.Clear();
                this.viewModel.refresh();
                while (viewModel.surveys == null) { }
                this.loadSurveys();
            }
            else
            {
                if (this.currentControl != null)
                {
                    this.Controls.Remove(currentControl);
                    currentControl.Dispose();
                    currentControl = null;
                }
            }
        }

        private void PropretyChanged(object o, PropertyChangedEventArgs e)
        {
            if(e.PropertyName != null)
            {
                if (o != null)
                {
                    currentControl = (ResultsControl)o;
                    this.Controls.Add(currentControl);
                    currentControl.BringToFront();
                    currentControl.Show();
                }
                else
                {
                    OnNotifyPropertyChanged(e.PropertyName);
                }
            }
        }

    }
}
