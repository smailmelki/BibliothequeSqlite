using BibliothèqueSqlite.Class;
using BibliothèqueSqlite.DataConnection;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace BibliothèqueSqlite.Forms
{
    public partial class Frmbooks : FrmMaster
    {
        tblBooks tblBooks;
        public Frmbooks()
        {
            InitializeComponent();            
            this.Load += Frmbooks_Load;
            New();
        }

        public Frmbooks(long id)
        {
            InitializeComponent();
            using (var db = new DBContext())
            {
                tblBooks = db.tblBooks.Single(m => m.Id == id);
            }
            this.Text = "تعديل على كتاب " + tblBooks.TitalBook;
            RefreshData();
            GetData();
        }

        private void Frmbooks_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public override void New()
        {
            this.Text = "اضافة كتاب جديد";
            tblBooks = new tblBooks()
            {
                dateBook = DateTime.Now,
                NmbCopieBook = 0,
                QteBook = 0,
                PriceBook = 0,
                idPublishing=0,
                idClassBook=0
            };
            txtTitalBook.Focus();
            base.New();
        }

        public override void GetData()
        {
            dtp.Value = (DateTime)tblBooks.dateBook;
            txtTitalBook.Text = tblBooks.TitalBook;
            txtAuthorName.Text = tblBooks.AuthorName;
            nmNmbCopieBook.Value = (decimal)tblBooks.NmbCopieBook;
            nmQteBook.Value = (decimal)tblBooks.QteBook;
            nmPriceBook.Value = (decimal)tblBooks.PriceBook;
            cmbPublishing.SelectedValue = tblBooks.idPublishing;
            cmbClassBook.SelectedValue = tblBooks.idClassBook;
            txtSiteBook.Text = tblBooks.SiteBook;
            cmbBookStatus.Text = tblBooks.BookStatus;
            base.GetData();
        }
        public override void SetData()
        {
            tblBooks.dateBook = dtp.Value ;
            tblBooks.TitalBook = txtTitalBook.Text;
            tblBooks.AuthorName = txtAuthorName.Text;
            tblBooks.NmbCopieBook = (long?)nmNmbCopieBook.Value;
            tblBooks.QteBook = (long?)nmQteBook.Value ;
            tblBooks.PriceBook = (double?)nmPriceBook.Value;
            tblBooks.idPublishing = (long?)cmbPublishing.SelectedValue;
            tblBooks.idClassBook = (long?)cmbClassBook.SelectedValue;
            tblBooks.SiteBook = txtSiteBook.Text;
            tblBooks.BookStatus = cmbBookStatus.Text;
            base.SetData();
        }
        public override bool IsDataValdiate()
        {
            MasterClass.EpClear();
            int NumberOfErrors = 0;
            NumberOfErrors += txtTitalBook.IsTextValide() ? 0 : 1;
            NumberOfErrors += txtAuthorName.IsTextValide() ? 0 : 1;
            NumberOfErrors += nmQteBook.IsEditValue() ? 0 : 1;
            NumberOfErrors += nmPriceBook.IsEditValue() ? 0 : 1;

            return (NumberOfErrors == 0);
        }
        public override void Save()
        {
            using (var db = new DBContext())
            {
                SetData();
                db.tblBooks.AddOrUpdate(tblBooks);
                db.SaveChanges();
            }
                base.Save();
        }

        public override void RefreshData()
        {
            using (var db = new DBContext())
            {
                cmbClassBook.DataSource = (from p in db.tblPublishing.Where(x => x.isPublishing == false)
                                           select new
                                           {
                                               p.Id,
                                               p.Publishing
                                           }).ToList();
                cmbClassBook.DisplayMember =nameof(tblPublishing.Publishing);
                cmbClassBook.ValueMember = nameof(tblPublishing.Id);

                cmbPublishing.DataSource = (from p in db.tblPublishing.Where(x=>x.isPublishing==true)
                                           select new
                                           {
                                               p.Id,
                                               p.Publishing
                                           }).ToList();
                cmbPublishing.DisplayMember = nameof(tblPublishing.Publishing);
                cmbPublishing.ValueMember = nameof(tblPublishing.Id);
            }

            base.RefreshData();
        }
        public override void Delete()
        {
            if (tblBooks.Id == 0)
                return;
            using (var db = new DBContext())
            {

                if (MessageBox.Show(text: "هل تريد حذف الكتاب " + tblBooks.TitalBook, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SetData();
                    db.tblBooks.Remove(db.tblBooks.Single(x => x.Id == tblBooks.Id));
                    db.SaveChanges();
                    MessageBox.Show("تم حذف الكتاب");
                }
            }
            New();
            base.Delete();
        }

        private void btnNewPublishing_Click(object sender, EventArgs e)
        {
            FrmPublishingClassBooks frmPublishingClassBooks = new FrmPublishingClassBooks(true);
            frmPublishingClassBooks.ShowDialog();
            RefreshData();
        }

        private void btnNewClassBook_Click(object sender, EventArgs e)
        {
            FrmPublishingClassBooks frmPublishingClassBooks = new FrmPublishingClassBooks(false);
            frmPublishingClassBooks.ShowDialog();
            RefreshData();
        }

        private void btnUpdatePublishing_Click(object sender, EventArgs e)
        {
            FrmPublishingClassBooks frmPublishingClassBooks = new FrmPublishingClassBooks(true, (long)cmbPublishing.SelectedValue);
            frmPublishingClassBooks.ShowDialog();
            RefreshData();
        }

        private void btnUpdateClassBook_Click(object sender, EventArgs e)
        {
            FrmPublishingClassBooks frmPublishingClassBooks = new FrmPublishingClassBooks(true, (long)cmbClassBook.SelectedValue);
            frmPublishingClassBooks.ShowDialog();
            RefreshData();
        }
    }
}
