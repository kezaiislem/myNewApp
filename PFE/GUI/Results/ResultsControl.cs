﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.Model;
using PFE.ViewModel;
using PFE.model;
using ClosedXML.Excel;

namespace PFE.UserContol
{
    public partial class ResultsControl : UserControl
    {
        private int tabCount = 0;
        public ResultControlViewModel viewModel;
        public SectionResultControl currentSection { get; set; }

        public ResultsControl(int surveyId)
        {
            InitializeComponent();
            Init(surveyId);
        }

        private void Init(int surveyId)
        {
            panelSections.Controls.SetChildIndex(panel2, 0);
            viewModel = new ResultControlViewModel(surveyId);
            while (viewModel.factors == null) { }
            foreach (Factor factor in viewModel.factors)
            {
                addSection(factor);
            }

        }

        private void addSection(Factor factor)
        {
            Button panelSection = new Button();
            panelSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            panelSection.Dock = System.Windows.Forms.DockStyle.Top;
            panelSection.FlatAppearance.BorderSize = 0;
            panelSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            panelSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            panelSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            panelSection.ForeColor = System.Drawing.Color.White;
            panelSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            panelSection.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            panelSection.Height = 40;
            panelSection.TabIndex = tabCount;
            panelSection.Text = factor.title;
            panelSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            panelSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            panelSection.UseVisualStyleBackColor = false;
            panelSection.Click += (s, ev) => sectionClick(factor);
            tabCount++;
            panelSections.Controls.Add(panelSection);
            panelSections.Controls.SetChildIndex(panelSection, 0);
        }

        public void sectionClick(Factor factor)
        {
            SectionResultControl sectionResultControl = new SectionResultControl(factor);
            if (currentSection != null)
            {
                currentSection.Dispose();
            }
            sectionResultControl.Dock = DockStyle.Fill;
            sectionResultControl.AutoScaleMode = AutoScaleMode.None;
            panelSectionContainer.Controls.Add(sectionResultControl);
            sectionResultControl.Show();
            currentSection = sectionResultControl;
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "Sheet";
                saveFileDialog.Filter = "Exel File|*.xlsx|CSV File|*.csv";
                saveFileDialog.Title = "Export";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Task.Run(async () => await viewModel.saveExel(saveFileDialog.FileName));
                }
            }
        }
    }
}