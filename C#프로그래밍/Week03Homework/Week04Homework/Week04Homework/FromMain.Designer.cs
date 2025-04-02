namespace Week04Homework
{
    partial class FormManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblBirthMonth = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.tbxAdvisor = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbxDictionary = new System.Windows.Forms.ListBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbRegStatus = new System.Windows.Forms.ComboBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgDepartment = new System.Windows.Forms.TabPage();
            this.btnRegisterDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.tbxDepartmentCode = new System.Windows.Forms.TextBox();
            this.tpgProfessor = new System.Windows.Forms.TabPage();
            this.btnRegisterProfessor = new System.Windows.Forms.Button();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.lbxProfessor = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxProfessorName = new System.Windows.Forms.TextBox();
            this.tbxProfessorNumber = new System.Windows.Forms.TextBox();
            this.cmbProfessorDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpgStudent = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tpgDepartment.SuspendLayout();
            this.tpgProfessor.SuspendLayout();
            this.tpgStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNumber.Location = new System.Drawing.Point(38, 39);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(39, 16);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "학번";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(117, 34);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(102, 21);
            this.tbxNumber.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(332, 34);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(101, 21);
            this.tbxName.TabIndex = 1;
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.Location = new System.Drawing.Point(117, 81);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(102, 21);
            this.tbxBirthYear.TabIndex = 1;
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.Location = new System.Drawing.Point(270, 80);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(49, 21);
            this.tbxBirthMonth.TabIndex = 1;
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.Location = new System.Drawing.Point(355, 81);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(49, 21);
            this.tbxBirthDay.TabIndex = 1;
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 12;
            this.lbxArray.Location = new System.Drawing.Point(467, 34);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(184, 124);
            this.lbxArray.TabIndex = 3;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirth.Location = new System.Drawing.Point(38, 80);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(71, 16);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "생년월일";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDepartment.Location = new System.Drawing.Point(38, 121);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(71, 16);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "소속학과";
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAdvisor.Location = new System.Drawing.Point(38, 162);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(71, 16);
            this.lblAdvisor.TabIndex = 0;
            this.lblAdvisor.Text = "지도교수";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblYear.Location = new System.Drawing.Point(38, 203);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "학년";
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.AutoSize = true;
            this.lblRegStatus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRegStatus.Location = new System.Drawing.Point(38, 244);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(71, 16);
            this.lblRegStatus.TabIndex = 0;
            this.lblRegStatus.Text = "재적상태";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAddress.Location = new System.Drawing.Point(38, 285);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 16);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "주소";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblContact.Location = new System.Drawing.Point(38, 326);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 16);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "연락처";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(262, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirthYear.Location = new System.Drawing.Point(225, 81);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(23, 16);
            this.lblBirthYear.TabIndex = 0;
            this.lblBirthYear.Text = "년";
            // 
            // lblBirthMonth
            // 
            this.lblBirthMonth.AutoSize = true;
            this.lblBirthMonth.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirthMonth.Location = new System.Drawing.Point(325, 81);
            this.lblBirthMonth.Name = "lblBirthMonth";
            this.lblBirthMonth.Size = new System.Drawing.Size(23, 16);
            this.lblBirthMonth.TabIndex = 0;
            this.lblBirthMonth.Text = "월";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBirthDay.Location = new System.Drawing.Point(410, 81);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(23, 16);
            this.lblBirthDay.TabIndex = 0;
            this.lblBirthDay.Text = "일";
            // 
            // tbxAdvisor
            // 
            this.tbxAdvisor.Location = new System.Drawing.Point(117, 163);
            this.tbxAdvisor.Name = "tbxAdvisor";
            this.tbxAdvisor.Size = new System.Drawing.Size(316, 21);
            this.tbxAdvisor.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClass.Location = new System.Drawing.Point(262, 204);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 16);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "분반";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(117, 286);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(316, 21);
            this.tbxAddress.TabIndex = 1;
            // 
            // tbxContact
            // 
            this.tbxContact.Location = new System.Drawing.Point(117, 327);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(316, 21);
            this.tbxContact.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Location = new System.Drawing.Point(41, 379);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 55);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegister.Location = new System.Drawing.Point(145, 379);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(288, 55);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 12;
            this.lbxDictionary.Location = new System.Drawing.Point(467, 310);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(184, 124);
            this.lbxDictionary.TabIndex = 3;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 12;
            this.lbxList.Location = new System.Drawing.Point(467, 172);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(184, 124);
            this.lbxList.TabIndex = 3;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(117, 122);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(316, 20);
            this.cmbDepartment.TabIndex = 5;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(117, 203);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(102, 20);
            this.cmbYear.TabIndex = 5;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(332, 205);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(98, 20);
            this.cmbClass.TabIndex = 5;
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(117, 244);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(102, 20);
            this.cmbRegStatus.TabIndex = 5;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgDepartment);
            this.tabMain.Controls.Add(this.tpgProfessor);
            this.tabMain.Controls.Add(this.tpgStudent);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(64, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(746, 525);
            this.tabMain.TabIndex = 6;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpgDepartment
            // 
            this.tpgDepartment.Controls.Add(this.btnRegisterDepartment);
            this.tpgDepartment.Controls.Add(this.btnRemoveDepartment);
            this.tpgDepartment.Controls.Add(this.lbxDepartment);
            this.tpgDepartment.Controls.Add(this.label1);
            this.tpgDepartment.Controls.Add(this.label2);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentName);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentCode);
            this.tpgDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpgDepartment.Name = "tpgDepartment";
            this.tpgDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDepartment.Size = new System.Drawing.Size(738, 487);
            this.tpgDepartment.TabIndex = 1;
            this.tpgDepartment.Text = "학과정보";
            this.tpgDepartment.UseVisualStyleBackColor = true;
            // 
            // btnRegisterDepartment
            // 
            this.btnRegisterDepartment.BackColor = System.Drawing.Color.White;
            this.btnRegisterDepartment.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegisterDepartment.Location = new System.Drawing.Point(264, 36);
            this.btnRegisterDepartment.Name = "btnRegisterDepartment";
            this.btnRegisterDepartment.Size = new System.Drawing.Size(109, 61);
            this.btnRegisterDepartment.TabIndex = 7;
            this.btnRegisterDepartment.Text = "등록";
            this.btnRegisterDepartment.UseVisualStyleBackColor = false;
            this.btnRegisterDepartment.Click += new System.EventHandler(this.btnRegisterDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.White;
            this.btnRemoveDepartment.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemoveDepartment.Location = new System.Drawing.Point(571, 398);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(101, 55);
            this.btnRemoveDepartment.TabIndex = 7;
            this.btnRemoveDepartment.Text = "삭제";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.ItemHeight = 12;
            this.lbxDepartment.Location = new System.Drawing.Point(48, 123);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(624, 256);
            this.lbxDepartment.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "학과코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "학과이름";
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Location = new System.Drawing.Point(132, 76);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(101, 21);
            this.tbxDepartmentName.TabIndex = 4;
            // 
            // tbxDepartmentCode
            // 
            this.tbxDepartmentCode.Location = new System.Drawing.Point(132, 36);
            this.tbxDepartmentCode.Name = "tbxDepartmentCode";
            this.tbxDepartmentCode.Size = new System.Drawing.Size(102, 21);
            this.tbxDepartmentCode.TabIndex = 5;
            // 
            // tpgProfessor
            // 
            this.tpgProfessor.Controls.Add(this.btnRegisterProfessor);
            this.tpgProfessor.Controls.Add(this.btnRemoveProfessor);
            this.tpgProfessor.Controls.Add(this.lbxProfessor);
            this.tpgProfessor.Controls.Add(this.label4);
            this.tpgProfessor.Controls.Add(this.label5);
            this.tpgProfessor.Controls.Add(this.tbxProfessorName);
            this.tpgProfessor.Controls.Add(this.tbxProfessorNumber);
            this.tpgProfessor.Controls.Add(this.cmbProfessorDepartment);
            this.tpgProfessor.Controls.Add(this.label3);
            this.tpgProfessor.Location = new System.Drawing.Point(4, 34);
            this.tpgProfessor.Name = "tpgProfessor";
            this.tpgProfessor.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProfessor.Size = new System.Drawing.Size(738, 487);
            this.tpgProfessor.TabIndex = 2;
            this.tpgProfessor.Text = "교수정보";
            this.tpgProfessor.UseVisualStyleBackColor = true;
            // 
            // btnRegisterProfessor
            // 
            this.btnRegisterProfessor.BackColor = System.Drawing.Color.White;
            this.btnRegisterProfessor.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegisterProfessor.Location = new System.Drawing.Point(259, 66);
            this.btnRegisterProfessor.Name = "btnRegisterProfessor";
            this.btnRegisterProfessor.Size = new System.Drawing.Size(109, 61);
            this.btnRegisterProfessor.TabIndex = 13;
            this.btnRegisterProfessor.Text = "등록";
            this.btnRegisterProfessor.UseVisualStyleBackColor = false;
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.BackColor = System.Drawing.Color.White;
            this.btnRemoveProfessor.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemoveProfessor.Location = new System.Drawing.Point(558, 409);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(101, 55);
            this.btnRemoveProfessor.TabIndex = 14;
            this.btnRemoveProfessor.Text = "삭제";
            this.btnRemoveProfessor.UseVisualStyleBackColor = false;
            // 
            // lbxProfessor
            // 
            this.lbxProfessor.FormattingEnabled = true;
            this.lbxProfessor.ItemHeight = 12;
            this.lbxProfessor.Location = new System.Drawing.Point(35, 147);
            this.lbxProfessor.Name = "lbxProfessor";
            this.lbxProfessor.Size = new System.Drawing.Size(624, 256);
            this.lbxProfessor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(32, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "교수번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(32, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "교수이름";
            // 
            // tbxProfessorName
            // 
            this.tbxProfessorName.Location = new System.Drawing.Point(125, 106);
            this.tbxProfessorName.Name = "tbxProfessorName";
            this.tbxProfessorName.Size = new System.Drawing.Size(101, 21);
            this.tbxProfessorName.TabIndex = 10;
            // 
            // tbxProfessorNumber
            // 
            this.tbxProfessorNumber.Location = new System.Drawing.Point(125, 66);
            this.tbxProfessorNumber.Name = "tbxProfessorNumber";
            this.tbxProfessorNumber.Size = new System.Drawing.Size(102, 21);
            this.tbxProfessorNumber.TabIndex = 11;
            // 
            // cmbProfessorDepartment
            // 
            this.cmbProfessorDepartment.FormattingEnabled = true;
            this.cmbProfessorDepartment.Location = new System.Drawing.Point(125, 30);
            this.cmbProfessorDepartment.Name = "cmbProfessorDepartment";
            this.cmbProfessorDepartment.Size = new System.Drawing.Size(243, 20);
            this.cmbProfessorDepartment.TabIndex = 7;
            this.cmbProfessorDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbProfessorDepartment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(32, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "소속학과";
            // 
            // tpgStudent
            // 
            this.tpgStudent.Controls.Add(this.lblNumber);
            this.tpgStudent.Controls.Add(this.cmbClass);
            this.tpgStudent.Controls.Add(this.lblName);
            this.tpgStudent.Controls.Add(this.cmbRegStatus);
            this.tpgStudent.Controls.Add(this.lblClass);
            this.tpgStudent.Controls.Add(this.cmbYear);
            this.tpgStudent.Controls.Add(this.lblBirthYear);
            this.tpgStudent.Controls.Add(this.cmbDepartment);
            this.tpgStudent.Controls.Add(this.lblBirthMonth);
            this.tpgStudent.Controls.Add(this.btnRegister);
            this.tpgStudent.Controls.Add(this.lblBirthDay);
            this.tpgStudent.Controls.Add(this.btnNew);
            this.tpgStudent.Controls.Add(this.lblBirth);
            this.tpgStudent.Controls.Add(this.lbxList);
            this.tpgStudent.Controls.Add(this.lblDepartment);
            this.tpgStudent.Controls.Add(this.lbxDictionary);
            this.tpgStudent.Controls.Add(this.lblAdvisor);
            this.tpgStudent.Controls.Add(this.lbxArray);
            this.tpgStudent.Controls.Add(this.lblYear);
            this.tpgStudent.Controls.Add(this.tbxName);
            this.tpgStudent.Controls.Add(this.lblRegStatus);
            this.tpgStudent.Controls.Add(this.tbxBirthDay);
            this.tpgStudent.Controls.Add(this.lblAddress);
            this.tpgStudent.Controls.Add(this.tbxBirthMonth);
            this.tpgStudent.Controls.Add(this.lblContact);
            this.tpgStudent.Controls.Add(this.tbxContact);
            this.tpgStudent.Controls.Add(this.tbxNumber);
            this.tpgStudent.Controls.Add(this.tbxAddress);
            this.tpgStudent.Controls.Add(this.tbxBirthYear);
            this.tpgStudent.Controls.Add(this.tbxAdvisor);
            this.tpgStudent.Location = new System.Drawing.Point(4, 34);
            this.tpgStudent.Name = "tpgStudent";
            this.tpgStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStudent.Size = new System.Drawing.Size(738, 487);
            this.tpgStudent.TabIndex = 3;
            this.tpgStudent.Text = "학생정보";
            this.tpgStudent.UseVisualStyleBackColor = true;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 525);
            this.Controls.Add(this.tabMain);
            this.Name = "FormManager";
            this.Text = "학생관리";
            this.tabMain.ResumeLayout(false);
            this.tpgDepartment.ResumeLayout(false);
            this.tpgDepartment.PerformLayout();
            this.tpgProfessor.ResumeLayout(false);
            this.tpgProfessor.PerformLayout();
            this.tpgStudent.ResumeLayout(false);
            this.tpgStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblBirthMonth;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.TextBox tbxAdvisor;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxDictionary;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbRegStatus;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgDepartment;
        private System.Windows.Forms.TabPage tpgProfessor;
        private System.Windows.Forms.TabPage tpgStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.TextBox tbxDepartmentCode;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.ListBox lbxDepartment;
        private System.Windows.Forms.Button btnRegisterDepartment;
        private System.Windows.Forms.Button btnRegisterProfessor;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.ListBox lbxProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxProfessorName;
        private System.Windows.Forms.TextBox tbxProfessorNumber;
        private System.Windows.Forms.ComboBox cmbProfessorDepartment;
        private System.Windows.Forms.Label label3;
    }
}

