using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager : Form
    {
        Department[] departments;
        List<Professor> professors;
        Dictionary<string, Student> students;

        List<Grade> testGrades;
        TextBox[] tbxTestScores;
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[10];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();
            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]
            {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9
            };
        }
        
        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < departments.Length; i++){
                if (departments[i] == null){
                    if (index < 0) {
                        index = i;
                    }
                }else if (departments[i].Code == tbxDepartmentCode.Text){
                    return;
                }
            }
            if(index < 0) {
                return;
            }
            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;
            departments[index] = dept;
            
            lbxDepartment.Items.Add(dept);
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedItem is Department){
                var target = (Department) lbxDepartment.SelectedItem;
                for (int i = 0; i < departments.Length; i++){
                    if (departments[i] == target){
                        departments[i] = null;
                        break;
                    }
                }
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
                lbxDepartment.SelectedIndex = -1;
            }

        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //창 변경시
            switch (tabTestScore.SelectedIndex){
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach(var department in departments){
                        if(department != null){
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }
                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                    }
                    cmbDepartment.SelectedIndex = -1;
                    break;
                default:
                    break;
            }
        }
        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProfessor.Items.Clear();
            var department = cmbProfessorDepartment.SelectedItem as Department;
            if(department != null){
                foreach (var professor in professors){
                    if(professor.DepartmentCode == department.Code){
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            foreach(var professor in professors){
                if(professor.Number == tbxProfessorNumber.Text){
                    return;
                }
            }
            var select = cmbProfessorDepartment.SelectedItem as Department;
            if (select == null) return;
            Professor prof = new Professor();
            prof.DepartmentCode = select.Code;
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;

            professors.Add(prof);
            lbxProfessor.Items.Add(prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedItem is Professor){
                var target = (Professor)lbxProfessor.SelectedItem;
                professors.Remove(target);
                lbxProfessor.Items.Remove(target);
                lbxProfessor.SelectedIndex = -1;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();
            var department = cmbDepartment.SelectedItem as Department;
            if (department != null){
                foreach (var professor in professors){
                    if (professor.DepartmentCode == department.Code){
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tpgStudent.Controls){
                if (ctrl is TextBox tb){
                    tb.Text = "";
                }else if (ctrl is ComboBox cb){
                    cb.SelectedIndex = -1;
                }
            }
            tbxNumber.Text = "20";
            tbxBirthYear.Text = "20";
        }
        Student selectedStudent = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(selectedStudent == null){
                RegisterStudent();
            } else {
                UpdateStudent();
            }
        }

        private void RegisterStudent()
        {
            var number = tbxNumber.Text.Trim();
            if(students.ContainsKey(number) == true){
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;//, birthDay;
            if(int.TryParse(tbxBirthYear.Text, out birthYear)){

            } else { return; }

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth)){

            } else { return; }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay)){

            } else { return; }

            //현재시간 DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if(cmbDepartment.SelectedIndex <0){
                student.DepartmentCode = null;
            } else{
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            students[number] = student; //추가, 덮어쓰기
            //students.Add(number, student);
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudent()
        {
            throw new NotImplementedException();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxDictionary.SelectedIndex < 0){
                return;
            }
            btnNew_Click(sender,EventArgs.Empty);
            selectedStudent = (lbxDictionary.SelectedItem as Student);
            if(selectedStudent != null){
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();

        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number)){
                return students[number];
            } else {
                return null;
            }
        }
    }

}
