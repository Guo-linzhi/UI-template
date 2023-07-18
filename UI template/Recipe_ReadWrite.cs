using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Shapes;

namespace UI_template
{
    public static class Recipe_ReadWrite
    {
        public static List<string> crawl_Var(System.Windows.Forms.Control controls, List<string> strings)   //抓資料
        {
            foreach (System.Windows.Forms.Control control in controls.Controls)
            {
                if (control.Controls.Count > 0)
                    crawl_Var(control, strings);
                else
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        strings.Add(control.Name);
                        strings.Add(control.Text);
                    }
                    else if (control is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox ck = (System.Windows.Forms.CheckBox)control;
                        strings.Add(ck.Name);
                        strings.Add(ck.Checked.ToString());
                    }
                    else if (control is System.Windows.Forms.RadioButton)
                    {
                        System.Windows.Forms.RadioButton rb = (System.Windows.Forms.RadioButton)control;
                        strings.Add(rb.Name);
                        strings.Add(rb.Checked.ToString());
                    }
                }
            }
            return strings;
        }
        public static DataTable create_table(List<string> strings)//存成datatable
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Text", typeof(String));

            for (int i = 0; i < strings.Count; i += 2)
            {
                dt.Rows.Add(strings[i], strings[i + 1]);
            }
            return dt;
        }
        public static void create_CSV_Step(string path, DataTable dt,string name)
        {
            create_file(path);
            create_CSV(path, dt,name);
        }
        private static void create_file(string fulllPath)
        {
            if (!Directory.Exists(fulllPath))
            {
                Directory.CreateDirectory(fulllPath);
            }
        }
        private static void create_CSV(string path, DataTable dt, string name)
        {
            path = $"{path}\\{name}";
            StreamWriter s = new StreamWriter(path, false);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                s.Write(dt.Columns[i]);
                if (i < dt.Columns.Count - 1)
                {
                    s.Write(",");
                }
            }
            s.Write(s.NewLine);
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            s.Write(value);
                        }
                        else
                        {
                            s.Write(dr[i].ToString());
                        }
                    }
                    if (i < dt.Columns.Count - 1)
                    {
                        s.Write(",");
                    }
                }
                s.Write(s.NewLine);
            }
            s.Close();
        }
    }
}
