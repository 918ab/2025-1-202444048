using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#if false

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
            departments[0] = new Department()
            {
                Code = "A001",
                Name = "컴퓨터정보"
            };
            departments[1] = new Department()
            {
                Code = "A002",
                Name = "컴퓨터시스템"
            };
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] != null)
                {
                    lbxDepartment.Items.Add(departments[i]);
                }
            }
            professors.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2020001",
                Name = "김인하"
            });
            professors.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2023003",
                Name = "김정석"
            });
            professors.Add(new Professor()
            {
                DepartmentCode = departments[1].Code,
                Number = "2023004",
                Name = "이공전"
            });
            students.Add("20240001", new Student()
            {
                Number = "20240001",
                Name = "김미영",
                RegStatus = "재학",
                Year = 1,
                BirthInfo = new DateTime(2004, 01, 01),
                DepartmentCode = "A001",
                AdvisorNumber = "2020001",
                Class = "B",
                Address = "인천 남구 용현동 100",
                Contact = "032-870-0000"
            });
            foreach (var student in students)
            {
                if (student.Value != null)
                {
                    lbxDictionary.Items.Add(student.Value);
                }
            }
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
                case 3:
                    tbxTestNumber.Text = "";
                    lblTestName.Text = "";
                    tbxTestScore1.Text = "";
                    tbxTestScore2.Text = "";
                    tbxTestScore3.Text = "";
                    tbxTestScore4.Text = "";
                    tbxTestScore5.Text = "";
                    tbxTestScore6.Text = "";
                    tbxTestScore7.Text = "";
                    tbxTestScore8.Text = "";
                    tbxTestScore9.Text = "";
                    lblTestTotalCount.Text = "";
                    lblTestAverage.Text = "";
                    ClearStudentInfo(); 
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
            ClearStudentInfo();
        }

        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;

            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
            lbxDictionary.SelectedIndex = -1;

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
            
            if (tbxNumber == null || tbxNumber.Text.Length != 8){
                MessageBox.Show("학번이 비었거나 8자리가 아닙니다");
                return;
            }
            if (tbxName == null || tbxName.Text.Length < 2){
                MessageBox.Show("이름이 비었거나 2자 미만입니다");
                return;
            }
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
                if(birthYear <= 1900 ||  birthYear >= 9000)
                {
                    return;
                }
            } else { return; }

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth)){
                if (birthMonth <= 1 || birthMonth >= 12)
                {
                    return;
                }
            } else { return; }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay)){
                if (birthDay <= 1 || birthDay >= 12)
                {
                    return;
                }
            } else { return; }

            //현재시간 DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if(cmbDepartment.SelectedIndex <0){
                student.DepartmentCode = null;
            } else{
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }
            
            if(cmbAdvisor.SelectedIndex < 0){
                student.AdvisorNumber = null;
            }else{
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }
            if (cmbYear == null) return;
            student.Year = int.Parse(cmbYear.SelectedItem.ToString());

            if (cmbClass == null) return;
            student.Class = cmbClass.SelectedItem.ToString();

            if (cmbRegStatus == null) return;
            student.RegStatus = cmbRegStatus.SelectedItem.ToString();

            student.Address = tbxAddress.Text;
            student.Contact = tbxContact.Text;


            students[number] = student; //추가, 덮어쓰기
            //students.Add(number, student);
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudent()
        {
            tbxNumber.ReadOnly = true;

            if (selectedStudent == null) return;
            selectedStudent.Name = tbxName.Text.Trim();

            if (int.TryParse(tbxBirthYear.Text, out int birthYear))
            {
                if (birthYear <= 1900 || birthYear >= 9000) return;
            }
            else { return; }

            if (int.TryParse(tbxBirthMonth.Text, out int birthMonth))
            {
                if (birthMonth <= 1 || birthMonth >= 12) return;
            }
            else { return; }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay <= 1 || birthDay >= 31) return;
            }
            else { return; }

            selectedStudent.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                selectedStudent.DepartmentCode = null;
            }
            else
            {
                selectedStudent.DepartmentCode = (cmbDepartment.SelectedItem as Department)?.Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                selectedStudent.AdvisorNumber = null;
            }
            else
            {
                selectedStudent.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor)?.Number;
            }


            if (cmbYear.SelectedIndex < 0) return;
            selectedStudent.Year = (int)cmbYear.SelectedItem;

            if (cmbClass.SelectedIndex < 0) return;
            selectedStudent.Class = cmbClass.SelectedItem.ToString();

            if (cmbRegStatus.SelectedIndex < 0) return;
            selectedStudent.RegStatus = cmbRegStatus.SelectedItem.ToString();


            selectedStudent.Address = tbxAddress.Text;
            selectedStudent.Contact = tbxContact.Text;

            int index = lbxDictionary.SelectedIndex;
            lbxDictionary.Items[index] = selectedStudent;

            MessageBox.Show("수정완료");
            ClearStudentInfo();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxDictionary.SelectedIndex < 0){
                return;
            }

            var student = (lbxDictionary.SelectedItem as Student);
            ClearStudentInfo();
            if (student != null)
            {
                DisplaySelectedStudent(student);
            }

        }

        private void DisplaySelectedStudent(Student student)
        {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                if ((cmbDepartment.Items[i] as Department).Code == student.DepartmentCode){
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }


            cmbAdvisor.Text = student.AdvisorNumber;
            cmbYear.Text = student.Year.ToString();
            cmbClass.Text = student.Class;
            cmbRegStatus.Text = student.RegStatus;
            tbxAddress.Text = student.Address;
            tbxContact.Text = student.Contact;
            tbxName.Text = student.Name;
            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();

            if(tbxTestNumber == null)
            {
                MessageBox.Show("학번을 입력해주세요");
                return;
            }
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
            if (selectedStudent == null)
            {
                MessageBox.Show("존재하지 않은 학번입니다");
                return;
            }
            lblTestName.Text = selectedStudent.Name;

            Grade grade = SearchGradeByNumber(selectedStudent.Number);
            if(grade != null){
                for(int i = 0; i < grade.Scores.Count && i < tbxTestScores.Length; i++){
                    tbxTestScores[i].Text = grade.Scores[i].ToString("0.0");
                }
            }
        }

        Grade SearchGradeByNumber(string number)
        {
            foreach (Grade grade in testGrades){
                if(grade.StudentNumber == number){
                    return grade;
                }
            }
            return null;
        }


        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number)){
                return students[number];
            } else {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if(selectedStudent == null){
                tbxTestNumber.Focus();
                return;
            }
            for (int i = 1; i < tbxTestScores.Length; i++){
                if (string.IsNullOrEmpty(tbxTestScores[i - 1].Text) == true
                    && string.IsNullOrEmpty(tbxTestScores[i].Text) == false){
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }

            var grade = SearchGradeByNumber(selectedStudent.Number);
            if(grade == null){
                grade = new Grade() { StudentNumber = selectedStudent.Number };
            }
            grade.Scores.Clear();
            double temp;
            
            for(int i = 0;i < tbxTestScores.Length; i++){
                if (string.IsNullOrEmpty(tbxTestScores[i].Text)){
                    break;
                }
                if (double.TryParse(tbxTestScores[i].Text, out temp) == false){
                    tbxTestScores[i].Focus();
                    return;
                }
                grade.Scores.Add(temp);
            }
            testGrades.Add(grade);

            lblTestTotalCount.Text = grade.Scores.Count.ToString();

            double average = grade.Average();
            lblTestAverage.Text = average.ToString("F1");
        }
    }

}
#else
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
            departments[0] = new Department()
            {
                Code = "A001",
                Name = "컴퓨터정보"
            };
            departments[1] = new Department()
            {
                Code = "A002",
                Name = "컴퓨터시스템"
            };
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] != null)
                {
                    lbxDepartment.Items.Add(departments[i]);
                }
            }
            professors.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2020001",
                Name = "김인하"
            });
            professors.Add(new Professor()
            {
                DepartmentCode = departments[0].Code,
                Number = "2023003",
                Name = "김정석"
            });
            professors.Add(new Professor()
            {
                DepartmentCode = departments[1].Code,
                Number = "2023004",
                Name = "이공전"
            });
            students.Add("20240001", new Student()
            {
                Number = "20240001",
                Name = "김미영",
                RegStatus = "재학",
                Year = 1,
                BirthInfo = new DateTime(2004, 01, 01),
                DepartmentCode = "A001",
                AdvisorNumber = "2020001",
                Class = "B",
                Address = "인천 남구 용현동 100",
                Contact = "032-870-0000"
            });
            foreach (var student in students)
            {
                if (student.Value != null)
                {
                    lbxDictionary.Items.Add(student.Value);
                }
            }
        }


        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if (index < 0)
                    {
                        index = i;
                    }
                } else if (departments[i].Code == tbxDepartmentCode.Text)
                {
                    return;
                }
            }
            if (index < 0)
            {
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
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;
                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i] == target)
                    {
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
            switch (tabTestScore.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
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
                case 3:
                    tbxTestNumber.Text = "";
                    lblTestName.Text = "";
                    tbxTestScore1.Text = "";
                    tbxTestScore2.Text = "";
                    tbxTestScore3.Text = "";
                    tbxTestScore4.Text = "";
                    tbxTestScore5.Text = "";
                    tbxTestScore6.Text = "";
                    tbxTestScore7.Text = "";
                    tbxTestScore8.Text = "";
                    tbxTestScore9.Text = "";
                    lblTestTotalCount.Text = "";
                    lblTestAverage.Text = "";
                    ClearStudentInfo();
                    break;
                default:
                    break;
            }
        }
        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProfessor.Items.Clear();
            var department = cmbProfessorDepartment.SelectedItem as Department;
            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor.DepartmentCode == department.Code)
                    {
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            foreach (var professor in professors)
            {
                if (professor.Number == tbxProfessorNumber.Text)
                {
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
            if (lbxProfessor.SelectedItem is Professor)
            {
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
            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor.DepartmentCode == department.Code)
                    {
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
        }

        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;

            tbxNumber.ReadOnly = false;
            selectedStudent = null;
            btnRegister.Text = "등록";
            lbxDictionary.SelectedIndex = -1;

        }
        Student selectedStudent = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                RegisterStudent();
            } else
            {
                UpdateStudent();
            }
        }

        private void RegisterStudent()
        {

            if (tbxNumber == null || tbxNumber.Text.Length != 8)
            {
                MessageBox.Show("학번이 비었거나 8자리가 아닙니다");
                return;
            }
            if (tbxName == null || tbxName.Text.Length < 2)
            {
                MessageBox.Show("이름이 비었거나 2자 미만입니다");
                return;
            }
            var number = tbxNumber.Text.Trim();
            if (students.ContainsKey(number) == true)
            {
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;//, birthDay;
            if (int.TryParse(tbxBirthYear.Text, out birthYear))
            {
                if (birthYear <= 1900 || birthYear >= 9000)
                {
                    return;
                }
            } else { return; }

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                if (birthMonth <= 1 || birthMonth >= 12)
                {
                    return;
                }
            } else { return; }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay <= 1 || birthDay >= 12)
                {
                    return;
                }
            } else { return; }

            //현재시간 DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            } else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            } else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }
            if (cmbYear == null) return;
            student.Year = int.Parse(cmbYear.SelectedItem.ToString());

            if (cmbClass == null) return;
            student.Class = cmbClass.SelectedItem.ToString();

            if (cmbRegStatus == null) return;
            student.RegStatus = cmbRegStatus.SelectedItem.ToString();

            student.Address = tbxAddress.Text;
            student.Contact = tbxContact.Text;


            students[number] = student; //추가, 덮어쓰기
            //students.Add(number, student);
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudent()
        {
            tbxNumber.ReadOnly = true;

            if (selectedStudent == null) return;
            selectedStudent.Name = tbxName.Text.Trim();

            if (int.TryParse(tbxBirthYear.Text, out int birthYear))
            {
                if (birthYear <= 1900 || birthYear >= 9000) return;
            } else { return; }

            if (int.TryParse(tbxBirthMonth.Text, out int birthMonth))
            {
                if (birthMonth <= 1 || birthMonth >= 12) return;
            } else { return; }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay <= 1 || birthDay >= 31) return;
            } else { return; }

            selectedStudent.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                selectedStudent.DepartmentCode = null;
            } else
            {
                selectedStudent.DepartmentCode = (cmbDepartment.SelectedItem as Department)?.Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                selectedStudent.AdvisorNumber = null;
            } else
            {
                selectedStudent.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor)?.Number;
            }


            if (cmbYear.SelectedIndex < 0) return;
            selectedStudent.Year = (int)cmbYear.SelectedItem;

            if (cmbClass.SelectedIndex < 0) return;
            selectedStudent.Class = cmbClass.SelectedItem.ToString();

            if (cmbRegStatus.SelectedIndex < 0) return;
            selectedStudent.RegStatus = cmbRegStatus.SelectedItem.ToString();


            selectedStudent.Address = tbxAddress.Text;
            selectedStudent.Contact = tbxContact.Text;

            int index = lbxDictionary.SelectedIndex;
            lbxDictionary.Items[index] = selectedStudent;

            MessageBox.Show("수정완료");
            ClearStudentInfo();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDictionary.SelectedIndex < 0)
            {
                return;
            }

            var student = (lbxDictionary.SelectedItem as Student);
            ClearStudentInfo();
            if (student != null)
            {
                DisplaySelectedStudent(student);
            }

        }

        private void DisplaySelectedStudent(Student student)
        {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                if ((cmbDepartment.Items[i] as Department).Code == student.DepartmentCode)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }


            cmbAdvisor.Text = student.AdvisorNumber;
            cmbYear.Text = student.Year.ToString();
            cmbClass.Text = student.Class;
            cmbRegStatus.Text = student.RegStatus;
            tbxAddress.Text = student.Address;
            tbxContact.Text = student.Contact;
            tbxName.Text = student.Name;
            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();

            if (tbxTestNumber == null)
            {
                MessageBox.Show("학번을 입력해주세요");
                return;
            }
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
            if (selectedStudent == null)
            {
                MessageBox.Show("존재하지 않은 학번입니다");
                return;
            }
            lblTestName.Text = selectedStudent.Name;

            Grade grade = SearchGradeByNumber(selectedStudent.Number);
            if (grade != null)
            {
                for (int i = 0; i < grade.Count() && i < tbxTestScores.Length; i++)
                {
                    tbxTestScores[i].Text = grade.Get(i).ToString("0.0");
                }
            }
        }

        Grade SearchGradeByNumber(string number)
        {
            foreach (Grade grade in testGrades)
            {
                if (grade.StudentNumber == number)
                {
                    return grade;
                }
            }
            return null;
        }


        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            } else
            {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                tbxTestNumber.Focus();
                return;
            }
            for (int i = 1; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i - 1].Text) == true
                    && string.IsNullOrEmpty(tbxTestScores[i].Text) == false)
                {
                    tbxTestScores[i - 1].Focus();
                    return;
                }
            }

            var grade = SearchGradeByNumber(selectedStudent.Number);
            if (grade == null)
            {
                grade = new Grade() { StudentNumber = selectedStudent.Number };
            }
            grade.Clear();
            double temp;

            for (int i = 0; i < tbxTestScores.Length; i++)
            {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text))
                {
                    break;
                }
                if (double.TryParse(tbxTestScores[i].Text, out temp) == false)
                {
                    tbxTestScores[i].Focus();
                    return;
                }
                grade.Add(temp);
            }
            testGrades.Add(grade);

            lblTestTotalCount.Text = grade.Count().ToString();

            double average = grade.Average();
            lblTestAverage.Text = average.ToString("F1");
        }
    }

}
#endif