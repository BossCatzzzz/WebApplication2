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

namespace WebApplication2.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QUANLYSANPHAM2")]
	public partial class Model2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertLOAISANPHAM(LOAISANPHAM instance);
    partial void UpdateLOAISANPHAM(LOAISANPHAM instance);
    partial void DeleteLOAISANPHAM(LOAISANPHAM instance);
    #endregion
		
		public Model2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QUANLYSANPHAM2ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Model2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Model2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Model2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Model2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<LOAISANPHAM> LOAISANPHAMs
		{
			get
			{
				return this.GetTable<LOAISANPHAM>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.XoaSP")]
		public int XoaSP([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string masp)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), masp);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CapNhatGia")]
		public int CapNhatGia([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string masp, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> giamoi)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), masp, giamoi);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LayAllSP")]
		public ISingleResult<LayAllSPResult> LayAllSP()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<LayAllSPResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LayMotSP")]
		public ISingleResult<LayMotSPResult> LayMotSP([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string masp)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), masp);
			return ((ISingleResult<LayMotSPResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ThemSP")]
		public int ThemSP([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string masp, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string tensp, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> ma_loai, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string hinh, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> gia)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), masp, tensp, ma_loai, hinh, gia);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ID_LOAI;
		
		private string _MASANPHAM;
		
		private string _TENSANPHAM;
		
		private string _HINHANH;
		
		private int _DONGIA;
		
		private EntityRef<LOAISANPHAM> _LOAISANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnID_LOAIChanging(int value);
    partial void OnID_LOAIChanged();
    partial void OnMASANPHAMChanging(string value);
    partial void OnMASANPHAMChanged();
    partial void OnTENSANPHAMChanging(string value);
    partial void OnTENSANPHAMChanged();
    partial void OnHINHANHChanging(string value);
    partial void OnHINHANHChanged();
    partial void OnDONGIAChanging(int value);
    partial void OnDONGIAChanged();
    #endregion
		
		public SANPHAM()
		{
			this._LOAISANPHAM = default(EntityRef<LOAISANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_LOAI", DbType="Int NOT NULL")]
		public int ID_LOAI
		{
			get
			{
				return this._ID_LOAI;
			}
			set
			{
				if ((this._ID_LOAI != value))
				{
					if (this._LOAISANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_LOAIChanging(value);
					this.SendPropertyChanging();
					this._ID_LOAI = value;
					this.SendPropertyChanged("ID_LOAI");
					this.OnID_LOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASANPHAM", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MASANPHAM
		{
			get
			{
				return this._MASANPHAM;
			}
			set
			{
				if ((this._MASANPHAM != value))
				{
					this.OnMASANPHAMChanging(value);
					this.SendPropertyChanging();
					this._MASANPHAM = value;
					this.SendPropertyChanged("MASANPHAM");
					this.OnMASANPHAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSANPHAM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENSANPHAM
		{
			get
			{
				return this._TENSANPHAM;
			}
			set
			{
				if ((this._TENSANPHAM != value))
				{
					this.OnTENSANPHAMChanging(value);
					this.SendPropertyChanging();
					this._TENSANPHAM = value;
					this.SendPropertyChanged("TENSANPHAM");
					this.OnTENSANPHAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HINHANH", DbType="NVarChar(MAX)")]
		public string HINHANH
		{
			get
			{
				return this._HINHANH;
			}
			set
			{
				if ((this._HINHANH != value))
				{
					this.OnHINHANHChanging(value);
					this.SendPropertyChanging();
					this._HINHANH = value;
					this.SendPropertyChanged("HINHANH");
					this.OnHINHANHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int NOT NULL")]
		public int DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISANPHAM_SANPHAM", Storage="_LOAISANPHAM", ThisKey="ID_LOAI", OtherKey="ID", IsForeignKey=true)]
		public LOAISANPHAM LOAISANPHAM
		{
			get
			{
				return this._LOAISANPHAM.Entity;
			}
			set
			{
				LOAISANPHAM previousValue = this._LOAISANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._LOAISANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAISANPHAM.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAISANPHAM.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._ID_LOAI = value.ID;
					}
					else
					{
						this._ID_LOAI = default(int);
					}
					this.SendPropertyChanged("LOAISANPHAM");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAISANPHAM")]
	public partial class LOAISANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MALOAI;
		
		private string _TENLOAI;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMALOAIChanging(string value);
    partial void OnMALOAIChanged();
    partial void OnTENLOAIChanging(string value);
    partial void OnTENLOAIChanged();
    #endregion
		
		public LOAISANPHAM()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOAI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENLOAI
		{
			get
			{
				return this._TENLOAI;
			}
			set
			{
				if ((this._TENLOAI != value))
				{
					this.OnTENLOAIChanging(value);
					this.SendPropertyChanging();
					this._TENLOAI = value;
					this.SendPropertyChanged("TENLOAI");
					this.OnTENLOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISANPHAM_SANPHAM", Storage="_SANPHAMs", ThisKey="ID", OtherKey="ID_LOAI")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISANPHAM = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISANPHAM = null;
		}
	}
	
	public partial class LayAllSPResult
	{
		
		private int _ID;
		
		private int _ID_LOAI;
		
		private string _MASANPHAM;
		
		private string _TENSANPHAM;
		
		private string _HINHANH;
		
		private int _DONGIA;
		
		public LayAllSPResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_LOAI", DbType="Int NOT NULL")]
		public int ID_LOAI
		{
			get
			{
				return this._ID_LOAI;
			}
			set
			{
				if ((this._ID_LOAI != value))
				{
					this._ID_LOAI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASANPHAM", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MASANPHAM
		{
			get
			{
				return this._MASANPHAM;
			}
			set
			{
				if ((this._MASANPHAM != value))
				{
					this._MASANPHAM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSANPHAM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENSANPHAM
		{
			get
			{
				return this._TENSANPHAM;
			}
			set
			{
				if ((this._TENSANPHAM != value))
				{
					this._TENSANPHAM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HINHANH", DbType="NVarChar(MAX)")]
		public string HINHANH
		{
			get
			{
				return this._HINHANH;
			}
			set
			{
				if ((this._HINHANH != value))
				{
					this._HINHANH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int NOT NULL")]
		public int DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this._DONGIA = value;
				}
			}
		}
	}
	
	public partial class LayMotSPResult
	{
		
		private int _ID;
		
		private int _ID_LOAI;
		
		private string _MASANPHAM;
		
		private string _TENSANPHAM;
		
		private string _HINHANH;
		
		private int _DONGIA;
		
		public LayMotSPResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_LOAI", DbType="Int NOT NULL")]
		public int ID_LOAI
		{
			get
			{
				return this._ID_LOAI;
			}
			set
			{
				if ((this._ID_LOAI != value))
				{
					this._ID_LOAI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASANPHAM", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MASANPHAM
		{
			get
			{
				return this._MASANPHAM;
			}
			set
			{
				if ((this._MASANPHAM != value))
				{
					this._MASANPHAM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSANPHAM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENSANPHAM
		{
			get
			{
				return this._TENSANPHAM;
			}
			set
			{
				if ((this._TENSANPHAM != value))
				{
					this._TENSANPHAM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HINHANH", DbType="NVarChar(MAX)")]
		public string HINHANH
		{
			get
			{
				return this._HINHANH;
			}
			set
			{
				if ((this._HINHANH != value))
				{
					this._HINHANH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Int NOT NULL")]
		public int DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this._DONGIA = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
