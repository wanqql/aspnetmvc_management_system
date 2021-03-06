﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HTNResp.DAL
{
	/// <summary>
	/// 数据访问类:EvaluationContent
	/// </summary>
	public partial class EvaluationContent
	{
		public EvaluationContent()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "EvaluationContent"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EvaluationContent");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HTNResp.Model.EvaluationContent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EvaluationContent(");
			strSql.Append("DecisionRule,Contents,Sex,Status,Sort,Separator,TypeName,Remark,EvalGuidId)");
			strSql.Append(" values (");
			strSql.Append("@DecisionRule,@Contents,@Sex,@Status,@Sort,@Separator,@TypeName,@Remark,@EvalGuidId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DecisionRule", SqlDbType.NVarChar,-1),
					new SqlParameter("@Contents", SqlDbType.NVarChar,-1),
					new SqlParameter("@Sex", SqlDbType.NVarChar,1),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@Separator", SqlDbType.NVarChar,2),
					new SqlParameter("@TypeName", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@EvalGuidId", SqlDbType.Int,4)};
			parameters[0].Value = model.DecisionRule;
			parameters[1].Value = model.Contents;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.Sort;
			parameters[5].Value = model.Separator;
			parameters[6].Value = model.TypeName;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.EvalGuidId;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HTNResp.Model.EvaluationContent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EvaluationContent set ");
			strSql.Append("DecisionRule=@DecisionRule,");
			strSql.Append("Contents=@Contents,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Status=@Status,");
			strSql.Append("Sort=@Sort,");
			strSql.Append("Separator=@Separator,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("EvalGuidId=@EvalGuidId");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DecisionRule", SqlDbType.NVarChar,-1),
					new SqlParameter("@Contents", SqlDbType.NVarChar,-1),
					new SqlParameter("@Sex", SqlDbType.NVarChar,1),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@Separator", SqlDbType.NVarChar,2),
					new SqlParameter("@TypeName", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@EvalGuidId", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.DecisionRule;
			parameters[1].Value = model.Contents;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.Sort;
			parameters[5].Value = model.Separator;
			parameters[6].Value = model.TypeName;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.EvalGuidId;
			parameters[9].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EvaluationContent ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EvaluationContent ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HTNResp.Model.EvaluationContent GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DecisionRule,Contents,Sex,Status,Sort,Separator,TypeName,Remark,EvalGuidId from EvaluationContent ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			HTNResp.Model.EvaluationContent model=new HTNResp.Model.EvaluationContent();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HTNResp.Model.EvaluationContent DataRowToModel(DataRow row)
		{
			HTNResp.Model.EvaluationContent model=new HTNResp.Model.EvaluationContent();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["DecisionRule"]!=null)
				{
					model.DecisionRule=row["DecisionRule"].ToString();
				}
				if(row["Contents"]!=null)
				{
					model.Contents=row["Contents"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["Sort"]!=null && row["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(row["Sort"].ToString());
				}
				if(row["Separator"]!=null)
				{
					model.Separator=row["Separator"].ToString();
				}
				if(row["TypeName"]!=null && row["TypeName"].ToString()!="")
				{
					model.TypeName=int.Parse(row["TypeName"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["EvalGuidId"]!=null && row["EvalGuidId"].ToString()!="")
				{
					model.EvalGuidId=int.Parse(row["EvalGuidId"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,DecisionRule,Contents,Sex,Status,Sort,Separator,TypeName,Remark,EvalGuidId ");
			strSql.Append(" FROM EvaluationContent ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,DecisionRule,Contents,Sex,Status,Sort,Separator,TypeName,Remark,EvalGuidId ");
			strSql.Append(" FROM EvaluationContent ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM EvaluationContent ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from EvaluationContent T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "EvaluationContent";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

