﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace datalayer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StudentDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertteachers_salary(teachers_salary instance);
    partial void Updateteachers_salary(teachers_salary instance);
    partial void Deleteteachers_salary(teachers_salary instance);
    partial void Insertteacher_information(teacher_information instance);
    partial void Updateteacher_information(teacher_information instance);
    partial void Deleteteacher_information(teacher_information instance);
    partial void Insertstudent_info(student_info instance);
    partial void Updatestudent_info(student_info instance);
    partial void Deletestudent_info(student_info instance);
    partial void Insertrslt(rslt instance);
    partial void Updaterslt(rslt instance);
    partial void Deleterslt(rslt instance);
    partial void Insertlogin(login instance);
    partial void Updatelogin(login instance);
    partial void Deletelogin(login instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::datalayer.Properties.Settings.Default.StudentDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<teachers_salary> teachers_salaries
		{
			get
			{
				return this.GetTable<teachers_salary>();
			}
		}
		
		public System.Data.Linq.Table<teacher_information> teacher_informations
		{
			get
			{
				return this.GetTable<teacher_information>();
			}
		}
		
		public System.Data.Linq.Table<student_info> student_infos
		{
			get
			{
				return this.GetTable<student_info>();
			}
		}
		
		public System.Data.Linq.Table<rslt> rslts
		{
			get
			{
				return this.GetTable<rslt>();
			}
		}
		
		public System.Data.Linq.Table<login> logins
		{
			get
			{
				return this.GetTable<login>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.teachers_salary")]
	public partial class teachers_salary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _type_id;
		
		private string _type;
		
		private System.Nullable<int> _salary;
		
		private EntitySet<teacher_information> _teacher_informations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontype_idChanging(int value);
    partial void Ontype_idChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OnsalaryChanging(System.Nullable<int> value);
    partial void OnsalaryChanged();
    #endregion
		
		public teachers_salary()
		{
			this._teacher_informations = new EntitySet<teacher_information>(new Action<teacher_information>(this.attach_teacher_informations), new Action<teacher_information>(this.detach_teacher_informations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_id", DbType="Int NOT NULL")]
		public int type_id
		{
			get
			{
				return this._type_id;
			}
			set
			{
				if ((this._type_id != value))
				{
					this.Ontype_idChanging(value);
					this.SendPropertyChanging();
					this._type_id = value;
					this.SendPropertyChanged("type_id");
					this.Ontype_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Int")]
		public System.Nullable<int> salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="teachers_salary_teacher_information", Storage="_teacher_informations", ThisKey="type", OtherKey="teacher_type")]
		public EntitySet<teacher_information> teacher_informations
		{
			get
			{
				return this._teacher_informations;
			}
			set
			{
				this._teacher_informations.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_teacher_informations(teacher_information entity)
		{
			this.SendPropertyChanging();
			entity.teachers_salary = this;
		}
		
		private void detach_teacher_informations(teacher_information entity)
		{
			this.SendPropertyChanging();
			entity.teachers_salary = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.teacher_information")]
	public partial class teacher_information : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _teacher_id;
		
		private string _teacher_name;
		
		private string _teacher_address;
		
		private System.Nullable<int> _teacher_phone;
		
		private string _teacher_type;
		
		private string _teacher_gender;
		
		private System.Nullable<int> _teacher_age;
		
		private EntityRef<teachers_salary> _teachers_salary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onteacher_idChanging(int value);
    partial void Onteacher_idChanged();
    partial void Onteacher_nameChanging(string value);
    partial void Onteacher_nameChanged();
    partial void Onteacher_addressChanging(string value);
    partial void Onteacher_addressChanged();
    partial void Onteacher_phoneChanging(System.Nullable<int> value);
    partial void Onteacher_phoneChanged();
    partial void Onteacher_typeChanging(string value);
    partial void Onteacher_typeChanged();
    partial void Onteacher_genderChanging(string value);
    partial void Onteacher_genderChanged();
    partial void Onteacher_ageChanging(System.Nullable<int> value);
    partial void Onteacher_ageChanged();
    #endregion
		
		public teacher_information()
		{
			this._teachers_salary = default(EntityRef<teachers_salary>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int teacher_id
		{
			get
			{
				return this._teacher_id;
			}
			set
			{
				if ((this._teacher_id != value))
				{
					this.Onteacher_idChanging(value);
					this.SendPropertyChanging();
					this._teacher_id = value;
					this.SendPropertyChanged("teacher_id");
					this.Onteacher_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_name", DbType="NVarChar(50)")]
		public string teacher_name
		{
			get
			{
				return this._teacher_name;
			}
			set
			{
				if ((this._teacher_name != value))
				{
					this.Onteacher_nameChanging(value);
					this.SendPropertyChanging();
					this._teacher_name = value;
					this.SendPropertyChanged("teacher_name");
					this.Onteacher_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_address", DbType="NVarChar(50)")]
		public string teacher_address
		{
			get
			{
				return this._teacher_address;
			}
			set
			{
				if ((this._teacher_address != value))
				{
					this.Onteacher_addressChanging(value);
					this.SendPropertyChanging();
					this._teacher_address = value;
					this.SendPropertyChanged("teacher_address");
					this.Onteacher_addressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_phone", DbType="Int")]
		public System.Nullable<int> teacher_phone
		{
			get
			{
				return this._teacher_phone;
			}
			set
			{
				if ((this._teacher_phone != value))
				{
					this.Onteacher_phoneChanging(value);
					this.SendPropertyChanging();
					this._teacher_phone = value;
					this.SendPropertyChanged("teacher_phone");
					this.Onteacher_phoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_type", DbType="NVarChar(50)")]
		public string teacher_type
		{
			get
			{
				return this._teacher_type;
			}
			set
			{
				if ((this._teacher_type != value))
				{
					if (this._teachers_salary.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onteacher_typeChanging(value);
					this.SendPropertyChanging();
					this._teacher_type = value;
					this.SendPropertyChanged("teacher_type");
					this.Onteacher_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_gender", DbType="NVarChar(50)")]
		public string teacher_gender
		{
			get
			{
				return this._teacher_gender;
			}
			set
			{
				if ((this._teacher_gender != value))
				{
					this.Onteacher_genderChanging(value);
					this.SendPropertyChanging();
					this._teacher_gender = value;
					this.SendPropertyChanged("teacher_gender");
					this.Onteacher_genderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher_age", DbType="Int")]
		public System.Nullable<int> teacher_age
		{
			get
			{
				return this._teacher_age;
			}
			set
			{
				if ((this._teacher_age != value))
				{
					this.Onteacher_ageChanging(value);
					this.SendPropertyChanging();
					this._teacher_age = value;
					this.SendPropertyChanged("teacher_age");
					this.Onteacher_ageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="teachers_salary_teacher_information", Storage="_teachers_salary", ThisKey="teacher_type", OtherKey="type", IsForeignKey=true)]
		public teachers_salary teachers_salary
		{
			get
			{
				return this._teachers_salary.Entity;
			}
			set
			{
				teachers_salary previousValue = this._teachers_salary.Entity;
				if (((previousValue != value) 
							|| (this._teachers_salary.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._teachers_salary.Entity = null;
						previousValue.teacher_informations.Remove(this);
					}
					this._teachers_salary.Entity = value;
					if ((value != null))
					{
						value.teacher_informations.Add(this);
						this._teacher_type = value.type;
					}
					else
					{
						this._teacher_type = default(string);
					}
					this.SendPropertyChanged("teachers_salary");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student_info")]
	public partial class student_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _s_class;
		
		private int _id;
		
		private string _name;
		
		private int _contactno;
		
		private string _address;
		
		private int _age;
		
		private string _register;
		
		private string _gender;
		
		private string _father;
		
		private string _mother;
		
		private int _contact;
		
		private System.Nullable<int> _amount;
		
		private System.Nullable<int> _paid;
		
		private System.Nullable<int> _payable;
		
		private EntitySet<rslt> _rslts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ons_classChanging(string value);
    partial void Ons_classChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncontactnoChanging(int value);
    partial void OncontactnoChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnageChanging(int value);
    partial void OnageChanged();
    partial void OnregisterChanging(string value);
    partial void OnregisterChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnfatherChanging(string value);
    partial void OnfatherChanged();
    partial void OnmotherChanging(string value);
    partial void OnmotherChanged();
    partial void OncontactChanging(int value);
    partial void OncontactChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    partial void OnpaidChanging(System.Nullable<int> value);
    partial void OnpaidChanged();
    partial void OnpayableChanging(System.Nullable<int> value);
    partial void OnpayableChanged();
    #endregion
		
		public student_info()
		{
			this._rslts = new EntitySet<rslt>(new Action<rslt>(this.attach_rslts), new Action<rslt>(this.detach_rslts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_s_class", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string s_class
		{
			get
			{
				return this._s_class;
			}
			set
			{
				if ((this._s_class != value))
				{
					this.Ons_classChanging(value);
					this.SendPropertyChanging();
					this._s_class = value;
					this.SendPropertyChanged("s_class");
					this.Ons_classChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactno", DbType="Int NOT NULL")]
		public int contactno
		{
			get
			{
				return this._contactno;
			}
			set
			{
				if ((this._contactno != value))
				{
					this.OncontactnoChanging(value);
					this.SendPropertyChanging();
					this._contactno = value;
					this.SendPropertyChanged("contactno");
					this.OncontactnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int NOT NULL")]
		public int age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_register", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string register
		{
			get
			{
				return this._register;
			}
			set
			{
				if ((this._register != value))
				{
					this.OnregisterChanging(value);
					this.SendPropertyChanging();
					this._register = value;
					this.SendPropertyChanged("register");
					this.OnregisterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_father", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string father
		{
			get
			{
				return this._father;
			}
			set
			{
				if ((this._father != value))
				{
					this.OnfatherChanging(value);
					this.SendPropertyChanging();
					this._father = value;
					this.SendPropertyChanged("father");
					this.OnfatherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mother", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string mother
		{
			get
			{
				return this._mother;
			}
			set
			{
				if ((this._mother != value))
				{
					this.OnmotherChanging(value);
					this.SendPropertyChanging();
					this._mother = value;
					this.SendPropertyChanged("mother");
					this.OnmotherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact", DbType="Int NOT NULL")]
		public int contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				if ((this._contact != value))
				{
					this.OncontactChanging(value);
					this.SendPropertyChanging();
					this._contact = value;
					this.SendPropertyChanged("contact");
					this.OncontactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paid", DbType="Int")]
		public System.Nullable<int> paid
		{
			get
			{
				return this._paid;
			}
			set
			{
				if ((this._paid != value))
				{
					this.OnpaidChanging(value);
					this.SendPropertyChanging();
					this._paid = value;
					this.SendPropertyChanged("paid");
					this.OnpaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payable", DbType="Int")]
		public System.Nullable<int> payable
		{
			get
			{
				return this._payable;
			}
			set
			{
				if ((this._payable != value))
				{
					this.OnpayableChanging(value);
					this.SendPropertyChanging();
					this._payable = value;
					this.SendPropertyChanged("payable");
					this.OnpayableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_info_rslt", Storage="_rslts", ThisKey="id", OtherKey="s_id")]
		public EntitySet<rslt> rslts
		{
			get
			{
				return this._rslts;
			}
			set
			{
				this._rslts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_rslts(rslt entity)
		{
			this.SendPropertyChanging();
			entity.student_info = this;
		}
		
		private void detach_rslts(rslt entity)
		{
			this.SendPropertyChanging();
			entity.student_info = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.rslt")]
	public partial class rslt : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _r_id;
		
		private int _s_id;
		
		private System.Nullable<int> _math;
		
		private System.Nullable<int> _english;
		
		private System.Nullable<int> _bangla;
		
		private System.Nullable<int> _science;
		
		private System.Nullable<int> _total_mark;
		
		private EntityRef<student_info> _student_info;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onr_idChanging(int value);
    partial void Onr_idChanged();
    partial void Ons_idChanging(int value);
    partial void Ons_idChanged();
    partial void OnmathChanging(System.Nullable<int> value);
    partial void OnmathChanged();
    partial void OnenglishChanging(System.Nullable<int> value);
    partial void OnenglishChanged();
    partial void OnbanglaChanging(System.Nullable<int> value);
    partial void OnbanglaChanged();
    partial void OnscienceChanging(System.Nullable<int> value);
    partial void OnscienceChanged();
    partial void Ontotal_markChanging(System.Nullable<int> value);
    partial void Ontotal_markChanged();
    #endregion
		
		public rslt()
		{
			this._student_info = default(EntityRef<student_info>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_r_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int r_id
		{
			get
			{
				return this._r_id;
			}
			set
			{
				if ((this._r_id != value))
				{
					this.Onr_idChanging(value);
					this.SendPropertyChanging();
					this._r_id = value;
					this.SendPropertyChanged("r_id");
					this.Onr_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_s_id", DbType="Int NOT NULL")]
		public int s_id
		{
			get
			{
				return this._s_id;
			}
			set
			{
				if ((this._s_id != value))
				{
					if (this._student_info.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ons_idChanging(value);
					this.SendPropertyChanging();
					this._s_id = value;
					this.SendPropertyChanged("s_id");
					this.Ons_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_math", DbType="Int")]
		public System.Nullable<int> math
		{
			get
			{
				return this._math;
			}
			set
			{
				if ((this._math != value))
				{
					this.OnmathChanging(value);
					this.SendPropertyChanging();
					this._math = value;
					this.SendPropertyChanged("math");
					this.OnmathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_english", DbType="Int")]
		public System.Nullable<int> english
		{
			get
			{
				return this._english;
			}
			set
			{
				if ((this._english != value))
				{
					this.OnenglishChanging(value);
					this.SendPropertyChanging();
					this._english = value;
					this.SendPropertyChanged("english");
					this.OnenglishChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bangla", DbType="Int")]
		public System.Nullable<int> bangla
		{
			get
			{
				return this._bangla;
			}
			set
			{
				if ((this._bangla != value))
				{
					this.OnbanglaChanging(value);
					this.SendPropertyChanging();
					this._bangla = value;
					this.SendPropertyChanged("bangla");
					this.OnbanglaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_science", DbType="Int")]
		public System.Nullable<int> science
		{
			get
			{
				return this._science;
			}
			set
			{
				if ((this._science != value))
				{
					this.OnscienceChanging(value);
					this.SendPropertyChanging();
					this._science = value;
					this.SendPropertyChanged("science");
					this.OnscienceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_mark", DbType="Int")]
		public System.Nullable<int> total_mark
		{
			get
			{
				return this._total_mark;
			}
			set
			{
				if ((this._total_mark != value))
				{
					this.Ontotal_markChanging(value);
					this.SendPropertyChanging();
					this._total_mark = value;
					this.SendPropertyChanged("total_mark");
					this.Ontotal_markChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_info_rslt", Storage="_student_info", ThisKey="s_id", OtherKey="id", IsForeignKey=true)]
		public student_info student_info
		{
			get
			{
				return this._student_info.Entity;
			}
			set
			{
				student_info previousValue = this._student_info.Entity;
				if (((previousValue != value) 
							|| (this._student_info.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student_info.Entity = null;
						previousValue.rslts.Remove(this);
					}
					this._student_info.Entity = value;
					if ((value != null))
					{
						value.rslts.Add(this);
						this._s_id = value.id;
					}
					else
					{
						this._s_id = default(int);
					}
					this.SendPropertyChanged("student_info");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.login")]
	public partial class login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_id;
		
		private string _user_name;
		
		private string _user_password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Onuser_nameChanging(string value);
    partial void Onuser_nameChanged();
    partial void Onuser_passwordChanging(string value);
    partial void Onuser_passwordChanged();
    #endregion
		
		public login()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string user_name
		{
			get
			{
				return this._user_name;
			}
			set
			{
				if ((this._user_name != value))
				{
					this.Onuser_nameChanging(value);
					this.SendPropertyChanging();
					this._user_name = value;
					this.SendPropertyChanged("user_name");
					this.Onuser_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string user_password
		{
			get
			{
				return this._user_password;
			}
			set
			{
				if ((this._user_password != value))
				{
					this.Onuser_passwordChanging(value);
					this.SendPropertyChanging();
					this._user_password = value;
					this.SendPropertyChanged("user_password");
					this.Onuser_passwordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
