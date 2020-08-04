using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using w2.Common.Sql;
using w2.Common.Web;

public partial class _Default : System.Web.UI.Page
{
	/// <summary>
	/// ページロード
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!IsPostBack)
		{
			// 初期表示の時だけここに来ます。

			tbDispId.Text = "001";
			tbUpdateId.Text = "001";

			tbRedirect1.Text = "ABC";
			tbRedirect2.Text = "XYZ";
		}
    }

	/// <summary>
	/// 表示ボタンクリック
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnDisp_Click(object sender, EventArgs e)
	{
		var data = Get(tbDispId.Text);
		if (data == null)
		{
			lDispText.Text = HtmlSanitizer.HtmlEncode("見つかりませんでした。");
			tbUpdateId.Text = "";
			tbUpdateText.Text = "";
			return;
		}
		lDispText.Text = HtmlSanitizer.HtmlEncode((string)data["text"]);
		tbUpdateId.Text = tbDispId.Text;
		tbUpdateText.Text = (string)data["text"];
	}

	/// <summary>
	/// 取得
	/// </summary>
	/// <param name="id">ID</param>
	/// <returns>取得できた場合、テーブルのレコード（取得できなかった場合はnull）</returns>
	private DataRowView Get(string id)
	{
		using (var accessor = new SqlAccessor())
		using (var statement = new SqlStatement("Sample", "Get"))
		{
			var ht = new Hashtable
			{
				{"id", id}
			};
			var dv = statement.SelectSingleStatementWithOC(accessor, ht);
			return (dv.Count != 0) ? dv[0] : null;
		}
	}

	/// <summary>
	/// 更新ボタンクリック
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnUpdate_Click(object sender, EventArgs e)
	{
		var result = Update(tbUpdateId.Text, tbUpdateText.Text);
		lUpdateResult.Text = HtmlSanitizer.HtmlEncode(result ? "更新に成功しました。" : "更新に失敗しました。");
	}

	/// <summary>
	/// 更新
	/// </summary>
	/// <param name="id">更新対象ID</param>
	/// <param name="text">テキスト</param>
	private bool Update(string id, string text)
	{
		using (var accessor = new SqlAccessor())
		using (var statement = new SqlStatement("Sample", "Update"))
		{
			var ht = new Hashtable
			{
				{"id", id},
				{"text", text}
			};
			var result = statement.ExecStatementWithOC(accessor, ht);
			return (result > 0);
		}
	}

	/// <summary>
	/// 画面遷移ボタンクリック
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnRedirect_Click(object sender, EventArgs e)
	{
		var ht = new Hashtable
		{
			{"value1", tbRedirect1.Text},
			{"value2", tbRedirect2.Text},
		};
		Session["param"] = ht;
		Response.Redirect("./Complete.aspx");
	}
}