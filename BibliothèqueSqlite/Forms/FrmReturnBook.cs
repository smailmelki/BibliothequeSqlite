using BibliothèqueSqlite.DataConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothèqueSqlite.Forms
{
    public partial class FrmReturnBook : FrmMaster
    {
        tblLoan tblLoans;
        public FrmReturnBook(tblLoan _tblLoan)
        {
            InitializeComponent();
            btnDelete.Visible = false;
            btnNew.Visible = false;
            tblLoans = _tblLoan;
            
            using (var db = new DBContext())
                this.Text ="استرجاع الكتاب " + db.tblBooks.Find( tblLoans.idBook).TitalBook;
        }
        public override void GetData()
        {
            tblLoans.dateActualEnty = dateTimePicker1.Value ;
            base.GetData();
        }
        public override void Save()
        {
            using (var db = new DBContext())
            {
                GetData();
                db.tblLoan.AddOrUpdate(tblLoans);
                db.SaveChanges();
            }
            base.Save();
        }
    }
}
