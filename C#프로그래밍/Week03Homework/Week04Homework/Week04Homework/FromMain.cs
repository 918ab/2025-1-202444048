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
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[10];
            professors = new List<Professor>();
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
            lbxDepartment.Items.Add(dept.Code);
            lbxDepartment.Items.Add(dept.Name);
            lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            //is 연산자 , 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItems is Department){
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
            switch (tabMain.SelectedIndex){
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
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProfessor.Items.Clear();
            //as 형변환 연산자
            //형변환이 정상적이지 않으면 null 변환
            var department = cmbProfessorDepartment.SelectedItem as Department;
            if(department != null){
                foreach (var professor in professors){
                    if(professor.DepartmentCode == department.Code){
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }
    }
}
