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
using System.Web.UI.Design;
using MetroFramework.Controls;
using PFE.Shared;
using PFE.Model;
using Newtonsoft.Json;
using MetroFramework;
using PFE.Constants;
using PFE.model;
using DocumentFormat.OpenXml.Bibliography;

namespace PFE.UserContol
{
    public partial class StatisticsControl : UserControl
    {

        StatisticsControlViewModel viewModel;

        FirstCollectControl firstCollectConrol;

        ConfirmatoryAnalysisControl confirmatoryAnalysisControl;


        public StatisticsControl(String id)
        {
            InitializeComponent();
            Init(id);
        }

        private void Init(String id)
        {
            panelSections.Controls.SetChildIndex(panel2, 0);
            panelSections.Controls.SetChildIndex(buttonExploratoryAnalysis, 0);
            panelSections.Controls.SetChildIndex(buttonConfirmatory, 0);
            this.viewModel = new StatisticsControlViewModel(id);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonExploratoryAnalysis_Click(object sender, EventArgs e)
        {
            if (this.viewModel.survey != null)
            {
                this.hideConfirmatoryAnalisis();
                if (this.firstCollectConrol != null)
                {
                    firstCollectConrol.Show();
                }
                else
                {
                    this.firstCollectConrol = new FirstCollectControl(this.viewModel.survey);
                    this.firstCollectConrol.Dock = DockStyle.Fill;
                    this.firstCollectConrol.AutoScaleMode = AutoScaleMode.None;
                    this.firstCollectConrol.Show();
                    this.panelStepContent.Controls.Add(firstCollectConrol);
                }
            }
            else
            {
                MessageBox.Show("Cant load survey please check ur connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonConfirmatory_Click(object sender, EventArgs e)
        {
            this.hideExploratoryAnalisis();
            if (this.confirmatoryAnalysisControl != null)
            {
                confirmatoryAnalysisControl.Show();
            }
            else
            {
                this.confirmatoryAnalysisControl = new ConfirmatoryAnalysisControl(this.viewModel.survey);
                this.confirmatoryAnalysisControl.Dock = DockStyle.Fill;
                this.confirmatoryAnalysisControl.AutoScaleMode = AutoScaleMode.None;
                this.confirmatoryAnalysisControl.Show();
                this.panelStepContent.Controls.Add(confirmatoryAnalysisControl);
            }
        }

        private void hideExploratoryAnalisis()
        {
            if (this.firstCollectConrol != null)
            {
                this.firstCollectConrol.Hide();
            }
        }
        
        private void hideConfirmatoryAnalisis()
        {
            if (this.confirmatoryAnalysisControl != null)
            {
                this.confirmatoryAnalysisControl.Hide();
            }
        }
    }
}
