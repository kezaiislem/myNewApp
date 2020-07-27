using DocumentFormat.OpenXml.Wordprocessing;
using PFE.Constants;
using PFE.CustomObjects;
using PFE.model;
using PFE.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Shared
{
    public static class DataTableManager
    {
        public static DataTable prepareExportTable(List<Factor> factors, List<CustomPersonalAnswer> personalAnswers)
        {
            try
            {
                DataTable dt = new DataTable();
                foreach (Factor f in factors)
                {
                    foreach (Question q in f.questions)
                    {
                        dt.Columns.Add(q.text, typeof(string));
                    }
                }
                List<DataRow> dataRows = new List<DataRow>();
                foreach (CustomPersonalAnswer answer in personalAnswers)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < answer.answers.Count; i++)
                    {
                        switch (answer.questions.ElementAt(i).type)
                        {
                            case QuestionTypes.LIKERT_3:
                                dataRow[answer.questions.ElementAt(i).text] = QuestionTypes.likertStrings_3().ElementAt(answer.answers.ElementAt(i).value - 1);
                                break;
                            case QuestionTypes.LIKERT_5:
                                dataRow[answer.questions.ElementAt(i).text] = QuestionTypes.likertStrings_5().ElementAt(answer.answers.ElementAt(i).value - 1);
                                break;
                            case QuestionTypes.LIKERT_7:
                                dataRow[answer.questions.ElementAt(i).text] = QuestionTypes.likertStrings_7().ElementAt(answer.answers.ElementAt(i).value - 1);
                                break;
                            case QuestionTypes.RADIO:
                                dataRow[answer.questions.ElementAt(i).text] = answer.questions.ElementAt(i).choices[answer.answers.ElementAt(i).value - 1];
                                break;
                            case QuestionTypes.CHECK_BOX:
                                string value = "";
                                foreach (int index in answer.answers.ElementAt(i).chValues)
                                {
                                    value += answer.questions.ElementAt(i).choices[index] + ",";
                                }
                                value = value.Remove(value.Length - 1);
                                dataRow[answer.questions.ElementAt(i).text] = value;
                                break;
                        }
                    }
                    dt.Rows.Add(dataRow);
                }
                return dt;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return null;
        }

        public static DataTable prepareEvalTable(List<Factor> factors, List<CustomPersonalAnswer> personalAnswers)
        {
            try
            {
                DataTable dt = new DataTable();
                foreach (Factor f in factors)
                {
                    if (f.title != "None")
                    {
                        foreach (Question q in f.questions)
                        {
                            dt.Columns.Add(q.text, typeof(string));
                        }
                    }
                }
                List<DataRow> dataRows = new List<DataRow>();
                foreach (CustomPersonalAnswer answer in personalAnswers)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < answer.answers.Count; i++)
                    {
                        if (answer.questions.ElementAt(i).type <= QuestionTypes.LIKERT_7)
                        {
                            dataRow[answer.questions.ElementAt(i).text] = answer.answers.ElementAt(i).value;
                        }
                    }
                    dt.Rows.Add(dataRow);
                }
                foreach (Factor f in factors)
                {
                    if (f.title != "None")
                    {
                        int i = 0;
                        foreach (Question q in f.questions)
                        {
                            i++;
                            dt.Columns[q.text].ColumnName = f.title + i;
                        }
                    }
                }
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return null;
        }
    }
}
