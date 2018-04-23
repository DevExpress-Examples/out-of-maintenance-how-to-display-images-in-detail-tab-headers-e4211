using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using S133193Example;

namespace S133193Example
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            dataBase = DataHelper.CreateDataBase();
            customGridControl2.DataSource = dataBase.Tables[0];
            customGridView1.GetTabImage += GetTabImage;
        }
        DataSet dataBase;

        enum CustomerType { Person, Company };

        void GetTabImage(object sender, DrawTabImageEventArgs e)
        {
            CustomerType value = (CustomerType)customGridView1.GetRowCellValue(e.RowHandle, customGridView1.Columns["CustomerType"]);
            if (e.RelationIndex == 0)
            {
                switch (value)
                {
                    case CustomerType.Person:
                        e.Image = GetImageByName(e, "Person.bmp"); 
                        break;
                    case CustomerType.Company:
                        e.Image = GetImageByName(e, "Company.png");
                        break;
                    default:
                        break;
                }
            }
            else e.Image = GetImageByName(e, "Delivered.png");
        }

        private Image GetImageByName(DrawTabImageEventArgs e, string imageName)
        {
            return Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(String.Format("S133193Example.{0}", imageName)));
        }

    }
}
