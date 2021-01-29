using POTZProjektZaliczeniowy.Data;
using POTZProjektZaliczeniowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POTZProjektZaliczeniowy.Form
{
    public partial class EditEmployeForm : System.Windows.Forms.Form
    {
        MainForm mainForm;
        Employe editedEmploye;
        public EditEmployeForm(MainForm mainForm, Employe employe)
        {
            this.mainForm = mainForm;
            this.editedEmploye = employe;
            InitializeComponent();
            FillComboBoxData();
            FillemployeData(editedEmploye);

        }
        void FillemployeData(Employe employe)
        {
            txtBoxEmployeId.Text = employe.EmployeID.ToString();
            txtBoxEmployeFirstName.Text = employe.FristName;
            txtBoxEmployeLastName.Text = employe.LastName;
            txtBoxEmployeEmail.Text = employe.Email;
            if (employe.CompanyID != null)
            {
                var findedCompany = FindCompany(employe);
                comboBoxEmployeCompany.SelectedIndex = comboBoxEmployeCompany.FindStringExact(findedCompany.CompanyName);

            }
            else
            {
                comboBoxEmployeCompany.Text = null;
            }

        }
        void FillComboBoxData()
        {
            using (var dbContext = new CompanyContext())
            {
                var emptyCompany = new Company();
                List<Company> company = new List<Company>();
                company.Add(emptyCompany);
                company.AddRange(dbContext.Companies.ToList());
                comboBoxEmployeCompany.DataSource = company;
                comboBoxEmployeCompany.ValueMember = "CompanyID";
                comboBoxEmployeCompany.DisplayMember = "CompanyName";
            }
        }
        private void EditEmploye(Employe employe)
        {


            using (CompanyContext dbcontext = new CompanyContext())
            {
                employe.FristName = txtBoxEmployeFirstName.Text;
                employe.LastName = txtBoxEmployeLastName.Text;
                employe.Email = txtBoxEmployeEmail.Text;
                var selectedCompany = (Company)comboBoxEmployeCompany.SelectedItem;
                if (selectedCompany != null)
                {
                    var findedCompany = FindCompany(selectedCompany);

                    if (findedCompany != null)
                    {
                        if (findedCompany.CompanyName != null)
                        {
                            employe.Company = findedCompany;
                            employe.CompanyID = findedCompany.CompanyID;
                        }
                        else if (selectedCompany.CompanyName == null)
                        {
                            employe.Company = null;
                            employe.CompanyID = null;
                        }
                    }
                }
                else
                {
                    employe.Company = null;
                    employe.CompanyID = null;
                }
                dbcontext.Employes.Update(employe);
                dbcontext.SaveChanges();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditEmploye(editedEmploye);
            mainForm.RefreshEmployeGridView();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DeleteEmploye(editedEmploye);
            mainForm.RefreshEmployeGridView();
            this.Close();

        }

        private void DeleteEmploye(Employe employe)
        {
            using (CompanyContext dbcontext = new CompanyContext())
            {

                dbcontext.Employes.Remove(employe);
                dbcontext.SaveChanges();
            }
        }

        private void comboBoxEmployeCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditEmployeForm_Load(object sender, EventArgs e)
        {

        }
        private Company FindCompany(Employe employe)
        {
            if (employe.CompanyID != null)
            {
                using (var dbContext = new CompanyContext())
                {
                    var findedCompany = dbContext.Companies.Where(c => c.CompanyID == employe.CompanyID).FirstOrDefault();
                    return findedCompany;
                }
            }
            else return null;
        }

        private Company FindCompany(Company company)
        {
            if (company != null)
            {
                if (company.CompanyID != null)
                {
                    using (var dbContext = new CompanyContext())
                    {
                        var findedCompany = dbContext.Companies.Where(c => c.CompanyID == company.CompanyID).FirstOrDefault();
                        return findedCompany;
                    }
                }
                else return null; ;
            }
            else return null;
        }
    }
}
