<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maindesk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maindesk))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add_new_book = New System.Windows.Forms.Button()
        Me.btn_renewal_sub = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_add_new_person = New System.Windows.Forms.Button()
        Me.btn_borrow_book = New System.Windows.Forms.Button()
        Me.btn_renewal = New System.Windows.Forms.Button()
        Me.btn_setting_person = New System.Windows.Forms.Button()
        Me.btn_add_sub = New System.Windows.Forms.Button()
        Me.btn_authors = New System.Windows.Forms.Button()
        Me.btn_translator = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcardnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandlinenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcceptedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditeddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aseman_library_vbDataSet2 = New rc_library.aseman_library_vbDataSet2()
        Me.MakepjDataSet = New rc_library.makepjDataSet()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New rc_library.makepjDataSetTableAdapters.personTableAdapter()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.MakepjDataSet1 = New rc_library.makepjDataSet()
        Me.Aseman_library_vbDataSet = New rc_library.aseman_library_vbDataSet()
        Me.PersonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter1 = New rc_library.aseman_library_vbDataSetTableAdapters.personTableAdapter()
        Me.PersonTableAdapter2 = New rc_library.aseman_library_vbDataSet2TableAdapters.personTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aseman_library_vbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakepjDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakepjDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aseman_library_vbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vazir", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "سیستم مدیریت کتابخانه"
        '
        'btn_add_new_book
        '
        Me.btn_add_new_book.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_book.Location = New System.Drawing.Point(561, 254)
        Me.btn_add_new_book.Name = "btn_add_new_book"
        Me.btn_add_new_book.Size = New System.Drawing.Size(179, 41)
        Me.btn_add_new_book.TabIndex = 1
        Me.btn_add_new_book.Text = "ثبت کتاب جدید"
        Me.btn_add_new_book.UseVisualStyleBackColor = True
        '
        'btn_renewal_sub
        '
        Me.btn_renewal_sub.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_renewal_sub.Location = New System.Drawing.Point(280, 314)
        Me.btn_renewal_sub.Name = "btn_renewal_sub"
        Me.btn_renewal_sub.Size = New System.Drawing.Size(179, 41)
        Me.btn_renewal_sub.TabIndex = 3
        Me.btn_renewal_sub.Text = "تمدید عضویت "
        Me.btn_renewal_sub.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vazir", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(589, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "عملیات کتاب"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vazir", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "عملیات اشخاص"
        '
        'btn_add_new_person
        '
        Me.btn_add_new_person.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_person.Location = New System.Drawing.Point(280, 196)
        Me.btn_add_new_person.Name = "btn_add_new_person"
        Me.btn_add_new_person.Size = New System.Drawing.Size(179, 41)
        Me.btn_add_new_person.TabIndex = 6
        Me.btn_add_new_person.Text = "ثبت شخص جدید الورود"
        Me.btn_add_new_person.UseVisualStyleBackColor = True
        '
        'btn_borrow_book
        '
        Me.btn_borrow_book.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrow_book.Location = New System.Drawing.Point(561, 314)
        Me.btn_borrow_book.Name = "btn_borrow_book"
        Me.btn_borrow_book.Size = New System.Drawing.Size(179, 41)
        Me.btn_borrow_book.TabIndex = 7
        Me.btn_borrow_book.Text = "امانت کتاب"
        Me.btn_borrow_book.UseVisualStyleBackColor = True
        '
        'btn_renewal
        '
        Me.btn_renewal.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_renewal.Location = New System.Drawing.Point(561, 387)
        Me.btn_renewal.Name = "btn_renewal"
        Me.btn_renewal.Size = New System.Drawing.Size(179, 41)
        Me.btn_renewal.TabIndex = 8
        Me.btn_renewal.Text = "تمدید امانت"
        Me.btn_renewal.UseVisualStyleBackColor = True
        '
        'btn_setting_person
        '
        Me.btn_setting_person.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setting_person.Location = New System.Drawing.Point(280, 387)
        Me.btn_setting_person.Name = "btn_setting_person"
        Me.btn_setting_person.Size = New System.Drawing.Size(179, 41)
        Me.btn_setting_person.TabIndex = 9
        Me.btn_setting_person.Text = "تنظیمات اشخاص"
        Me.btn_setting_person.UseVisualStyleBackColor = True
        '
        'btn_add_sub
        '
        Me.btn_add_sub.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_sub.Location = New System.Drawing.Point(280, 254)
        Me.btn_add_sub.Name = "btn_add_sub"
        Me.btn_add_sub.Size = New System.Drawing.Size(179, 41)
        Me.btn_add_sub.TabIndex = 10
        Me.btn_add_sub.Text = "ثبت عضویت"
        Me.btn_add_sub.UseVisualStyleBackColor = True
        '
        'btn_authors
        '
        Me.btn_authors.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authors.Location = New System.Drawing.Point(667, 196)
        Me.btn_authors.Name = "btn_authors"
        Me.btn_authors.Size = New System.Drawing.Size(73, 41)
        Me.btn_authors.TabIndex = 11
        Me.btn_authors.Text = "نویسنده"
        Me.btn_authors.UseVisualStyleBackColor = True
        '
        'btn_translator
        '
        Me.btn_translator.Font = New System.Drawing.Font("Vazir", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_translator.Location = New System.Drawing.Point(561, 196)
        Me.btn_translator.Name = "btn_translator"
        Me.btn_translator.Size = New System.Drawing.Size(73, 41)
        Me.btn_translator.TabIndex = 12
        Me.btn_translator.Text = "مترجم"
        Me.btn_translator.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.IdcardnumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.LandlinenumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.UseridDataGridViewTextBoxColumn, Me.AcceptedDataGridViewTextBoxColumn, Me.CreateddateDataGridViewTextBoxColumn, Me.DeleteddateDataGridViewTextBoxColumn, Me.EditeddateDataGridViewTextBoxColumn, Me.GroupidDataGridViewTextBoxColumn, Me.RoleidDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'IdcardnumberDataGridViewTextBoxColumn
        '
        Me.IdcardnumberDataGridViewTextBoxColumn.DataPropertyName = "id_card_number"
        Me.IdcardnumberDataGridViewTextBoxColumn.HeaderText = "id_card_number"
        Me.IdcardnumberDataGridViewTextBoxColumn.Name = "IdcardnumberDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        '
        'LandlinenumberDataGridViewTextBoxColumn
        '
        Me.LandlinenumberDataGridViewTextBoxColumn.DataPropertyName = "landline_number"
        Me.LandlinenumberDataGridViewTextBoxColumn.HeaderText = "landline_number"
        Me.LandlinenumberDataGridViewTextBoxColumn.Name = "LandlinenumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "birth_date"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "birth_date"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "user_id"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        '
        'AcceptedDataGridViewTextBoxColumn
        '
        Me.AcceptedDataGridViewTextBoxColumn.DataPropertyName = "accepted"
        Me.AcceptedDataGridViewTextBoxColumn.HeaderText = "accepted"
        Me.AcceptedDataGridViewTextBoxColumn.Name = "AcceptedDataGridViewTextBoxColumn"
        '
        'CreateddateDataGridViewTextBoxColumn
        '
        Me.CreateddateDataGridViewTextBoxColumn.DataPropertyName = "created_date"
        Me.CreateddateDataGridViewTextBoxColumn.HeaderText = "created_date"
        Me.CreateddateDataGridViewTextBoxColumn.Name = "CreateddateDataGridViewTextBoxColumn"
        '
        'DeleteddateDataGridViewTextBoxColumn
        '
        Me.DeleteddateDataGridViewTextBoxColumn.DataPropertyName = "deleted_date"
        Me.DeleteddateDataGridViewTextBoxColumn.HeaderText = "deleted_date"
        Me.DeleteddateDataGridViewTextBoxColumn.Name = "DeleteddateDataGridViewTextBoxColumn"
        '
        'EditeddateDataGridViewTextBoxColumn
        '
        Me.EditeddateDataGridViewTextBoxColumn.DataPropertyName = "edited_date"
        Me.EditeddateDataGridViewTextBoxColumn.HeaderText = "edited_date"
        Me.EditeddateDataGridViewTextBoxColumn.Name = "EditeddateDataGridViewTextBoxColumn"
        '
        'GroupidDataGridViewTextBoxColumn
        '
        Me.GroupidDataGridViewTextBoxColumn.DataPropertyName = "group_id"
        Me.GroupidDataGridViewTextBoxColumn.HeaderText = "group_id"
        Me.GroupidDataGridViewTextBoxColumn.Name = "GroupidDataGridViewTextBoxColumn"
        '
        'RoleidDataGridViewTextBoxColumn
        '
        Me.RoleidDataGridViewTextBoxColumn.DataPropertyName = "role_id"
        Me.RoleidDataGridViewTextBoxColumn.HeaderText = "role_id"
        Me.RoleidDataGridViewTextBoxColumn.Name = "RoleidDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'PersonBindingSource2
        '
        Me.PersonBindingSource2.DataMember = "person"
        Me.PersonBindingSource2.DataSource = Me.Aseman_library_vbDataSet2
        '
        'Aseman_library_vbDataSet2
        '
        Me.Aseman_library_vbDataSet2.DataSetName = "aseman_library_vbDataSet2"
        Me.Aseman_library_vbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MakepjDataSet
        '
        Me.MakepjDataSet.DataSetName = "makepjDataSet"
        Me.MakepjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "person"
        Me.PersonBindingSource.DataSource = Me.MakepjDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(100, 314)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'MakepjDataSet1
        '
        Me.MakepjDataSet1.DataSetName = "makepjDataSet"
        Me.MakepjDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Aseman_library_vbDataSet
        '
        Me.Aseman_library_vbDataSet.DataSetName = "aseman_library_vbDataSet"
        Me.Aseman_library_vbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource1
        '
        Me.PersonBindingSource1.DataMember = "person"
        Me.PersonBindingSource1.DataSource = Me.Aseman_library_vbDataSet
        '
        'PersonTableAdapter1
        '
        Me.PersonTableAdapter1.ClearBeforeFill = True
        '
        'PersonTableAdapter2
        '
        Me.PersonTableAdapter2.ClearBeforeFill = True
        '
        'maindesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 440)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_translator)
        Me.Controls.Add(Me.btn_authors)
        Me.Controls.Add(Me.btn_add_sub)
        Me.Controls.Add(Me.btn_setting_person)
        Me.Controls.Add(Me.btn_renewal)
        Me.Controls.Add(Me.btn_borrow_book)
        Me.Controls.Add(Me.btn_add_new_person)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_renewal_sub)
        Me.Controls.Add(Me.btn_add_new_book)
        Me.Controls.Add(Me.Label1)
        Me.Name = "maindesk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "maindesk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aseman_library_vbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakepjDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakepjDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aseman_library_vbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_add_new_book As System.Windows.Forms.Button
    Friend WithEvents btn_renewal_sub As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_add_new_person As System.Windows.Forms.Button
    Friend WithEvents btn_borrow_book As System.Windows.Forms.Button
    Friend WithEvents btn_renewal As System.Windows.Forms.Button
    Friend WithEvents btn_setting_person As System.Windows.Forms.Button
    Friend WithEvents btn_add_sub As System.Windows.Forms.Button
    Friend WithEvents btn_authors As System.Windows.Forms.Button
    Friend WithEvents btn_translator As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MakepjDataSet As rc_library.makepjDataSet
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As rc_library.makepjDataSetTableAdapters.personTableAdapter
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents MakepjDataSet1 As rc_library.makepjDataSet
    Friend WithEvents Aseman_library_vbDataSet As rc_library.aseman_library_vbDataSet
    Friend WithEvents PersonBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter1 As rc_library.aseman_library_vbDataSetTableAdapters.personTableAdapter
    Friend WithEvents Aseman_library_vbDataSet2 As rc_library.aseman_library_vbDataSet2
    Friend WithEvents PersonBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter2 As rc_library.aseman_library_vbDataSet2TableAdapters.personTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcardnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandlinenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UseridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcceptedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditeddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
