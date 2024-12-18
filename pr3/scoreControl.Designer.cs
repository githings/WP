﻿namespace pr3
{
    partial class ScoreControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.btnDeleteScore = new System.Windows.Forms.Button();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtFinalTerm = new System.Windows.Forms.TextBox();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.lblFinalTerm = new System.Windows.Forms.Label();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IbltxtYear = new System.Windows.Forms.Label();
            this.IbltxtSemester = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lectureComboBox = new System.Windows.Forms.ComboBox();
            this.EnrollmentDataGridView = new System.Windows.Forms.DataGridView();
            this.EnrollmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScores
            // 
            this.dgvScores.AllowUserToAddRows = false;
            this.dgvScores.AllowUserToDeleteRows = false;
            this.dgvScores.AutoGenerateColumns = false;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LectureId,
            this.LectureName,
            this.midTermDataGridViewTextBoxColumn,
            this.finalTermDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn});
            this.dgvScores.DataSource = this.registrationBindingSource;
            this.dgvScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScores.Location = new System.Drawing.Point(453, 3);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = true;
            this.dgvScores.RowHeadersWidth = 51;
            this.dgvScores.RowTemplate.Height = 24;
            this.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScores.Size = new System.Drawing.Size(4915, 544);
            this.dgvScores.TabIndex = 30;
            this.dgvScores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScores_CellDoubleClick);
            // 
            // btnDeleteScore
            // 
            this.btnDeleteScore.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeleteScore.Location = new System.Drawing.Point(250, 458);
            this.btnDeleteScore.Name = "btnDeleteScore";
            this.btnDeleteScore.Size = new System.Drawing.Size(103, 42);
            this.btnDeleteScore.TabIndex = 10;
            this.btnDeleteScore.Text = "삭제";
            this.btnDeleteScore.UseVisualStyleBackColor = true;
            this.btnDeleteScore.Click += new System.EventHandler(this.btnDeleteScore_Click);
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdateScore.Location = new System.Drawing.Point(142, 458);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(103, 42);
            this.btnUpdateScore.TabIndex = 10;
            this.btnUpdateScore.Text = "수정";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddScore.Location = new System.Drawing.Point(33, 458);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(103, 42);
            this.btnAddScore.TabIndex = 9;
            this.btnAddScore.Text = "추가";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // txtAttendance
            // 
            this.txtAttendance.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAttendance.Location = new System.Drawing.Point(165, 388);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(205, 40);
            this.txtAttendance.TabIndex = 8;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentName.Location = new System.Drawing.Point(165, 94);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(205, 40);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentId.Location = new System.Drawing.Point(165, 45);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(205, 40);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAttendance.Location = new System.Drawing.Point(29, 392);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(77, 28);
            this.lblAttendance.TabIndex = 22;
            this.lblAttendance.Text = "출석:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubject.Location = new System.Drawing.Point(29, 245);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(77, 28);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "과목:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentName.Location = new System.Drawing.Point(29, 98);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(77, 28);
            this.lblStudentName.TabIndex = 18;
            this.lblStudentName.Text = "이름:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentId.Location = new System.Drawing.Point(29, 49);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(136, 28);
            this.lblStudentId.TabIndex = 16;
            this.lblStudentId.Text = "학번 (ID):";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // txtFinalTerm
            // 
            this.txtFinalTerm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFinalTerm.Location = new System.Drawing.Point(165, 339);
            this.txtFinalTerm.Name = "txtFinalTerm";
            this.txtFinalTerm.Size = new System.Drawing.Size(205, 40);
            this.txtFinalTerm.TabIndex = 7;
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMidTerm.Location = new System.Drawing.Point(165, 290);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(205, 40);
            this.txtMidTerm.TabIndex = 6;
            // 
            // lblFinalTerm
            // 
            this.lblFinalTerm.AutoSize = true;
            this.lblFinalTerm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFinalTerm.Location = new System.Drawing.Point(29, 343);
            this.lblFinalTerm.Name = "lblFinalTerm";
            this.lblFinalTerm.Size = new System.Drawing.Size(142, 28);
            this.lblFinalTerm.TabIndex = 34;
            this.lblFinalTerm.Text = "기말 고사:";
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMidTerm.Location = new System.Drawing.Point(29, 294);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(142, 28);
            this.lblMidTerm.TabIndex = 32;
            this.lblMidTerm.Text = "중간 고사:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(453, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4915, 2775);
            this.panel1.TabIndex = 32;
            // 
            // IbltxtYear
            // 
            this.IbltxtYear.AutoSize = true;
            this.IbltxtYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IbltxtYear.Location = new System.Drawing.Point(29, 147);
            this.IbltxtYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbltxtYear.Name = "IbltxtYear";
            this.IbltxtYear.Size = new System.Drawing.Size(105, 28);
            this.IbltxtYear.TabIndex = 36;
            this.IbltxtYear.Text = "학년도:";
            // 
            // IbltxtSemester
            // 
            this.IbltxtSemester.AutoSize = true;
            this.IbltxtSemester.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IbltxtSemester.Location = new System.Drawing.Point(29, 196);
            this.IbltxtSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbltxtSemester.Name = "IbltxtSemester";
            this.IbltxtSemester.Size = new System.Drawing.Size(77, 28);
            this.IbltxtSemester.TabIndex = 37;
            this.IbltxtSemester.Text = "학기:";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtYear.Location = new System.Drawing.Point(165, 143);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(205, 40);
            this.txtYear.TabIndex = 3;
            // 
            // txtsemester
            // 
            this.txtsemester.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsemester.Location = new System.Drawing.Point(165, 192);
            this.txtsemester.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(205, 40);
            this.txtsemester.TabIndex = 4;
            // 
            // lectureComboBox
            // 
            this.lectureComboBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lectureComboBox.FormattingEnabled = true;
            this.lectureComboBox.ItemHeight = 28;
            this.lectureComboBox.Location = new System.Drawing.Point(165, 241);
            this.lectureComboBox.MaxDropDownItems = 12;
            this.lectureComboBox.Name = "lectureComboBox";
            this.lectureComboBox.Size = new System.Drawing.Size(205, 36);
            this.lectureComboBox.TabIndex = 5;
            // 
            // EnrollmentDataGridView
            // 
            this.EnrollmentDataGridView.AllowUserToAddRows = false;
            this.EnrollmentDataGridView.AllowUserToDeleteRows = false;
            this.EnrollmentDataGridView.AutoGenerateColumns = false;
            this.EnrollmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnrollmentId,
            this.yearDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.EnrollmentDataGridView.DataSource = this.enrollmentBindingSource;
            this.EnrollmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnrollmentDataGridView.Location = new System.Drawing.Point(3, 553);
            this.EnrollmentDataGridView.Name = "EnrollmentDataGridView";
            this.EnrollmentDataGridView.ReadOnly = true;
            this.EnrollmentDataGridView.RowHeadersWidth = 72;
            this.EnrollmentDataGridView.RowTemplate.Height = 34;
            this.EnrollmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnrollmentDataGridView.Size = new System.Drawing.Size(444, 2775);
            this.EnrollmentDataGridView.TabIndex = 41;
            this.EnrollmentDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnrollmentDataGridView_CellDoubleClick);
            // 
            // EnrollmentId
            // 
            this.EnrollmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnrollmentId.DataPropertyName = "Id";
            this.EnrollmentId.HeaderText = "Id";
            this.EnrollmentId.MinimumWidth = 9;
            this.EnrollmentId.Name = "EnrollmentId";
            this.EnrollmentId.ReadOnly = true;
            this.EnrollmentId.Visible = false;
            this.EnrollmentId.Width = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvScores, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EnrollmentDataGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(5371, 3331);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.txtMidTerm);
            this.groupBox1.Controls.Add(this.lblStudentId);
            this.groupBox1.Controls.Add(this.lectureComboBox);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.txtsemester);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.lblAttendance);
            this.groupBox1.Controls.Add(this.IbltxtSemester);
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.IbltxtYear);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtFinalTerm);
            this.groupBox1.Controls.Add(this.txtAttendance);
            this.groupBox1.Controls.Add(this.btnAddScore);
            this.groupBox1.Controls.Add(this.lblFinalTerm);
            this.groupBox1.Controls.Add(this.btnUpdateScore);
            this.groupBox1.Controls.Add(this.lblMidTerm);
            this.groupBox1.Controls.Add(this.btnDeleteScore);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 13F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 544);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생 성적 관리";
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataSource = typeof(pr3.Registration);
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "년도";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "학기";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(pr3.Enrollment);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // LectureId
            // 
            this.LectureId.DataPropertyName = "LectureId";
            this.LectureId.HeaderText = "LectureId";
            this.LectureId.MinimumWidth = 9;
            this.LectureId.Name = "LectureId";
            this.LectureId.ReadOnly = true;
            this.LectureId.Visible = false;
            this.LectureId.Width = 175;
            // 
            // LectureName
            // 
            this.LectureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LectureName.DataPropertyName = "LectureName";
            this.LectureName.HeaderText = "교과명";
            this.LectureName.MinimumWidth = 9;
            this.LectureName.Name = "LectureName";
            this.LectureName.ReadOnly = true;
            // 
            // midTermDataGridViewTextBoxColumn
            // 
            this.midTermDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.midTermDataGridViewTextBoxColumn.DataPropertyName = "MidTerm";
            this.midTermDataGridViewTextBoxColumn.HeaderText = "중간고사";
            this.midTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midTermDataGridViewTextBoxColumn.Name = "midTermDataGridViewTextBoxColumn";
            this.midTermDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalTermDataGridViewTextBoxColumn
            // 
            this.finalTermDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finalTermDataGridViewTextBoxColumn.DataPropertyName = "FinalTerm";
            this.finalTermDataGridViewTextBoxColumn.HeaderText = "기말고사";
            this.finalTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalTermDataGridViewTextBoxColumn.Name = "finalTermDataGridViewTextBoxColumn";
            this.finalTermDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "출석";
            this.attendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ScoreControl";
            this.Size = new System.Drawing.Size(5371, 3331);
            this.Load += new System.EventHandler(this.ScoreControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.Button btnDeleteScore;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtFinalTerm;
        private System.Windows.Forms.TextBox txtMidTerm;
        private System.Windows.Forms.Label lblFinalTerm;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IbltxtYear;
        private System.Windows.Forms.Label IbltxtSemester;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.ComboBox lectureComboBox;
        private System.Windows.Forms.DataGridView EnrollmentDataGridView;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn midTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
    }
}
